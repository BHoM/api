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

namespace APIGenerator
{
    public static partial class TypeToMarkdown
    {
        /***************************************************/
        /**** Table methods                             ****/
        /***************************************************/

        private static List<Type> GetBaseTypes(this Type type)
        { 
            if(!BaseTypes.TryGetValue(type, out var baseTypes))
                baseTypes = ExtractBaseTypes(type);

            return baseTypes;
        }

        /***************************************************/

        private static string TypeStructure(this Type type, string classWordCaptial, string classWord, out List<Type> baseTypes)
        {
            string markdown = $"## {classWordCaptial} structure\n\n";

            if (type.IsGenericType)
            {
                markdown += $"### Generic parameters\n\n";
                markdown += $"The {type.Name.Split('`')[0]} contains the following generic paramters:\n\n";

                foreach (Type genericArgument in type.GetGenericArguments())
                {
                    markdown += $"#### {genericArgument.Name}\n\n";
                    Type[] typeContraints = genericArgument.GetGenericParameterConstraints();
                    if (typeContraints.Length == 0)
                    {
                        markdown += $"Unconstrained generic type. Can be any type of object.\n\n";
                    }
                    else
                    {
                        markdown += $"Constrained by the following arguments:\n\n";
                        foreach (Type constriant in typeContraints)
                        {
                            markdown += $"- {GetNameAsLink(constriant, true)}\n";
                        }
                        markdown += "\n";
                    }

                }
            }

            if (BaseTypes.TryGetValue(type, out baseTypes) && baseTypes.Count > 0)
            {
                markdown += $"### Implemented interfaces and base types\n\n";
                markdown += AdmonitionStart(false, $"The {type.Name} is inheriting from the following base type(s) and implements the following interfaces:");
                foreach (Type baseType in baseTypes)
                {
                    markdown += $"    -  {GetNameAsLink(baseType, true)}\n";
                }

                markdown += "\n\n";
            }
            else
                baseTypes = new List<Type>();

            List<Type> subTypes;
            if (SubTypes.TryGetValue(type, out subTypes))
            {
                List<Type> subInterfaceTypes = subTypes.Where(x => x.IsInterface).ToList();
                List<Type> nonInterfaceTypes = subTypes.Where(x => !x.IsInterface).ToList();

                if (subInterfaceTypes.Count > 0)
                {
                    markdown += $"### Interfaces implementing this interface\n\n";
                    bool collapsed = subInterfaceTypes.Count > 20;

                    markdown += AdmonitionStart(collapsed, "The following interfaces are implementing this interface:");

                    foreach (Type baseType in subInterfaceTypes)
                    {
                        markdown += $"    - {GetNameAsLink(baseType, true)}\n";
                    }

                    markdown += "\n\n";
                }

                if (nonInterfaceTypes.Count > 0)
                {
                    string implementingWord = type.IsInterface ? "implementing this" : "inheriting from this";
                    markdown += $"### Classes {implementingWord} {classWord}\n\n";

                    bool collapsed = nonInterfaceTypes.Count > 50;

                    string title;
                    if (type.IsInterface)
                        title = $"The following classes are implementing this interface:";
                    else
                        title = $"The following classes are inheriting from this class:";

                    markdown += AdmonitionStart(collapsed, title);


                    foreach (Type baseType in nonInterfaceTypes)
                    {
                        markdown += $"    - {GetNameAsLink(baseType, true)}\n";
                    }

                    markdown += "\n\n";
                }
            }

            return markdown;
        }

        private static string AdmonitionStart(bool collapsed, string title)
        {
            string markdown = "???";
            if(!collapsed)
                markdown += "+";

            markdown += $" bhom \"{title}\"\n\n";
            return markdown;
        }

        /***************************************************/

        public static void MapDependecies(this Type type)
        {
            List<Type> baseTypes = ExtractBaseTypes(type);

            BaseTypes[type] = baseTypes;

            List<Type> baseTypeForSubTypes = new List<Type>();
            foreach (var baseType in baseTypes)
            {
                if (baseType.IsGenericType)
                    baseTypeForSubTypes.Add(baseType.GetGenericTypeDefinition());
                else
                    baseTypeForSubTypes.Add(baseType);
            }

            foreach (Type baseType in baseTypeForSubTypes)
            {
                if (!baseType.Namespace.StartsWith("BH.oM."))
                    continue;

                if (!SubTypes.ContainsKey(baseType))
                    SubTypes[baseType] = new List<Type>();

                SubTypes[baseType].Add(type);
            }
        }

        /***************************************************/

        private static List<Type> ExtractBaseTypes(this Type type)
        {
            List<Type> baseTypes = new List<Type>();

            Type baseType = type.BaseType;

            while (baseType != null && baseType != typeof(System.Object))
            {
                baseTypes.Add(baseType);
                baseType = baseType.BaseType;
            }

            baseTypes.AddRange(type.GetInterfaces());


            baseTypes = baseTypes.Distinct().ToList();

            return baseTypes;
        }


        private static Dictionary<Type, List<Type>> BaseTypes { get; set; } = new Dictionary<Type, List<Type>>();
        private static Dictionary<Type, List<Type>> SubTypes { get; set; } = new Dictionary<Type, List<Type>>();

        /*
         *     [0]: {Name = "BHoMObject" FullName = "BH.oM.Base.BHoMObject"}
    [1]: {Name = "IBHoMObject" FullName = "BH.oM.Base.IBHoMObject"}
    [2]: {Name = "IObject" FullName = "BH.oM.Base.IObject"}
    [3]: {Name = "IResult" FullName = "BH.oM.Analytical.Results.IResult"}
    [4]: {Name = "IImmutable" FullName = "BH.oM.Base.IImmutable"}
    [5]: {Name = "IFragment" FullName = "BH.oM.Base.IFragment"}
        */

        /***************************************************/
    }
}
