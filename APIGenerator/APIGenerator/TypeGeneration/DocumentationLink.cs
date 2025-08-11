using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using BH.oM.Base;
using BH.oM.Base.Attributes;
using BH.oM.Quantities.Attributes;

namespace SchemaDocumentationGenerator
{
    public static partial class TypeToMarkdown
    {
        /***************************************************/

        private static string GetNameAsLink(this Type type, bool isTypeStructure, string owner = "")
        {
            if (type.IsGenericTypeParameter)
            {
                if (isTypeStructure && !string.IsNullOrEmpty(owner))
                    return $"[{type.Name}]({owner}#{type.Name.ToLower()})";    //for a T type, link to the definition on the same page
                else
                    return $"[{type.Name}](#{type.Name.ToLower()})";    //for a T type, link to the definition on the same page
            }
            else if (type.IsGenericType)
            {
                string genType = type.GetGenericTypeDefinition().GetNameAsLinkNonGeneric(isTypeStructure);

                List<string> args = new List<string>();

                foreach (Type t in type.GetGenericArguments())
                {
                    args.Add(t.GetNameAsLink(isTypeStructure, isTypeStructure ? type.GetGenericTypeDefinition().GetDocumentLink() : ""));
                }

                return $"{genType}&lt;{string.Join(", ", args)}&gt;";   //&lt; is the same as < and &gt; is the same as >. If simply typing < it will be treated as html and cause issues.
            }
            else if (type.IsArray)
            {
                return $"{type.GetElementType().GetNameAsLink(false, "")}[{string.Join("", Enumerable.Repeat(',', type.GetArrayRank() - 1))}]";
            }
            else
            {
                return type.GetNameAsLinkNonGeneric(isTypeStructure);
            }

        }

        /***************************************************/

        private static string GetNameAsLinkNonGeneric(this Type type, bool includeNamespace)
        {
            string nameWithLink = type.GetNameAsLink();

            if (!includeNamespace || type.IsSystemNamespace())
                return nameWithLink;

            string fullName = type.FullName;
            string[] fullNameSplit = fullName.Split('.');
            fullNameSplit[fullNameSplit.Length - 1] = nameWithLink;
            return string.Join(".", fullNameSplit);
        }

        /***************************************************/

        private static string BHoMTypeFullName(this Type type)
        {
            if (type.FullName == null)
                return "";
            return type.FullName.Replace("BH.oM.", "");
        }

        /***************************************************/

        private static string GetNameAsLink(this Type type)
        {
            string name;
            if (!Aliases.TryGetValue(type, out name))   //Use aliases for system types
            {
                name = type.Name;

                if (name.Contains("`"))
                    name = name.Split('`')[0];
            }

            string link = type.GetDocumentLink();
            if (string.IsNullOrEmpty(link))
                return name;
            else
                return $"[{name}]({link})";
        }

        /***************************************************/

        public static string GetDocumentLink(this Type type)
        {
            if (m_docLinks.ContainsKey(type))
                return m_docLinks[type];

            if (type.Namespace.StartsWith("BH.oM"))
            {
                string categoryPath;
                if (Settings.AssemblyCategory.TryGetValue(type.Assembly.GetName().Name, out categoryPath) && TryGetFileLink(type, out string fileLink))
                {
                    string partLink = fileLink.Split('.')[0].Replace('\\', '/');
                    string link = $"/api/oM/{categoryPath}/{type.BHoMMainNameSpace()}/{partLink}";
                    m_docLinks[type] = link;
                    return link;
                }
            }
            else if (type.IsSystemNamespace())
            {
                string baseLink = "https://learn.microsoft.com/en-us/dotnet/api/";
                string ending = "?view=netstandard-2.0";
                string link = $"{baseLink}{type.FullName.Replace('`', '-')}{ending}";
                m_docLinks[type] = link;
                return link;
            }

            return "";
        }

        /***************************************************/

        private static string BHoMMainNameSpace(this Type type)
        {
            string fullName = type.Namespace;
            string[] split = fullName.Split('.');
            if (split.Length < 3)
                return "";

            IEnumerable<string> parts;
            if (split[2] == "Adapters")
                return $"{split[2]}/{split[3]}";
            else
                return split[2];
        }

        /***************************************************/

        private static bool IsSystemNamespace(this Type type)
        {
            return type.Namespace == "System" || type.Namespace.StartsWith("System.");
        }

        /***************************************************/

        private static Dictionary<Type, string> m_docLinks = new Dictionary<Type, string>();
        //Alias names taken from https://stackoverflow.com/a/1362899
        private static readonly Dictionary<Type, string> Aliases = new Dictionary<Type, string>()
        {
            { typeof(byte), "byte" },
            { typeof(sbyte), "sbyte" },
            { typeof(short), "short" },
            { typeof(ushort), "ushort" },
            { typeof(int), "int" },
            { typeof(uint), "uint" },
            { typeof(long), "long" },
            { typeof(ulong), "ulong" },
            { typeof(float), "float" },
            { typeof(double), "double" },
            { typeof(decimal), "decimal" },
            { typeof(object), "object" },
            { typeof(bool), "bool" },
            { typeof(char), "char" },
            { typeof(string), "string" },
            { typeof(void), "void" },
            // From C# 11 onwards
            { typeof(nint), "nint" },
            { typeof(nuint), "nuint" },
        };
    }
}
