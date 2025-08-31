---
title: Mesh
---

# <small>BH.oM.Geometry.</small>**Mesh**

A polygon mesh, defined by a list of triangular or quadrilateral Faces and their Vertices.

## Class structure

### Implemented interfaces and base types

???+ bhom "The Mesh is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Geometry.[IGeometry](/api/oM/Dimensional/Geometry/Interface/IGeometry)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Vertices | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api/oM/Dimensional/Geometry/Vector/Point)&gt; | Defines the three-dimensional Mesh geometry as  X, Y, Z coordinates. | - |
| Faces | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Face](/api/oM/Dimensional/Geometry/Mesh/Face)&gt; | The list of polygons, defined as corner Point indices referencing the list of Vertices. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Area | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Calculates the area of the provided geometry. | [Area](/api/oM/Dimensional/Quantities/Attributes/Area) [m²] | Geometry_Engine |
| Bounds | [BoundingBox](/api/oM/Dimensional/Geometry/Misc/BoundingBox) | Returns the global world axis oriented enclosing BoundingBox for all verices of the mesh, i.e. the box with the smallest volume within which all the mesh vertices lie. | - | Geometry_Engine |
| Centres | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api/oM/Dimensional/Geometry/Vector/Point)&gt; | Gets the centre Points of all faces in a Mesh. | - | Geometry_Engine |
| Edges | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Line](/api/oM/Dimensional/Geometry/Curve/Line)&gt; | Gets all the unique edges of a Mesh as a collection of Lines. | - | Geometry_Engine |
| ExternalEdges | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Line](/api/oM/Dimensional/Geometry/Curve/Line)&gt; | Gets the external edge curves of a mesh as a set of lines. Extraction is done by finding all unique edges in the mesh. | - | Geometry_Engine |
| GeometryHash | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Returns a signature of the input geometry, useful for diffing.<br>The hash is computed as a serialised array representing the coordinate of significant points taken on the geometry.<br>The number of points is reduced to the minimum essential to determine uniquely any geometry.<br>Additionally, the resulting points are transformed based on the source geometry type, to remove or minimise collisions.<br>(Any transformation so performed is translational only, in order to support geometrical tolerance, i.e. numerical distance, when comparing GeometryHashes downstream). | - | Geometry_Engine |
| IArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Calculates the area of the provided geometry. | [Area](/api/oM/Dimensional/Quantities/Attributes/Area) [m²] | Geometry_Engine |
| IBounds | [BoundingBox](/api/oM/Dimensional/Geometry/Misc/BoundingBox) | Returns the global world axis oriented enclosing BoundingBox for all points of the geometry, i.e. the box with the smallest volume within which all the points on the geometry lie. | - | Geometry_Engine |
| IHashArray | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0)[] | Returns a signature of the input geometry, useful for distance-based comparisons and diffing.<br>The hash is computed as an array representing the coordinate of significant points taken on the geometry.<br>The number of points is reduced to the minimum essential to determine uniquely any geometry.<br>Additionally, the resulting points are transformed based on the source geometry type, to remove or minimise collisions.<br>(Any transformation so performed is translational only, in order to support geometrical tolerance, i.e. numerical distance, when comparing GeometryHashes downstream). | - | Geometry_Engine |
| IIsPlanar | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if the IGeometry is planar, i.e. all of its parts fit in a single plane. | - | Geometry_Engine |
| IIsValid | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if any IGeometry is valid using dynamic dispatch. | - | Geometry_Engine |
| INormals | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Vector](/api/oM/Dimensional/Geometry/Vector/Vector)&gt; | Interface method that returns the list of vectors normal to any IGeometry. | - | Geometry_Engine |
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a Geometry is null and outputs relevant error message. | - | Geometry_Engine |
| IsPlanar | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if the Mesh is planar, i.e. all of its parts fit in a single plane. Check is done by evaluating if all the vertices are co-planar within the provided tolerance. | - | Geometry_Engine |
| ISubParts | [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netstandard-2.0)&lt;[IGeometry](/api/oM/Dimensional/Geometry/Interface/IGeometry)&gt; | Gets the individual parts that make up any IGeometry. | - | Geometry_Engine |
| IsValid | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if any IGeometry is valid. Currently returns true for all geometries. | - | Geometry_Engine |
| Normals | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Vector](/api/oM/Dimensional/Geometry/Vector/Vector)&gt; | Returns a list of vectors normal to each face of the mesh. | - | Geometry_Engine |
| SubParts | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Mesh](/api/oM/Dimensional/Geometry/Mesh/Mesh)&gt; | Gets the individual mesh parts that make up a Mesh. Returns individual face meshes from the original mesh. | - | Geometry_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class Mesh : BH.oM.Geometry.IGeometry, BH.oM.Base.IObject
```

Assembly: Geometry_oM.dll

The C# class definition is available on github:

- [Mesh.cs](https://github.com/BHoM/BHoM/blob/develop/Geometry_oM/Mesh\Mesh.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Geometry_oM/Mesh.json"
}
```

The JSON Schema is available on github here:

- [Mesh.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Geometry_oM/Mesh.json)
### Example JSON instance

Example JSON instance of type Mesh.

``` json title="Example JSON"
{
  "_t": "BH.oM.Geometry.Mesh",
  "Vertices": [
    {
      "_t": "BH.oM.Geometry.Point",
      "X": 0.0,
      "Y": 0.0,
      "Z": 0.0
    },
    {
      "_t": "BH.oM.Geometry.Point",
      "X": 2.0,
      "Y": 0.0,
      "Z": 0.0
    },
    {
      "_t": "BH.oM.Geometry.Point",
      "X": 4.0,
      "Y": 0.0,
      "Z": 0.0
    },
    {
      "_t": "BH.oM.Geometry.Point",
      "X": 6.0,
      "Y": 0.0,
      "Z": 0.0
    },
    {
      "_t": "BH.oM.Geometry.Point",
      "X": 0.0,
      "Y": 2.0,
      "Z": 0.0
    },
    {
      "_t": "BH.oM.Geometry.Point",
      "X": 2.0,
      "Y": 2.0,
      "Z": 0.0
    },
    {
      "_t": "BH.oM.Geometry.Point",
      "X": 4.0,
      "Y": 2.0,
      "Z": 0.0
    },
    {
      "_t": "BH.oM.Geometry.Point",
      "X": 6.0,
      "Y": 2.0,
      "Z": 0.0
    },
    {
      "_t": "BH.oM.Geometry.Point",
      "X": 0.0,
      "Y": 4.0,
      "Z": 0.0
    },
    {
      "_t": "BH.oM.Geometry.Point",
      "X": 2.0,
      "Y": 4.0,
      "Z": 0.0
    },
    {
      "_t": "BH.oM.Geometry.Point",
      "X": 4.0,
      "Y": 4.0,
      "Z": 0.0
    },
    {
      "_t": "BH.oM.Geometry.Point",
      "X": 6.0,
      "Y": 4.0,
      "Z": 0.0
    },
    {
      "_t": "BH.oM.Geometry.Point",
      "X": 0.0,
      "Y": 6.0,
      "Z": 0.0
    },
    {
      "_t": "BH.oM.Geometry.Point",
      "X": 2.0,
      "Y": 6.0,
      "Z": 0.0
    },
    {
      "_t": "BH.oM.Geometry.Point",
      "X": 4.0,
      "Y": 6.0,
      "Z": 0.0
    },
    {
      "_t": "BH.oM.Geometry.Point",
      "X": 6.0,
      "Y": 6.0,
      "Z": 0.0
    }
  ],
  "Faces": [
    {
      "_t": "BH.oM.Geometry.Face",
      "A": 0,
      "B": 1,
      "C": 5,
      "D": 4
    },
    {
      "_t": "BH.oM.Geometry.Face",
      "A": 1,
      "B": 2,
      "C": 6,
      "D": 5
    },
    {
      "_t": "BH.oM.Geometry.Face",
      "A": 2,
      "B": 3,
      "C": 7,
      "D": 6
    },
    {
      "_t": "BH.oM.Geometry.Face",
      "A": 4,
      "B": 5,
      "C": 9,
      "D": 8
    },
    {
      "_t": "BH.oM.Geometry.Face",
      "A": 5,
      "B": 6,
      "C": 10,
      "D": 9
    },
    {
      "_t": "BH.oM.Geometry.Face",
      "A": 6,
      "B": 7,
      "C": 11,
      "D": 10
    },
    {
      "_t": "BH.oM.Geometry.Face",
      "A": 8,
      "B": 9,
      "C": 13,
      "D": 12
    },
    {
      "_t": "BH.oM.Geometry.Face",
      "A": 9,
      "B": 10,
      "C": 14,
      "D": 13
    },
    {
      "_t": "BH.oM.Geometry.Face",
      "A": 10,
      "B": 11,
      "C": 15,
      "D": 14
    }
  ],
  "_bhomVersion": "8.2"
}
```

