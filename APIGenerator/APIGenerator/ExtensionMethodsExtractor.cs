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
    public static class ExtensionMethodsExtractor
    {
        [Description("Loads all .dll assemblies with names ending with oM, _Engine and _Adapter (with optional suffixes) from a given folder.")]
        public static (Dictionary<Type, List<MethodInfo>>, Dictionary<Type, List<MethodInfo>>) GetAllExtensionMethods(List<Assembly> engineAssemblies)
        {
            Dictionary<Type, List<MethodInfo>> extensionMethods = new Dictionary<Type, List<MethodInfo>>();
            Dictionary<Type, List<MethodInfo>> genericExtensionMethods = new Dictionary<Type, List<MethodInfo>>();

            foreach (Assembly assembly in engineAssemblies)
            {
                try
                {


                    foreach (Type type in assembly.GetTypes())
                    {
                        if (type.Name == "Query")
                        {
                            List<MethodInfo> allMethods = type.GetMethods(BindingFlags.Static | BindingFlags.Public).ToList();

                            List<MethodInfo> methods = allMethods.Where(x =>
                            {
                                var parameters = x.GetParameters();

                                if(parameters.Length == 0)  //Rule out methods with no parameters
                                    return false;

                                if (parameters.Length == 1) //Keep methods with exactly one parameter
                                    return true;

                                //ALso keep for which the only additional parameters are tolerance parameters
                                //Filtered as need to be double type with default value and name containing tol
                                //Doing this to get methods like Area included (currently has a tolerance to check if curves are closed
                                return parameters.Skip(1).All(x => x.HasDefaultValue);

                            }).ToList();

                            foreach (MethodInfo method in methods)
                            {
                                if (method.IsGenericMethod)
                                {
                                    Type[] methodGenerics = method.GetGenericArguments();
                                    ParameterInfo[] parameters = method.GetParameters();
                                    Type paramType = parameters[0].ParameterType;
                                    if (!(paramType.IsGenericParameter || paramType.IsGenericType))
                                    {
                                        Console.WriteLine($"Skipping generic method {method.DeclaringType.FullName}.{method.Name} as the first parameter is not generic.");
                                        continue;
                                    }

                                    if (typeof(IEnumerable).IsAssignableFrom(paramType))
                                    {
                                        Console.WriteLine($"Skipping generic method {method.DeclaringType.FullName}.{method.Name} as the first parameter an IEnumerable.");
                                        continue;
                                    }

                                    bool allMethodGenericsReferToFirstType = true;

                                    foreach (Type constraint in methodGenerics)
                                    {
                                        if (paramType == constraint)
                                            continue;

                                        if (paramType.IsGenericType)
                                        {
                                            if (paramType.GenericTypeArguments.Any(x => x == constraint))
                                                continue;
                                        }

                                        allMethodGenericsReferToFirstType = false;
                                        break;
                                    }

                                    if (!allMethodGenericsReferToFirstType)
                                    {
                                        Console.WriteLine($"Skipping generic method {method.DeclaringType.FullName}.{method.Name} as unable to match all method type constraints to the first parameter.");
                                        continue;
                                    }

                                    if (!genericExtensionMethods.ContainsKey(paramType))
                                        genericExtensionMethods[paramType] = new List<MethodInfo>();

                                    genericExtensionMethods[paramType].Add(method);

                                }
                                else
                                {
                                    Type paramType = method.GetParameters()[0].ParameterType;
                                    if (!extensionMethods.ContainsKey(paramType))
                                        extensionMethods[paramType] = new List<MethodInfo>();

                                    extensionMethods[paramType].Add(method);
                                }
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    
                }
            }

            return (extensionMethods, genericExtensionMethods);
        }

    }
}
