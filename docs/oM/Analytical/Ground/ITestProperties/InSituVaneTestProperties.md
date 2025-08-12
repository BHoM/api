---
title: InSituVaneTestProperties
---

# <small>BH.oM.Ground.</small>**InSituVaneTestProperties**

Properties related to the in-Situ Hand Vane Test.

## Class structure

### Implemented interfaces and base types

???+ bhom "The InSituVaneTestProperties is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Ground.[ITestProperties](/api/oM/Analytical/Ground/ITestProperties/ITestProperties)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Reference | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Test reference (IVAN_TESN). | - |
| Type | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Vane Type (IVAN_TYPE). | - |
| Method | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Test Method (IVAN_METH). | - |
| Tester | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Name of testing organisation (IVAN_CONT). | - |
| AccreditingBody | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Accrediting body and reference number (IVAN_CRED). | - |
| Status | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Test Status (TEST_STAT). | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class InSituVaneTestProperties : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.Ground.ITestProperties
```

Assembly: Ground_oM.dll

The C# class definition is available on github:

- [InSituVaneTestProperties.cs](https://github.com/BHoM/BHoM/blob/develop/Ground_oM/ITestProperties\InSituVaneTestProperties.cs)

All history and changes of the class can be found by inspection the history.
