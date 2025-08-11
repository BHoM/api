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
    public static class Settings
    {
        public static bool LoadSettings(string settingsPath)
        {
            List<string> lines = File.ReadAllLines(settingsPath).ToList();

            foreach (string line in lines.Skip(1))
            {
                string[] split = line.Split(',');
                if (split.Length != 4)
                {
                    Console.WriteLine($"failed splitting the line {line}");
                    continue;
                }

                AssemblyLink[split[0]] = split[1];
                AssemblyCategory[split[0]] = split[2];
                AssemblyIncluded[split[0]] = bool.Parse(split[3]);
            }
            return true;
        }

        public static Dictionary<string, string> AssemblyLink { get; set; } = new Dictionary<string, string>();
        public static Dictionary<string, string> AssemblyCategory { get; set; } = new Dictionary<string, string>();
        public static Dictionary<string, bool> AssemblyIncluded { get; set; } = new Dictionary<string, bool>();
    }
}
