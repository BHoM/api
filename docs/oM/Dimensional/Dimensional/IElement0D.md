---
title: IElement0D
---

# <small>BH.oM.Dimensional.</small>**IElement0D**

Enables geometrical operations to be performed on a Point based spatial element, whilst preserving all other object properties as unchanged. /nObjects implementing this interface will be required to implement some base methods for getting and setting data in a way that maintains the object's other properties.

[Documentation link](https://bhom.xyz/documentation/BHoM_oM/Dimensional_oM/IElement-required-extension-methods/)

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IElement0D is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Dimensional.[IElement](/api/oM/Dimensional/Dimensional/IElement)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - BH.oM.Analytical.Elements.[INode](/api/oM/Analytical/Analytical/Elements/INode)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Architecture.BuildersWork.[Opening](/api/oM/Analytical/Architecture/BuildersWork/Opening)
    - BH.oM.Environment.Analysis.[Node](/api/oM/Analytical/Environment/Analysis/Node)
    - BH.oM.Geometry.[Point](/api/oM/Dimensional/Geometry/Vector/Point)
    - BH.oM.Graphics.[RenderPoint](/api/oM/Graphics/Graphics/Render/RenderPoint)
    - BH.oM.Lighting.Elements.[Luminaire](/api/oM/Analytical/Lighting/Elements/Luminaire)
    - BH.oM.Lighting.Analysis.[Node](/api/oM/Analytical/Lighting/Analysis/Node)
    - BH.oM.MEP.System.[Node](/api/oM/Analytical/MEP/System/Node)
    - BH.oM.MEP.System.Fittings.[Fitting](/api/oM/Analytical/MEP/System/Fittings/Fitting)
    - BH.oM.MEP.System.Dampers.[Damper](/api/oM/Analytical/MEP/System/Dampers/Damper)
    - BH.oM.MEP.System.Dampers.[VolumeDamper](/api/oM/Analytical/MEP/System/Dampers/VolumeDamper)
    - BH.oM.MEP.System.Dampers.[Valve](/api/oM/Analytical/MEP/System/Valves/Valve)
    - BH.oM.MEP.Fixtures.[AirTerminal](/api/oM/Analytical/MEP/Fixtures/AirTerminal)
    - BH.oM.MEP.Fixtures.[ElectricalFixture](/api/oM/Analytical/MEP/Fixtures/ElectricalFixture)
    - BH.oM.MEP.Fixtures.[FireAlarmDevice](/api/oM/Analytical/MEP/Fixtures/FireAlarmDevice)
    - BH.oM.MEP.Fixtures.[LightFixture](/api/oM/Analytical/MEP/Fixtures/LightFixture)
    - BH.oM.MEP.Fixtures.[PlumbingFixture](/api/oM/Analytical/MEP/Fixtures/PlumbingFixture)
    - BH.oM.MEP.Equipment.[ElectricalEquipment](/api/oM/Analytical/MEP/Equipment/ElectricalEquipment)
    - BH.oM.MEP.Equipment.[MechanicalEquipment](/api/oM/Analytical/MEP/Equipment/MechanicalEquipment)
    - BH.oM.Security.Elements.[CameraDevice](/api/oM/Analytical/Security/Elements/CameraDevice)
    - BH.oM.Structure.Elements.[Node](/api/oM/Analytical/Structure/Elements/Node)


## Properties

### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Bounds | [BoundingBox](/api/oM/Dimensional/Geometry/Misc/BoundingBox) | Queries the IElement0Ds BoundingBox. Acts on the Point definition of the IElement0D through the Geometry_Engine. | - | Spatial_Engine |
| Centroid | [Point](/api/oM/Dimensional/Geometry/Vector/Point) | Queries the centre of weight for the homogeneous geometrical representation of an IElement0D. Always returns the point location due to zero-dimensionality of an IElement0D. | - | Spatial_Engine |
| ControlPoints | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api/oM/Dimensional/Geometry/Vector/Point)&gt; | Queries the control points of the geometrical representation of an IElement0D. Always returns the point location due to zero-dimensionality of an IElement0D. | - | Spatial_Engine |
| ElementCurves | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve)&gt; | Queries the defining curves of an IElement0D. Always returns empty collection due to zero-dimensionality of an IElement0D. | - | Spatial_Engine |
| ElementVertices | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api/oM/Dimensional/Geometry/Vector/Point)&gt; | Returns the point from the IElement0D. Mainly to accommodate the interface method. | - | Spatial_Engine |
| IArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Queries the area of the geometrical representation of an IElement. | [Area](/api/oM/Dimensional/Quantities/Attributes/Area) [m²] | Spatial_Engine |
| IBounds | [BoundingBox](/api/oM/Dimensional/Geometry/Misc/BoundingBox) | Queries the IElements BoundingBox. Acts on the elements geometrical definition of the IElement through the Geometry_Engine. | - | Spatial_Engine |
| ICentroid | [Point](/api/oM/Dimensional/Geometry/Vector/Point) | Queries the centre of weight for the homogeneous geometrical representation of an IElement. | - | Spatial_Engine |
| IControlPoints | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api/oM/Dimensional/Geometry/Vector/Point)&gt; | Queries the control points of the geometrical representation of an IElement. | - | Spatial_Engine |
| IElementCurves | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve)&gt; | Queries the geometrically defining curves of the IElements geometry. | - | Spatial_Engine |
| IElementVertices | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api/oM/Dimensional/Geometry/Vector/Point)&gt; | Returns the discontinuity points from the defining ICurves of the IElement. | - | Spatial_Engine |
| IGeometry | [Point](/api/oM/Dimensional/Geometry/Vector/Point) | Queries the defining geometrical object which all spatial operations will act on. | - | Spatial_Engine |
| IIsPlanar | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks whether all control points of an element lie in a single plane. | - | Spatial_Engine |
| IIsSelfIntersecting | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if any of the curves defining an IElement is closer to itself than the tolerance at any two points (is self intersecting). In case of IElement2D, does not check for intersections between external and internal curves, or between different internal curves. | - | Spatial_Engine |
| IsPlanar | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks whether all control points of an element lie in a single plane. | - | Spatial_Engine |
| IsSelfIntersecting | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if the one dimensional representation of the IElement0D is closer to itself than the tolerance at any two points. Always false because a zero-dimensional IElement0D does not consist of curves. | - | Spatial_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IElement0D : BH.oM.Dimensional.IElement, BH.oM.Base.IObject
```

Assembly: Dimensional_oM.dll

The C# interface definition is available on github:

- [IElement0D.cs](https://github.com/BHoM/BHoM/blob/develop/Dimensional_oM/IElement0D.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Dimensional_oM/IElement0D.json"
}
```

The JSON Schema is available on github here:

- [IElement0D.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Dimensional_oM/IElement0D.json)
