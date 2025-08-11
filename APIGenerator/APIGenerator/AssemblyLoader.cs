using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SchemaDocumentationGenerator
{
    public static class AssemblyLoader
    {
        [Description("Loads all .dll assemblies with names ending with oM, _Engine and _Adapter (with optional suffixes) from a given folder.")]
        public static List<Assembly> LoadAlloMAssemblies(List<string> organisations)
        {
            string regexFilter = @"oM$";
            List<Assembly> result = new List<Assembly>();

            string folder = BHoMFolder();

            Regex regex;
            if (!string.IsNullOrWhiteSpace(regexFilter))
                regex = new Regex(regexFilter);
            else
                regex = new Regex(".*");

            SearchOption searchOption = SearchOption.TopDirectoryOnly;
            foreach (string file in Directory.GetFiles(folder, "*.dll", searchOption))
            {
                string name = Path.GetFileNameWithoutExtension(file);
                if (regex.IsMatch(name))
                {
                    Assembly loaded = Assembly.LoadFrom(file);
                    if (loaded != null && loaded.IsOmAssembly() && loaded.IsInOrg(organisations) && Settings.AssemblyIncluded.TryGetValue(loaded.GetName().Name, out bool included) && included)
                        result.Add(loaded);
                }
            }

            return result;
        }

        [Description("Loads all .dll assemblies with names ending with oM, _Engine and _Adapter (with optional suffixes) from a given folder.")]
        public static List<Assembly> LoadAllEngineAssemblies(List<string> organisations)
        {
            string regexFilter = @"_Engine$";
            List<Assembly> result = new List<Assembly>();

            string folder = BHoMFolder();

            Regex regex;
            if (!string.IsNullOrWhiteSpace(regexFilter))
                regex = new Regex(regexFilter);
            else
                regex = new Regex(".*");

            SearchOption searchOption = SearchOption.TopDirectoryOnly;
            foreach (string file in Directory.GetFiles(folder, "*.dll", searchOption))
            {
                string name = Path.GetFileNameWithoutExtension(file);
                if (regex.IsMatch(name))
                {
                    Assembly loaded = Assembly.LoadFrom(file);
                    if (loaded != null && loaded.IsEngineAssembly() && loaded.IsInOrg(organisations))
                        result.Add(loaded);
                }
            }

            return result;
        }

        public static string BHoMFolder()
        {
            return System.IO.Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.CommonApplicationData), "BHoM", "Assemblies");
        }

        [Description("Checks whether a given assembly is a BHoM oM assembly.")]
        public static bool IsOmAssembly(this Assembly assembly)
        {
            return assembly != null && assembly.GetName().Name.IsOmAssembly();
        }

        /***************************************************/

        [Description("Checks whether a given assembly name follows the BHoM oM assembly naming convention.")]
        public static bool IsOmAssembly(this string assemblyName)
        {
            return assemblyName != null && (assemblyName == "BHoM" || assemblyName.EndsWith("_oM") || assemblyName.Contains("_oM_"));
        }

        /***************************************************/

        [Description("Checks whether a given assembly is a BHoM oM assembly.")]
        public static bool IsEngineAssembly(this Assembly assembly)
        {
            return assembly != null && assembly.GetName().Name.IsEngineAssembly();
        }

        /***************************************************/

        [Description("Checks whether a given assembly name follows the BHoM oM assembly naming convention.")]
        public static bool IsEngineAssembly(this string assemblyName)
        {
            return assemblyName != null && (assemblyName.EndsWith("_Engine") || assemblyName.Contains("_Engine_"));
        }

        /***************************************************/

        [Description("Checks whether a given assembly name follows the BHoM oM assembly naming convention.")]
        public static bool IsInOrg(this Assembly assembly, List<string> orgs)
        {
            AssemblyDescriptionAttribute atr = assembly.GetCustomAttribute< AssemblyDescriptionAttribute>();
            if (atr != null)
            {
                return orgs.Any(x => atr.Description.Contains($"github.com/{x}"));
            }
            return false;
        }

        /***************************************************/
    }
}
