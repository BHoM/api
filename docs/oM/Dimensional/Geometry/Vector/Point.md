---
title: Point
---

# <small>BH.oM.Geometry.</small>**Point**

Defines a dimensionless location in three-dimensional space.

## Class structure

### Implemented interfaces and base types

???+ bhom "The Point is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Geometry.[IGeometry](/api/oM/Dimensional/Geometry/Interface/IGeometry)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  [IComparable](https://learn.microsoft.com/en-us/dotnet/api/System.IComparable-1?view=netstandard-2.0)&lt;BH.oM.Geometry.[Point](/api/oM/Dimensional/Geometry/Vector/Point)&gt;
    -  BH.oM.Dimensional.[IElement0D](/api/oM/Dimensional/Dimensional/IElement0D)
    -  BH.oM.Dimensional.[IElement](/api/oM/Dimensional/Dimensional/IElement)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| X | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Position along global X coordinate axis. | - |
| Y | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Position along global Y coordinate axis. | - |
| Z | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Position along global Z coordinate axis. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Bounds | [BoundingBox](/api/oM/Dimensional/Geometry/Misc/BoundingBox) | Returns the global world axis oriented BoundingBox of the Point. Will be a singluar BoundingBox with Min and Max value set to the Point. | - | Geometry_Engine |
| Bounds | [BoundingBox](/api/oM/Dimensional/Geometry/Misc/BoundingBox) | Queries the IElement0Ds BoundingBox. Acts on the Point definition of the IElement0D through the Geometry_Engine. | - | Spatial_Engine |
| Centroid | [Point](/api/oM/Dimensional/Geometry/Vector/Point) | Queries the centre of weight for the homogeneous geometrical representation of an IElement0D. Always returns the point location due to zero-dimensionality of an IElement0D. | - | Spatial_Engine |
| ControlPoints | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api/oM/Dimensional/Geometry/Vector/Point)&gt; | Queries the control points of the geometrical representation of an IElement0D. Always returns the point location due to zero-dimensionality of an IElement0D. | - | Spatial_Engine |
| ElementCurves | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve)&gt; | Queries the defining curves of an IElement0D. Always returns empty collection due to zero-dimensionality of an IElement0D. | - | Spatial_Engine |
| ElementVertices | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api/oM/Dimensional/Geometry/Vector/Point)&gt; | Returns the point from the IElement0D. Mainly to accomodate the interface method. | - | Spatial_Engine |
| Geometry | [Point](/api/oM/Dimensional/Geometry/Vector/Point) | - | - | Geometry_Engine |
| GeometryHash | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Returns a signature of the input geometry, useful for diffing.<br>The hash is computed as a serialised array representing the coordinate of significant points taken on the geometry.<br>The number of points is reduced to the minimum essential to determine uniquely any geometry.<br>Additionally, the resulting points are transformed based on the source geometry type, to remove or minimize collisions.<br>(Any transformation so performed is translational only, in order to support geometrical tolerance, i.e. numerical distance, when comparing GeometryHashes downstream). | - | Geometry_Engine |
| IArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Calculates the area of the provided geometry. | [Area](/api/oM/Dimensional/Quantities/Attributes/Area) [m²] | Geometry_Engine |
| IArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Queries the area of the geometrical representation of an IElement. | [Area](/api/oM/Dimensional/Quantities/Attributes/Area) [m²] | Spatial_Engine |
| IBounds | [BoundingBox](/api/oM/Dimensional/Geometry/Misc/BoundingBox) | Returns the global world axis oriented enclosing BoundingBox for all points of the geometry, i.e. the box with the smallest volume within which all the points on the geometry lie. | - | Geometry_Engine |
| IBounds | [BoundingBox](/api/oM/Dimensional/Geometry/Misc/BoundingBox) | Queries the IElements BoundingBox. Acts on the elements geometrical definition of the IElement through the Geometry_Engine. | - | Spatial_Engine |
| ICentroid | [Point](/api/oM/Dimensional/Geometry/Vector/Point) | Queries the centre of weight for the homogeneous geometrical representation of an IElement. | - | Spatial_Engine |
| IControlPoints | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api/oM/Dimensional/Geometry/Vector/Point)&gt; | Queries the control points of the geometrical representation of an IElement. | - | Spatial_Engine |
| IElementCurves | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve)&gt; | Queries the geometricly defining curves of the IElements geometry. | - | Spatial_Engine |
| IElementVertices | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api/oM/Dimensional/Geometry/Vector/Point)&gt; | Returns the discontinuity points from the defining ICurves of the IElement. | - | Spatial_Engine |
| IGeometry | [Point](/api/oM/Dimensional/Geometry/Vector/Point) | Queries the defining geometrical object which all spatial operations will act on. | - | Spatial_Engine |
| IHashArray | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0)[] | Returns a signature of the input geometry, useful for distance-based comparisons and diffing.<br>The hash is computed as an array representing the coordinate of significant points taken on the geometry.<br>The number of points is reduced to the minimum essential to determine uniquely any geometry.<br>Additionally, the resulting points are transformed based on the source geometry type, to remove or minimize collisions.<br>(Any transformation so performed is translational only, in order to support geometrical tolerance, i.e. numerical distance, when comparing GeometryHashes downstream). | - | Geometry_Engine |
| IIsPlanar | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks whether all control points of an element lie in a single plane. | - | Spatial_Engine |
| IIsPlanar | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if the IGeometry is planar, i.e. all of its parts fit in a single plane. | - | Geometry_Engine |
| IIsSelfIntersecting | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if any of the curves defining an IElement is closer to itself than the tolerance at any two points (is self intersecting). In case of IElement2D, does not check for intersections between external and internal curves, or between different internal curves. | - | Spatial_Engine |
| IIsValid | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - | Geometry_Engine |
| INormals | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Vector](/api/oM/Dimensional/Geometry/Vector/Vector)&gt; | Interface method that returns the list of vectors normal to any IGeometry. | - | Geometry_Engine |
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a Geometry is null and outputs relevant error message. | - | Geometry_Engine |
| IsPlanar | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks whether all control points of an element lie in a single plane. | - | Spatial_Engine |
| IsPlanar | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if the Point is planar, i.e. all of its parts fit in a single plane. For a Point this is always the case, why this method always returns true. | - | Geometry_Engine |
| IsSelfIntersecting | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if the one dimensional representation of the IElement0D is closer to itself than the tolerance at any two points. Always false because a zero-dimensional IElement0D does not consist of curves. | - | Spatial_Engine |
| ISubParts | [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netstandard-2.0)&lt;[IGeometry](/api/oM/Dimensional/Geometry/Interface/IGeometry)&gt; | - | - | Geometry_Engine |
| IsValid | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - | Geometry_Engine |
| IsValid | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - | Geometry_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class Point : BH.oM.Geometry.IGeometry,
BH.oM.Base.IObject,
System.IComparable<BH.oM.Geometry.Point>,
BH.oM.Dimensional.IElement0D,
BH.oM.Dimensional.IElement
```

Assembly: Geometry_oM.dll

The C# class definition is available on github:

- [Point.cs](https://github.com/BHoM/BHoM/blob/develop/Geometry_oM/Vector\Point.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Geometry_oM/Point.json"
}
```

The JSON Schema is available on github here:

- [Point.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Geometry_oM/Point.json)
### Example JSON instance

Example JSON instance of type Point.

``` json title="Example JSON"
{
  "_t": "BH.oM.Geometry.Point",
  "X": 1.0,
  "Y": 2.0,
  "Z": 3.0,
  "_bhomVersion": "8.2"
}
```

