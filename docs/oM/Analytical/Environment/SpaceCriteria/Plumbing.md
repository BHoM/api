---
title: Plumbing
---

# <small>BH.oM.Environment.SpaceCriteria.</small>**Plumbing**

The plumbing attributes of a space are indicative of the amount of cold water, hot water and waste required by a space, as well as requirements for vent, floor drains, hose bibs or natural gas

## Class structure

### Implemented interfaces and base types

???+ bhom "The Plumbing is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ColdWaterUnits | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The total number of cold water units (aka fixture units or loading units) that should be provided to the space based on the number of plumbing fixtures requiring cold water within the space (e.g. 1 sink = 1.0 units, 2 sinks = 2.0 units, 1 urinal = 10.0 units per IPC2015 Table E103.3). | - |
| HotWaterUnits | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The total number of hot water units (aka fixture units or loading units) that should be provided to the space based on the number of plumbing fixtures requiring hot water within the space (e.g. 1 sink = 1.0 units, 2 sinks = 2.0 units, 1 urinal = 0.0 units (no hot water for urinals!) per IPC2015 Table E103.3). | - |
| WasteUnits | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The total number of waste/sanitary/drainage units (aka fixture units or loading units) that should be provided to the space based on the number of plumbing fixtures requiring waste/sanitary/drainage connections within the space (e.g. 1 sink = 2.0 units, 2 sinks = 4.0 units, 1 urinal = 4.0 units per IPC2018 Table 709.1). | - |
| NaturalGasRate | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The natural gas rate will indicate the m3/hr of gas required within the space incurred by stovetops, fireplaces or clothes dryers. | - |
| VentRequirement | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | An indication that the space will require vent (inherently linked to the need for waste/sanitary/drainage) the size will be calculated based on the number of waste units required. | - |
| FloorDrainRequirement | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | An indication that the space will require floor drains (janitor's closet or mechanical room). | - |
| HoseBibRequirement | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | An indication that the space will require hose bibs (janitor's closet or mechanical room). | - |


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
public class Plumbing : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: Environment_oM.dll

The C# class definition is available on github:

- [Plumbing.cs](https://github.com/BHoM/BHoM/blob/develop/Environment_oM/SpaceCriteria\Plumbing.cs)

All history and changes of the class can be found by inspection the history.
