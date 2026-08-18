---
title: WaterStrike
---

# <small>BH.oM.Ground.</small>**WaterStrike**

A water strike object containing the details of the water strike based on the AGS schema.

## Class structure

### Implemented interfaces and base types

???+ bhom "The WaterStrike is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Id | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Location identifier relating the borehole to the strata (LOCA_ID). | - |
| Depth | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Depth to the initial water strike (WSTG_DPTH). | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| TimePostStrike | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The time after strike. Note the BHoM stores time in SI units (i.e. seconds) <br> whereas this is defined in minutes in the AGS schema (WSTD_NMIN). | [Time](/api/oM/Dimensional/Quantities/Attributes/Time) [s] |
| DepthPostStrike | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Depth to water after TimePostStrike (WSTD_POST). | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| Remarks | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | General remarks for the investigation (WSTD_REM). | - |
| File | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Associated file reference including instructions and photographs (FILE_FSET). | - |


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
public class WaterStrike : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: Ground_oM.dll

The C# class definition is available on github:

- [WaterStrike.cs](https://github.com/BHoM/BHoM/blob/develop/Ground_oM/WaterStrike.cs)

All history and changes of the class can be found by inspection the history.
