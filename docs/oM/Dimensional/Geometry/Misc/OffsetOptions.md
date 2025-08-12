---
title: OffsetOptions
---

# <small>BH.oM.Geometry.</small>**OffsetOptions**

Options for curve offset operations.

## Class structure

### Implemented interfaces and base types

???+ bhom "The OffsetOptions is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| RemoveShortSegments | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true segments shorter than tolerance are removed. Only applicable for polyline offsets. Recomended for the general case to be set to true. To be noted that when this option is true, the topology of the polyline might change due to segments being removed. Defaults to true. | - |
| HandleCreatedLocalSelfIntersections | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true mehtod avoids creation of self intersections for offsets of concave curves by removal of segments tending to 0 length. Only applicable for Polyline offsets. Recomended for the general case to be set to true. To be noted that when this option is true, the topology of the polyline might change due to segments being removed. Defaults to true. | - |
| HandleGeneralCreatedSelfIntersections | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true mehtod avoids creation of self intersections for offsets of concave curves checking if any vertex being offsetted is ending up on or beyond another segment. Recomended for the general case to be set to true. To be noted that when this option is true, the topology of the polyline might change due to segments being removed. Only applicable for Polyline offsets. Defaults to true. | - |
| HandleAdjacentParallelSegments | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true handles adjecent parallel segemnts, that is, segments that have an angle below tolerance. This is handled by removal of the vertex connection the two segments for a concave offset and introductions of one additional vertex for a convex offset. Recomended for the general case to be set to true. To be noted that when this option is true, the topology of the polyline might change due to segments being added and/or removed. Only applicable for Polyline offsets. Defaults to true. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class OffsetOptions : BH.oM.Base.IObject
```

Assembly: Geometry_oM.dll

The C# class definition is available on github:

- [OffsetOptions.cs](https://github.com/BHoM/BHoM/blob/develop/Geometry_oM/Misc\OffsetOptions.cs)

All history and changes of the class can be found by inspection the history.
