---
title: Location
---

# <small>BH.oM.Ground.</small>**Location**

Details for the location of the borehole including project references, phasing and location algorithms.

## Class structure

### Implemented interfaces and base types

???+ bhom "The Location is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Ground.[IBoreholeProperty](/api/oM/Analytical/Ground/BoreholeProperties/IBoreholeProperty)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Method | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Method of location (LOCA_LOCM). | - |
| SubDivision | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Site location sub division (within project) code or description (LOCA_LOCA). | - |
| Phase | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Investigation phase grouping code or description (LOCA_CLST). | - |
| Alignment | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Alignment identifier (LOCA_ALID). | - |
| Offset | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Offset from the alignment (LOCA_OFFS). | - |
| Chainage | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Chainage relating to the project (LOCA_CNGE). | - |
| Algorithm | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Reference to details of algorithm used to calculate local grid reference, local ground levels or chainage (LOCA_TRAN). | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IsValid | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a IBoreholeProperty is valid and outputs relevant error message. | - | Ground_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class Location : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.Ground.IBoreholeProperty
```

Assembly: Ground_oM.dll

The C# class definition is available on github:

- [Location.cs](https://github.com/BHoM/BHoM/blob/develop/Ground_oM/BoreholeProperties\Location.cs)

All history and changes of the class can be found by inspection the history.
