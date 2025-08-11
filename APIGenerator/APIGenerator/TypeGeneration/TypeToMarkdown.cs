using BH.oM.Base;
using BH.oM.Base.Attributes;
using BH.oM.Quantities.Attributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace SchemaDocumentationGenerator
{
    public static partial class TypeToMarkdown
    {
        /***************************************************/

        public static bool WriteTypeToMarkdown(string basePath, Type type, Dictionary<Type, List<MethodInfo>> extensionMethods, Dictionary<Type, List<MethodInfo>> genericExtensionMethods)
        {
            if (type.IsEnum)
                return WriteTypeToMarkdownEnum(basePath, type);

            if(typeof(QuantityAttribute).IsAssignableFrom(type))
                return WriteTypeToMarkdownQuantity(basePath, type, extensionMethods);

            string filePath = GetFilePath(type, basePath);

            if (string.IsNullOrEmpty(filePath))
                return false;

            string classWord = type.IsInterface ? "interface" : "class";
            string classWordCaptial = type.IsInterface ? "Interface" : "Class";

            string markdown = type.Header();

            List<Type> baseTypes;
            markdown += type.TypeStructure(classWordCaptial, classWord, out baseTypes);

            markdown += "## Properties\n\n";

            PropertyInfo[] props = type.GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public);
            if (props.Length > 0)
            {
                markdown += "\n\n";
                markdown += "### Defining properties\n\n";
                markdown += $"The following properties are defined on the {classWord}\n\n";
                markdown += props.PropertyTable();
                markdown += "\n\n";
            }

            if (typeof(IDynamicObject).IsAssignableFrom(type) && !typeof(IDynamicPropertyProvider).IsAssignableFrom(type))
            {
                List<PropertyInfo> optionProps = type.GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public).Where(prop =>
                    prop.GetCustomAttribute<DynamicPropertyAttribute>() != null
                    && typeof(IDictionary).IsAssignableFrom(prop.PropertyType)
                    && prop.PropertyType.GenericTypeArguments.First().IsEnum).ToList();

                if (optionProps.Count != 0)
                {
                    markdown += "\n\n";
                    markdown += "### Optional properties\n\n";
                    markdown += $"The following properties are optional and can be included on a object definition in any combination\n\n";
                    markdown += optionProps.OptionalPropertyTable();
                    markdown += "\n\n";
                }

            }

            PropertyInfo[] inheritedProps = type.GetProperties(BindingFlags.Instance | BindingFlags.Public).Except(props).ToArray();

            if (inheritedProps.Length > 0)
            {
                markdown += "### Inherited properties\n";
                markdown += "The following properties are inherited from the base class of the object\n\n";
                markdown += inheritedProps.PropertyTable();
                markdown += "\n\n";
            }

            //Types for which extension methods are ignored from being included
            List<Type> ignoredTargetTypes = new List<Type> { typeof(IObject), typeof(IBHoMObject), typeof(BHoMObject), typeof(System.Object) };

            //Gets query methods that has a single input that accepts this type as input, excluding methods that target one of the other listed types
            List<MethodInfo> methods = GetExtensionMethods(type, baseTypes, ignoredTargetTypes, extensionMethods, genericExtensionMethods);
            if (methods.Count > 0)
            {
                markdown += "### Derived properties\n\n";
                markdown += "The following properties are defined as extension methods in one of the BHoM_Engines\n\n";
                markdown += methods.PropertyTable();
                markdown += "\n\n";

            }

            markdown += Links(type);

            Write(filePath, markdown);


            return true;
        }

        /***************************************************/

        private static bool WriteTypeToMarkdownEnum(string basePath, Type type)
        {
            string filePath = GetFilePath(type, basePath);

            if (string.IsNullOrEmpty(filePath))
                return false;


            string markdown = type.Header();

            markdown += "## Enum values\n\n";

            FieldInfo[] fields = type.GetFields();
            markdown += fields.EnumTable();
            markdown += "\n\n";
            markdown += Links(type);

            Write(filePath, markdown);
            return false;
        }

        /***************************************************/

        private static bool WriteTypeToMarkdownQuantity(string basePath, Type type, Dictionary<Type, List<MethodInfo>> extensionMethods)
        {
            if (type == typeof(QuantityAttribute))
                return WriteTypeToMarkdownBaseQuantity(basePath, type, extensionMethods);

                string filePath = GetFilePath(type, basePath);

            if (string.IsNullOrEmpty(filePath))
                return false;


            string markdown = type.Header();
            QuantityAttribute attribute;
            try
            {
                attribute = Activator.CreateInstance(type) as QuantityAttribute;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

            markdown += "## Dimensions and units\n\n";
            markdown += $"### SI Unit [{attribute.SIUnit}]\n\n";
            markdown += $"{type.Name} is defined in [{attribute.SIUnit}] following the [International System of Units](https://en.wikipedia.org/wiki/International_System_of_Units) \n\n";

            markdown += $"### Dimensions\n\n";
            List<PropertyInfo> dimensions = attribute.GetType().GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public).Where(x => x.PropertyType == typeof(int)).ToList();

            if (dimensions.Count == 0)
            {
                markdown += "The quantity is dimensionless.\n\n";
            }
            else
            {
                markdown += "The quantity is made up of the following [SI base units](https://en.wikipedia.org/wiki/SI_base_unit)\n\n";
                markdown += attribute.QuantityTable(dimensions);
            }
            markdown += "\n";

            markdown += type.TypeStructure("Class", "class", out var baseTypes);

            markdown += "\n\n";
            markdown += Links(type);

            Write(filePath, markdown);
            return false;
        }

        /***************************************************/

        private static bool WriteTypeToMarkdownBaseQuantity(string basePath, Type type, Dictionary<Type, List<MethodInfo>> extensionMethods)
        {
            string filePath = GetFilePath(type, basePath);

            if (string.IsNullOrEmpty(filePath))
                return false;

            string classWord = type.IsInterface ? "interface" : "class";
            string classWordCaptial = type.IsInterface ? "Interface" : "Class";

            string markdown = type.Header();

            markdown += "## Properties\n\n";

            PropertyInfo[] props = type.GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public);
            if (props.Length > 0)
            {
                markdown += "\n\n";
                markdown += "### Defining properties\n\n";
                markdown += $"The following properties are defined on the base quantity attribute, to be overridden by the subclasses to indicate the dimensionality and SI units that make up the quantities. \n\n";
                markdown += props.PropertyTable(false);
                markdown += "\n\n";
            }
            PropertyInfo[] inheritedProps = type.GetProperties(BindingFlags.Instance | BindingFlags.Public).Except(props).ToArray();

            if (inheritedProps.Length > 0)
            {
                markdown += "### Inherited properties\n";
                markdown += "The following properties are inherited from the base class of the object. These properties are framework related, and helps associate the quantity with specific targets.\n\n";
                markdown += inheritedProps.PropertyTable(false);
                markdown += "\n\n";
            }


            //Types for which extension methods are ignored from being included
            List<Type> ignoredTargetTypes = new List<Type> { typeof(IObject), typeof(IBHoMObject), typeof(BHoMObject), typeof(System.Object) };
            List<Type> baseTypes = GetBaseTypes(type);
            //Gets query methods that has a single input that accepts this type as input, excluding methods that target one of the other listed types
            List<MethodInfo> methods = GetExtensionMethods(type, baseTypes, ignoredTargetTypes, extensionMethods, new Dictionary<Type, List<MethodInfo>>());
            if (methods.Count > 0)
            {
                markdown += "### Derived properties\n\n";
                markdown += "The following properties are defined as extension methods in one of the BHoM_Engines\n\n";
                markdown += methods.PropertyTable(false);
                markdown += "\n\n";
            }


            markdown += type.TypeStructure(classWordCaptial, classWord, out baseTypes);

            markdown += Links(type);

            Write(filePath, markdown);


            return true;
        }

        /***************************************************/

        private static string Header(this Type type)
        {
            string markdown = "---\n";
            markdown += $"title: {type.TitleName(false)}\n";
            markdown += "---\n\n";

            string title = type.TitleName(true);
            string[] split = title.Split('.');
            string nameSpace = string.Join('.', split.Take(split.Length - 1));
            string name = split[split.Length - 1];
            markdown += $"# <small>{nameSpace}.</small>**{name}**";
            markdown += "\n\n";

            markdown += type.SafeDescString("", false, true) + "\n\n";

            return markdown;
        }

        /***************************************************/

        private static string TitleName(this Type type, bool includeNameSpace)
        {
            if (type.FullName == null)
                return "";

            string name;
            if (includeNameSpace)
                name = type.FullName;
            else
                name = type.Name;

            if (type.IsGenericType)
            {
                return $"{name.Split('`')[0]}&lt;{string.Join(",", type.GetGenericArguments().Select(x => x.Name))}&gt;";
            }
            else
                return name;
        }

        /***************************************************/

    }
}
