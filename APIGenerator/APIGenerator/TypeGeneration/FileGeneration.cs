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

        private static string GetFilePath(this Type type, string basePath)
        {
            if (type.Namespace.StartsWith("BH.oM"))
            {
                string link = type.GetDocumentLink();
                if (!string.IsNullOrEmpty(link))
                {
                    return $"{link.Replace("/api/", basePath).Replace("/", "\\")}.md";
                }
            }

            return "";
        }

        /***************************************************/

        private static bool Write(string filePath, string markdown)
        {
            if (File.Exists(filePath))
                File.Delete(filePath);

            EnsureFolder(filePath);

            File.WriteAllText(filePath, markdown.Replace("\n", Environment.NewLine));
            return true;
        }

        /***************************************************/

        private static bool EnsureFolder(string path)
        {
            string[] split = path.Split("\\");

            string current = Path.Join(split[0], split[1]);

            for (int i = 2; i < split.Length - 1; i++)
            {
                current = Path.Join(current, split[i]);
                if (!Directory.Exists(current))
                    Directory.CreateDirectory(current);
            }

            return true;

        }

        /***************************************************/

    }
}
