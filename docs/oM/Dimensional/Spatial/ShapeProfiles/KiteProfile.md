---
title: KiteProfile
---

# Spatial.ShapeProfiles.KiteProfile



## Class structure

### Implemented interfaces and base types

???+ bhom "The KiteProfile in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/api/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api/oM/Framework/Base/IObject)
    -  Spatial.ShapeProfiles.[IProfile](/api/oM/Dimensional/Spatial/ShapeProfiles/IProfile)
    -  Base.[IImmutable](/api/oM/Framework/Base/IImmutable)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Shape | [ShapeType](/api/oM/Dimensional/Spatial/ShapeProfiles/ShapeType) | - | - |
| Width1 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| Angle1 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| Thickness | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| Edges | [ReadOnlyCollection](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1?view=netstandard-2.0)&lt;[ICurve](/api/oM/Dimensional/Geometry/ICurve)&gt; | - | - |


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
| Bounds | [BoundingBox](/api/oM/Dimensional/Geometry/BoundingBox) | Queries the BoundingBox of a Profile. Acts on the profile edges through the Geometry_Engine. | - | Spatial_Engine |
| Description | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Generates a default description for the profile as 'Kite Angle x Width x Thickness'. | - | Structure_Engine |
| DescriptionOrName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Gets the name from a profile. If null or empty, a default description name is provided instead. | - | Structure_Engine |
| Geometry | [CompositeGeometry](/api/oM/Dimensional/Geometry/CompositeGeometry) | Queries edge curves from an IProfile. | - | Spatial_Engine |
| ICircularEquivalentDiameter | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the Circular Equivalent Diameter for elements that are non-circular, equivalent in length, fluid resistance and airflow. | - | MEP_Engine |
| IDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Generates a default description for the Profile, based on dimensions. | - | Structure_Engine |
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if an Profile is null and outputs relevant error message. | - | Spatial_Engine |
| IThickness | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the thickness of a ShapeProfile. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] | Spatial_Engine |
| ITorsionalConstant | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Calculates the torsional constant for the profile. Note that this is not the polar moment of inertia. | [TorsionConstant](/api/oM/Dimensional/Quantities/Attributes/TorsionConstant) [m⁴] | Structure_Engine |
| IWarpingConstant | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the warping constant for the profile. | [WarpingConstant](/api/oM/Dimensional/Quantities/Attributes/WarpingConstant) [m⁶] | Structure_Engine |
| Thickness | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the thickness of a KiteProfile. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] | Spatial_Engine |
| VoidArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the void area enclosed by an IProfile. This assumes that the outermost curve(s) are solid. Curves inside a solid region are assumed to be openings, and curves within openings are assumed to be solid, etc. Also, for TaperedProfiles, the average void area is returned. | [Area](/api/oM/Dimensional/Quantities/Attributes/Area) [m²] | Spatial_Engine |
| WarpingConstant | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the warping constant for the profile. This will always return 0 for closed sections. | [WarpingConstant](/api/oM/Dimensional/Quantities/Attributes/WarpingConstant) [m⁶] | Structure_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [KiteProfile.cs](https://github.com/BHoM/BHoM/blob/develop/Spatial_oM/ShapeProfiles\KiteProfile.cs)

All history and changes of the class can be found by inspection the history.
