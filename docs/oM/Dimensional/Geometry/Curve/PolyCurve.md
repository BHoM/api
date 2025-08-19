---
title: PolyCurve
---

# <small>BH.oM.Geometry.</small>**PolyCurve**

A composite curve constructed by combining a collection of curves of any type. Whole PolyCurve integrity, continuity and closure is not guaranteed at creation. Discontinuous and/or multi-region definitions are possible, although not recommended as may cause unexpected results in method operating on PolyCurves.

## Class structure

### Implemented interfaces and base types

???+ bhom "The PolyCurve is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Geometry.[ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve)
    -  BH.oM.Geometry.[IGeometry](/api/oM/Dimensional/Geometry/Interface/IGeometry)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Dimensional.[IElement1D](/api/oM/Dimensional/Dimensional/IElement1D)
    -  BH.oM.Dimensional.[IElement](/api/oM/Dimensional/Dimensional/IElement)
    -  BH.oM.Geometry.[IPolyCurve](/api/oM/Dimensional/Geometry/Curve/IPolyCurve)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Curves | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve)&gt; | A collection of curves, of any or mixed type, which together define the composite shape. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Area | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Calculates the area of the provided geometry. | [Area](/api/oM/Dimensional/Quantities/Attributes/Area) [m²] | Geometry_Engine |
| Bounds | [BoundingBox](/api/oM/Dimensional/Geometry/Misc/BoundingBox) | Returns the global world axis oriented enclosing BoundingBox for all points on all the inner curves of the PolyCurve, i.e. the box with the smallest volume within which all the curve points lie. | - | Geometry_Engine |
| Bounds | [BoundingBox](/api/oM/Dimensional/Geometry/Misc/BoundingBox) | Queries the IElement1Ds BoundingBox. Acts on the ICurve definition of the IElement1D through the Geometry_Engine. | - | Spatial_Engine |
| Centroid | [Point](/api/oM/Dimensional/Geometry/Vector/Point) | Queries the centre of area enclosed by a closed, planar, non-self-intersecting PolyCurve. | - | Geometry_Engine |
| Centroid | [Point](/api/oM/Dimensional/Geometry/Vector/Point) | Queries the centre of weight for a IElement1Ds ICurve representation. | - | Spatial_Engine |
| ControlPoints | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api/oM/Dimensional/Geometry/Vector/Point)&gt; | Queries the control points of the one dimensional representation of the IElement1D. | - | Spatial_Engine |
| ControlPoints | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api/oM/Dimensional/Geometry/Vector/Point)&gt; | Gets the ControlPoints of the PolyCurve as the ControlPoints of all of its inner curves. | - | Geometry_Engine |
| Curves | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve)&gt; | Returns the inner curves of the PolyCurve. | - | Geometry_Engine |
| DiscontinuityPoints | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api/oM/Dimensional/Geometry/Vector/Point)&gt; | Gets the points at kinks of the curve, i.e. Points where the tangent between two sub curves coming in to the same point is outside of the provided tolerance. | - | Geometry_Engine |
| DominantVector | [Vector](/api/oM/Dimensional/Geometry/Vector/Vector) | Gets the dominant vector (orientation) of an Element1D based on its line lengths. | - | Spatial_Engine |
| ElementCurves | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve)&gt; | Queries the defining curves of an IElement1D. | - | Spatial_Engine |
| ElementVertices | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api/oM/Dimensional/Geometry/Vector/Point)&gt; | Returns the discontinuity points from the defining ICurve of the IElement1D. | - | Spatial_Engine |
| EndDir | [Vector](/api/oM/Dimensional/Geometry/Vector/Vector) | Gets the tangent vector at the end of the PolyCurve. | - | Geometry_Engine |
| EndPoint | [Point](/api/oM/Dimensional/Geometry/Vector/Point) | - | - | Geometry_Engine |
| Geometry | [ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve) | - | - | Geometry_Engine |
| GeometryHash | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Returns a signature of the input geometry, useful for diffing.<br>The hash is computed as a serialised array representing the coordinate of significant points taken on the geometry.<br>The number of points is reduced to the minimum essential to determine uniquely any geometry.<br>Additionally, the resulting points are transformed based on the source geometry type, to remove or minimize collisions.<br>(Any transformation so performed is translational only, in order to support geometrical tolerance, i.e. numerical distance, when comparing GeometryHashes downstream). | - | Geometry_Engine |
| Height | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the height of a BHoM Geometry ICurve based on the bounding box of the curve. | - | Environment_Engine |
| IArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Calculates the area of the provided geometry. | [Area](/api/oM/Dimensional/Quantities/Attributes/Area) [m²] | Geometry_Engine |
| IArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Queries the area of the geometrical representation of an IElement. | [Area](/api/oM/Dimensional/Quantities/Attributes/Area) [m²] | Spatial_Engine |
| IBounds | [BoundingBox](/api/oM/Dimensional/Geometry/Misc/BoundingBox) | Returns the global world axis oriented enclosing BoundingBox for all points of the geometry, i.e. the box with the smallest volume within which all the points on the geometry lie. | - | Geometry_Engine |
| IBounds | [BoundingBox](/api/oM/Dimensional/Geometry/Misc/BoundingBox) | Queries the IElements BoundingBox. Acts on the elements geometrical definition of the IElement through the Geometry_Engine. | - | Spatial_Engine |
| ICentroid | [Point](/api/oM/Dimensional/Geometry/Vector/Point) | Queries the centre of weight for the homogeneous geometrical representation of an IElement. | - | Spatial_Engine |
| ICentroid | [Point](/api/oM/Dimensional/Geometry/Vector/Point) | Interface method that queries the centre of area for any ICurve. | - | Geometry_Engine |
| IControlPoints | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api/oM/Dimensional/Geometry/Vector/Point)&gt; | Queries the control points of the geometrical representation of an IElement. | - | Spatial_Engine |
| IControlPoints | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api/oM/Dimensional/Geometry/Vector/Point)&gt; | Gets the ControlPoints of the ICurve. Result will depend on the curve provided. Note that for NurbsCurves might not returns curves that are on the curve. | - | Geometry_Engine |
| ICurves | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve)&gt; | Returns the inner curves of the IPolyCurve. | - | Geometry_Engine |
| IDiscontinuityPoints | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api/oM/Dimensional/Geometry/Vector/Point)&gt; | Gets the points at kinks of the curve, i.e. points where the tangent between two segments coming in to the same point is outside of the provided tolerance. | - | Geometry_Engine |
| IElementCurves | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve)&gt; | Queries the geometrically defining curves of the IElements geometry. | - | Spatial_Engine |
| IElements0D | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IElement0D](/api/oM/Dimensional/Dimensional/IElement0D)&gt; | Queries the IElement0Ds from a IElement1D. Returns null if no IElement0Ds are defined for the type of IElement1D. | - | Spatial_Engine |
| IElementVertices | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api/oM/Dimensional/Geometry/Vector/Point)&gt; | Returns the discontinuity points from the defining ICurves of the IElement. | - | Spatial_Engine |
| IEndDir | [Vector](/api/oM/Dimensional/Geometry/Vector/Vector) | Gets the tangent vector at the end of the curve. | - | Geometry_Engine |
| IEndPoint | [Point](/api/oM/Dimensional/Geometry/Vector/Point) | - | - | Geometry_Engine |
| IGeometry | [ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve) | - | - | Geometry_Engine |
| IGeometry | [ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve) | Queries the defining geometrical object which all spatial operations will act on. | - | Spatial_Engine |
| IHashArray | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0)[] | Returns a signature of the input geometry, useful for distance-based comparisons and diffing.<br>The hash is computed as an array representing the coordinate of significant points taken on the geometry.<br>The number of points is reduced to the minimum essential to determine uniquely any geometry.<br>Additionally, the resulting points are transformed based on the source geometry type, to remove or minimize collisions.<br>(Any transformation so performed is translational only, in order to support geometrical tolerance, i.e. numerical distance, when comparing GeometryHashes downstream). | - | Geometry_Engine |
| IIsClosed | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if the ICurve is closed, i.e. forms a closed loop. | - | Geometry_Engine |
| IIsLinear | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Returns if the curve is Linear or not. | - | Geometry_Engine |
| IIsPlanar | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks whether all control points of an element lie in a single plane. | - | Spatial_Engine |
| IIsPlanar | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if the IGeometry is planar, i.e. all of its parts fit in a single plane. | - | Geometry_Engine |
| IIsPolylinear | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Returns if the curve is polylinear or not. | - | Geometry_Engine |
| IIsSelfIntersecting | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if any part of the the ICurve is intersecting with any other part of the curve. | - | Geometry_Engine |
| IIsSelfIntersecting | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if any of the curves defining an IElement is closer to itself than the tolerance at any two points (is self intersecting). In case of IElement2D, does not check for intersections between external and internal curves, or between different internal curves. | - | Spatial_Engine |
| IIsValid | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - | Geometry_Engine |
| ILength | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Calculates the length of a Curve. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] | Geometry_Engine |
| INormal | [Vector](/api/oM/Dimensional/Geometry/Vector/Vector) | Interface method that returns a vector normal to the plane of any ICurve and oriented according to the right hand rule. Works only for closed and planar curves with an exception for single Arcs. | - | Geometry_Engine |
| INormals | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Vector](/api/oM/Dimensional/Geometry/Vector/Vector)&gt; | Interface method that returns the list of vectors normal to any IGeometry. | - | Geometry_Engine |
| IPrimaryPropertyName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Returns the name of an elements primary defining property | - | Facade_Engine |
| IsClosed | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if the PolyCurve is closed, i.e. forms a closed loop, by checking if the end points are within tolerance of each other or if it is made up of a single inner Curve that is itself closed. | - | Geometry_Engine |
| IsLinear | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Returns if the curve is Linear or not, i.e. if the Polycurve is built up of a set of colinear curves. | - | Geometry_Engine |
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a Geometry is null and outputs relevant error message. | - | Geometry_Engine |
| IsNurbsCurve | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Queries if any part of the curve is a nurbs curve. | - | Geometry_Engine |
| IsPlanar | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if the PolyCurve is planar, i.e. all of its parts fit in a single plane. Check is done by evaluating if all the controlpoints are co-planar within the provided tolerance. | - | Geometry_Engine |
| IsPlanar | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks whether all control points of an element lie in a single plane. | - | Spatial_Engine |
| IsPolylinear | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Returns if the curve is polylinear or not, i.e. if the Polycurve is built up of a set of Line segments. | - | Geometry_Engine |
| IsQuad | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Determines whether a Polycurve is a quadilaterial. | - | Geometry_Engine |
| IsRectangular | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Determines whether a Polycurve is a rectangular. | - | Geometry_Engine |
| IsSelfIntersecting | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if the one dimensional representation of the IElement1D is closer to itself than the tolerance at any two points. | - | Spatial_Engine |
| IsSelfIntersecting | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if any part of the the PolyCurve is intersecting with any other part of the curve. | - | Geometry_Engine |
| IsSquare | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Determines whether a Polycurve is a square. | - | Geometry_Engine |
| IStartDir | [Vector](/api/oM/Dimensional/Geometry/Vector/Vector) | Gets the tangent vector at the start of the curve. | - | Geometry_Engine |
| IStartPoint | [Point](/api/oM/Dimensional/Geometry/Vector/Point) | - | - | Geometry_Engine |
| IsTriangular | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Determines whether a Polycurve is triangular. | - | Geometry_Engine |
| ISubParts | [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netstandard-2.0)&lt;[ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve)&gt; | - | - | Geometry_Engine |
| ISubParts | [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netstandard-2.0)&lt;[IGeometry](/api/oM/Dimensional/Geometry/Interface/IGeometry)&gt; | - | - | Geometry_Engine |
| IsValid | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - | Geometry_Engine |
| Length | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the length of the IElement1Ds curve. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] | Spatial_Engine |
| Length | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Calculates the length of an PolyCurve. Calculated as the sum of the length of its parts. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] | Geometry_Engine |
| Normal | [Vector](/api/oM/Dimensional/Geometry/Vector/Vector) | Returns a vector normal to the plane of a given curve, oriented according to the right hand rule. Works only for closed and planar curves. | - | Geometry_Engine |
| PointInRegion | [Point](/api/oM/Dimensional/Geometry/Vector/Point) | - | - | Geometry_Engine |
| StartDir | [Vector](/api/oM/Dimensional/Geometry/Vector/Vector) | Gets the tangent vector at the start of the PolyCurve. | - | Geometry_Engine |
| StartPoint | [Point](/api/oM/Dimensional/Geometry/Vector/Point) | - | - | Geometry_Engine |
| SubParts | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve)&gt; | - | - | Geometry_Engine |
| ToEdges | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Edge](/api/oM/Analytical/Environment/Elements/Edge)&gt; | Returns a collection of Environment Edges from a BHoM Geomtry Polyline | - | Environment_Engine |
| Width | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the width of a BHoM Geometry ICurve based on the bounding box of the curve. | - | Environment_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class PolyCurve : BH.oM.Geometry.ICurve,
BH.oM.Geometry.IGeometry,
BH.oM.Base.IObject,
BH.oM.Dimensional.IElement1D,
BH.oM.Dimensional.IElement,
BH.oM.Geometry.IPolyCurve
```

Assembly: Geometry_oM.dll

The C# class definition is available on github:

- [PolyCurve.cs](https://github.com/BHoM/BHoM/blob/develop/Geometry_oM/Curve\PolyCurve.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Geometry_oM/PolyCurve.json"
}
```

The JSON Schema is available on github here:

- [PolyCurve.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Geometry_oM/PolyCurve.json)
### Example JSON instance

Example JSON instance of type PolyCurve.

``` json title="Example JSON"
{
  "_t": "BH.oM.Geometry.PolyCurve",
  "Curves": [
    {
      "_t": "BH.oM.Geometry.Arc",
      "CoordinateSystem": {
        "_t": "BH.oM.Geometry.CoordinateSystem.Cartesian",
        "X": {
          "_t": "BH.oM.Geometry.Vector",
          "X": 1.0,
          "Y": 0.0,
          "Z": 0.0
        },
        "Y": {
          "_t": "BH.oM.Geometry.Vector",
          "X": 0.0,
          "Y": 1.0,
          "Z": 0.0
        },
        "Z": {
          "_t": "BH.oM.Geometry.Vector",
          "X": 0.0,
          "Y": 0.0,
          "Z": 1.0
        },
        "Origin": {
          "_t": "BH.oM.Geometry.Point",
          "X": 0.0,
          "Y": 0.0,
          "Z": 0.0
        }
      },
      "Radius": 3.0,
      "StartAngle": 0.0,
      "EndAngle": 1.5707963267948966
    },
    {
      "_t": "BH.oM.Geometry.Line",
      "Start": {
        "_t": "BH.oM.Geometry.Point",
        "X": 0.0,
        "Y": 3.0,
        "Z": 0.0
      },
      "End": {
        "_t": "BH.oM.Geometry.Point",
        "X": -3.0,
        "Y": 3.0,
        "Z": 0.0
      },
      "Infinite": false
    },
    {
      "_t": "BH.oM.Geometry.Line",
      "Start": {
        "_t": "BH.oM.Geometry.Point",
        "X": -3.0,
        "Y": 3.0,
        "Z": 0.0
      },
      "End": {
        "_t": "BH.oM.Geometry.Point",
        "X": -3.0,
        "Y": -1.0,
        "Z": 0.0
      },
      "Infinite": false
    },
    {
      "_t": "BH.oM.Geometry.Line",
      "Start": {
        "_t": "BH.oM.Geometry.Point",
        "X": -3.0,
        "Y": -1.0,
        "Z": 0.0
      },
      "End": {
        "_t": "BH.oM.Geometry.Point",
        "X": 0.0,
        "Y": -1.0,
        "Z": 0.0
      },
      "Infinite": false
    }
  ],
  "_bhomVersion": "8.2"
}
```

