---
title: CellularSection
---

# <small>BH.oM.Structure.SectionProperties.</small>**CellularSection**

Steel section to be used on Bars. Defined by a SectionProfile.

## Class structure

### Implemented interfaces and base types

???+ bhom "The CellularSection is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Structure.SectionProperties.[ISteelSection](/api/oM/Analytical/Structure/SectionProperties/ISteelSection)
    -  BH.oM.Structure.SectionProperties.[IGeometricalSection](/api/oM/Analytical/Structure/SectionProperties/IGeometricalSection)
    -  BH.oM.Structure.SectionProperties.[ISectionProperty](/api/oM/Analytical/Structure/SectionProperties/ISectionProperty)
    -  BH.oM.Structure.[IProperty](/api/oM/Analytical/Structure/IProperty)
    -  BH.oM.Base.[IImmutable](/api/oM/Framework/Base/Interface/IImmutable)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | A unique name is required for some structural packages to create and identify the object. | - |
| Fabrication | [SteelFabrication](/api/oM/Analytical/Structure/SectionProperties/Enums/SteelFabrication) | The fabrication method used for the section. | - |
| PlateRestraint | [SteelPlateRestraint](/api/oM/Analytical/Structure/SectionProperties/Enums/SteelPlateRestraint) | Defines whether any of the plates of the section have any external restraint, from for example a connecting slab. | - |
| Material | [IMaterialFragment](/api/oM/Analytical/Structure/MaterialFragments/IMaterialFragment) | Homogeneous material used throughout the full section. | - |
| SectionProfile | [IProfile](/api/oM/Dimensional/Spatial/ShapeProfiles/IProfile) | Profile of the section through the point of the largest opening, containing dimensions and section geometry. | - |
| SolidProfile | [ISectionProfile](/api/oM/Dimensional/Spatial/ShapeProfiles/ISectionProfile) | The profile at a cut through the solid section. | - |
| Opening | [ICellularOpening](/api/oM/Dimensional/Spatial/ShapeProfiles/CellularOpenings/ICellularOpening) | Dimensions of the opening. | - |
| BaseProfile | [ISectionProfile](/api/oM/Dimensional/Spatial/ShapeProfiles/ISectionProfile) | The IShape from which the cellular beam was cut. | - |
| Area | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Area of the cross section through the section with the largest opening. | [Area](/api/oM/Dimensional/Quantities/Attributes/Area) [m²] |
| Rgy | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Radius of gyration about the local Y-Axis as the arithmetic mean between the solid and open parts of the section. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| Rgz | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Radius of gyration about the local Z-Axis through the section with the largest opening. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| J | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Torsion Constant through the section with the largest opening. | [TorsionConstant](/api/oM/Dimensional/Quantities/Attributes/TorsionConstant) [m⁴] |
| Iy | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Moment of Inertia about the local Y-Axis as the arithmetic mean between the solid and open parts of the section. | [SecondMomentOfArea](/api/oM/Dimensional/Quantities/Attributes/SecondMomentOfArea) [m⁴] |
| Iz | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Moment of Inertia about the local Z-Axis through the section with the largest opening. | [SecondMomentOfArea](/api/oM/Dimensional/Quantities/Attributes/SecondMomentOfArea) [m⁴] |
| Iw | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Warping Constant through the section with the largest opening. | [WarpingConstant](/api/oM/Dimensional/Quantities/Attributes/WarpingConstant) [m⁶] |
| Wely | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Elastic Modulus of the section about the local Y-Axis through the section with the largest opening. | [SectionModulus](/api/oM/Dimensional/Quantities/Attributes/SectionModulus) [m³] |
| Welz | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Elastic Modulus of the section about the local Z-Axis through the section with the largest opening. | [SectionModulus](/api/oM/Dimensional/Quantities/Attributes/SectionModulus) [m³] |
| Wply | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Plastic Modulus of the section about the local Y-Axis through the section with the largest opening. | [SectionModulus](/api/oM/Dimensional/Quantities/Attributes/SectionModulus) [m³] |
| Wplz | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Plastic Modulus of the section about the local Z-Axis through the section with the largest opening. | [SectionModulus](/api/oM/Dimensional/Quantities/Attributes/SectionModulus) [m³] |
| CentreZ | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Geometric centre of the section in the local Z direction. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| CentreY | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Geometric centre of the section in the local Y direction. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| Vz | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Z distance from the centroid of the section to top edge of the section. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| Vpz | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Z distance from the centroid of the section to bottom edge of the section. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| Vy | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Y distance from the centroid of the section to right edge of the section. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| Vpy | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Y distance from the centroid of the section to Left edge of the section. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| Asy | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Shear Area in the local Y direction through the section with the largest opening. Only acounts for contributions from the flanges. | [Area](/api/oM/Dimensional/Quantities/Attributes/Area) [m²] |
| Asz | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Shear Area in the local Z direction through the section with the largest opening. Only acounts for contributions from the uncut parts of the web. | [Area](/api/oM/Dimensional/Quantities/Attributes/Area) [m²] |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


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
| InvalidSectionProfile | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - | Lusas_Engine |
| InvalidSectionProperty | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - | Lusas_Engine |
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a SectionProperty is null and outputs relevant error message. | - | Structure_Engine |
| IVolumePerLength | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Calculates the volume per length for the section, generally as its area mulitplied by the density. General dispatch method that calls the correct method based on type. | [MassPerUnitLength](/api/oM/Dimensional/Quantities/Attributes/MassPerUnitLength) [kg/m] | Structure_Engine |
| Modifiers | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0)[] | Gets any modifiers from a section as an array of doubles. The modifiers are used to scale one or more of the section constants for analysis.  Constants are multiplied with the modifiers, hence a modifier value of 1 means no change. <br>The values returned are in the following order: Area, Iy, Iz, J, Asy, Asz. Method returns null if no modifiers are found. | - | Structure_Engine |
| VolumePerLength | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Calculates the volume per length for the section the volume per metre of the concrete section + the volume per metre of the steel section. | [MassPerUnitLength](/api/oM/Dimensional/Quantities/Attributes/MassPerUnitLength) [kg/m] | Structure_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class CellularSection : BH.oM.Base.BHoMObject,
BH.oM.Base.IBHoMObject,
BH.oM.Base.IObject,
BH.oM.Structure.SectionProperties.ISteelSection,
BH.oM.Structure.SectionProperties.IGeometricalSection,
BH.oM.Structure.SectionProperties.ISectionProperty,
BH.oM.Structure.IProperty,
BH.oM.Base.IImmutable
```

Assembly: Structure_oM.dll

The C# class definition is available on github:

- [CellularSection.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/SectionProperties\CellularSection.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Structure_oM/SectionProperties/CellularSection.json"
}
```

The JSON Schema is available on github here:

- [CellularSection.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Structure_oM/SectionProperties/CellularSection.json)
