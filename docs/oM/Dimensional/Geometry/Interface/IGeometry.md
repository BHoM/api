---
title: IGeometry
---

# <small>BH.oM.Geometry.</small>**IGeometry**

The parent interface for all primative geometrical objects.
IGeometry implements IObject - and not IBHoMObject. Equally primative geometrical objects do not inherit from the base BHoMObject class either. As primatives, the additional base BHoM properties are omitted for both efficency and performace.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IGeometry is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - BH.oM.Geometry.[IBoundary](/api/oM/Dimensional/Geometry/Curve/IBoundary)
    - BH.oM.Geometry.[ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve)
    - BH.oM.Geometry.[IPolyCurve](/api/oM/Dimensional/Geometry/Curve/IPolyCurve)
    - BH.oM.Geometry.[IPolyline](/api/oM/Dimensional/Geometry/Curve/IPolyline)
    - BH.oM.Geometry.[ISolid](/api/oM/Dimensional/Geometry/Solid/ISolid)
    - BH.oM.Geometry.[ISurface](/api/oM/Dimensional/Geometry/Surface/ISurface)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Geometry.[Arc](/api/oM/Dimensional/Geometry/Curve/Arc)
    - BH.oM.Geometry.[BoundaryCurve](/api/oM/Dimensional/Geometry/Curve/BoundaryCurve)
    - BH.oM.Geometry.[Circle](/api/oM/Dimensional/Geometry/Curve/Circle)
    - BH.oM.Geometry.[Ellipse](/api/oM/Dimensional/Geometry/Curve/Ellipse)
    - BH.oM.Geometry.[Line](/api/oM/Dimensional/Geometry/Curve/Line)
    - BH.oM.Geometry.[NurbsCurve](/api/oM/Dimensional/Geometry/Curve/NurbsCurve)
    - BH.oM.Geometry.[PolyCurve](/api/oM/Dimensional/Geometry/Curve/PolyCurve)
    - BH.oM.Geometry.[Polygon](/api/oM/Dimensional/Geometry/Curve/Polygon)
    - BH.oM.Geometry.[Polyline](/api/oM/Dimensional/Geometry/Curve/Polyline)
    - BH.oM.Geometry.[CellRelation](/api/oM/Dimensional/Geometry/Mesh/CellRelation)
    - BH.oM.Geometry.[Face](/api/oM/Dimensional/Geometry/Mesh/Face)
    - BH.oM.Geometry.[Mesh](/api/oM/Dimensional/Geometry/Mesh/Mesh)
    - BH.oM.Geometry.[Mesh3D](/api/oM/Dimensional/Geometry/Mesh/Mesh3D)
    - BH.oM.Geometry.[BoundingBox](/api/oM/Dimensional/Geometry/Misc/BoundingBox)
    - BH.oM.Geometry.[CompositeGeometry](/api/oM/Dimensional/Geometry/Misc/CompositeGeometry)
    - BH.oM.Geometry.[Quaternion](/api/oM/Dimensional/Geometry/Misc/Quaternion)
    - BH.oM.Geometry.[SurfaceTrim](/api/oM/Dimensional/Geometry/Misc/SurfaceTrim)
    - BH.oM.Geometry.[TransformMatrix](/api/oM/Dimensional/Geometry/Misc/TransformMatrix)
    - BH.oM.Geometry.[BoundaryRepresentation](/api/oM/Dimensional/Geometry/Solid/BoundaryRepresentation)
    - BH.oM.Geometry.[Cone](/api/oM/Dimensional/Geometry/Solid/Cone)
    - BH.oM.Geometry.[Cuboid](/api/oM/Dimensional/Geometry/Solid/Cuboid)
    - BH.oM.Geometry.[Cylinder](/api/oM/Dimensional/Geometry/Solid/Cylinder)
    - BH.oM.Geometry.[Sphere](/api/oM/Dimensional/Geometry/Solid/Sphere)
    - BH.oM.Geometry.[Torus](/api/oM/Dimensional/Geometry/Solid/Torus)
    - BH.oM.Geometry.[Extrusion](/api/oM/Dimensional/Geometry/Surface/Extrusion)
    - BH.oM.Geometry.[Loft](/api/oM/Dimensional/Geometry/Surface/Loft)
    - BH.oM.Geometry.[NurbsSurface](/api/oM/Dimensional/Geometry/Surface/NurbsSurface)
    - BH.oM.Geometry.[Pipe](/api/oM/Dimensional/Geometry/Surface/Pipe)
    - BH.oM.Geometry.[PlanarSurface](/api/oM/Dimensional/Geometry/Surface/PlanarSurface)
    - BH.oM.Geometry.[PolySurface](/api/oM/Dimensional/Geometry/Surface/PolySurface)
    - BH.oM.Geometry.[Basis](/api/oM/Dimensional/Geometry/Vector/Basis)
    - BH.oM.Geometry.[Plane](/api/oM/Dimensional/Geometry/Vector/Plane)
    - BH.oM.Geometry.[Point](/api/oM/Dimensional/Geometry/Vector/Point)
    - BH.oM.Geometry.[Vector](/api/oM/Dimensional/Geometry/Vector/Vector)
    - BH.oM.Geometry.CoordinateSystem.[Cartesian](/api/oM/Dimensional/Geometry/CoordinateSystem/Cartesian)
    - BH.oM.Graphics.[RenderMesh](/api/oM/Graphics/Graphics/Render/RenderMesh)
    - BH.oM.Graphics.[RenderPoint](/api/oM/Graphics/Graphics/Render/RenderPoint)


## Properties

### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| GeometryHash | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Returns a signature of the input geometry, useful for diffing.<br>The hash is computed as a serialised array representing the coordinate of significant points taken on the geometry.<br>The number of points is reduced to the minimum essential to determine uniquely any geometry.<br>Additionally, the resulting points are transformed based on the source geometry type, to remove or minimise collisions.<br>(Any transformation so performed is translational only, in order to support geometrical tolerance, i.e. numerical distance, when comparing GeometryHashes downstream). | - | Geometry_Engine |
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
public interface IGeometry : BH.oM.Base.IObject
```

Assembly: Geometry_oM.dll

The C# interface definition is available on github:

- [IGeometry.cs](https://github.com/BHoM/BHoM/blob/develop/Geometry_oM/Interface\IGeometry.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Geometry_oM/IGeometry.json"
}
```

The JSON Schema is available on github here:

- [IGeometry.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Geometry_oM/IGeometry.json)
