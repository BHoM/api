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

        private static List<MethodInfo> GetExtensionMethods(this Type type, List<Type> baseTypes, List<Type> ignoredTargetTypes, Dictionary<Type, List<MethodInfo>> extensionMethods, Dictionary<Type, List<MethodInfo>> genericExtensionMethods)
        {
            List<MethodInfo> methods;
            if (!extensionMethods.TryGetValue(type, out methods))
                methods = new List<MethodInfo>();

            if (baseTypes != null)
            {
                List<Type> methodBaseTypes;
                if (!ignoredTargetTypes.Contains(type))
                    methodBaseTypes = baseTypes.Except(ignoredTargetTypes).ToList();    //Skip methods targeting base types to avoid flooding the docs with methods acceptiong IObejct, BHoMObject etc, except for thos types
                else
                    methodBaseTypes = baseTypes;

                foreach (Type baseType in methodBaseTypes)
                {
                    if (extensionMethods.TryGetValue(baseType, out List<MethodInfo> baseExtensionMethod))
                        methods.AddRange(baseExtensionMethod);
                }
            }

            List<Type> genericTypes = baseTypes.Where(x => x.IsGenericType).ToList();
            if(type.IsGenericType)
                genericTypes.Add(type);

            if (genericTypes.Count > 0)
            {
                foreach (var genericExtensions in extensionMethods.Where(x => x.Key.IsGenericType))
                {
                    if (genericTypes.Any(x => PassesGenericTypeAndAllTypeConstraints(genericExtensions.Key, x)))
                        methods.AddRange(genericExtensions.Value);
                }
            }

            methods.AddRange(GenericExtensionMethods(type, baseTypes, ignoredTargetTypes.Contains(type) ? new List<Type>() : ignoredTargetTypes, genericExtensionMethods));

            methods = methods.Distinct().ToList();
            methods.Sort((a, b) => a.CompareMethods(b, type));


            return methods;
        }

        /***************************************************/


        private static List<MethodInfo> GenericExtensionMethods(this Type type, List<Type> baseTypes, List<Type> ignoredTargetTypes, Dictionary<Type, List<MethodInfo>> genericExtensionMethods)
        {
            List<MethodInfo> methods = new List<MethodInfo>();
            foreach (var typeMethods in genericExtensionMethods)
            {
                Type methodType = typeMethods.Key;

                if (methodType.IsGenericParameter)
                {
                    bool assignable = true;

                    Type[] constraints = methodType.GetGenericParameterConstraints();

                    foreach (var constraint in constraints)
                    {
                        if(!constraint.IsAssignableFrom(type))
                            assignable = false;
                    }

                    if (assignable)
                    {
                        bool ignored = false;

                        foreach (Type ignoredType in ignoredTargetTypes)
                        {
                            bool ignoredTypeAssignable = true;
                            foreach (var constraint in constraints)
                            {
                                if (!constraint.IsAssignableFrom(ignoredType))
                                    ignoredTypeAssignable = false;
                            }
                            if (ignoredTypeAssignable)
                            {
                                ignored = true;
                                break;
                            }
                        }
                        if (!ignored)
                            methods.AddRange(typeMethods.Value);
                    }

                }
                else if (methodType.IsGenericType)
                {
                    Type genTypeDef = methodType.GetGenericTypeDefinition();
                    if (type.IsGenericType && genTypeDef == type.GetGenericTypeDefinition())
                    {
                        methods.AddRange(typeMethods.Value);
                    }

                    if (baseTypes != null)
                    {
                        foreach (Type baseType in baseTypes.Where(x => x.IsGenericType))
                        {
                            if (baseType.GetGenericTypeDefinition() == genTypeDef)
                            {
                                methods.AddRange(typeMethods.Value);
                            }
                        }
                    }
                }
            }
            return methods;
        }

        /***************************************************/

        private static bool PassesGenericTypeAndAllTypeConstraints(Type methodType, Type type)
        { 
            if(methodType.GetGenericTypeDefinition() != type.GetGenericTypeDefinition())
                return false;

            Type[] methodTypeArg = methodType.GenericTypeArguments;
            Type[] typeArgs = type.GenericTypeArguments;

            if(methodTypeArg.Length != typeArgs.Length)
                return false;

            for (int i = 0; i < methodTypeArg.Length; i++)
            { 
                Type methArg = methodTypeArg[i];
                Type arg = typeArgs[i];

                if (methArg.IsAssignableFrom(arg))
                    continue;

                if (methArg.IsGenericParameter)
                {
                    bool assignable = true;

                    Type[] constraints = methArg.GetGenericParameterConstraints();

                    foreach (var constraint in constraints)
                    {
                        if (!constraint.IsAssignableFrom(arg))
                            assignable = false;
                    }

                    if(!assignable)
                        return false;
                }
                if (methArg.IsGenericType && arg.IsGenericType)
                    return PassesGenericTypeAndAllTypeConstraints(methArg, arg);
            }

            return true;
        }

        /***************************************************/

        private static int CompareMethods(this MethodInfo a, MethodInfo b, Type type)
        {
            //Check if adapter method if so, put after
            //bool aIsAdapter = a.IsAdapterNamespaceMethod();
            //bool bIsAdapter = b.IsAdapterNamespaceMethod();
            //if (aIsAdapter && !bIsAdapter)
            //    return 1;

            //if (bIsAdapter && !aIsAdapter)
            //    return -1;

            ////Check if on of the methods come from an engine with matching namespace
            //string omNameSpace = type.MainNameSpace();
            //string aNameSpace = a.MainNameSpace();
            //string bNameSpace = b.MainNameSpace();

            //if (aNameSpace == omNameSpace && bNameSpace != omNameSpace)
            //    return -1;

            //if (bNameSpace == omNameSpace && aNameSpace != omNameSpace)
            //    return 1;

            ////Check if type is matching provided type
            //bool aMatchingType = a.GetParameters()[0].ParameterType == type;
            //bool bMatchingType = a.GetParameters()[0].ParameterType == type;

            //if (aMatchingType && !bMatchingType)
            //    return -1;

            //if (bMatchingType && !aMatchingType)
            //    return 1;

            ////Compare namespace
            //int nameSpaceCompare = aNameSpace.CompareTo(bNameSpace);
            //if (nameSpaceCompare != 0)
            //    return nameSpaceCompare;

            //Compare method name
            return a.Name.CompareTo(b.Name);
        }

        /***************************************************/

        private static bool IsAdapterNamespaceMethod(this MethodInfo method)
        {
            return method.DeclaringType.Namespace.StartsWith("BH.Engine.Adapters");
        }

        /***************************************************/

        private static string MainNameSpace(this MethodInfo method)
        {
            return method.DeclaringType.MainNameSpace();
        }

        /***************************************************/

        private static string MainNameSpace(this Type type)
        {
            string[] split = type.Namespace.Split('.');
            if (split.Length < 3)
                return "";

            if (split.Length > 3 && split[3] == "Adapters")
                return split[3];

            return split[2];
        }

        /***************************************************/
    }
}
