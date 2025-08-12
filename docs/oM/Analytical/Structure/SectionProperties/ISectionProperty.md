---
title: ISectionProperty
---

# <small>BH.oM.Structure.SectionProperties.</small>**ISectionProperty**

Base interface for all bar section properties. Contains the material and all section constants.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The ISectionProperty is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Structure.[IProperty](/api/oM/Analytical/Structure/IProperty)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - BH.oM.Structure.SectionProperties.[IGeometricalSection](/api/oM/Analytical/Structure/SectionProperties/IGeometricalSection)
    - BH.oM.Structure.SectionProperties.[ISteelSection](/api/oM/Analytical/Structure/SectionProperties/ISteelSection)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Structure.SectionProperties.[AluminiumSection](/api/oM/Analytical/Structure/SectionProperties/AluminiumSection)
    - BH.oM.Structure.SectionProperties.[CableSection](/api/oM/Analytical/Structure/SectionProperties/CableSection)
    - BH.oM.Structure.SectionProperties.[CellularSection](/api/oM/Analytical/Structure/SectionProperties/CellularSection)
    - BH.oM.Structure.SectionProperties.[CompositeSection](/api/oM/Analytical/Structure/SectionProperties/CompositeSection)
    - BH.oM.Structure.SectionProperties.[ConcreteSection](/api/oM/Analytical/Structure/SectionProperties/ConcreteSection)
    - BH.oM.Structure.SectionProperties.[ExplicitSection](/api/oM/Analytical/Structure/SectionProperties/ExplicitSection)
    - BH.oM.Structure.SectionProperties.[GenericSection](/api/oM/Analytical/Structure/SectionProperties/GenericSection)
    - BH.oM.Structure.SectionProperties.[SteelSection](/api/oM/Analytical/Structure/SectionProperties/SteelSection)
    - BH.oM.Structure.SectionProperties.[TimberSection](/api/oM/Analytical/Structure/SectionProperties/TimberSection)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Material | [IMaterialFragment](/api/oM/Analytical/Structure/MaterialFragments/IMaterialFragment) | Material of the section. | - |
| Area | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gross Area of the cross section. | [Area](/api/oM/Dimensional/Quantities/Attributes/Area) [m²] |
| Rgy | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Radius of Gyration about the local Y-Axis. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| Rgz | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Radius of Gyration about the local Z-Axis. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| J | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Torsion Constant. | [TorsionConstant](/api/oM/Dimensional/Quantities/Attributes/TorsionConstant) [m⁴] |
| Iy | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Moment of Inertia about the local Y-Axis. | [SecondMomentOfArea](/api/oM/Dimensional/Quantities/Attributes/SecondMomentOfArea) [m⁴] |
| Iz | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Moment of Inertia about the local Z-Axis. | [SecondMomentOfArea](/api/oM/Dimensional/Quantities/Attributes/SecondMomentOfArea) [m⁴] |
| Iw | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Warping Constant. | [WarpingConstant](/api/oM/Dimensional/Quantities/Attributes/WarpingConstant) [m⁶] |
| Wely | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Elastic Modulus of the section about the local Y-Axis. | [SectionModulus](/api/oM/Dimensional/Quantities/Attributes/SectionModulus) [m³] |
| Welz | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Elastic Modulus of the section about the local Z-Axis. | [SectionModulus](/api/oM/Dimensional/Quantities/Attributes/SectionModulus) [m³] |
| Wply | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Plastic Modulus of the section about the local Y-Axis. | [SectionModulus](/api/oM/Dimensional/Quantities/Attributes/SectionModulus) [m³] |
| Wplz | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Plastic Modulus of the section about the local Z-Axis. | [SectionModulus](/api/oM/Dimensional/Quantities/Attributes/SectionModulus) [m³] |
| CentreZ | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Geometric centre of the section in the local Z direction. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| CentreY | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Geometric centre of the section in the local Y direction. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| Vz | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Z distance from the centroid of the section to top edge of the section. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| Vpz | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Z distance from the centroid of the section to bottom edge of the section. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| Vy | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Y distance from the centroid of the section to right edge of the section. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| Vpy | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Y distance from the centroid of the section to Left edge of the section. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| Asy | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Shear Area in the local Y direction. | [Area](/api/oM/Dimensional/Quantities/Attributes/Area) [m²] |
| Asz | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Shear Area in the local Z direction. | [Area](/api/oM/Dimensional/Quantities/Attributes/Area) [m²] |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| DescriptionOrName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Gets the name from a IProperty. If null or empty, a default description name is provided instead. | - | Structure_Engine |
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
public interface ISectionProperty : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.Structure.IProperty
```

Assembly: Structure_oM.dll

The C# interface definition is available on github:

- [ISectionProperty.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/SectionProperties\ISectionProperty.cs)

All history and changes of the class can be found by inspection the history.
