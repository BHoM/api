---
title: Waffle
---

# Structure.SurfaceProperties.Waffle

Property for 2D analytical elements, made up of a slab on top of parallel ribs running in two directions, all sharing the same material.

## Class structure

### Implemented interfaces and base types

???+ bhom "The Waffle in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/om_documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/om_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)
    -  Structure.SurfaceProperties.[ISurfaceProperty](/om_documentation/oM/Analytical/Structure/SurfaceProperties/ISurfaceProperty)
    -  Structure.[IProperty](/om_documentation/oM/Analytical/Structure/IProperty)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | A unique Name is required for some structural packages to create and identify the object. | - |
| Thickness | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The thickness of the slab sitting on top of the ribs. | [Length](/om_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] |
| Material | [IMaterialFragment](/om_documentation/oM/Analytical/Structure/MaterialFragments/IMaterialFragment) | Homogenous structural material throughout the full thickness of the element. | - |
| TotalDepthX | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Total depth measured from the bottom of the ribs in local x-direction to the top of the slab. | [Length](/om_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] |
| TotalDepthY | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Total depth meassured from the bottom of the ribs in local y-direction to the top of the slab. | [Length](/om_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] |
| StemWidthX | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Width of each rib in local x-direction. | [Length](/om_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] |
| StemWidthY | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Width of each rib in local y-direction. | [Length](/om_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] |
| SpacingX | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Centre-Centre distance between the ribs running in local x-direction. | [Length](/om_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] |
| SpacingY | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Centre-Centre distance between the ribs running in local y-direction. | [Length](/om_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] |
| PanelType | [PanelType](/om_documentation/oM/Analytical/Structure/SurfaceProperties/PanelType) | Defines what type of element this property will be used. Used by some analysis packages. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/om_documentation/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Construction | [Construction](/om_documentation/oM/Physical/Physical/Constructions/Construction) | Creates a physical Construction from a structural ISurfaceProperty. Extracts the Structural MaterialFragment and creates a physical material with the same name. | - | Structure_Engine |
| Description | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Generates a default description for the SurfaceProperty as 'Ribbed DepthX DepthY SpacingX SpacingY StemWidthX StemWidthY - MaterialName'. | - | Structure_Engine |
| DescriptionOrName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Gets the name from a IProperty. If null or empty, a default description name is provided instead. | - | Structure_Engine |
| HasModifiers | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a SurfaceProperty has any modifiers by first checking if any modifiers has been assigned, and if any of them are set to a value different than 1. | - | Structure_Engine |
| IConstruction | [Construction](/om_documentation/oM/Physical/Physical/Constructions/Construction) | Creates a physical Construction from a structural ISurfaceProperty. Extracts the Structural MaterialFragment and creates a physical material with the same name. | - | Structure_Engine |
| IDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Generates a default description for the SurfaceProperty, based on type, dimensions and material. | - | Structure_Engine |
| IDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Generates a default description for the IProperty, based on its properties. | - | Structure_Engine |
| IMassPerArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Calculates the mass per area for the property. | [MassPerUnitArea](/om_documentation/oM/Dimensional/Quantities/Attributes/MassPerUnitArea) [kg/m²] | Structure_Engine |
| IMaterialComposition | [MaterialComposition](/om_documentation/oM/Physical/Physical/Materials/MaterialComposition) | Returns a SurfaceProperty's MaterialComposition. | - | Structure_Engine |
| InvalidSurfaceProperty | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - | Lusas_Engine |
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a SurfaceProperty is null and outputs relevant error message. | - | Structure_Engine |
| ITotalThickness | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the total thickness of the surface property. | [Length](/om_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] | Structure_Engine |
| IVolumePerArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the volume per area of the property for the purpose of calculating solid volume. | [Length](/om_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] | Structure_Engine |
| MassPerArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Calculates the mass per area for the property as its average thickness mutiplied by the density. | [MassPerUnitArea](/om_documentation/oM/Dimensional/Quantities/Attributes/MassPerUnitArea) [kg/m²] | Structure_Engine |
| Modifiers | [Double[]](https://learn.microsoft.com/en-us/dotnet/api/System.Double[]?view=netstandard-2.0) | Gets any modifiers from a property as an array of doubles. The modifiers are used to scale one or more of the property constants for analysis. Constants are multiplied with the modifiers, hence a modifier value of 1 means no change. <br>The values returned are in the following order: FXX, FXY, FYY, MXX, MXY, MYY, VXZ, VYZ, Mass, Weight. Method returns null if no modifiers are found. | - | Structure_Engine |
| TotalThickness | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the total thickness of the surface property. | [Length](/om_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] | Structure_Engine |
| VolumePerArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the volume per area of the property for the purpose of calculating solid volume. | [Length](/om_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] | Structure_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [Waffle.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/SurfaceProperties\Waffle.cs)

All history and changes of the class can be found by inspection the history.
