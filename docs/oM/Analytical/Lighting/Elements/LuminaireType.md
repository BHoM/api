---
title: LuminaireType
---

# <small>BH.oM.Lighting.Elements.</small>**LuminaireType**

A LuminaireType containing manufacturer, dimensional, and other property data applied to a Luminaire.

## Class structure

### Implemented interfaces and base types

???+ bhom "The LuminaireType is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Manufacturer | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Name of the Manufacturer of this LuminaireType | - |
| LuminaireGeometry | [BoundaryRepresentation](/api/oM/Dimensional/Geometry/Solid/BoundaryRepresentation) | Boundary Representation of the LuminaireType's Geometry | - |
| Load | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Total Load of the LuminaireType | - |
| Flux | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Total Flux of the LuminaireType | - |
| NumberOfLamps | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Number of lamps included in this LuminaireType | - |
| MountingType | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Mounting type eg Wall-Mounted, Ceiling Recessed, etc) | - |
| Description | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | General description | - |
| Model | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Model name of the LuminaireType as per the Manufacturer | - |


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
public class LuminaireType : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: Lighting_oM.dll

The C# class definition is available on github:

- [LuminaireType.cs](https://github.com/BHoM/BHoM/blob/develop/Lighting_oM/Elements\LuminaireType.cs)

All history and changes of the class can be found by inspection the history.
