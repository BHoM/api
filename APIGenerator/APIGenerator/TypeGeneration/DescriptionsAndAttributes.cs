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
        /**** Description methods                       ****/
        /***************************************************/

        private static string SafeDescString(this MemberInfo member, string defaultValue = "-", bool replaceNewLine = true, bool inherit = true)
        {
            string desc = member.GetCustomAttribute<DescriptionAttribute>(inherit)?.Description ?? defaultValue;
            DocumentationURLAttribute urlAttribute = member.GetCustomAttribute<DocumentationURLAttribute>();
            if (urlAttribute != null && !string.IsNullOrWhiteSpace(urlAttribute.DocumentationURL))
            {
                if (!string.IsNullOrWhiteSpace(urlAttribute.Description))   //Use description as link text if defined
                {
                    desc += $"\n\n[{urlAttribute.Description}]({urlAttribute.DocumentationURL})";
                }
                else if (desc.Contains("documentation"))    //If the description contains the word documentation, replace it with a link
                {
                    desc = desc.Replace("documentation", $"[documentation]({urlAttribute.DocumentationURL})");
                }
                else    //Otherwhise, add link after, with word based on documentation type
                {
                    string linkName;
                    switch (urlAttribute.Type)
                    {
                        case BH.oM.Base.Attributes.Enums.DocumentationType.API:
                            linkName = "Api link";
                            break;
                        case BH.oM.Base.Attributes.Enums.DocumentationType.SampleScript:
                            linkName = "Sample Script";
                            break;
                        case BH.oM.Base.Attributes.Enums.DocumentationType.Documentation:
                        case BH.oM.Base.Attributes.Enums.DocumentationType.Undefined:   //For Undefined case, assume Documentation. Should remove undefined from the enum
                        default:
                            linkName = "Documentation link";
                            break;
                    }

                    desc += $"\n\n[{linkName}]({urlAttribute.DocumentationURL})";
                }
            }

            return desc.SafeDescString(replaceNewLine);
        }

        /***************************************************/

        private static string SafeDescString(this string desc, bool replaceNewLine)
        {
            desc = desc.Replace("&", "&amp;").Replace("<", "&lt;").Replace(">", "&gt;");
            if (replaceNewLine)
                desc = desc.Replace("\n", "<br>");
            return desc;
        }

        /***************************************************/
        /**** Quantity methods                          ****/
        /***************************************************/

        private static string QuantityString(this QuantityAttribute quantity, string defaultValue = "-")
        {
            if (quantity == null)
                return defaultValue;

            return $"{quantity.GetType().GetNameAsLink(false, "")} [{quantity.SIUnit}]";


        }

        /***************************************************/
    }
}
