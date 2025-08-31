---
title: Extrusion
---

# <small>BH.oM.Geometry.</small>**Extrusion**

A constant cross section surface, defined by a single profile curve and a linear axis.

## Class structure

### Implemented interfaces and base types

???+ bhom "The Extrusion is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Geometry.[ISurface](/api/oM/Dimensional/Geometry/Surface/ISurface)
    -  BH.oM.Geometry.[IGeometry](/api/oM/Dimensional/Geometry/Interface/IGeometry)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Curve | [ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve) | The Extrusion profile curve defining the constant cross sectional shape. Idential curves can be recreated at any point along the Extrusion axis through intersection with the Surface. | - |
| Direction | [Vector](/api/oM/Dimensional/Geometry/Vector/Vector) | The axis along which to translate the profile curve. The Vector magnitude determining the Extrusion length. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| Capped | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Defines the Extrusion as closed and therfore a solid volume. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Bounds | [BoundingBox](/api/oM/Dimensional/Geometry/Misc/BoundingBox) | Returns the global world axis oriented enclosing BoundingBox for all points on the surface, i.e. the box with the smallest volume within which all the surface points lie. | - | Geometry_Engine |
| Edges | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve)&gt; | Gets the edge curves of any ISurface by combining external and internal edges. | - | Geometry_Engine |
| ExternalEdges | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve)&gt; | Gets the external edge curves of the Extrusion. | - | Geometry_Engine |
| GeometryHash | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Returns a signature of the input geometry, useful for diffing.<br>The hash is computed as a serialised array representing the coordinate of significant points taken on the geometry.<br>The number of points is reduced to the minimum essential to determine uniquely any geometry.<br>Additionally, the resulting points are transformed based on the source geometry type, to remove or minimise collisions.<br>(Any transformation so performed is translational only, in order to support geometrical tolerance, i.e. numerical distance, when comparing GeometryHashes downstream). | - | Geometry_Engine |
| IArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Calculates the area of the provided geometry. | [Area](/api/oM/Dimensional/Quantities/Attributes/Area) [m²] | Geometry_Engine |
| IBounds | [BoundingBox](/api/oM/Dimensional/Geometry/Misc/BoundingBox) | Returns the global world axis oriented enclosing BoundingBox for all points of the geometry, i.e. the box with the smallest volume within which all the points on the geometry lie. | - | Geometry_Engine |
| IExternalEdges | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve)&gt; | Gets the external edge curves of the ISurface. | - | Geometry_Engine |
| IHashArray | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0)[] | Returns a signature of the input geometry, useful for distance-based comparisons and diffing.<br>The hash is computed as an array representing the coordinate of significant points taken on the geometry.<br>The number of points is reduced to the minimum essential to determine uniquely any geometry.<br>Additionally, the resulting points are transformed based on the source geometry type, to remove or minimise collisions.<br>(Any transformation so performed is translational only, in order to support geometrical tolerance, i.e. numerical distance, when comparing GeometryHashes downstream). | - | Geometry_Engine |
| IInternalEdges | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve)&gt; | Gets the internal edges of any ISurface. | - | Geometry_Engine |
| IIsPlanar | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if the IGeometry is planar, i.e. all of its parts fit in a single plane. | - | Geometry_Engine |
| IIsValid | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if any IGeometry is valid using dynamic dispatch. | - | Geometry_Engine |
| INormals | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Vector](/api/oM/Dimensional/Geometry/Vector/Vector)&gt; | Interface method that returns the list of vectors normal to any IGeometry. | - | Geometry_Engine |
| InternalEdges | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve)&gt; | Gets the internal edges of an Extrusion surface. | - | Geometry_Engine |
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a Geometry is null and outputs relevant error message. | - | Geometry_Engine |
| IsPlanar | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if the Extrusion is planar, i.e. all of its parts fit in a single plane. This is true if the direction vector has a length lower than the tolerance, or if the base curve is linear. | - | Geometry_Engine |
| ISubParts | [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netstandard-2.0)&lt;[ISurface](/api/oM/Dimensional/Geometry/Surface/ISurface)&gt; | Gets the individual surface parts that make up any ISurface. | - | Geometry_Engine |
| ISubParts | [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netstandard-2.0)&lt;[IGeometry](/api/oM/Dimensional/Geometry/Interface/IGeometry)&gt; | Gets the individual parts that make up any IGeometry. | - | Geometry_Engine |
| IsValid | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if any IGeometry is valid. Currently returns true for all geometries. | - | Geometry_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class Extrusion : BH.oM.Geometry.ISurface, BH.oM.Geometry.IGeometry, BH.oM.Base.IObject
```

Assembly: Geometry_oM.dll

The C# class definition is available on github:

- [Extrusion.cs](https://github.com/BHoM/BHoM/blob/develop/Geometry_oM/Surface\Extrusion.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Geometry_oM/Extrusion.json"
}
```

The JSON Schema is available on github here:

- [Extrusion.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Geometry_oM/Extrusion.json)
### Example JSON instance

Example JSON instance of type Extrusion.

``` json title="Example JSON"
{
  "_t": "BH.oM.Geometry.Extrusion",
  "Curve": {
    "_t": "BH.oM.Geometry.Circle",
    "Centre": {
      "_t": "BH.oM.Geometry.Point",
      "X": 0.0,
      "Y": 0.0,
      "Z": 0.0
    },
    "Normal": {
      "_t": "BH.oM.Geometry.Vector",
      "X": 0.0,
      "Y": 0.0,
      "Z": 1.0
    },
    "Radius": 5.0
  },
  "Direction": {
    "_t": "BH.oM.Geometry.Vector",
    "X": 0.0,
    "Y": 0.0,
    "Z": 1.0
  },
  "Capped": true,
  "_bhomVersion": "8.2"
}
```

