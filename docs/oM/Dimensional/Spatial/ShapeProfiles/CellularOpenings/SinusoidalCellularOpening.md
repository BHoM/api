---
title: SinusoidalCellularOpening
---

# <small>BH.oM.Spatial.ShapeProfiles.CellularOpenings.</small>**SinusoidalCellularOpening**



## Class structure

### Implemented interfaces and base types

???+ bhom "The SinusoidalCellularOpening is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Spatial.ShapeProfiles.CellularOpenings.[ICellularOpening](/api/oM/Dimensional/Spatial/ShapeProfiles/CellularOpenings/ICellularOpening)
    -  BH.oM.Base.[IImmutable](/api/oM/Framework/Base/Interface/IImmutable)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Height | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Total height of the opening. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| Width | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Total width of the opening. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| SinusoidalLength | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Width of the sinusoidal part of the opening. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| WidthWebPost | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Clear distance between openings. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| Spacing | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Centre to centre distance between openings. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |


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
| IOpeningArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the area of a single opening. | [Area](/api/oM/Dimensional/Quantities/Attributes/Area) [m²] | Spatial_Engine |
| IOpeningCurve | [ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve) | Returns the curve of a single opening in the XY plane. | - | Spatial_Engine |
| OpeningArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the area of a single opening. | [Area](/api/oM/Dimensional/Quantities/Attributes/Area) [m²] | Spatial_Engine |
| OpeningCurve | [PolyCurve](/api/oM/Dimensional/Geometry/Curve/PolyCurve) | Returns the curve of a single opening in the XY plane. | - | Spatial_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class SinusoidalCellularOpening : BH.oM.Base.BHoMObject,
BH.oM.Base.IBHoMObject,
BH.oM.Base.IObject,
BH.oM.Spatial.ShapeProfiles.CellularOpenings.ICellularOpening,
BH.oM.Base.IImmutable
```

Assembly: Spatial_oM.dll

The C# class definition is available on github:

- [SinusoidalCellularOpening.cs](https://github.com/BHoM/BHoM/blob/develop/Spatial_oM/ShapeProfiles\CellularOpenings\SinusoidalCellularOpening.cs)

All history and changes of the class can be found by inspection the history.
