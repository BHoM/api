---
title: Ellipse
---

# <small>BH.oM.Geometry.</small>**Ellipse**

A plane curve. A standard ellipse defining a curve of constant combined distance around two foci.
The larger of the two radii defines the major axis of the Ellipse, and the line along which the two foci lie.

## Class structure

### Implemented interfaces and base types

???+ bhom "The Ellipse is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Geometry.[ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve)
    -  BH.oM.Geometry.[IGeometry](/api/oM/Dimensional/Geometry/Interface/IGeometry)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Dimensional.[IElement1D](/api/oM/Dimensional/Dimensional/IElement1D)
    -  BH.oM.Dimensional.[IElement](/api/oM/Dimensional/Dimensional/IElement)
    -  BH.oM.Geometry.[IBoundary](/api/oM/Dimensional/Geometry/Curve/IBoundary)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Centre | [Point](/api/oM/Dimensional/Geometry/Vector/Point) | Origin point defining location of the Ellipse in three-dimensional space. | - |
| Axis1 | [Vector](/api/oM/Dimensional/Geometry/Vector/Vector) | Together with Axis2 defines orientation in three-dimensional space. Direction only, and not magnitude, matters. | - |
| Axis2 | [Vector](/api/oM/Dimensional/Geometry/Vector/Vector) | Together with Axis1 defines orientation in three-dimensional space. Direction only, and not magnitude, matters. | - |
| Radius1 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Distance from the Centre to a point on the Ellipse along Axis1. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| Radius2 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Distance from the Centre to a point on the Ellipse along Axis2. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Area | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Calculates the area of the provided geometry. | [Area](/api/oM/Dimensional/Quantities/Attributes/Area) [m²] | Geometry_Engine |
| Bounds | [BoundingBox](/api/oM/Dimensional/Geometry/Misc/BoundingBox) | Returns the global world axis oriented enclosing BoundingBox for all points on the curve, i.e. the box with the smallest volume within which all the curve points lie. | - | Geometry_Engine |
| Bounds | [BoundingBox](/api/oM/Dimensional/Geometry/Misc/BoundingBox) | Queries the IElement1Ds BoundingBox. Acts on the ICurve definition of the IElement1D through the Geometry_Engine. | - | Spatial_Engine |
| Centroid | [Point](/api/oM/Dimensional/Geometry/Vector/Point) | Queries the centre of area for an Ellipse. | - | Geometry_Engine |
| Centroid | [Point](/api/oM/Dimensional/Geometry/Vector/Point) | Queries the centre of weight for a IElement1Ds ICurve representation. | - | Spatial_Engine |
| ControlPoints | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api/oM/Dimensional/Geometry/Vector/Point)&gt; | Gets points at the vertices and co-vertices of the Ellipse. | - | Geometry_Engine |
| ControlPoints | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api/oM/Dimensional/Geometry/Vector/Point)&gt; | Queries the control points of the one dimensional representation of the IElement1D. | - | Spatial_Engine |
| DiscontinuityPoints | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api/oM/Dimensional/Geometry/Vector/Point)&gt; | Gets the points at kinks of the curve. An Ellipse does not have any discontinuity points, why this method is returning an empty list. | - | Geometry_Engine |
| DominantVector | [Vector](/api/oM/Dimensional/Geometry/Vector/Vector) | Gets the dominant vector (orientation) of an Element1D based on its line lengths. | - | Spatial_Engine |
| ElementCurves | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve)&gt; | Queries the defining curves of an IElement1D. | - | Spatial_Engine |
| ElementVertices | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api/oM/Dimensional/Geometry/Vector/Point)&gt; | Returns the discontinuity points from the defining ICurve of the IElement1D. | - | Spatial_Engine |
| EndDir | [Vector](/api/oM/Dimensional/Geometry/Vector/Vector) | Gets the tangent vector at the end of the Ellipse. An ellipse starts and ends at the first axis point, and move towards the second axis, hence second axis is the tangent at start and end. | - | Geometry_Engine |
| EndPoint | [Point](/api/oM/Dimensional/Geometry/Vector/Point) | Gets the end Point of an Ellipse, which is the same as the start point for closed curves. | - | Geometry_Engine |
| FocalPoints | [Output](/api/oM/Framework/Base/Output)&lt;[Point](/api/oM/Dimensional/Geometry/Vector/Point), [Point](/api/oM/Dimensional/Geometry/Vector/Point)&gt; | Gets the two focal points of the Ellipse. For all points on the ellipse, the sum of the two distances to the focal points is constant. | - | Geometry_Engine |
| Geometry | [ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve) | Returns the geometry of an Ellipse as an ICurve. | - | Geometry_Engine |
| GeometryHash | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Returns a signature of the input geometry, useful for diffing.<br>The hash is computed as a serialised array representing the coordinate of significant points taken on the geometry.<br>The number of points is reduced to the minimum essential to determine uniquely any geometry.<br>Additionally, the resulting points are transformed based on the source geometry type, to remove or minimise collisions.<br>(Any transformation so performed is translational only, in order to support geometrical tolerance, i.e. numerical distance, when comparing GeometryHashes downstream). | - | Geometry_Engine |
| Height | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the height of a BHoM Geometry ICurve based on the bounding box of the curve. | - | Environment_Engine |
| IArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Calculates the area of the provided geometry. | [Area](/api/oM/Dimensional/Quantities/Attributes/Area) [m²] | Geometry_Engine |
| IArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Queries the area of the geometrical representation of an IElement. | [Area](/api/oM/Dimensional/Quantities/Attributes/Area) [m²] | Spatial_Engine |
| IBounds | [BoundingBox](/api/oM/Dimensional/Geometry/Misc/BoundingBox) | Queries the IElements BoundingBox. Acts on the elements geometrical definition of the IElement through the Geometry_Engine. | - | Spatial_Engine |
| IBounds | [BoundingBox](/api/oM/Dimensional/Geometry/Misc/BoundingBox) | Returns the global world axis oriented enclosing BoundingBox for all points of the geometry, i.e. the box with the smallest volume within which all the points on the geometry lie. | - | Geometry_Engine |
| ICentroid | [Point](/api/oM/Dimensional/Geometry/Vector/Point) | Queries the centre of weight for the homogeneous geometrical representation of an IElement. | - | Spatial_Engine |
| ICentroid | [Point](/api/oM/Dimensional/Geometry/Vector/Point) | Interface method that queries the centre of area for any ICurve. | - | Geometry_Engine |
| IControlPoints | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api/oM/Dimensional/Geometry/Vector/Point)&gt; | Queries the control points of the geometrical representation of an IElement. | - | Spatial_Engine |
| IControlPoints | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api/oM/Dimensional/Geometry/Vector/Point)&gt; | Gets the ControlPoints of the ICurve. Result will depend on the curve provided. Note that for NurbsCurves might not returns curves that are on the curve. | - | Geometry_Engine |
| IDiscontinuityPoints | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api/oM/Dimensional/Geometry/Vector/Point)&gt; | Gets the points at kinks of the curve, i.e. points where the tangent between two segments coming in to the same point is outside of the provided tolerance. | - | Geometry_Engine |
| IElementCurves | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve)&gt; | Queries the geometrically defining curves of the IElements geometry. | - | Spatial_Engine |
| IElements0D | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IElement0D](/api/oM/Dimensional/Dimensional/IElement0D)&gt; | Queries the IElement0Ds from a IElement1D. Returns null if no IElement0Ds are defined for the type of IElement1D. | - | Spatial_Engine |
| IElementVertices | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api/oM/Dimensional/Geometry/Vector/Point)&gt; | Returns the discontinuity points from the defining ICurves of the IElement. | - | Spatial_Engine |
| IEndDir | [Vector](/api/oM/Dimensional/Geometry/Vector/Vector) | Gets the tangent vector at the end of the curve. | - | Geometry_Engine |
| IEndPoint | [Point](/api/oM/Dimensional/Geometry/Vector/Point) | Gets the end Point of any ICurve. | - | Geometry_Engine |
| IGeometry | [ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve) | Queries the defining geometrical object which all spatial operations will act on. | - | Spatial_Engine |
| IGeometry | [ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve) | Returns the geometry of any ICurve as an ICurve. | - | Geometry_Engine |
| IHashArray | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0)[] | Returns a signature of the input geometry, useful for distance-based comparisons and diffing.<br>The hash is computed as an array representing the coordinate of significant points taken on the geometry.<br>The number of points is reduced to the minimum essential to determine uniquely any geometry.<br>Additionally, the resulting points are transformed based on the source geometry type, to remove or minimise collisions.<br>(Any transformation so performed is translational only, in order to support geometrical tolerance, i.e. numerical distance, when comparing GeometryHashes downstream). | - | Geometry_Engine |
| IIsClosed | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if the ICurve is closed, i.e. forms a closed loop. | - | Geometry_Engine |
| IIsLinear | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Returns if the curve is Linear or not. | - | Geometry_Engine |
| IIsPlanar | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks whether all control points of an element lie in a single plane. | - | Spatial_Engine |
| IIsPlanar | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if the IGeometry is planar, i.e. all of its parts fit in a single plane. | - | Geometry_Engine |
| IIsPolylinear | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Returns if the curve is polylinear or not. | - | Geometry_Engine |
| IIsSelfIntersecting | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if any of the curves defining an IElement is closer to itself than the tolerance at any two points (is self intersecting). In case of IElement2D, does not check for intersections between external and internal curves, or between different internal curves. | - | Spatial_Engine |
| IIsSelfIntersecting | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if any part of the the ICurve is intersecting with any other part of the curve. | - | Geometry_Engine |
| IIsValid | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if any IGeometry is valid using dynamic dispatch. | - | Geometry_Engine |
| ILength | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Calculates the length of a Curve. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] | Geometry_Engine |
| INormal | [Vector](/api/oM/Dimensional/Geometry/Vector/Vector) | Interface method that returns a vector normal to the plane of any ICurve and oriented according to the right hand rule. Works only for closed and planar curves with an exception for single Arcs. | - | Geometry_Engine |
| INormals | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Vector](/api/oM/Dimensional/Geometry/Vector/Vector)&gt; | Interface method that returns the list of vectors normal to any IGeometry. | - | Geometry_Engine |
| IPrimaryPropertyName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Returns the name of an elements primary defining property | - | Facade_Engine |
| IsClosed | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if the Ellipse is closed, i.e. forms a closed loop. An Ellipse is by definition always closed, why this method always returns true. | - | Geometry_Engine |
| IsLinear | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Returns if the curve is Linear or not. For a Ellipse this always returns false. | - | Geometry_Engine |
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a Geometry is null and outputs relevant error message. | - | Geometry_Engine |
| IsNurbsCurve | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Queries if any part of the curve is a nurbs curve. | - | Geometry_Engine |
| IsPlanar | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if the Ellipse is planar, i.e. all of its parts fit in a single plane. For a Ellipse this is always the case, why this method always returns true. | - | Geometry_Engine |
| IsPlanar | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks whether all control points of an element lie in a single plane. | - | Spatial_Engine |
| IsPolylinear | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Returns if the curve is polylinear or not. For a Ellipse this always returns false. | - | Geometry_Engine |
| IsSelfIntersecting | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if any part of the the Curve is intersecting with any other part of the curve. An Ellipse is by definition never self intersecting, hence this method always returns false. | - | Geometry_Engine |
| IsSelfIntersecting | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if the one dimensional representation of the IElement1D is closer to itself than the tolerance at any two points. | - | Spatial_Engine |
| IStartDir | [Vector](/api/oM/Dimensional/Geometry/Vector/Vector) | Gets the tangent vector at the start of the curve. | - | Geometry_Engine |
| IStartPoint | [Point](/api/oM/Dimensional/Geometry/Vector/Point) | Gets the start Point of any ICurve. | - | Geometry_Engine |
| ISubParts | [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netstandard-2.0)&lt;[ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve)&gt; | Gets the individual curve parts that make up any ICurve. | - | Geometry_Engine |
| ISubParts | [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netstandard-2.0)&lt;[IGeometry](/api/oM/Dimensional/Geometry/Interface/IGeometry)&gt; | Gets the individual parts that make up any IGeometry. | - | Geometry_Engine |
| IsValid | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if any IGeometry is valid. Currently returns true for all geometries. | - | Geometry_Engine |
| Length | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the length of the IElement1Ds curve. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] | Spatial_Engine |
| Length | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Calculates the length of an Ellipse. Evaluated as an infinite series, utilising 10 times the ratio of the long and short radius number of terms.<br>Gives very close to exact results for ellipses with an ratio of up to 1:20 000 between the long and short radius. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] | Geometry_Engine |
| Normal | [Vector](/api/oM/Dimensional/Geometry/Vector/Vector) | Returns a vector normal to the plane of an ellipse. | - | Geometry_Engine |
| PointInRegion | [Point](/api/oM/Dimensional/Geometry/Vector/Point) | Finds a semi-arbitrary Point that lies within the region defined by a closed curve. | - | Geometry_Engine |
| StartDir | [Vector](/api/oM/Dimensional/Geometry/Vector/Vector) | Gets the tangent vector at the start of the Ellipse. An ellipse starts and ends at the first axis point, and move towards the second axis, hence second axis is the tangent at start and end. | - | Geometry_Engine |
| StartPoint | [Point](/api/oM/Dimensional/Geometry/Vector/Point) | Gets the start Point of an Ellipse. For closed curves, this is typically at the end of the first axis. | - | Geometry_Engine |
| ToEdges | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Edge](/api/oM/Analytical/Environment/Elements/Edge)&gt; | Returns a collection of Environment Edges from a BHoM Geomtry Polyline | - | Environment_Engine |
| Width | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the width of a BHoM Geometry ICurve based on the bounding box of the curve. | - | Environment_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class Ellipse : BH.oM.Geometry.ICurve,
BH.oM.Geometry.IGeometry,
BH.oM.Base.IObject,
BH.oM.Dimensional.IElement1D,
BH.oM.Dimensional.IElement,
BH.oM.Geometry.IBoundary
```

Assembly: Geometry_oM.dll

The C# class definition is available on github:

- [Ellipse.cs](https://github.com/BHoM/BHoM/blob/develop/Geometry_oM/Curve\Ellipse.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Geometry_oM/Ellipse.json"
}
```

The JSON Schema is available on github here:

- [Ellipse.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Geometry_oM/Ellipse.json)
### Example JSON instance

Example JSON instance of type Ellipse.

``` json title="Example JSON"
{
  "_t": "BH.oM.Geometry.Ellipse",
  "Centre": {
    "_t": "BH.oM.Geometry.Point",
    "X": 0.0,
    "Y": 0.0,
    "Z": 0.0
  },
  "Axis1": {
    "_t": "BH.oM.Geometry.Vector",
    "X": 1.0,
    "Y": 0.0,
    "Z": 0.0
  },
  "Axis2": {
    "_t": "BH.oM.Geometry.Vector",
    "X": 0.0,
    "Y": 1.0,
    "Z": 0.0
  },
  "Radius1": 3.0,
  "Radius2": 5.0,
  "_bhomVersion": "8.2"
}
```

