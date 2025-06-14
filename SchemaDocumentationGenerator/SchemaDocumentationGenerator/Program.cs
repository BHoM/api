﻿

using BH.oM.Base;
using SchemaDocumentationGenerator;
using System.Collections.Generic;
using System.Reflection;

Console.WriteLine("Loading Settings.");

Settings.LoadSettings(Path.Join(Environment.CurrentDirectory, "oM_categorisation.csv"));

Console.WriteLine("Loading Engine assemblies.");
List<Assembly> engineAssemblies = AssemblyLoader.LoadAllEngineAssemblies(new List<string> { "BHoM" });
Console.WriteLine("Extracting query methods.");
(Dictionary<Type, List<MethodInfo>> methods, Dictionary<Type, List<MethodInfo>> genericMethods) = ExtensionMethodsExtractor.GetAllExtensionMethods(engineAssemblies);

Console.WriteLine("Loading oM Asseblies");
List<Assembly> oMAssemblies = AssemblyLoader.LoadAlloMAssemblies(new List<string> { "BHoM" });

Console.WriteLine("Mapping types");
foreach (Assembly assembly in oMAssemblies)
{
    foreach (Type type in assembly.GetTypes())
    {
        TypeToMarkdown.MapDependecies(type);
    }
}


TypeToMarkdown.SetupAssemblyFolders(@"C:\BHoMBot\Github", oMAssemblies);

foreach (Assembly assembly in oMAssemblies)
{
    Console.WriteLine($"Generating {assembly.GetName().Name} type docs");

    foreach (Type type in assembly.GetTypes())
    {
        if (!(type.IsAbstract && type.IsSealed) && (type.IsEnum || typeof(IObject).IsAssignableFrom(type)))
        {
            TypeToMarkdown.WriteTypeToMarkdown(@"C:\Github\api\docs\", type, methods, genericMethods);
        }
    }
}
