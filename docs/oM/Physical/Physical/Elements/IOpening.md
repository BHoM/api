---
title: IOpening
---

# Physical.Elements.IOpening



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IOpening in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IBHoMObject](/api/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api/oM/Framework/Base/IObject)
    -  Physical.[IPhysical](/api/oM/Physical/Physical/IPhysical)
    -  Dimensional.[IElement2D](/api/oM/Dimensional/Dimensional/IElement2D)
    -  Dimensional.[IElement](/api/oM/Dimensional/Dimensional/IElement)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Physical.Elements.[Door](/api/oM/Physical/Physical/Elements/Door)
    - Physical.Elements.[Void](/api/oM/Physical/Physical/Elements/Void)
    - Physical.Elements.[Window](/api/oM/Physical/Physical/Elements/Window)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Location | [ISurface](/api/oM/Dimensional/Geometry/ISurface) | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Area | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Queries the IElement2Ds area defined as the area confined by the outline curves subtracting the area of the internal elements. | [Area](/api/oM/Dimensional/Quantities/Attributes/Area) [m²] | Spatial_Engine |
| Bottom | [ICurve](/api/oM/Dimensional/Geometry/ICurve) | Returns the bottom curve of a given generic opening object. | - | Physical_Engine |
| Bounds | [BoundingBox](/api/oM/Dimensional/Geometry/BoundingBox) | Queries the IElement2Ds BoundingBox. Acts on the element curve definition of the IElement2D through the Geometry_Engine. | - | Spatial_Engine |
| Centroid | [Point](/api/oM/Dimensional/Geometry/Point) | Queries the centre of area for a IElement2Ds surface representation. For an IElement2D with homogeneous material and thickness this will also be the centre of weight. | - | Spatial_Engine |
| ControlPoints | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api/oM/Dimensional/Geometry/Point)&gt; | Queries the control points of the element curve representation of the IElement2D. | - | Spatial_Engine |
| DominantVector | [Vector](/api/oM/Dimensional/Geometry/Vector) | Gets the the dominant vector (orientation) of an Element2D based on its lines lengths. | - | Spatial_Engine |
| ElementCurves | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api/oM/Dimensional/Geometry/ICurve)&gt; | Queries the geometricly defining curves of the IElement2Ds surface. | - | Spatial_Engine |
| ElementVertices | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api/oM/Dimensional/Geometry/Point)&gt; | Returns the discontinuity points from the defining ICurves of the IElement2D. | - | Spatial_Engine |
| ExternalElementCurves | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api/oM/Dimensional/Geometry/ICurve)&gt; | Queries the geometricly defining external curves of the IElement2Ds surface. | - | Spatial_Engine |
| ExternalPolyline | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Polyline](/api/oM/Dimensional/Geometry/Polyline)&gt; | Returns the External Polyline representation of a physical object (e.g. wall or window). | - | Physical_Engine |
| ExternalPolyline | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Polyline](/api/oM/Dimensional/Geometry/Polyline)&gt; | Returns the External Polyline representation of a physical object that represents an opening (e.g. window or door). | - | Physical_Engine |
| IArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Queries the area of the geometrical representation of an IElement. | [Area](/api/oM/Dimensional/Quantities/Attributes/Area) [m²] | Spatial_Engine |
| IBounds | [BoundingBox](/api/oM/Dimensional/Geometry/BoundingBox) | Queries the IElements BoundingBox. Acts on the elements geometrical definition of the IElement through the Geometry_Engine. | - | Spatial_Engine |
| ICentroid | [Point](/api/oM/Dimensional/Geometry/Point) | Queries the centre of weight for the homogeneous geometrical representation of an IElement. | - | Spatial_Engine |
| IControlPoints | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api/oM/Dimensional/Geometry/Point)&gt; | Queries the control points of the geometrical representation of an IElement. | - | Spatial_Engine |
| IElementCurves | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api/oM/Dimensional/Geometry/ICurve)&gt; | Queries the geometricly defining curves of the IElements geometry. | - | Spatial_Engine |
| IElementVertices | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api/oM/Dimensional/Geometry/Point)&gt; | Returns the discontinuity points from the defining ICurves of the IElement. | - | Spatial_Engine |
| IGeneralMaterialTakeoff | [GeneralMaterialTakeoff](/api/oM/Physical/Physical/Materials/GeneralMaterialTakeoff) | Gets the volumetric material takeoff from the IOpening. | - | Facade_Engine |
| IGeneralMaterialTakeoff | [GeneralMaterialTakeoff](/api/oM/Physical/Physical/Materials/GeneralMaterialTakeoff) | Gets the volumetric material takeoff from the IOpening. | - | Physical_Engine |
| IHeight | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the vertical orthogonal height of a generic opening based on global coordinates of its BoundingBox. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] | Physical_Engine |
| IInternalElements2D | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IElement2D](/api/oM/Dimensional/Dimensional/IElement2D)&gt; | Queries the IElement2Ds internal IElement2Ds. Returns a empty list for objects without definied internal elements | - | Spatial_Engine |
| IIsPlanar | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks whether all control points of an element lie in a single plane. | - | Spatial_Engine |
| IIsSelfIntersecting | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if any of the curves defining an IElement is closer to itself than the tolerance at any two points (is self intersecting). In case of IElement2D, does not check for intersections between external and internal curves, or between different internal curves. | - | Spatial_Engine |
| INewInternalElement2D | [IElement2D](/api/oM/Dimensional/Dimensional/IElement2D) | Creates a IElement2D of a type which can be assigned to the IElement2D. | - | Spatial_Engine |
| InternalElementCurves | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api/oM/Dimensional/Geometry/ICurve)&gt; | Queries the geometricly defining internal curves, such as Openings, of the IElement2Ds surface. | - | Spatial_Engine |
| InternalOutlineCurves | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[PolyCurve](/api/oM/Dimensional/Geometry/PolyCurve)&gt; | Queries the IElement2Ds internal IElement2Ds outline curves. | - | Spatial_Engine |
| InternalPolyline | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Polyline](/api/oM/Dimensional/Geometry/Polyline)&gt; | Returns the Internal Polyline representation of a physical object (e.g. wall or window). | - | Physical_Engine |
| InternalPolyline | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Polyline](/api/oM/Dimensional/Geometry/Polyline)&gt; | Returns the Internal Polyline representation of a physical object that represents an opening (e.g. window or door). | - | Physical_Engine |
| IOutlineElements1D | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IElement1D](/api/oM/Dimensional/Dimensional/IElement1D)&gt; | Returns every IElement1D which makes up the exterior perimeter of the IElement2D. | - | Spatial_Engine |
| IPrimaryPropertyName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Returns the name of an elements primary defining construction property | - | Facade_Engine |
| IsPlanar | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks whether all control points of an element lie in a single plane. | - | Spatial_Engine |
| IsSelfIntersecting | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if any of the element curves of the IElement2D is closer to itself than the tolerance at any two points. Does not check for intersections between external and internal curves, or between different internal curves. | - | Spatial_Engine |
| IVolumetricMaterialTakeoff | [VolumetricMaterialTakeoff](/api/oM/Physical/Physical/Materials/VolumetricMaterialTakeoff) | Gets the volumetric material takeoff from the IOpening. | - | Physical_Engine |
| IWidth | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the horizontal orthogonal width of a generic opening based on global coordinates of its BoundingBox. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] | Physical_Engine |
| Mass | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Evaluates the mass of an object based its Solid Volume and Density.<br>Requires a single consistent value of Density to be provided across all MaterialProperties of a given element. | [Mass](/api/oM/Dimensional/Quantities/Attributes/Mass) [kg] | Physical_Engine |
| MaterialComposition | [MaterialComposition](/api/oM/Physical/Physical/Materials/MaterialComposition) | Gets all the Materials an IOpening is composed of and in which ratios. | - | Physical_Engine |
| Normal | [Vector](/api/oM/Dimensional/Geometry/Vector) | Returns the normal to the IElement2D which is perpendicular to its plane and oriented according to the right hand rule in relation to the outline curve. | - | Spatial_Engine |
| OutlineCurve | [PolyCurve](/api/oM/Dimensional/Geometry/PolyCurve) | Returns a single polycurve outline created from the external elements. | - | Spatial_Engine |
| OutlineElements1D | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IElement1D](/api/oM/Dimensional/Dimensional/IElement1D)&gt; | Gets the external outline elements of an IOpening. | - | Physical_Engine |
| Polyline | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Polyline](/api/oM/Dimensional/Geometry/Polyline)&gt; | Returns a Polyline representation of a physical object that represents an opening (e.g. window or door). | - | Physical_Engine |
| Polyline | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Polyline](/api/oM/Dimensional/Geometry/Polyline)&gt; | Returns a Polyline representation of a physical object (e.g. wall or window). | - | Physical_Engine |
| SolidVolume | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns an IOpening's solid volume based on thickness and area. | [Volume](/api/oM/Dimensional/Quantities/Attributes/Volume) [m³] | Physical_Engine |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IOpening.cs](https://github.com/BHoM/BHoM/blob/develop/Physical_oM/Elements\IOpening.cs)

All history and changes of the class can be found by inspection the history.
