---
title: Cassette
---

# Structure.SurfaceProperties.Cassette

Property for 2D analytical elements, made up of two slabs with parallel ribs running in one direction between them. Ribs and slabs can all be made up of different materials.

## Class structure

### Implemented interfaces and base types

???+ bhom "The Cassette in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/api_documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/api_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)
    -  Structure.SurfaceProperties.[ISurfaceProperty](/api_documentation/oM/Analytical/Structure/SurfaceProperties/ISurfaceProperty)
    -  Structure.[IProperty](/api_documentation/oM/Analytical/Structure/IProperty)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | A unique Name is required for some structural packages to create and identify the object. | - |
| TopThickness | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The thickness of the slab sitting on top of the ribs. | [Length](/api_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] |
| BottomThickness | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The thickness of the slab sitting beneath the ribs. | [Length](/api_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] |
| RibThickness | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Width of each rib. | [Length](/api_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] |
| RibHeight | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Height of the ribs, equal to the distance between the bottom of the top slab and top of the bottom slab. | [Length](/api_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] |
| RibSpacing | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Centre-centre distance between the ribs. Measured perpendicular to the rib direction. | [Length](/api_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] |
| Material | [IMaterialFragment](/api_documentation/oM/Analytical/Structure/MaterialFragments/IMaterialFragment) | Structural material of the top slab. If no material is provided for the ribs and/or the bottom slab then this material is used for those parts as well. | - |
| RibMaterial | [IMaterialFragment](/api_documentation/oM/Analytical/Structure/MaterialFragments/IMaterialFragment) | Structural material of the ribs. If nothing is provided, the Material will be used instead. | - |
| BottomMaterial | [IMaterialFragment](/api_documentation/oM/Analytical/Structure/MaterialFragments/IMaterialFragment) | Structural material of the bottom slab. If nothing is provided, the Material will be used instead. | - |
| Direction | [PanelDirection](/api_documentation/oM/Analytical/Structure/SurfaceProperties/PanelDirection) | Specifies if the ribs are running in local x or y direction. | - |
| PanelType | [PanelType](/api_documentation/oM/Analytical/Structure/SurfaceProperties/PanelType) | Defines what type of element this property will be used. Used by some analysis packages. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api_documentation/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Construction | [Construction](/api_documentation/oM/Physical/Physical/Constructions/Construction) | Creates a physical Construction from a structural ISurfaceProperty. Extracts the Structural MaterialFragment and creates a physical material with the same name. | - | Structure_Engine |
| Description | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Generates a default description for the SurfaceProperty. | - | Structure_Engine |
| DescriptionOrName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Gets the name from a IProperty. If null or empty, a default description name is provided instead. | - | Structure_Engine |
| HasModifiers | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a SurfaceProperty has any modifiers by first checking if any modifiers has been assigned, and if any of them are set to a value different than 1. | - | Structure_Engine |
| IConstruction | [Construction](/api_documentation/oM/Physical/Physical/Constructions/Construction) | Creates a physical Construction from a structural ISurfaceProperty. Extracts the Structural MaterialFragment and creates a physical material with the same name. | - | Structure_Engine |
| IDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Generates a default description for the IProperty, based on its properties. | - | Structure_Engine |
| IDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Generates a default description for the SurfaceProperty, based on type, dimensions and material. | - | Structure_Engine |
| IMassPerArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Calculates the mass per area for the property. | [MassPerUnitArea](/api_documentation/oM/Dimensional/Quantities/Attributes/MassPerUnitArea) [kg/m²] | Structure_Engine |
| IMaterialComposition | [MaterialComposition](/api_documentation/oM/Physical/Physical/Materials/MaterialComposition) | Returns a SurfaceProperty's MaterialComposition. | - | Structure_Engine |
| InvalidSurfaceProperty | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - | Lusas_Engine |
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a SurfaceProperty is null and outputs relevant error message. | - | Structure_Engine |
| ITotalThickness | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the total thickness of the surface property. | [Length](/api_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] | Structure_Engine |
| IVolumePerArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the volume per area of the property for the purpose of calculating solid volume. | [Length](/api_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] | Structure_Engine |
| MassPerArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the mass per area for a Cassette. | [MassPerUnitArea](/api_documentation/oM/Dimensional/Quantities/Attributes/MassPerUnitArea) [kg/m²] | Structure_Engine |
| MaterialComposition | [MaterialComposition](/api_documentation/oM/Physical/Physical/Materials/MaterialComposition) | Returns a SurfaceProperty's MaterialComposition. | - | Structure_Engine |
| Modifiers | [Double[]](https://learn.microsoft.com/en-us/dotnet/api/System.Double[]?view=netstandard-2.0) | Gets any modifiers from a property as an array of doubles. The modifiers are used to scale one or more of the property constants for analysis. Constants are multiplied with the modifiers, hence a modifier value of 1 means no change. <br>The values returned are in the following order: FXX, FXY, FYY, MXX, MXY, MYY, VXZ, VYZ, Mass, Weight. Method returns null if no modifiers are found. | - | Structure_Engine |
| TotalThickness | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the total thickness of the surface property. | [Length](/api_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] | Structure_Engine |
| VolumePerArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the volume per area of the property for the purpose of calculating solid volume. | [Length](/api_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] | Structure_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [Cassette.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/SurfaceProperties\Cassette.cs)

All history and changes of the class can be found by inspection the history.
