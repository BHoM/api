---
title: BoundingBox
---

# <small>BH.oM.Geometry.</small>**BoundingBox**

An axis aligned cuboid, which describes the smallest volume Box, oriented with the global coordinate system, that fully encompases a set of geometry.
Defined by its two extreme corner Points, these six coordinate values of Min and Max X, Y and Z are combined to specify all eight Box corners.

## Class structure

### Implemented interfaces and base types

???+ bhom "The BoundingBox is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Geometry.[IGeometry](/api/oM/Dimensional/Geometry/Interface/IGeometry)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Min | [Point](/api/oM/Dimensional/Geometry/Vector/Point) | The lower bound values for the X, Y and Z coordinates of the Box corner Points. | - |
| Max | [Point](/api/oM/Dimensional/Geometry/Vector/Point) | The upper bound values for the X, Y and Z coordinates of the Box corner Points. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Bounds | [BoundingBox](/api/oM/Dimensional/Geometry/Misc/BoundingBox) | Returns the BoundingBox of the BoundingBox (itself). | - | Geometry_Engine |
| Centre | [Point](/api/oM/Dimensional/Geometry/Vector/Point) | Gets the centre Point of a BoundingBox. | - | Geometry_Engine |
| Corners | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api/oM/Dimensional/Geometry/Vector/Point)&gt; | Returns a list of 8 corner points of a bounding box. | - | Geometry_Engine |
| DiagonalLength | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns a diagonal length (distance between Min and Max) of a BoundingBox. | - | Geometry_Engine |
| Edges | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Line](/api/oM/Dimensional/Geometry/Curve/Line)&gt; | Gets all the edges of a BoundingBox as a collection of Lines. | - | Geometry_Engine |
| Extents | [Vector](/api/oM/Dimensional/Geometry/Vector/Vector) | Gets the extents of a BoundingBox as a Vector representing its dimensions. | - | Geometry_Engine |
| GeometryHash | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Returns a signature of the input geometry, useful for diffing.<br>The hash is computed as a serialised array representing the coordinate of significant points taken on the geometry.<br>The number of points is reduced to the minimum essential to determine uniquely any geometry.<br>Additionally, the resulting points are transformed based on the source geometry type, to remove or minimise collisions.<br>(Any transformation so performed is translational only, in order to support geometrical tolerance, i.e. numerical distance, when comparing GeometryHashes downstream). | - | Geometry_Engine |
| Height | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the vertical orthogonal height of a BHoM BoundingBox based on its Z minimum and maximum values. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] | Geometry_Engine |
| HorizontalHypotenuseLength | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the horizontal hypotenuse length of a BHoM BoundingBox. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] | Geometry_Engine |
| IArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Calculates the area of the provided geometry. | [Area](/api/oM/Dimensional/Quantities/Attributes/Area) [m²] | Geometry_Engine |
| IBounds | [BoundingBox](/api/oM/Dimensional/Geometry/Misc/BoundingBox) | Returns the global world axis oriented enclosing BoundingBox for all points of the geometry, i.e. the box with the smallest volume within which all the points on the geometry lie. | - | Geometry_Engine |
| IHashArray | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0)[] | Returns a signature of the input geometry, useful for distance-based comparisons and diffing.<br>The hash is computed as an array representing the coordinate of significant points taken on the geometry.<br>The number of points is reduced to the minimum essential to determine uniquely any geometry.<br>Additionally, the resulting points are transformed based on the source geometry type, to remove or minimise collisions.<br>(Any transformation so performed is translational only, in order to support geometrical tolerance, i.e. numerical distance, when comparing GeometryHashes downstream). | - | Geometry_Engine |
| IIsPlanar | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if the IGeometry is planar, i.e. all of its parts fit in a single plane. | - | Geometry_Engine |
| IIsValid | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if any IGeometry is valid using dynamic dispatch. | - | Geometry_Engine |
| INormals | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Vector](/api/oM/Dimensional/Geometry/Vector/Vector)&gt; | Interface method that returns the list of vectors normal to any IGeometry. | - | Geometry_Engine |
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a Geometry is null and outputs relevant error message. | - | Geometry_Engine |
| ISubParts | [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netstandard-2.0)&lt;[IGeometry](/api/oM/Dimensional/Geometry/Interface/IGeometry)&gt; | Gets the individual parts that make up any IGeometry. | - | Geometry_Engine |
| IsValid | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if any IGeometry is valid. Currently returns true for all geometries. | - | Geometry_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class BoundingBox : BH.oM.Geometry.IGeometry, BH.oM.Base.IObject
```

Assembly: Geometry_oM.dll

The C# class definition is available on github:

- [BoundingBox.cs](https://github.com/BHoM/BHoM/blob/develop/Geometry_oM/Misc\BoundingBox.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Geometry_oM/BoundingBox.json"
}
```

The JSON Schema is available on github here:

- [BoundingBox.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Geometry_oM/BoundingBox.json)
### Example JSON instance

Example JSON instance of type BoundingBox.

``` json title="Example JSON"
{
  "_t": "BH.oM.Geometry.BoundingBox",
  "Min": {
    "_t": "BH.oM.Geometry.Point",
    "X": 0.0,
    "Y": 0.0,
    "Z": 0.0
  },
  "Max": {
    "_t": "BH.oM.Geometry.Point",
    "X": 10.0,
    "Y": 10.0,
    "Z": 5.0
  },
  "_bhomVersion": "8.2"
}
```

