---
title: Material
---

# Physical.Materials.Material

Physical material to be used for Takeoffs and asigned to Physical elements. Material is capable of storing discipline specific data in Properties.

## Class structure

### Implemented interfaces and base types

???+ bhom "The Material in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/om_documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/om_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)
    -  Physical.[IPhysical](/om_documentation/oM/Physical/Physical/IPhysical)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Density | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The density to be used for material takeoffs. Can differ from discipline specific densities assigned on Properties as required for analysis. | [Density](/om_documentation/oM/Dimensional/Quantities/Attributes/Density) [kg/m³] |
| Properties | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IMaterialProperties](/om_documentation/oM/Physical/Physical/Materials/IMaterialProperties)&gt; | Discipline data related to the material. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/om_documentation/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Absorptance | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the absorptance of a material calculated as 1 minus the maximum emissivity (external and internal) | - | Environment_Engine |
| AllDensitiesEqual | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks the density on all IDensityProviders on the material has the same density as the density on the Material within given tolerance. Returns false if the density is unset (NaN) on the material or any of its properties. | - | Matter_Engine |
| Density | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the density of a Material. | [Density](/om_documentation/oM/Dimensional/Quantities/Attributes/Density) [kg/m³] | Matter_Engine |
| ExternalPolyline | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Polyline](/om_documentation/oM/Dimensional/Geometry/Polyline)&gt; | Returns the External Polyline representation of a physical object (e.g. wall or window). | - | Physical_Engine |
| InternalPolyline | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Polyline](/om_documentation/oM/Dimensional/Geometry/Polyline)&gt; | Returns the Internal Polyline representation of a physical object (e.g. wall or window). | - | Physical_Engine |
| IsTransparent | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Determines whether a material is transparent or not | - | Environment_Engine |
| IsValidStructural | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a physical Material contains exactly one structural material fragment, i.e. checks if the Material contains structural data. | - | Structure_Engine |
| Polyline | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Polyline](/om_documentation/oM/Dimensional/Geometry/Polyline)&gt; | Returns a Polyline representation of a physical object (e.g. wall or window). | - | Physical_Engine |
| Roughness | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the numerical roughness of a material | - | Environment_Engine |
| StructuralMaterialFragment | [IMaterialFragment](/om_documentation/oM/Analytical/Structure/MaterialFragments/IMaterialFragment) | Checks if the physical Material contains a single structural MaterialFragment, and if it does returns this fragment, containing all relevant structural material data. Returns null if not exactly one structural MaterialFragment is found. | - | Structure_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [Material.cs](https://github.com/BHoM/BHoM/blob/develop/Physical_oM/Materials\Material.cs)

All history and changes of the class can be found by inspection the history.
