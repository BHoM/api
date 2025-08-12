---
title: PlumbingFlowFragment
---

# <small>BH.oM.MEP.Fragments.</small>**PlumbingFlowFragment**



## Class structure

### Implemented interfaces and base types

???+ bhom "The PlumbingFlowFragment is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ColdWaterFlowRate | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The volume of cold water being conveyed by the Plumbing Fixture per second (m3/s). | [VolumetricFlowRate](/api/oM/Dimensional/Quantities/Attributes/VolumetricFlowRate) [m³/s] |
| HotWaterFlowRate | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The volume of hot water being conveyed by the Plumbing Fixture per second (m3/s). | [VolumetricFlowRate](/api/oM/Dimensional/Quantities/Attributes/VolumetricFlowRate) [m³/s] |
| DrainageFlowRate | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The volume of waste/drainage being conveyed by the Plumbing Fixture per second (m3/s). | [VolumetricFlowRate](/api/oM/Dimensional/Quantities/Attributes/VolumetricFlowRate) [m³/s] |


## Code and Schema

### C# implementation

``` C# title="C#"
public class PlumbingFlowFragment : BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: MEP_oM.dll

The C# class definition is available on github:

- [PlumbingFlowFragment.cs](https://github.com/BHoM/BHoM/blob/develop/MEP_oM/Fragments\PlumbingFlowFragment.cs)

All history and changes of the class can be found by inspection the history.
