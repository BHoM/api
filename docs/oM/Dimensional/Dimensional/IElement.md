---
title: IElement
---

# <small>BH.oM.Dimensional.</small>**IElement**

The common base interface for all the Spatial Dimensional Objects.This interface should not be implemented directly, only through its sub-interfaces.Methods operating on IElement assume a specific implementation of one or other of the sub-interfaces (i.e. IElement0D, IElement1D, IElement2D)

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IElement is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - BH.oM.Analytical.Elements.[IEdge](/api/oM/Analytical/Analytical/Elements/IEdge)
    - BH.oM.Analytical.Elements.[ILink](/api/oM/Analytical/Analytical/Elements/ILink)&lt;[TNode](/api/oM/Analytical/Analytical/Elements/ILink#tnode)&gt;
    - BH.oM.Analytical.Elements.[INode](/api/oM/Analytical/Analytical/Elements/INode)
    - BH.oM.Analytical.Elements.[IOpening](/api/oM/Analytical/Analytical/Elements/IOpening)&lt;[TEdge](/api/oM/Analytical/Analytical/Elements/IOpening#tedge)&gt;
    - BH.oM.Analytical.Elements.[IPanel](/api/oM/Analytical/Analytical/Elements/IPanel)&lt;[TEdge](/api/oM/Analytical/Analytical/Elements/IPanel#tedge), [TOpening](/api/oM/Analytical/Analytical/Elements/IPanel#topening)&gt;
    - BH.oM.Analytical.Elements.[IRegion](/api/oM/Analytical/Analytical/Elements/IRegion)
    - BH.oM.Dimensional.[IElement0D](/api/oM/Dimensional/Dimensional/IElement0D)
    - BH.oM.Dimensional.[IElement1D](/api/oM/Dimensional/Dimensional/IElement1D)
    - BH.oM.Dimensional.[IElement2D](/api/oM/Dimensional/Dimensional/IElement2D)
    - BH.oM.Dimensional.[IElement3D](/api/oM/Dimensional/Dimensional/IElement3D)
    - BH.oM.Geometry.[IBoundary](/api/oM/Dimensional/Geometry/Curve/IBoundary)
    - BH.oM.Geometry.[ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve)
    - BH.oM.Geometry.[IPolyCurve](/api/oM/Dimensional/Geometry/Curve/IPolyCurve)
    - BH.oM.Geometry.[IPolyline](/api/oM/Dimensional/Geometry/Curve/IPolyline)
    - BH.oM.MEP.System.[IFlow](/api/oM/Analytical/MEP/System/IFlow)
    - BH.oM.Physical.Elements.[IFramingElement](/api/oM/Physical/Physical/Elements/IFramingElement)
    - BH.oM.Physical.Elements.[IOpening](/api/oM/Physical/Physical/Elements/IOpening)
    - BH.oM.Physical.Elements.[ISurface](/api/oM/Physical/Physical/Elements/ISurface)


### Classes implementing this interface

??? bhom "The following classes are implementing this interface:"

    - BH.oM.Architecture.Elements.[Ceiling](/api/oM/Analytical/Architecture/Elements/Ceiling)
    - BH.oM.Architecture.Elements.[CeilingTile](/api/oM/Analytical/Architecture/Elements/CeilingTile)
    - BH.oM.Architecture.Elements.[Room](/api/oM/Analytical/Architecture/Elements/Room)
    - BH.oM.Architecture.BuildersWork.[Opening](/api/oM/Analytical/Architecture/BuildersWork/Opening)
    - BH.oM.Environment.Elements.[Edge](/api/oM/Analytical/Environment/Elements/Edge)
    - BH.oM.Environment.Elements.[Opening](/api/oM/Analytical/Environment/Elements/Opening)
    - BH.oM.Environment.Elements.[Panel](/api/oM/Analytical/Environment/Elements/Panel)
    - BH.oM.Environment.Elements.[Space](/api/oM/Analytical/Environment/Elements/Space)
    - BH.oM.Environment.Elements.[Zone](/api/oM/Analytical/Environment/Elements/Zone)
    - BH.oM.Environment.Analysis.[Node](/api/oM/Analytical/Environment/Analysis/Node)
    - BH.oM.Facade.Elements.[CurtainWall](/api/oM/Analytical/Facade/Elements/CurtainWall)
    - BH.oM.Facade.Elements.[FrameEdge](/api/oM/Analytical/Facade/Elements/FrameEdge)
    - BH.oM.Facade.Elements.[Opening](/api/oM/Analytical/Facade/Elements/Opening)
    - BH.oM.Facade.Elements.[Panel](/api/oM/Analytical/Facade/Elements/Panel)
    - BH.oM.Geometry.[Arc](/api/oM/Dimensional/Geometry/Curve/Arc)
    - BH.oM.Geometry.[BoundaryCurve](/api/oM/Dimensional/Geometry/Curve/BoundaryCurve)
    - BH.oM.Geometry.[Circle](/api/oM/Dimensional/Geometry/Curve/Circle)
    - BH.oM.Geometry.[Ellipse](/api/oM/Dimensional/Geometry/Curve/Ellipse)
    - BH.oM.Geometry.[Line](/api/oM/Dimensional/Geometry/Curve/Line)
    - BH.oM.Geometry.[NurbsCurve](/api/oM/Dimensional/Geometry/Curve/NurbsCurve)
    - BH.oM.Geometry.[PolyCurve](/api/oM/Dimensional/Geometry/Curve/PolyCurve)
    - BH.oM.Geometry.[Polygon](/api/oM/Dimensional/Geometry/Curve/Polygon)
    - BH.oM.Geometry.[Polyline](/api/oM/Dimensional/Geometry/Curve/Polyline)
    - BH.oM.Geometry.[PlanarSurface](/api/oM/Dimensional/Geometry/Surface/PlanarSurface)
    - BH.oM.Geometry.[Point](/api/oM/Dimensional/Geometry/Vector/Point)
    - BH.oM.Graphics.[RenderPoint](/api/oM/Graphics/Graphics/Render/RenderPoint)
    - BH.oM.Lighting.Elements.[Luminaire](/api/oM/Analytical/Lighting/Elements/Luminaire)
    - BH.oM.Lighting.Analysis.[Node](/api/oM/Analytical/Lighting/Analysis/Node)
    - BH.oM.MEP.System.[CableTray](/api/oM/Analytical/MEP/System/CableTray)
    - BH.oM.MEP.System.[Duct](/api/oM/Analytical/MEP/System/Duct)
    - BH.oM.MEP.System.[FlowSystem](/api/oM/Analytical/MEP/System/FlowSystem)
    - BH.oM.MEP.System.[Node](/api/oM/Analytical/MEP/System/Node)
    - BH.oM.MEP.System.[Pipe](/api/oM/Analytical/MEP/System/Pipe)
    - BH.oM.MEP.System.[WireSegment](/api/oM/Analytical/MEP/System/WireSegment)
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
    - BH.oM.Physical.Elements.[Beam](/api/oM/Physical/Physical/Elements/Beam)
    - BH.oM.Physical.Elements.[Bracing](/api/oM/Physical/Physical/Elements/Bracing)
    - BH.oM.Physical.Elements.[Cable](/api/oM/Physical/Physical/Elements/Cable)
    - BH.oM.Physical.Elements.[Column](/api/oM/Physical/Physical/Elements/Column)
    - BH.oM.Physical.Elements.[Door](/api/oM/Physical/Physical/Elements/Door)
    - BH.oM.Physical.Elements.[Floor](/api/oM/Physical/Physical/Elements/Floor)
    - BH.oM.Physical.Elements.[MeshElement](/api/oM/Physical/Physical/Elements/MeshElement)
    - BH.oM.Physical.Elements.[PadFoundation](/api/oM/Physical/Physical/Elements/PadFoundation)
    - BH.oM.Physical.Elements.[Pile](/api/oM/Physical/Physical/Elements/Pile)
    - BH.oM.Physical.Elements.[Roof](/api/oM/Physical/Physical/Elements/Roof)
    - BH.oM.Physical.Elements.[Void](/api/oM/Physical/Physical/Elements/Void)
    - BH.oM.Physical.Elements.[Wall](/api/oM/Physical/Physical/Elements/Wall)
    - BH.oM.Physical.Elements.[Window](/api/oM/Physical/Physical/Elements/Window)
    - BH.oM.Security.Elements.[CameraDevice](/api/oM/Analytical/Security/Elements/CameraDevice)
    - BH.oM.Spatial.SettingOut.[Grid](/api/oM/Dimensional/Spatial/SettingOut/Grid)
    - BH.oM.Structure.Reinforcement.[ReinforcementRegion](/api/oM/Analytical/Structure/Reinforcement/ReinforcementRegion)
    - BH.oM.Structure.Elements.[Bar](/api/oM/Analytical/Structure/Elements/Bar)
    - BH.oM.Structure.Elements.[Edge](/api/oM/Analytical/Structure/Elements/Edge)
    - BH.oM.Structure.Elements.[Node](/api/oM/Analytical/Structure/Elements/Node)
    - BH.oM.Structure.Elements.[Opening](/api/oM/Analytical/Structure/Elements/Opening)
    - BH.oM.Structure.Elements.[PadFoundation](/api/oM/Analytical/Structure/Elements/PadFoundation)
    - BH.oM.Structure.Elements.[Panel](/api/oM/Analytical/Structure/Elements/Panel)
    - BH.oM.Structure.Elements.[Pile](/api/oM/Analytical/Structure/Elements/Pile)
    - BH.oM.Structure.Elements.[Stem](/api/oM/Analytical/Structure/Elements/Stem)


## Properties

### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Queries the area of the geometrical representation of an IElement. | [Area](/api/oM/Dimensional/Quantities/Attributes/Area) [m²] | Spatial_Engine |
| IBounds | [BoundingBox](/api/oM/Dimensional/Geometry/Misc/BoundingBox) | Queries the IElements BoundingBox. Acts on the elements geometrical definition of the IElement through the Geometry_Engine. | - | Spatial_Engine |
| ICentroid | [Point](/api/oM/Dimensional/Geometry/Vector/Point) | Queries the centre of weight for the homogeneous geometrical representation of an IElement. | - | Spatial_Engine |
| IControlPoints | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api/oM/Dimensional/Geometry/Vector/Point)&gt; | Queries the control points of the geometrical representation of an IElement. | - | Spatial_Engine |
| IElementCurves | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve)&gt; | Queries the geometricly defining curves of the IElements geometry. | - | Spatial_Engine |
| IElementVertices | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api/oM/Dimensional/Geometry/Vector/Point)&gt; | Returns the discontinuity points from the defining ICurves of the IElement. | - | Spatial_Engine |
| IIsPlanar | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks whether all control points of an element lie in a single plane. | - | Spatial_Engine |
| IIsSelfIntersecting | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if any of the curves defining an IElement is closer to itself than the tolerance at any two points (is self intersecting). In case of IElement2D, does not check for intersections between external and internal curves, or between different internal curves. | - | Spatial_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IElement : BH.oM.Base.IObject
```

Assembly: Dimensional_oM.dll

The C# interface definition is available on github:

- [IElement.cs](https://github.com/BHoM/BHoM/blob/develop/Dimensional_oM/IElement.cs)

All history and changes of the class can be found by inspection the history.
