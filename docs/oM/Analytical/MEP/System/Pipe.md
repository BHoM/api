---
title: Pipe
---

# <small>BH.oM.MEP.System.</small>**Pipe**

A pipe object is a passageway which conveys material (water, waste, glycol)

## Class structure

### Implemented interfaces and base types

???+ bhom "The Pipe is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.MEP.System.[IFlow](/api/oM/Analytical/MEP/System/IFlow)
    -  BH.oM.Dimensional.[IElement1D](/api/oM/Dimensional/Dimensional/IElement1D)
    -  BH.oM.Dimensional.[IElement](/api/oM/Dimensional/Dimensional/IElement)
    -  BH.oM.Dimensional.[IElementM](/api/oM/Dimensional/Dimensional/IElementM)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| StartPoint | [Point](/api/oM/Dimensional/Geometry/Vector/Point) | The point at which the Pipe object begins. | - |
| EndPoint | [Point](/api/oM/Dimensional/Geometry/Vector/Point) | The point at which the Pipe object ends. | - |
| FlowRate | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The volume of fluid being conveyed by the pipe per second (m3/s). | - |
| SectionProperty | [PipeSectionProperty](/api/oM/Analytical/MEP/System/SectionProperties/PipeSectionProperty) | The pipe section property defines the shape and its associated properties (radius, material, thickness). | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Bounds | [BoundingBox](/api/oM/Dimensional/Geometry/Misc/BoundingBox) | Queries the IElement1Ds BoundingBox. Acts on the ICurve definition of the IElement1D through the Geometry_Engine. | - | Spatial_Engine |
| Centreline | [Line](/api/oM/Dimensional/Geometry/Curve/Line) | Returns the centreline of any IFlow object as the line between the StartPoint and EndPoint. No offsets or similar is accounted for. | - | MEP_Engine |
| Centroid | [Point](/api/oM/Dimensional/Geometry/Vector/Point) | Queries the centre of weight for a IElement1Ds ICurve representation. | - | Spatial_Engine |
| CompositeSolidVolumes | [Output](/api/oM/Framework/Base/Output)&lt;[double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0), [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0), [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0)&gt; | Queries the solid volume of a Pipe by multiplying the section profile's solid area by the element's length. | - | MEP_Engine |
| ControlPoints | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api/oM/Dimensional/Geometry/Vector/Point)&gt; | Queries the control points of the one dimensional representation of the IElement1D. | - | Spatial_Engine |
| DominantVector | [Vector](/api/oM/Dimensional/Geometry/Vector/Vector) | Gets the the dominant vector (orientation) of an Element1D based on its lines lengths. | - | Spatial_Engine |
| ElementCurves | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve)&gt; | Queries the defining curves of an IElement1D. | - | Spatial_Engine |
| ElementVertices | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api/oM/Dimensional/Geometry/Vector/Point)&gt; | Returns the discontinuity points from the defining ICurve of the IElement1D. | - | Spatial_Engine |
| Geometry | [IGeometry](/api/oM/Dimensional/Geometry/Interface/IGeometry) | Queries an IFlow object for its geometry. | - | MEP_Engine |
| IArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Queries the area of the geometrical representation of an IElement. | [Area](/api/oM/Dimensional/Quantities/Attributes/Area) [m²] | Spatial_Engine |
| IBounds | [BoundingBox](/api/oM/Dimensional/Geometry/Misc/BoundingBox) | Queries the IElements BoundingBox. Acts on the elements geometrical definition of the IElement through the Geometry_Engine. | - | Spatial_Engine |
| ICentroid | [Point](/api/oM/Dimensional/Geometry/Vector/Point) | Queries the centre of weight for the homogeneous geometrical representation of an IElement. | - | Spatial_Engine |
| IControlPoints | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api/oM/Dimensional/Geometry/Vector/Point)&gt; | Queries the control points of the geometrical representation of an IElement. | - | Spatial_Engine |
| IElementCurves | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve)&gt; | Queries the geometricly defining curves of the IElements geometry. | - | Spatial_Engine |
| IElements0D | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IElement0D](/api/oM/Dimensional/Dimensional/IElement0D)&gt; | Queries the IElement0Ds from a IElement1D. Returns null if no IElement0Ds are defined for the type of IElement1D. | - | Spatial_Engine |
| IElementVertices | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api/oM/Dimensional/Geometry/Vector/Point)&gt; | Returns the discontinuity points from the defining ICurves of the IElement. | - | Spatial_Engine |
| IGeneralMaterialTakeoff | [GeneralMaterialTakeoff](/api/oM/Physical/Physical/Materials/GeneralMaterialTakeoff) | Gets the unique Materials along with their volumes defining an object's make-up. | - | Matter_Engine |
| IGeometry | [ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve) | Queries the defining geometrical object which all spatial operations will act on. | - | Spatial_Engine |
| IIsPlanar | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks whether all control points of an element lie in a single plane. | - | Spatial_Engine |
| IIsSelfIntersecting | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if any of the curves defining an IElement is closer to itself than the tolerance at any two points (is self intersecting). In case of IElement2D, does not check for intersections between external and internal curves, or between different internal curves. | - | Spatial_Engine |
| IMaterialComposition | [MaterialComposition](/api/oM/Physical/Physical/Materials/MaterialComposition) | Gets the unique Materials along with their relative proportions defining an object's make-up. | - | Matter_Engine |
| IPrimaryPropertyName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Returns the name of an elements primary defining property | - | Facade_Engine |
| ISolidVolume | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns an element's solid volume, i.e. the the volume of the element that had any materiality, excluding cavities, openings and voids. | [Volume](/api/oM/Dimensional/Quantities/Attributes/Volume) [m³] | Matter_Engine |
| IsPlanar | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks whether all control points of an element lie in a single plane. | - | Spatial_Engine |
| IsSelfIntersecting | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if the one dimensional representation of the IElement1D is closer to itself than the tolerance at any two points. | - | Spatial_Engine |
| IVolumetricMaterialTakeoff | [VolumetricMaterialTakeoff](/api/oM/Physical/Physical/Materials/VolumetricMaterialTakeoff) | Gets the unique Materials along with their volumes defining an object's make-up. | - | Matter_Engine |
| Length | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Query the length of any IFlow Object. | - | MEP_Engine |
| Length | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the length of the IElement1Ds curve. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] | Spatial_Engine |
| Mass | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Evaluates the mass of an object based its VolumetricMaterialTakeoff and Density. | [Mass](/api/oM/Dimensional/Quantities/Attributes/Mass) [kg] | Matter_Engine |
| MaterialComposition | [MaterialComposition](/api/oM/Physical/Physical/Materials/MaterialComposition) | Gets all the Materials a pipe is composed of and in which ratios | [Ratio](/api/oM/Dimensional/Quantities/Attributes/Ratio) [-] | MEP_Engine |
| SolidVolume | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Queries the solid volume of a Pipe by multiplying the section profile's solid area by the element's length. Note this element contains a composite section and this query method returns a single summed value. If you want precise values per section profile, please use CompositeSolidVolumes. | - | MEP_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class Pipe : BH.oM.Base.BHoMObject,
BH.oM.Base.IBHoMObject,
BH.oM.Base.IObject,
BH.oM.MEP.System.IFlow,
BH.oM.Dimensional.IElement1D,
BH.oM.Dimensional.IElement,
BH.oM.Dimensional.IElementM
```

Assembly: MEP_oM.dll

The C# class definition is available on github:

- [Pipe.cs](https://github.com/BHoM/BHoM/blob/develop/MEP_oM/System\Pipe.cs)

All history and changes of the class can be found by inspection the history.
