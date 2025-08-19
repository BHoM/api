---
title: Opening
---

# <small>BH.oM.Environment.Elements.</small>**Opening**

A cutout or hole in a building surface/panel (e.g. Window, Door, Rooflight)

## Class structure

### Implemented interfaces and base types

???+ bhom "The Opening is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Environment.[IEnvironmentObject](/api/oM/Analytical/Environment/IEnvironmentObject)
    -  BH.oM.Analytical.Elements.[IOpening](/api/oM/Analytical/Analytical/Elements/IOpening)&lt;BH.oM.Environment.Elements.[Edge](/api/oM/Analytical/Environment/Elements/Edge)&gt;
    -  BH.oM.Analytical.[IAnalytical](/api/oM/Analytical/Analytical/IAnalytical)
    -  BH.oM.Dimensional.[IElement2D](/api/oM/Dimensional/Dimensional/IElement2D)
    -  BH.oM.Dimensional.[IElement](/api/oM/Dimensional/Dimensional/IElement)
    -  BH.oM.Dimensional.[IElementM](/api/oM/Dimensional/Dimensional/IElementM)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Edges | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Edge](/api/oM/Analytical/Environment/Elements/Edge)&gt; | A collection of environment Edge objects which define the external boundary of the opening | - |
| FrameConstruction | [IConstruction](/api/oM/Physical/Physical/Constructions/IConstruction) | A construction object providing construction information about the frame of the opening | - |
| FrameFactorValue | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The percentage of the opening that is frame | - |
| InnerEdges | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Edge](/api/oM/Analytical/Environment/Elements/Edge)&gt; | A collection of environment Edge objects which define the internal boundary of the opening | - |
| OpeningConstruction | [IConstruction](/api/oM/Physical/Physical/Constructions/IConstruction) | A construction object providing construction information about the opening - typically gazing construction | - |
| Type | [OpeningType](/api/oM/Analytical/Environment/Elements/Enums/OpeningType) | The type of opening on a panel (e.g. Window, Door). Use OpeningType enum | - |


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
| Altitude | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the minimum altitude of an Environment Object as the minimum z value from the bounding box of the geometry. | - | Environment_Engine |
| AltitudeRange | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the range of altitude of an Environment Object taken as the maximum z value minus minimum z value from the bounding box of the geometry | - | Environment_Engine |
| Area | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Queries the IElement2Ds area defined as the area confined by the outline curves subtracting the area of the internal elements. | [Area](/api/oM/Dimensional/Quantities/Attributes/Area) [m²] | Spatial_Engine |
| Bottom | [ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve) | Returns the bottom of a given environment object. | - | Environment_Engine |
| Bounds | [BoundingBox](/api/oM/Dimensional/Geometry/Misc/BoundingBox) | Queries the IElement2Ds BoundingBox. Acts on the element curve definition of the IElement2D through the Geometry_Engine. | - | Spatial_Engine |
| Centroid | [Point](/api/oM/Dimensional/Geometry/Vector/Point) | Queries the centre of area for a IElement2Ds surface representation. For an IElement2D with homogeneous material and thickness this will also be the centre of weight. | - | Spatial_Engine |
| ControlPoints | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api/oM/Dimensional/Geometry/Vector/Point)&gt; | Queries the control points of the element curve representation of the IElement2D. | - | Spatial_Engine |
| DominantVector | [Vector](/api/oM/Dimensional/Geometry/Vector/Vector) | Gets the dominant vector (orientation) of an Element2D based on its line lengths. | - | Spatial_Engine |
| ElementCurves | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve)&gt; | Queries the geometrically defining curves of the IElement2Ds surface. | - | Spatial_Engine |
| ElementEmbodiedCarbon | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/IElementResult)&lt;[MaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/MaterialResults/MaterialResult)&gt;&gt; | Evaluates the embodied carbon on the provided element based on IStructE methodology of evaluation.<br>If you would like to evaluate other EPD metrics, please use one of the Query.EnvironmentalResults methods. <br>TemplateMaterials can be provided helping with picking the correct EPD corresponding to each material on the element. Please note that this evaluation method only support mass-based EPDs. | - | LifeCycleAssessment_Engine |
| ElementMaterialNames | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Query the element's MaterialComposition to form a Material Hint to aid in EPD-Material Mapping. | - | LifeCycleAssessment_Engine |
| ElementScope | [ScopeType](/api/oM/Analytical/LifeCycleAssessment/Enums/ScopeType) | Returns the enumerable type of the scope found on an element. | - | LifeCycleAssessment_Engine |
| ElementVertices | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api/oM/Dimensional/Geometry/Vector/Point)&gt; | Returns the discontinuity points from the defining ICurves of the IElement2D. | - | Spatial_Engine |
| EnvironmentalResults | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/IElementResult)&lt;[MaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/MaterialResults/MaterialResult)&gt;&gt; | Evaluates the EnvironmentalMetrics for the provided element and returns an ElementResult for each evaluated metric type.<br>Evaluation is done by extracting the material takeoff for the provided element, giving quantities and Materiality.<br>Each Material in the takeoff is then evaluated by finding the EnvironmentalProductDeclaration (EPD), either stored on the material or from the list of template materials.<br>Each metric, or filtered chosen metrics, on the EPD is then evaluated.<br>Finally, an element result is returned per metric type. Each element result being the sum result of all metrics of the same type. | - | LifeCycleAssessment_Engine |
| ExplodeToParts | [Output](/api/oM/Framework/Base/Output)&lt;[List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve)&gt;, [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve)&gt;, [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve)&gt;&gt; | Returns the sides, top and bottom of a given environment object. | - | Environment_Engine |
| ExternalElementCurves | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve)&gt; | Queries the geometrically defining external curves of the IElement2Ds surface. | - | Spatial_Engine |
| FrameFactor | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the Frame Factor of an opening as a decimal representing the percentage of the opening which is made up of frame. Result is between 0 (0% frame) to 1 (100% frame) | - | Environment_Engine |
| Geometry | [PolyCurve](/api/oM/Dimensional/Geometry/Curve/PolyCurve) | Gets the geometry of a analytical IOpening as an outline curve. Method required for automatic display in UI packages. | - | Analytical_Engine |
| Height | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the height of an Environment Opening. | - | Environment_Engine |
| Height | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the height of a generic Environment Object. | - | Environment_Engine |
| IArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Queries the area of the geometrical representation of an IElement. | [Area](/api/oM/Dimensional/Quantities/Attributes/Area) [m²] | Spatial_Engine |
| IBounds | [BoundingBox](/api/oM/Dimensional/Geometry/Misc/BoundingBox) | Queries the IElements BoundingBox. Acts on the elements geometrical definition of the IElement through the Geometry_Engine. | - | Spatial_Engine |
| ICentroid | [Point](/api/oM/Dimensional/Geometry/Vector/Point) | Queries the centre of weight for the homogeneous geometrical representation of an IElement. | - | Spatial_Engine |
| IControlPoints | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api/oM/Dimensional/Geometry/Vector/Point)&gt; | Queries the control points of the geometrical representation of an IElement. | - | Spatial_Engine |
| IElementCurves | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve)&gt; | Queries the geometrically defining curves of the IElements geometry. | - | Spatial_Engine |
| IElementVertices | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api/oM/Dimensional/Geometry/Vector/Point)&gt; | Returns the discontinuity points from the defining ICurves of the IElement. | - | Spatial_Engine |
| IGeneralMaterialTakeoff | [GeneralMaterialTakeoff](/api/oM/Physical/Physical/Materials/GeneralMaterialTakeoff) | Gets the unique Materials along with their volumes defining an object's make-up. | - | Matter_Engine |
| IInternalElements2D | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IElement2D](/api/oM/Dimensional/Dimensional/IElement2D)&gt; | Queries the IElement2Ds internal IElement2Ds. Returns an empty list for objects without defined internal elements. | - | Spatial_Engine |
| IIsPlanar | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks whether all control points of an element lie in a single plane. | - | Spatial_Engine |
| IIsSelfIntersecting | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if any of the curves defining an IElement is closer to itself than the tolerance at any two points (is self intersecting). In case of IElement2D, does not check for intersections between external and internal curves, or between different internal curves. | - | Spatial_Engine |
| IMaterialComposition | [MaterialComposition](/api/oM/Physical/Physical/Materials/MaterialComposition) | Gets the unique Materials along with their relative proportions defining an object's make-up. | - | Matter_Engine |
| Inclination | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the inclination of a generic Environment Object. | - | Environment_Engine |
| INewInternalElement2D | [IElement2D](/api/oM/Dimensional/Dimensional/IElement2D) | Creates a IElement2D of a type which can be assigned to the IElement2D. | - | Spatial_Engine |
| InternalElementCurves | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve)&gt; | Queries the geometrically defining internal curves, such as Openings, of the IElement2Ds surface. | - | Spatial_Engine |
| InternalOutlineCurves | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[PolyCurve](/api/oM/Dimensional/Geometry/Curve/PolyCurve)&gt; | Queries the IElement2Ds internal IElement2Ds outline curves. | - | Spatial_Engine |
| IOutlineElements1D | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IElement1D](/api/oM/Dimensional/Dimensional/IElement1D)&gt; | Returns every IElement1D which makes up the exterior perimeter of the IElement2D. | - | Spatial_Engine |
| IPrimaryPropertyName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Returns the name of an elements primary defining construction property | - | Facade_Engine |
| ISolidVolume | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns an element's solid volume, i.e. the the volume of the element that had any materiality, excluding cavities, openings and voids. | [Volume](/api/oM/Dimensional/Quantities/Attributes/Volume) [m³] | Matter_Engine |
| IsPlanar | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks whether all control points of an element lie in a single plane. | - | Spatial_Engine |
| IsSelfIntersecting | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if any of the element curves of the IElement2D is closer to itself than the tolerance at any two points. Does not check for intersections between external and internal curves, or between different internal curves. | - | Spatial_Engine |
| IVolumetricMaterialTakeoff | [VolumetricMaterialTakeoff](/api/oM/Physical/Physical/Materials/VolumetricMaterialTakeoff) | Gets the unique Materials along with their volumes defining an object's make-up. | - | Matter_Engine |
| Mass | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Evaluates the mass of an object based its VolumetricMaterialTakeoff and Density. | [Mass](/api/oM/Dimensional/Quantities/Attributes/Mass) [kg] | Matter_Engine |
| MaterialComposition | [MaterialComposition](/api/oM/Physical/Physical/Materials/MaterialComposition) | Gets all the Materials a Opening is composed of and in which ratios. | - | Environment_Engine |
| MaximumLevel | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the maximum level of the given opening based on the z axis. | - | Environment_Engine |
| MinimumLevel | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the minimum level of the given opening based on the z axis. | - | Environment_Engine |
| Normal | [Vector](/api/oM/Dimensional/Geometry/Vector/Vector) | Returns the normal to the IElement2D which is perpendicular to its plane and oriented according to the right hand rule in relation to the outline curve. | - | Spatial_Engine |
| Orientation | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0)&gt; | Returns the angle to north of a given environmental object on an xyPlane. | - | Environment_Engine |
| OutlineCurve | [PolyCurve](/api/oM/Dimensional/Geometry/Curve/PolyCurve) | Returns a single polycurve outline created from the external elements. | - | Spatial_Engine |
| OutlineElements1D | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IElement1D](/api/oM/Dimensional/Dimensional/IElement1D)&gt; | Gets the edge elements from an IOpening defining the boundary of the element. Method required for all IElement2Ds. <br>For an IOpening this will return a list of its Edges. | - | Analytical_Engine |
| OutlineElements1D | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IElement1D](/api/oM/Dimensional/Dimensional/IElement1D)&gt; | Returns the outline 1D elements of an Environment Opening | - | Environment_Engine |
| Polyline | [Polyline](/api/oM/Dimensional/Geometry/Curve/Polyline) | Returns the external boundary from an Environment Opening as a BHoM Geometry Polyline. | - | Environment_Engine |
| Polyline | [Polyline](/api/oM/Dimensional/Geometry/Curve/Polyline) | Returns the external boundary from a generic Environment Object. | - | Environment_Engine |
| Sides | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve)&gt; | Returns the sides of a given environment object. | - | Environment_Engine |
| SolidVolume | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns an Openings solid volume based on its area, and construction thickness. | [Volume](/api/oM/Dimensional/Quantities/Attributes/Volume) [m³] | Environment_Engine |
| Thickness | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the thickness of an Environment Opening based on its construction. | - | Environment_Engine |
| Thickness | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the thickness of an Environment Opening based on its construction. | - | Environment_Engine |
| Tilt | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the tilt of an Environment Object. | - | Environment_Engine |
| ToLines | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Line](/api/oM/Dimensional/Geometry/Curve/Line)&gt; | Returns the external boundary from a generic Environment Object | - | Environment_Engine |
| ToLines | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Line](/api/oM/Dimensional/Geometry/Curve/Line)&gt; | Returns the external boundary from an Environment Opening as a collection of BHoM Geometry Lines | - | Environment_Engine |
| Top | [ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve) | Returns the top of a given environment object. | - | Environment_Engine |
| Width | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the width of an Environment Opening. | - | Environment_Engine |
| Width | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the width of a generic Environment Object. | - | Environment_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class Opening : BH.oM.Base.BHoMObject,
BH.oM.Base.IBHoMObject,
BH.oM.Base.IObject,
BH.oM.Environment.IEnvironmentObject,
BH.oM.Analytical.Elements.IOpening<BH.oM.Environment.Elements.Edge>,
BH.oM.Analytical.IAnalytical,
BH.oM.Dimensional.IElement2D,
BH.oM.Dimensional.IElement,
BH.oM.Dimensional.IElementM
```

Assembly: Environment_oM.dll

The C# class definition is available on github:

- [Opening.cs](https://github.com/BHoM/BHoM/blob/develop/Environment_oM/Elements\Opening.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Environment_oM/Elements/Opening.json"
}
```

The JSON Schema is available on github here:

- [Opening.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Environment_oM/Elements/Opening.json)
