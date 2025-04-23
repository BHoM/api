---
title: Construction
---

# Physical.Constructions.Construction



## Class structure

### Implemented interfaces and base types

???+ bhom "The Construction in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/api/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api/oM/Framework/Base/IObject)
    -  Physical.Constructions.[IConstruction](/api/oM/Physical/Physical/Constructions/IConstruction)
    -  Physical.[IPhysical](/api/oM/Physical/Physical/IPhysical)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Layers | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Layer](/api/oM/Physical/Physical/Constructions/Layer)&gt; | - | - |


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
| Absorptance | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the absorptance of a construction | - | Environment_Engine |
| ExternalPolyline | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Polyline](/api/oM/Dimensional/Geometry/Polyline)&gt; | Returns the External Polyline representation of a physical object (e.g. wall or window). | - | Physical_Engine |
| IMaterialComposition | [MaterialComposition](/api/oM/Physical/Physical/Materials/MaterialComposition) | Gets all the Materials a ExplicitBulk is composed of and in which ratios. | [Ratio](/api/oM/Dimensional/Quantities/Attributes/Ratio) [-] | Physical_Engine |
| InternalPolyline | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Polyline](/api/oM/Dimensional/Geometry/Polyline)&gt; | Returns the Internal Polyline representation of a physical object (e.g. wall or window). | - | Physical_Engine |
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a IConstruction is null and outputs relevant error message. | - | Physical_Engine |
| IThickness | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the thickness of a generic construction | - | Physical_Engine |
| IVolumePerArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the average thickness of the property for the purpose of calculating solid volume. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] | Physical_Engine |
| Polyline | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Polyline](/api/oM/Dimensional/Geometry/Polyline)&gt; | Returns a Polyline representation of a physical object (e.g. wall or window). | - | Physical_Engine |
| Roughness | [Roughness](/api/oM/Analytical/Environment/MaterialFragments/Roughness) | Returns the average roughness of a construction | - | Environment_Engine |
| Thickness | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the thickness of a construction | - | Physical_Engine |
| UniqueConstructionName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Returns a unique name for a given IConstruction object based on the material names, and the construction name if the flag is set | - | Environment_Engine |
| UValue | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the UValue of a construction | - | Environment_Engine |
| VolumePerArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the average thickness of the property for the purpose of calculating solid volume. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] | Physical_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [Construction.cs](https://github.com/BHoM/BHoM/blob/develop/Physical_oM/Constructions\Construction.cs)

All history and changes of the class can be found by inspection the history.
