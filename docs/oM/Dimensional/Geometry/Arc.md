---
title: Arc
---

# Geometry.Arc

A plane curve. A circular Arc, a curve, with a constant distance from a point, its centre, defined it the local angular domain between start and end angle.

## Class structure

### Implemented interfaces and base types

???+ bhom "The Arc in inheriting from the following base type(s) and implements the following interfaces:"

    -  Geometry.[ICurve](/om_documentation/oM/Dimensional/Geometry/ICurve)
    -  Geometry.[IGeometry](/om_documentation/oM/Dimensional/Geometry/IGeometry)
    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)
    -  Dimensional.[IElement1D](/om_documentation/oM/Dimensional/Dimensional/IElement1D)
    -  Dimensional.[IElement](/om_documentation/oM/Dimensional/Dimensional/IElement)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| CoordinateSystem | [Cartesian](/om_documentation/oM/Dimensional/Geometry/CoordinateSystem/Cartesian) | Defines Arc centre equal to Origin of the CoordinateSystem, as well as the orientation of the Arc in three-dimensional space, equal to local xy-Plane of the CoordinateSystem. | - |
| Radius | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Distance from the CoordinateSystem.Origin to the any point on Arc. | [Length](/om_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] |
| StartAngle | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Angle in radians to the start point from the local x-axis, counter clockwise around the local z-axis. | [Angle](/om_documentation/oM/Dimensional/Quantities/Attributes/Angle) [rad] |
| EndAngle | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Angle in radians to the end point from the local x-axis, counter clockwise around the local z-axis. | [Angle](/om_documentation/oM/Dimensional/Quantities/Attributes/Angle) [rad] |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Angle | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Calculates the angle of the arc. | - | Geometry_Engine |
| Area | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Calculates the area of the provided geometry. | [Area](/om_documentation/oM/Dimensional/Quantities/Attributes/Area) [m²] | Geometry_Engine |
| Bounds | [BoundingBox](/om_documentation/oM/Dimensional/Geometry/BoundingBox) | Returns the global world axis oriented enclosing BoundingBox for all points on the curve, i.e. the box with the smallest volume within which all the curve points lie. | - | Geometry_Engine |
| Bounds | [BoundingBox](/om_documentation/oM/Dimensional/Geometry/BoundingBox) | Queries the IElement1Ds BoundingBox. Acts on the ICurve definition of the IElement1D through the Geometry_Engine. | - | Spatial_Engine |
| Centre | [Point](/om_documentation/oM/Dimensional/Geometry/Point) | - | - | Geometry_Engine |
| Centroid | [Point](/om_documentation/oM/Dimensional/Geometry/Point) | Queries the centre of weight for a IElement1Ds ICurve representation. | - | Spatial_Engine |
| ControlPoints | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/om_documentation/oM/Dimensional/Geometry/Point)&gt; | Gets points at start, quarter, mid thre quarters and end points on the Arc. | - | Geometry_Engine |
| ControlPoints | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/om_documentation/oM/Dimensional/Geometry/Point)&gt; | Queries the control points of the one dimensional representation of the IElement1D. | - | Spatial_Engine |
| DiscontinuityPoints | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/om_documentation/oM/Dimensional/Geometry/Point)&gt; | Gets the points at kinks of the curve. For an Arc this is the start and end points. | - | Geometry_Engine |
| DominantVector | [Vector](/om_documentation/oM/Dimensional/Geometry/Vector) | Gets the the dominant vector (orientation) of an Element1D based on its lines lengths. | - | Spatial_Engine |
| ElementCurves | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/om_documentation/oM/Dimensional/Geometry/ICurve)&gt; | Queries the defining curves of an IElement1D. | - | Spatial_Engine |
| ElementVertices | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/om_documentation/oM/Dimensional/Geometry/Point)&gt; | Returns the discontinuity points from the defining ICurve of the IElement1D. | - | Spatial_Engine |
| EndDir | [Vector](/om_documentation/oM/Dimensional/Geometry/Vector) | Gets the tangent vector at the end of the Arc. | - | Geometry_Engine |
| EndPoint | [Point](/om_documentation/oM/Dimensional/Geometry/Point) | - | - | Geometry_Engine |
| Geometry | [ICurve](/om_documentation/oM/Dimensional/Geometry/ICurve) | - | - | Geometry_Engine |
| GeometryHash | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Returns a signature of the input geometry, useful for diffing.<br>The hash is computed as a serialised array representing the coordinate of significant points taken on the geometry.<br>The number of points is reduced to the minimum essential to determine uniquely any geometry.<br>Additionally, the resulting points are transformed based on the source geometry type, to remove or minimize collisions.<br>(Any transformation so performed is translational only, in order to support geometrical tolerance, i.e. numerical distance, when comparing GeometryHashes downstream). | - | Geometry_Engine |
| Height | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the height of a BHoM Geometry ICurve based on the bounding box of the curve | - | Environment_Engine |
| IArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Calculates the area of the provided geometry. | [Area](/om_documentation/oM/Dimensional/Quantities/Attributes/Area) [m²] | Geometry_Engine |
| IArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Queries the area of the geometrical representation of an IElement. | [Area](/om_documentation/oM/Dimensional/Quantities/Attributes/Area) [m²] | Spatial_Engine |
| IBounds | [BoundingBox](/om_documentation/oM/Dimensional/Geometry/BoundingBox) | Returns the global world axis oriented enclosing BoundingBox for all points of the geometry, i.e. the box with the smallest volume within which all the points on the geometry lie. | - | Geometry_Engine |
| IBounds | [BoundingBox](/om_documentation/oM/Dimensional/Geometry/BoundingBox) | Queries the IElements BoundingBox. Acts on the elements geometrical definition of the IElement through the Geometry_Engine. | - | Spatial_Engine |
| ICentroid | [Point](/om_documentation/oM/Dimensional/Geometry/Point) | Queries the centre of weight for the homogeneous geometrical representation of an IElement. | - | Spatial_Engine |
| ICentroid | [Point](/om_documentation/oM/Dimensional/Geometry/Point) | Interface method that queries the centre of area for any ICurve. | - | Geometry_Engine |
| IControlPoints | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/om_documentation/oM/Dimensional/Geometry/Point)&gt; | Gets the ControlPoints of the ICurve. Result will depend on the curve provided. Note that for NurbsCurves might not returns curves that are on the curve. | - | Geometry_Engine |
| IControlPoints | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/om_documentation/oM/Dimensional/Geometry/Point)&gt; | Queries the control points of the geometrical representation of an IElement. | - | Spatial_Engine |
| IDiscontinuityPoints | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/om_documentation/oM/Dimensional/Geometry/Point)&gt; | Gets the points at kinks of the curve, i.e. points where the tangent between two segments coming in to the same point is outside of the provided tolerance. | - | Geometry_Engine |
| IElementCurves | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/om_documentation/oM/Dimensional/Geometry/ICurve)&gt; | Queries the geometricly defining curves of the IElements geometry. | - | Spatial_Engine |
| IElements0D | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IElement0D](/om_documentation/oM/Dimensional/Dimensional/IElement0D)&gt; | Queries the IElement0Ds from a IElement1D. Returns null if no IElement0Ds are defined for the type of IElement1D. | - | Spatial_Engine |
| IElementVertices | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/om_documentation/oM/Dimensional/Geometry/Point)&gt; | Returns the discontinuity points from the defining ICurves of the IElement. | - | Spatial_Engine |
| IEndDir | [Vector](/om_documentation/oM/Dimensional/Geometry/Vector) | Gets the tangent vector at the end of the curve. | - | Geometry_Engine |
| IEndPoint | [Point](/om_documentation/oM/Dimensional/Geometry/Point) | - | - | Geometry_Engine |
| IGeometry | [ICurve](/om_documentation/oM/Dimensional/Geometry/ICurve) | Queries the defining geometrical object which all spatial operations will act on. | - | Spatial_Engine |
| IGeometry | [ICurve](/om_documentation/oM/Dimensional/Geometry/ICurve) | - | - | Geometry_Engine |
| IHashArray | [Double[]](https://learn.microsoft.com/en-us/dotnet/api/System.Double[]?view=netstandard-2.0) | Returns a signature of the input geometry, useful for distance-based comparisons and diffing.<br>The hash is computed as an array representing the coordinate of significant points taken on the geometry.<br>The number of points is reduced to the minimum essential to determine uniquely any geometry.<br>Additionally, the resulting points are transformed based on the source geometry type, to remove or minimize collisions.<br>(Any transformation so performed is translational only, in order to support geometrical tolerance, i.e. numerical distance, when comparing GeometryHashes downstream). | - | Geometry_Engine |
| IIsClosed | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if the ICurve is closed, i.e. forms a closed loop. | - | Geometry_Engine |
| IIsLinear | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Returns if the curve is Linear or not. | - | Geometry_Engine |
| IIsPlanar | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if the IGeometry is planar, i.e. all of its parts fit in a single plane. | - | Geometry_Engine |
| IIsPlanar | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks whether all control points of an element lie in a single plane. | - | Spatial_Engine |
| IIsPolylinear | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Returns if the curve is polylinear or not. | - | Geometry_Engine |
| IIsSelfIntersecting | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if any of the curves defining an IElement is closer to itself than the tolerance at any two points (is self intersecting). In case of IElement2D, does not check for intersections between external and internal curves, or between different internal curves. | - | Spatial_Engine |
| IIsSelfIntersecting | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if any part of the the ICurve is intersecting with any other part of the curve. | - | Geometry_Engine |
| IIsValid | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - | Geometry_Engine |
| ILength | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Calculates the length of a Curve. | [Length](/om_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] | Geometry_Engine |
| INormal | [Vector](/om_documentation/oM/Dimensional/Geometry/Vector) | Interface method that returns a vector normal to the plane of any ICurve and oriented according to the right hand rule. Works only for closed and planar curves with an exception for single Arcs. | - | Geometry_Engine |
| INormals | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Vector](/om_documentation/oM/Dimensional/Geometry/Vector)&gt; | Interface method that returns the list of vectors normal to any IGeometry. | - | Geometry_Engine |
| IPrimaryPropertyName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Returns the name of an elements primary defining property | - | Facade_Engine |
| IsClosed | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if the Arc is closed, i.e. forms a closed loop by checking if the end points are within tolerance of each other. | - | Geometry_Engine |
| IsLinear | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Returns if the curve is Linear or not. For a Arc this always returns false. | - | Geometry_Engine |
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a Geometry is null and outputs relevant error message. | - | Geometry_Engine |
| IsNurbsCurve | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Queries if any part of the curve is a nurbs curve. | - | Geometry_Engine |
| IsPlanar | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if the Arc is planar, i.e. all of its parts fit in a single plane. For a Arc this is always the case, why this method always returns true. | - | Geometry_Engine |
| IsPlanar | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks whether all control points of an element lie in a single plane. | - | Spatial_Engine |
| IsPolylinear | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Returns if the curve is polylinear or not. For a Arc this always returns false. | - | Geometry_Engine |
| IsSelfIntersecting | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if any part of the the Curve is intersecting with any other part of the curve. For an Arc this is true if the angle range is larger than 2 PI, i.e. if the curve is overlapping itself. | - | Geometry_Engine |
| IsSelfIntersecting | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if the one dimensional representation of the IElement1D is closer to itself than the tolerance at any two points. | - | Spatial_Engine |
| IStartDir | [Vector](/om_documentation/oM/Dimensional/Geometry/Vector) | Gets the tangent vector at the start of the curve. | - | Geometry_Engine |
| IStartPoint | [Point](/om_documentation/oM/Dimensional/Geometry/Point) | - | - | Geometry_Engine |
| ISubParts | [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netstandard-2.0)&lt;[ICurve](/om_documentation/oM/Dimensional/Geometry/ICurve)&gt; | - | - | Geometry_Engine |
| ISubParts | [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netstandard-2.0)&lt;[IGeometry](/om_documentation/oM/Dimensional/Geometry/IGeometry)&gt; | - | - | Geometry_Engine |
| IsValid | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - | Geometry_Engine |
| IsValid | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - | Geometry_Engine |
| Length | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Calculates the length of an Arc. | [Length](/om_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] | Geometry_Engine |
| Length | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the length of the IElement1Ds curve. | [Length](/om_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] | Spatial_Engine |
| Normal | [Vector](/om_documentation/oM/Dimensional/Geometry/Vector) | Returns a vector normal to the plane of an arc. | - | Geometry_Engine |
| PointInRegion | [Point](/om_documentation/oM/Dimensional/Geometry/Point) | - | - | Geometry_Engine |
| StartDir | [Vector](/om_documentation/oM/Dimensional/Geometry/Vector) | Gets the tangent vector at the start of the Arc. | - | Geometry_Engine |
| StartPoint | [Point](/om_documentation/oM/Dimensional/Geometry/Point) | - | - | Geometry_Engine |
| ToEdges | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Edge](/om_documentation/oM/Analytical/Environment/Elements/Edge)&gt; | Returns a collection of Environment Edges from a BHoM Geomtry Polyline | - | Environment_Engine |
| Width | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the width of a BHoM Geometry ICurve based on the bounding box of the curve | - | Environment_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [Arc.cs](https://github.com/BHoM/BHoM/blob/develop/Geometry_oM/Curve/Arc.cs)

All history and changes of the class can be found by inspection the history.
