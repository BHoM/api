---
title: Triaxial
---

# <small>BH.oM.Ground.</small>**Triaxial**

A set of data related to triaxial tests carried out

## Class structure

### Implemented interfaces and base types

???+ bhom "The Triaxial is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Ground.[ITest](/api/oM/Analytical/Ground/ITest)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Id | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Location identifier relating the borehole to the strata (LOCA_ID). | - |
| Top | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Depth to the top of the sample, measured from the top of the borehole (SAMP_TOP). | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| SpecimenDepth | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Depth to the top of the specimen (SPEC_DPTH). | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| SampleId | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Sample Identification (SAMP_ID). | - |
| SpecimenReference | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Specimen Reference (SPEC_REF). | - |
| UndrainedShearStrength | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Undrained shear strength at failure (TRIT_CU). | [Pressure](/api/oM/Dimensional/Quantities/Attributes/Pressure) [Pa] |
| FailureMode | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Mode of Failure (TRIT_MODE). | - |
| Properties | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ITestProperties](/api/oM/Analytical/Ground/ITestProperties/ITestProperties)&gt; | A list of different properties including references and results. | - |


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
public class Triaxial : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.Ground.ITest
```

Assembly: Ground_oM.dll

The C# class definition is available on github:

- [Triaxial.cs](https://github.com/BHoM/BHoM/blob/develop/Ground_oM/Triaxial.cs)

All history and changes of the class can be found by inspection the history.
