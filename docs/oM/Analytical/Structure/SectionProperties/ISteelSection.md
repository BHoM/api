---
title: ISteelSection
---

# <small>BH.oM.Structure.SectionProperties.</small>**ISteelSection**

Base interface for Steel section types.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The ISteelSection is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Structure.SectionProperties.[IGeometricalSection](/api/oM/Analytical/Structure/SectionProperties/IGeometricalSection)
    -  BH.oM.Structure.SectionProperties.[ISectionProperty](/api/oM/Analytical/Structure/SectionProperties/ISectionProperty)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Structure.[IProperty](/api/oM/Analytical/Structure/IProperty)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Structure.SectionProperties.[CellularSection](/api/oM/Analytical/Structure/SectionProperties/CellularSection)
    - BH.oM.Structure.SectionProperties.[SteelSection](/api/oM/Analytical/Structure/SectionProperties/SteelSection)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Fabrication | [SteelFabrication](/api/oM/Analytical/Structure/SectionProperties/Enums/SteelFabrication) | The fabrication method used for the section. | - |
| PlateRestraint | [SteelPlateRestraint](/api/oM/Analytical/Structure/SectionProperties/Enums/SteelPlateRestraint) | Defines whether any of the plates of the section have any external restraint, from for example a connecting slab. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| DescriptionOrName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Gets the name from a IProperty. If null or empty, a default description name is provided instead. | - | Structure_Engine |
| Geometry | [IGeometry](/api/oM/Dimensional/Geometry/Interface/IGeometry) | Gets the geometry of a GeometricalSection as its profile outlines the global XY plane. Method required for automatic display in UI packages. | - | Structure_Engine |
| HasModifiers | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a SectionProperty has any modifiers by first checking if any modifiers has been assigned, and if any of them are set to a value different than 1. | - | Structure_Engine |
| IDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Generates a default description for the SectionProperty, based on type, profile and material. | - | Structure_Engine |
| IDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Generates a default description for the IProperty, based on its properties. | - | Structure_Engine |
| IGeometry | [IGeometry](/api/oM/Dimensional/Geometry/Interface/IGeometry) | Gets the geometry of a SectionProperty, generally as its profile outlines the global XY plane. Method required for automatic display in UI packages. | - | Structure_Engine |
| IMassPerMetre | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Calculates the mass per length for the section, generally as its area mulitplied by the density. General dispatch method that calls the correct method based on type. | [MassPerUnitLength](/api/oM/Dimensional/Quantities/Attributes/MassPerUnitLength) [kg/m] | Structure_Engine |
| IMaterialComposition | [MaterialComposition](/api/oM/Physical/Physical/Materials/MaterialComposition) | Returns a SectionProperty's MaterialComposition. | - | Structure_Engine |
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a SectionProperty is null and outputs relevant error message. | - | Structure_Engine |
| IVolumePerLength | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Calculates the volume per length for the section, generally as its area mulitplied by the density. General dispatch method that calls the correct method based on type. | [MassPerUnitLength](/api/oM/Dimensional/Quantities/Attributes/MassPerUnitLength) [kg/m] | Structure_Engine |
| Modifiers | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0)[] | Gets any modifiers from a section as an array of doubles. The modifiers are used to scale one or more of the section constants for analysis.  Constants are multiplied with the modifiers, hence a modifier value of 1 means no change. <br>The values returned are in the following order: Area, Iy, Iz, J, Asy, Asz. Method returns null if no modifiers are found. | - | Structure_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface ISteelSection : BH.oM.Structure.SectionProperties.IGeometricalSection,
BH.oM.Structure.SectionProperties.ISectionProperty,
BH.oM.Base.IBHoMObject,
BH.oM.Base.IObject,
BH.oM.Structure.IProperty
```

Assembly: Structure_oM.dll

The C# interface definition is available on github:

- [ISteelSection.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/SectionProperties\ISteelSection.cs)

All history and changes of the class can be found by inspection the history.
