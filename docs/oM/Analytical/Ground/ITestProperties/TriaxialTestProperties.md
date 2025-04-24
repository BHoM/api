---
title: TriaxialTestProperties
---

# <small>BH.oM.</small>**TriaxialTestProperties**

Properties of the triaxial tests.

## Class structure

### Implemented interfaces and base types

???+ bhom "The TriaxialTestProperties is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Ground.[ITestProperties](/api/oM/Analytical/Ground/ITestProperties/ITestProperties)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| SampleDiameter | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Specimen diameter (TRIT_SDIA). | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| SampleLength | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Specimen length (TRIT_SLEN). | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| TriaxialReference | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Triaxial test and/or stage reference (TRIT_TESN). | - |


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
public class TriaxialTestProperties : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.Ground.ITestProperties
```

Assembly: Ground_oM.dll

The class is defined in C#. The class definition is available on github:

- [TriaxialTestProperties.cs](https://github.com/BHoM/BHoM/blob/develop/Ground_oM/ITestProperties\TriaxialTestProperties.cs)

All history and changes of the class can be found by inspection the history.
