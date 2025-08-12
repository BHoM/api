---
title: ICellularOpening
---

# <small>BH.oM.Spatial.ShapeProfiles.CellularOpenings.</small>**ICellularOpening**



## Interface structure

### Implemented interfaces and base types

???+ bhom "The ICellularOpening is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Spatial.ShapeProfiles.CellularOpenings.[CircularCellularOpening](/api/oM/Dimensional/Spatial/ShapeProfiles/CellularOpenings/CircularCellularOpening)
    - BH.oM.Spatial.ShapeProfiles.CellularOpenings.[HexagonalCellularOpening](/api/oM/Dimensional/Spatial/ShapeProfiles/CellularOpenings/HexagonalCellularOpening)
    - BH.oM.Spatial.ShapeProfiles.CellularOpenings.[SinusoidalCellularOpening](/api/oM/Dimensional/Spatial/ShapeProfiles/CellularOpenings/SinusoidalCellularOpening)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| WidthWebPost | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Clear distance between openings. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| Spacing | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Centre to centre distance between openings. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IOpeningArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the area of a single opening. | [Area](/api/oM/Dimensional/Quantities/Attributes/Area) [m²] | Spatial_Engine |
| IOpeningCurve | [ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve) | Returns the curve of a single opening in the XY plane. | - | Spatial_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface ICellularOpening : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: Spatial_oM.dll

The C# interface definition is available on github:

- [ICellularOpening.cs](https://github.com/BHoM/BHoM/blob/develop/Spatial_oM/ShapeProfiles\CellularOpenings\ICellularOpening.cs)

All history and changes of the class can be found by inspection the history.
