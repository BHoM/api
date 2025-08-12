---
title: IProfile
---

# <small>BH.oM.Spatial.ShapeProfiles.</small>**IProfile**

Base interface for all shape profiles.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IProfile is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Spatial.ShapeProfiles.[AngleProfile](/api/oM/Dimensional/Spatial/ShapeProfiles/AngleProfile)
    - BH.oM.Spatial.ShapeProfiles.[BoxProfile](/api/oM/Dimensional/Spatial/ShapeProfiles/BoxProfile)
    - BH.oM.Spatial.ShapeProfiles.[ChannelProfile](/api/oM/Dimensional/Spatial/ShapeProfiles/ChannelProfile)
    - BH.oM.Spatial.ShapeProfiles.[CircleProfile](/api/oM/Dimensional/Spatial/ShapeProfiles/CircleProfile)
    - BH.oM.Spatial.ShapeProfiles.[FabricatedBoxProfile](/api/oM/Dimensional/Spatial/ShapeProfiles/FabricatedBoxProfile)
    - BH.oM.Spatial.ShapeProfiles.[FabricatedISectionProfile](/api/oM/Dimensional/Spatial/ShapeProfiles/FabricatedISectionProfile)
    - BH.oM.Spatial.ShapeProfiles.[FreeFormProfile](/api/oM/Dimensional/Spatial/ShapeProfiles/FreeFormProfile)
    - BH.oM.Spatial.ShapeProfiles.[GeneralisedFabricatedBoxProfile](/api/oM/Dimensional/Spatial/ShapeProfiles/GeneralisedFabricatedBoxProfile)
    - BH.oM.Spatial.ShapeProfiles.[GeneralisedTSectionProfile](/api/oM/Dimensional/Spatial/ShapeProfiles/GeneralisedTSectionProfile)
    - BH.oM.Spatial.ShapeProfiles.[ISectionProfile](/api/oM/Dimensional/Spatial/ShapeProfiles/ISectionProfile)
    - BH.oM.Spatial.ShapeProfiles.[KiteProfile](/api/oM/Dimensional/Spatial/ShapeProfiles/KiteProfile)
    - BH.oM.Spatial.ShapeProfiles.[RectangleProfile](/api/oM/Dimensional/Spatial/ShapeProfiles/RectangleProfile)
    - BH.oM.Spatial.ShapeProfiles.[TaperedProfile](/api/oM/Dimensional/Spatial/ShapeProfiles/TaperedProfile)
    - BH.oM.Spatial.ShapeProfiles.[TaperFlangeChannelProfile](/api/oM/Dimensional/Spatial/ShapeProfiles/TaperFlangeChannelProfile)
    - BH.oM.Spatial.ShapeProfiles.[TaperFlangeISectionProfile](/api/oM/Dimensional/Spatial/ShapeProfiles/TaperFlangeISectionProfile)
    - BH.oM.Spatial.ShapeProfiles.[TSectionProfile](/api/oM/Dimensional/Spatial/ShapeProfiles/TSectionProfile)
    - BH.oM.Spatial.ShapeProfiles.[TubeProfile](/api/oM/Dimensional/Spatial/ShapeProfiles/TubeProfile)
    - BH.oM.Spatial.ShapeProfiles.[VoidedISectionProfile](/api/oM/Dimensional/Spatial/ShapeProfiles/VoidedISectionProfile)
    - BH.oM.Spatial.ShapeProfiles.[ZSectionProfile](/api/oM/Dimensional/Spatial/ShapeProfiles/ZSectionProfile)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Shape | [ShapeType](/api/oM/Dimensional/Spatial/ShapeProfiles/Enums/ShapeType) | - | - |
| Edges | [ReadOnlyCollection](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1?view=netstandard-2.0)&lt;[ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve)&gt; | Edge curves that matches the dimensions in the global XY-plane. | - |


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
| VoidArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the void area enclosed by an IProfile. This assumes that the outermost curve(s) are solid. Curves inside a solid region are assumed to be openings, and curves within openings are assumed to be solid, etc. Also, for TaperedProfiles, the average void area is returned. | [Area](/api/oM/Dimensional/Quantities/Attributes/Area) [m²] | Spatial_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IProfile : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: Spatial_oM.dll

The C# interface definition is available on github:

- [IProfile.cs](https://github.com/BHoM/BHoM/blob/develop/Spatial_oM/ShapeProfiles\IProfile.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Spatial_oM/ShapeProfiles/IProfile.json"
}
```

The JSON Schema is available on github here:

- [IProfile.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Spatial_oM/ShapeProfiles/IProfile.json)
