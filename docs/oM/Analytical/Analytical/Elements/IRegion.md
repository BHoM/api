---
title: IRegion
---

# <small>BH.oM.Analytical.Elements.</small>**IRegion**

Base interface for analytical elements defined by a single closed perimiter curve.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IRegion is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Analytical.[IAnalytical](/api/oM/Analytical/Analytical/IAnalytical)
    -  BH.oM.Dimensional.[IElement2D](/api/oM/Dimensional/Dimensional/IElement2D)
    -  BH.oM.Dimensional.[IElement](/api/oM/Dimensional/Dimensional/IElement)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Architecture.Elements.[CeilingTile](/api/oM/Analytical/Architecture/Elements/CeilingTile)
    - BH.oM.Architecture.Elements.[Room](/api/oM/Analytical/Architecture/Elements/Room)
    - BH.oM.Environment.Elements.[Space](/api/oM/Analytical/Environment/Elements/Space)
    - BH.oM.Environment.Elements.[Zone](/api/oM/Analytical/Environment/Elements/Zone)
    - BH.oM.Structure.Reinforcement.[ReinforcementRegion](/api/oM/Analytical/Structure/Reinforcement/ReinforcementRegion)
    - BH.oM.Structure.Elements.[PadFoundation](/api/oM/Analytical/Structure/Elements/PadFoundation)
    - BH.oM.Structure.Elements.[Stem](/api/oM/Analytical/Structure/Elements/Stem)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Perimeter | [ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve) | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Area | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Queries the IElement2Ds area defined as the area confined by the outline curves subtracting the area of the internal elements. | [Area](/api/oM/Dimensional/Quantities/Attributes/Area) [m²] | Spatial_Engine |
| Bounds | [BoundingBox](/api/oM/Dimensional/Geometry/Misc/BoundingBox) | Queries the IElement2Ds BoundingBox. Acts on the element curve definition of the IElement2D through the Geometry_Engine. | - | Spatial_Engine |
| Centroid | [Point](/api/oM/Dimensional/Geometry/Vector/Point) | Queries the centre of area for a IElement2Ds surface representation. For an IElement2D with homogeneous material and thickness this will also be the centre of weight. | - | Spatial_Engine |
| ControlPoints | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api/oM/Dimensional/Geometry/Vector/Point)&gt; | Queries the control points of the element curve representation of the IElement2D. | - | Spatial_Engine |
| DominantVector | [Vector](/api/oM/Dimensional/Geometry/Vector/Vector) | Gets the the dominant vector (orientation) of an Element2D based on its lines lengths. | - | Spatial_Engine |
| ElementCurves | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve)&gt; | Queries the geometricly defining curves of the IElement2Ds surface. | - | Spatial_Engine |
| ElementVertices | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api/oM/Dimensional/Geometry/Vector/Point)&gt; | Returns the discontinuity points from the defining ICurves of the IElement2D. | - | Spatial_Engine |
| ExternalElementCurves | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve)&gt; | Queries the geometricly defining external curves of the IElement2Ds surface. | - | Spatial_Engine |
| Geometry | [ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve) | Gets the geometry of a IRegion as its Perimiter curve. Method required for automatic display in UI packages. | - | Analytical_Engine |
| IArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Queries the area of the geometrical representation of an IElement. | [Area](/api/oM/Dimensional/Quantities/Attributes/Area) [m²] | Spatial_Engine |
| IBounds | [BoundingBox](/api/oM/Dimensional/Geometry/Misc/BoundingBox) | Queries the IElements BoundingBox. Acts on the elements geometrical definition of the IElement through the Geometry_Engine. | - | Spatial_Engine |
| ICentroid | [Point](/api/oM/Dimensional/Geometry/Vector/Point) | Queries the centre of weight for the homogeneous geometrical representation of an IElement. | - | Spatial_Engine |
| IControlPoints | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api/oM/Dimensional/Geometry/Vector/Point)&gt; | Queries the control points of the geometrical representation of an IElement. | - | Spatial_Engine |
| IElementCurves | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve)&gt; | Queries the geometricly defining curves of the IElements geometry. | - | Spatial_Engine |
| IElementVertices | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api/oM/Dimensional/Geometry/Vector/Point)&gt; | Returns the discontinuity points from the defining ICurves of the IElement. | - | Spatial_Engine |
| IInternalElements2D | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IElement2D](/api/oM/Dimensional/Dimensional/IElement2D)&gt; | Queries the IElement2Ds internal IElement2Ds. Returns a empty list for objects without definied internal elements | - | Spatial_Engine |
| IIsPlanar | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks whether all control points of an element lie in a single plane. | - | Spatial_Engine |
| IIsSelfIntersecting | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if any of the curves defining an IElement is closer to itself than the tolerance at any two points (is self intersecting). In case of IElement2D, does not check for intersections between external and internal curves, or between different internal curves. | - | Spatial_Engine |
| INewInternalElement2D | [IElement2D](/api/oM/Dimensional/Dimensional/IElement2D) | Creates a IElement2D of a type which can be assigned to the IElement2D. | - | Spatial_Engine |
| InternalElementCurves | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve)&gt; | Queries the geometricly defining internal curves, such as Openings, of the IElement2Ds surface. | - | Spatial_Engine |
| InternalOutlineCurves | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[PolyCurve](/api/oM/Dimensional/Geometry/Curve/PolyCurve)&gt; | Queries the IElement2Ds internal IElement2Ds outline curves. | - | Spatial_Engine |
| IOutlineElements1D | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IElement1D](/api/oM/Dimensional/Dimensional/IElement1D)&gt; | Returns every IElement1D which makes up the exterior perimeter of the IElement2D. | - | Spatial_Engine |
| IPrimaryPropertyName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Returns the name of an elements primary defining construction property | - | Facade_Engine |
| IsPlanar | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks whether all control points of an element lie in a single plane. | - | Spatial_Engine |
| IsSelfIntersecting | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if any of the element curves of the IElement2D is closer to itself than the tolerance at any two points. Does not check for intersections between external and internal curves, or between different internal curves. | - | Spatial_Engine |
| Normal | [Vector](/api/oM/Dimensional/Geometry/Vector/Vector) | Returns the normal to the IElement2D which is perpendicular to its plane and oriented according to the right hand rule in relation to the outline curve. | - | Spatial_Engine |
| OutlineCurve | [PolyCurve](/api/oM/Dimensional/Geometry/Curve/PolyCurve) | Returns a single polycurve outline created from the external elements. | - | Spatial_Engine |
| OutlineElements1D | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IElement1D](/api/oM/Dimensional/Dimensional/IElement1D)&gt; | Gets the boundary from an IRegion defining the boundary of the element as the subparts of the perimiter curve. Method required for all IElement2Ds. | - | Analytical_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IRegion : BH.oM.Base.IBHoMObject,
BH.oM.Base.IObject,
BH.oM.Analytical.IAnalytical,
BH.oM.Dimensional.IElement2D,
BH.oM.Dimensional.IElement
```

Assembly: Analytical_oM.dll

The C# interface definition is available on github:

- [IRegion.cs](https://github.com/BHoM/BHoM/blob/develop/Analytical_oM/Elements\IRegion.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Analytical_oM/Elements/IRegion.json"
}
```

The JSON Schema is available on github here:

- [IRegion.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Analytical_oM/Elements/IRegion.json)
