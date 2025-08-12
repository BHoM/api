---
title: TriaxialResultProperties
---

# <small>BH.oM.Ground.</small>**TriaxialResultProperties**

Properties related to the results based on the triaxial tests.

## Class structure

### Implemented interfaces and base types

???+ bhom "The TriaxialResultProperties is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Ground.[ITestProperties](/api/oM/Analytical/Ground/ITestProperties/ITestProperties)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| InitialWaterMoistureContent | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Specimen initial water/moisture content (TRIT_IMC). | [Ratio](/api/oM/Dimensional/Quantities/Attributes/Ratio) [-] |
| FinalWaterMoistureContent | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Specimen final water/moisture content (TRIT_FMC). | [Ratio](/api/oM/Dimensional/Quantities/Attributes/Ratio) [-] |
| TotalCellPressure | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Total cell pressure (TRIT_CELL). | [Pressure](/api/oM/Dimensional/Quantities/Attributes/Pressure) [Pa] |
| DeviatorStress | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Corrected deviator stress at failure (TRIT_DEVF). | [Stress](/api/oM/Dimensional/Quantities/Attributes/Stress) [Pa] |
| BulkDensity | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Initial bulk density (TRIT_BDEN). | [Density](/api/oM/Dimensional/Quantities/Attributes/Density) [kg/m³] |
| DryDensity | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Initial dry density (TRIT_DDEN). | [Density](/api/oM/Dimensional/Quantities/Attributes/Density) [kg/m³] |
| AxialStrain | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Axial strain at failure (TRIT_STRN). | [Strain](/api/oM/Dimensional/Quantities/Attributes/Strain) [-] |
| ShearRate | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Mean rate of shear (TRIT_RATE). | - |
| FailureZoneWaterContent | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Failure zone water content (TRIT_FZWC). | [Ratio](/api/oM/Dimensional/Quantities/Attributes/Ratio) [-] |


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
public class TriaxialResultProperties : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.Ground.ITestProperties
```

Assembly: Ground_oM.dll

The C# class definition is available on github:

- [TriaxialResultProperties.cs](https://github.com/BHoM/BHoM/blob/develop/Ground_oM/ITestProperties\TriaxialResultProperties.cs)

All history and changes of the class can be found by inspection the history.
