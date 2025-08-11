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

        private static string Links(this Type type)
        {
            string classWord = type.TypeWord();

            string markdown = "## Code and Schema\n\n";
            markdown += CSharpSection(type, classWord);
            string jsonSchema = JsonSchemaSection(type, classWord);
            if(jsonSchema != null)
                markdown += jsonSchema;

            return markdown;



        }

        /***************************************************/

        private static string CSharpSection(Type type, string classWord)
        {
            string markdown = "### C# implementation\n\n";

            markdown += "``` C# title=\"C#\"\n";

            markdown += $"public {classWord} {type.Name}";
            List<Type> baseTypes = type.GetBaseTypes();
            if (baseTypes.Count > 0)
            {
                List<string> names = baseTypes.Select(x => x.TypeNameBaseTypes()).ToList();
                int charCount = names.Sum(x => x.Length);
                string split = charCount > 120 ? ",\n" : ", ";
                markdown += $" : {string.Join(split, names)}";
            }
            markdown += "\n";
            markdown += "```\n\n";
            markdown += $"Assembly: {type.Assembly.GetName().Name}.dll\n\n";

            string link = type.GithubLink();
            if (!string.IsNullOrEmpty(link))
            {
                markdown += $"The C# {classWord} definition is available on github:\n\n";
                markdown += $"- {link}\n";
                markdown += "\nAll history and changes of the class can be found by inspection the history.\n";
            }
            return markdown;
        }

        /***************************************************/

        private static string JsonSchemaSection(Type type, string classWord)
        {

            var (id, link) = JsonSchemaLink(type);

            if (id == null || link == null)
                return null;

            string markdown = "### JSON Schema implementation\n\n";
            markdown += "The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).\n\n";

            markdown += "``` json title=\"JSON Schema\"\n";
            markdown += "{\n";
            markdown += $" \"$ref\" : \"{id}\"\n";
            markdown += "}\n";

            markdown += "```\n\n";

            markdown += "The JSON Schema is available on github here:\n\n";
            markdown += $"- [{type.Name}.json]({link})\n";

            string json = TryGetExampleJson(type);

            if (json != null)
            {
                string formattedJson = System.Text.Json.Nodes.JsonNode.Parse(json).ToString().Replace(Environment.NewLine, "\n");

                markdown += "### Example JSON instance\n\n";
                markdown += $"Example JSON instance of type {type.Name}.\n\n";
                markdown += "``` json title=\"Example JSON\"\n";
                markdown += formattedJson + "\n";

                markdown += "```\n\n";

            }

            return markdown;
        }

        /***************************************************/

        public static string TryGetExampleJson(this Type type)
        {
            string executionPath = Environment.ProcessPath;
            string[] split = executionPath.Split(Path.DirectorySeparatorChar);

            string basePath = "";

            for (int i = 0; i < split.Length; i++)
            {
                basePath += split[i] + Path.DirectorySeparatorChar;
                if (split[i] == "SchemaDocumentationGenerator")
                    break;
            }
            basePath = Path.Combine(basePath, "SchemaDocumentationGenerator", "JsonExamples");

            string dir = Path.Combine(basePath, type.Assembly.GetName().Name);
            if (!Directory.Exists(dir))
                return null;

            string filePath = Path.Combine(dir, type.Name + ".json");
            if (!File.Exists(filePath))
                return null;

            return File.ReadAllText(filePath);
        }

        /***************************************************/

        private static string TypeWord(this Type type)
        {
            if (type.IsEnum)
                return "enum";
            if (type.IsInterface)
                return "interface";
            if (type.IsAbstract)
                return "abstract class";

            return "class";
        }

        /***************************************************/

        private static string TypeNameBaseTypes(this Type type)
        {
            if (type.IsGenericType)
            {
                string genType = type.GetGenericTypeDefinition().FullName.Split('`')[0];

                List<string> args = new List<string>();

                foreach (Type t in type.GetGenericArguments())
                {
                    args.Add(t.TypeNameBaseTypes());
                }

                return $"{genType}<{string.Join(", ", args)}>";
            }
            else
                return type.FullName;
        }

        /***************************************************/

        private static string GithubLink(this Type type)
        {

            if (Settings.AssemblyLink.TryGetValue(type.Assembly.GetName().Name, out string repoLink) && TryGetFileLink(type, out string objectLink))
            {
                string link = $"{repoLink}/blob/develop/{type.Assembly.GetName().Name}/{objectLink}";    //Skip the first three parts of the namespace
                return $"[{type.Name.Split('`')[0]}.cs]({link})";
            }
            return "";
        }

        /***************************************************/


        private static (string, string) JsonSchemaLink(this Type type, string branch = "develop")
        {
            if (!(typeof(IObject).IsAssignableFrom(type) || type.IsEnum))
                return (null, null);

            string relativeId = type.RelativeSchemaId();
            if(!SchemaExists(relativeId))
                return (null, null);

            string id = $"https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/{branch}/{relativeId}";
            string link = $"https://github.com/BHoM/BHoM_JSONSchema/blob/{branch}/{relativeId}";
            return (id, link) ;
        }

        /***************************************************/

        [Description("Gets the path to the type based on its assembly and namespace. This method just returns the relative path, not the full ID path URI to the type.")]
        public static string RelativeSchemaId(this Type type)
        {
            if (!(typeof(IObject).IsAssignableFrom(type) || (type.IsEnum && type.Namespace.StartsWith("BH.oM"))))
                return null;

            Assembly assembly = type.Assembly;
            if (type.IsGenericType)
                type = type.GetGenericTypeDefinition();
            //Get rid of initial either BH.oM.Adapters or BH.oM and split by .
            //Replacing the adapters version first, in case it is there to avoid blanket replace any "Adapters." in the string, in case it shows up later
            //Skip 1 to ignore the main namespace as that is taken care of by using the assembly name, avoinding for example Geometry_oM/Geometry
            string namePath = string.Join("/", type.FullName.Replace("BH.oM.Adapters.", "").Replace("BH.oM.", "").Split('.').Skip(1));

            return $"{assembly.GetName().Name}/{namePath}.json";
        }

        /***************************************************/

        private static bool SchemaExists(string relativeId)
        { 
            return File.Exists(Path.Combine(m_JsonSchemaFolder, relativeId));
        }

        /***************************************************/

    }
}
