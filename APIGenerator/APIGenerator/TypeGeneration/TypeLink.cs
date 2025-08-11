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

        public static bool TryGetFileLink(this Type type, out string objectLink)
        {
            //Method to find/validate the relative link to the file on github

            //Get the assumed relative link based on type name and namespace
            string relativeLink = type.GetBaseLink();
            if (string.IsNullOrEmpty(relativeLink))
            {
                Console.WriteLine($"Unable to generate relative link for type {type.Name}");
                objectLink = "";
                return false;
            }

            string folder;
            //If cant find folder to check against, for now, assume ok and return relative link
            if (!m_AssemblyFolder.TryGetValue(type.Assembly, out folder))
            {
                objectLink = relativeLink;
                return true;
            }

            //Check if the assumed place that it for msot cases should be (namespace matching folder path)
            if (File.Exists(Path.Combine(folder, relativeLink)))
            {
                objectLink = relativeLink;
                return true;
            }

            //If not, try scan folders matching the namespace, starting from inner subfolder and going up a level each time
            string[] relPathSplit = relativeLink.Split(Path.DirectorySeparatorChar);
            string fileName = relPathSplit.Last();
            for (int i = relPathSplit.Length - 1; i >= 0; i--)
            {
                string dir = Path.Combine(folder, Path.Combine(relPathSplit.Take(i).ToArray()));
                if (Directory.Exists(dir))
                {
                    string[] files = Directory.GetFiles(dir, fileName, SearchOption.AllDirectories);    //All directories to check if contained in subfolder. Checking for file amtching type name exactly. Should be the case and required compliance check
                    if (files.Length == 1)  //Single file found -> return
                    {
                        string[] fileSplit = files[0].Split(Path.DirectorySeparatorChar);
                        objectLink = string.Join("\\", fileSplit.Skip(folder.Split(Path.DirectorySeparatorChar).Length));    //Get rid of part leading up to the oM folder, and return the rest after. Link generation above handles all before.
                        return true;
                    }
                }
            }

            string[] allFiles = Directory.GetFiles(folder, fileName, SearchOption.AllDirectories); //Most likely not required and should be handled by final iteration above, but final scanning of all files in the folder
            if (allFiles.Length == 1)
            {
                string[] fileSplit = allFiles[0].Split(Path.DirectorySeparatorChar);
                objectLink = string.Join("\\", fileSplit.Skip(folder.Split(Path.DirectorySeparatorChar).Length));
                return true;
            }

            if (TryScanFiles(relPathSplit, folder, type, out objectLink))
                return true;

            Console.WriteLine($"Unable to find valid github link for {type.Name}.");

            objectLink = "";
            return false;
        }

        /***************************************************/

        private static bool TryScanFiles(string[] relPathSplit, string folder, Type type, out string objectLink)
        {
            string lineToFind = $"public {type.TypeWord()} {type.Name.Split('`')[0]}";
            for (int i = relPathSplit.Length - 1; i >= 0; i--)
            {
                string dir = Path.Combine(folder, Path.Combine(relPathSplit.Take(i).ToArray()));
                if (Directory.Exists(dir))
                {
                    string[] files = Directory.GetFiles(dir, "*.cs", SearchOption.AllDirectories);    //All directories to check if contained in subfolder. Checking for file amtching type name exactly. Should be the case and required compliance check

                    foreach (string file in files)
                    {
                        foreach (string line in File.ReadAllLines(file))
                        {
                            if (line.Contains(lineToFind))
                            {
                                string[] fileSplit = file.Split(Path.DirectorySeparatorChar);
                                objectLink = string.Join("\\", fileSplit.Skip(folder.Split(Path.DirectorySeparatorChar).Length));    //Get rid of part leading up to the oM folder, and return the rest after. Link generation above handles all before.
                                return true;
                            }
                        }
                    }
                }
            }
            objectLink = "";
            return false;
        }

        /***************************************************/

        private static string GetBaseLink(this Type type)
        {
            string fullName = type.FullName.Split('`')[0];
            string[] split = fullName.Split('.');
            if (split.Length < 4)
                return "";

            IEnumerable<string> parts;
            if (split[2] == "Adapters")
                parts = split.Skip(4);
            else
                parts = split.Skip(3);

            return string.Join(Path.DirectorySeparatorChar, parts) + ".cs";
        }

        /***************************************************/

        public static void SetupAssemblyFolders(string rootFolder, List<Assembly> assemblies)
        {

            string gitFolderPath = Path.Combine(rootFolder, "Repositories");

            List<Assembly> assembliesCopy = assemblies.ToList();

            foreach (string repo in Directory.GetDirectories(gitFolderPath))
            {
                if (repo.Contains("BHoM_JSONSchema"))   // Skip the JSON Schema repo as it is not an oM repo
                    continue;
                foreach (string projFolder in Directory.GetDirectories(repo))
                {
                    string dirName = Path.GetFileName(projFolder);
                    Assembly assembly = assemblies.FirstOrDefault(a => a.GetName().Name == dirName);

                    if (assembly != null)
                        m_AssemblyFolder[assembly] = projFolder;
                }
            }

            if (m_AssemblyFolder.Count != assemblies.Count)
            {
                Console.WriteLine($"Unable to find a filepath for git link checking for {string.Join(", ", assemblies.Except(m_AssemblyFolder.Keys))}.");
            }

            m_JsonSchemaFolder = Path.Combine(gitFolderPath, "BHoM_JSONSchema");
        }

        /***************************************************/

        private static Dictionary<Assembly, string> m_AssemblyFolder = new Dictionary<Assembly, string>();
        private static string m_JsonSchemaFolder;
        /***************************************************/
    }
}
