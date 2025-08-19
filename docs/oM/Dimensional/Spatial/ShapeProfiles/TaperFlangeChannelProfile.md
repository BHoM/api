---
title: TaperFlangeChannelProfile
---

# <small>BH.oM.Spatial.ShapeProfiles.</small>**TaperFlangeChannelProfile**

C-shaped profile with tapered flanges of the same length and thickness.

## Class structure

### Implemented interfaces and base types

???+ bhom "The TaperFlangeChannelProfile is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Spatial.ShapeProfiles.[IProfile](/api/oM/Dimensional/Spatial/ShapeProfiles/IProfile)
    -  BH.oM.Base.[IImmutable](/api/oM/Framework/Base/Interface/IImmutable)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Shape | [ShapeType](/api/oM/Dimensional/Spatial/ShapeProfiles/Enums/ShapeType) | - | - |
| Height | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Full depth between the extreme fibres of the flanges. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| FlangeWidth | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Full width between the extreme fibres of the web to the toe of the flange. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| WebThickness | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| FlangeThickness | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Mean thickness of the flange, taken at 1/2 the flange width | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| FlangeSlope | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Slope of the flange inner faces, generally from 0 to 1/6. | [Ratio](/api/oM/Dimensional/Quantities/Attributes/Ratio) [-] |
| RootRadius | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Fillet radius between inner face of the flanges and the inner face of web. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| ToeRadius | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Fillet radius at the end of the flanges. Value must be smaller or equal to the thickness of the flange at the tip. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| MirrorAboutLocalZ | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true, the section is mirrored about its local z-axis, resulting in a backwards facing C-shape. | - |
| Edges | [ReadOnlyCollection](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1?view=netstandard-2.0)&lt;[ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve)&gt; | Edge curves that match the dimensions in the global XY-plane. | - |


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
| Area | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the area of an IProfile. This assumes that the outermost curve(s) are solid. Curves inside a solid region are assumed to be openings, and curves within openings are assumed to be solid, etc. Also, for TaperedProfiles, the average area is returned. | [Area](/api/oM/Dimensional/Quantities/Attributes/Area) [m²] | Spatial_Engine |
| Bounds | [BoundingBox](/api/oM/Dimensional/Geometry/Misc/BoundingBox) | Queries the BoundingBox of a Profile. Acts on the profile edges through the Geometry_Engine. | - | Spatial_Engine |
| DescriptionOrName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Gets the name from a profile. If null or empty, a default description name is provided instead. | - | Structure_Engine |
| Geometry | [CompositeGeometry](/api/oM/Dimensional/Geometry/Misc/CompositeGeometry) | Queries edge curves from an IProfile. | - | Spatial_Engine |
| ICircularEquivalentDiameter | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the Circular Equivalent Diameter for elements that are non-circular, equivalent in length, fluid resistance and airflow. | - | MEP_Engine |
| IDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Generates a default description for the Profile, based on dimensions. | - | Structure_Engine |
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if an Profile is null and outputs relevant error message. | - | Spatial_Engine |
| ISymmetry | [Symmetry](/api/oM/Dimensional/Spatial/ShapeProfiles/Enums/Symmetry) | Determines the symmetry of the given IProfile about the X-Axis and Y-Axis. | - | Spatial_Engine |
| IThickness | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the thickness of a ShapeProfile. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] | Spatial_Engine |
| ITorsionalConstant | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Calculates the torsional constant for the profile. Note that this is not the polar moment of inertia. | [TorsionConstant](/api/oM/Dimensional/Quantities/Attributes/TorsionConstant) [m⁴] | Structure_Engine |
| IWarpingConstant | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the warping constant for the profile. | [WarpingConstant](/api/oM/Dimensional/Quantities/Attributes/WarpingConstant) [m⁶] | Structure_Engine |
| TorsionalConstant | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Calculates the torsional constant for the profile. Note that this is not the polar moment of inertia.<br>Formulae taken from Johnston &amp; El Darwish, 1964. | [TorsionConstant](/api/oM/Dimensional/Quantities/Attributes/TorsionConstant) [m⁴] | Structure_Engine |
| VoidArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the void area enclosed by an IProfile. This assumes that the outermost curve(s) are solid. Curves inside a solid region are assumed to be openings, and curves within openings are assumed to be solid, etc. Also, for TaperedProfiles, the average void area is returned. | [Area](/api/oM/Dimensional/Quantities/Attributes/Area) [m²] | Spatial_Engine |
| WarpingConstant | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the warping constant for the profile. | [WarpingConstant](/api/oM/Dimensional/Quantities/Attributes/WarpingConstant) [m⁶] | Structure_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class TaperFlangeChannelProfile : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.Spatial.ShapeProfiles.IProfile, BH.oM.Base.IImmutable
```

Assembly: Spatial_oM.dll

The C# class definition is available on github:

- [TaperFlangeChannelProfile.cs](https://github.com/BHoM/BHoM/blob/develop/Spatial_oM/ShapeProfiles\TaperFlangeChannelProfile.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Spatial_oM/ShapeProfiles/TaperFlangeChannelProfile.json"
}
```

The JSON Schema is available on github here:

- [TaperFlangeChannelProfile.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Spatial_oM/ShapeProfiles/TaperFlangeChannelProfile.json)
