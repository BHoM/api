---
title: IElement1D
---

# <small>BH.oM.Dimensional.</small>**IElement1D**

Enables geometrical operations to be performed on a Curve based spatial element, whilst preserving all other object properties as unchanged. /nObjects implementing this interface will be required to implement some base methods for getting and setting data in a way that maintains the object's other properties.

[Documentation link](https://bhom.xyz/documentation/BHoM_oM/Dimensional_oM/IElement-required-extension-methods/)

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IElement1D is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Dimensional.[IElement](/api/oM/Dimensional/Dimensional/IElement)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - BH.oM.Analytical.Elements.[IEdge](/api/oM/Analytical/Analytical/Elements/IEdge)
    - BH.oM.Analytical.Elements.[ILink](/api/oM/Analytical/Analytical/Elements/ILink)&lt;[TNode](/api/oM/Analytical/Analytical/Elements/ILink#tnode)&gt;
    - BH.oM.Geometry.[IBoundary](/api/oM/Dimensional/Geometry/Curve/IBoundary)
    - BH.oM.Geometry.[ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve)
    - BH.oM.Geometry.[IPolyCurve](/api/oM/Dimensional/Geometry/Curve/IPolyCurve)
    - BH.oM.Geometry.[IPolyline](/api/oM/Dimensional/Geometry/Curve/IPolyline)
    - BH.oM.MEP.System.[IFlow](/api/oM/Analytical/MEP/System/IFlow)
    - BH.oM.Physical.Elements.[IFramingElement](/api/oM/Physical/Physical/Elements/IFramingElement)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Environment.Elements.[Edge](/api/oM/Analytical/Environment/Elements/Edge)
    - BH.oM.Facade.Elements.[FrameEdge](/api/oM/Analytical/Facade/Elements/FrameEdge)
    - BH.oM.Geometry.[Arc](/api/oM/Dimensional/Geometry/Curve/Arc)
    - BH.oM.Geometry.[BoundaryCurve](/api/oM/Dimensional/Geometry/Curve/BoundaryCurve)
    - BH.oM.Geometry.[Circle](/api/oM/Dimensional/Geometry/Curve/Circle)
    - BH.oM.Geometry.[Ellipse](/api/oM/Dimensional/Geometry/Curve/Ellipse)
    - BH.oM.Geometry.[Line](/api/oM/Dimensional/Geometry/Curve/Line)
    - BH.oM.Geometry.[NurbsCurve](/api/oM/Dimensional/Geometry/Curve/NurbsCurve)
    - BH.oM.Geometry.[PolyCurve](/api/oM/Dimensional/Geometry/Curve/PolyCurve)
    - BH.oM.Geometry.[Polygon](/api/oM/Dimensional/Geometry/Curve/Polygon)
    - BH.oM.Geometry.[Polyline](/api/oM/Dimensional/Geometry/Curve/Polyline)
    - BH.oM.MEP.System.[CableTray](/api/oM/Analytical/MEP/System/CableTray)
    - BH.oM.MEP.System.[Duct](/api/oM/Analytical/MEP/System/Duct)
    - BH.oM.MEP.System.[FlowSystem](/api/oM/Analytical/MEP/System/FlowSystem)
    - BH.oM.MEP.System.[Pipe](/api/oM/Analytical/MEP/System/Pipe)
    - BH.oM.MEP.System.[WireSegment](/api/oM/Analytical/MEP/System/WireSegment)
    - BH.oM.Physical.Elements.[Beam](/api/oM/Physical/Physical/Elements/Beam)
    - BH.oM.Physical.Elements.[Bracing](/api/oM/Physical/Physical/Elements/Bracing)
    - BH.oM.Physical.Elements.[Cable](/api/oM/Physical/Physical/Elements/Cable)
    - BH.oM.Physical.Elements.[Column](/api/oM/Physical/Physical/Elements/Column)
    - BH.oM.Physical.Elements.[Pile](/api/oM/Physical/Physical/Elements/Pile)
    - BH.oM.Spatial.SettingOut.[Grid](/api/oM/Dimensional/Spatial/SettingOut/Grid)
    - BH.oM.Structure.Elements.[Bar](/api/oM/Analytical/Structure/Elements/Bar)
    - BH.oM.Structure.Elements.[Edge](/api/oM/Analytical/Structure/Elements/Edge)
    - BH.oM.Structure.Elements.[Pile](/api/oM/Analytical/Structure/Elements/Pile)


## Properties

### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Bounds | [BoundingBox](/api/oM/Dimensional/Geometry/Misc/BoundingBox) | Queries the IElement1Ds BoundingBox. Acts on the ICurve definition of the IElement1D through the Geometry_Engine. | - | Spatial_Engine |
| Centroid | [Point](/api/oM/Dimensional/Geometry/Vector/Point) | Queries the centre of weight for a IElement1Ds ICurve representation. | - | Spatial_Engine |
| ControlPoints | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api/oM/Dimensional/Geometry/Vector/Point)&gt; | Queries the control points of the one dimensional representation of the IElement1D. | - | Spatial_Engine |
| DominantVector | [Vector](/api/oM/Dimensional/Geometry/Vector/Vector) | Gets the the dominant vector (orientation) of an Element1D based on its lines lengths. | - | Spatial_Engine |
| ElementCurves | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve)&gt; | Queries the defining curves of an IElement1D. | - | Spatial_Engine |
| ElementVertices | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api/oM/Dimensional/Geometry/Vector/Point)&gt; | Returns the discontinuity points from the defining ICurve of the IElement1D. | - | Spatial_Engine |
| IArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Queries the area of the geometrical representation of an IElement. | [Area](/api/oM/Dimensional/Quantities/Attributes/Area) [m²] | Spatial_Engine |
| IBounds | [BoundingBox](/api/oM/Dimensional/Geometry/Misc/BoundingBox) | Queries the IElements BoundingBox. Acts on the elements geometrical definition of the IElement through the Geometry_Engine. | - | Spatial_Engine |
| ICentroid | [Point](/api/oM/Dimensional/Geometry/Vector/Point) | Queries the centre of weight for the homogeneous geometrical representation of an IElement. | - | Spatial_Engine |
| IControlPoints | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api/oM/Dimensional/Geometry/Vector/Point)&gt; | Queries the control points of the geometrical representation of an IElement. | - | Spatial_Engine |
| IElementCurves | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve)&gt; | Queries the geometricly defining curves of the IElements geometry. | - | Spatial_Engine |
| IElements0D | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IElement0D](/api/oM/Dimensional/Dimensional/IElement0D)&gt; | Queries the IElement0Ds from a IElement1D. Returns null if no IElement0Ds are defined for the type of IElement1D. | - | Spatial_Engine |
| IElementVertices | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api/oM/Dimensional/Geometry/Vector/Point)&gt; | Returns the discontinuity points from the defining ICurves of the IElement. | - | Spatial_Engine |
| IGeometry | [ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve) | Queries the defining geometrical object which all spatial operations will act on. | - | Spatial_Engine |
| IIsPlanar | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks whether all control points of an element lie in a single plane. | - | Spatial_Engine |
| IIsSelfIntersecting | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if any of the curves defining an IElement is closer to itself than the tolerance at any two points (is self intersecting). In case of IElement2D, does not check for intersections between external and internal curves, or between different internal curves. | - | Spatial_Engine |
| IPrimaryPropertyName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Returns the name of an elements primary defining property | - | Facade_Engine |
| IsPlanar | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks whether all control points of an element lie in a single plane. | - | Spatial_Engine |
| IsSelfIntersecting | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if the one dimensional representation of the IElement1D is closer to itself than the tolerance at any two points. | - | Spatial_Engine |
| Length | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the length of the IElement1Ds curve. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] | Spatial_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IElement1D : BH.oM.Dimensional.IElement, BH.oM.Base.IObject
```

Assembly: Dimensional_oM.dll

The C# interface definition is available on github:

- [IElement1D.cs](https://github.com/BHoM/BHoM/blob/develop/Dimensional_oM/IElement1D.cs)

All history and changes of the class can be found by inspection the history.
