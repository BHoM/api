---
title: CompositeSteelInfillBeams
---

# <small>BH.oM.Structure.FloorSystem.</small>**CompositeSteelInfillBeams**

Floor configuration of steel primary beams (girders) and steel secondary (infill) beams acting compositely with a concrete slab through shear studs.

## Class structure

### Implemented interfaces and base types

???+ bhom "The CompositeSteelInfillBeams is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Structure.FloorSystem.[IFloorConfiguration](/api/oM/Analytical/Structure/FloorSystem/IFloorConfiguration)
    -  BH.oM.Structure.FloorSystem.[ISteelFrameConfiguration](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/ISteelFrameConfiguration)
    -  BH.oM.Structure.FloorSystem.[ISecondaryBeamConfiguration](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/ISecondaryBeamConfiguration)&lt;BH.oM.Structure.SectionProperties.[ISteelSection](/api/oM/Analytical/Structure/SectionProperties/ISteelSection), BH.oM.Structure.SectionProperties.[ISteelSection](/api/oM/Analytical/Structure/SectionProperties/ISteelSection)&gt;
    -  BH.oM.Structure.FloorSystem.[IPrimaryBeamConfiguration](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/IPrimaryBeamConfiguration)&lt;BH.oM.Structure.SectionProperties.[ISteelSection](/api/oM/Analytical/Structure/SectionProperties/ISteelSection)&gt;
    -  BH.oM.Structure.FloorSystem.[IConcreteSlabConfiguration](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/IConcreteSlabConfiguration)&lt;BH.oM.Structure.SurfaceProperties.[ISurfaceProperty](/api/oM/Analytical/Structure/SurfaceProperties/ISurfaceProperty)&gt;
    -  BH.oM.Structure.FloorSystem.[ISlabConfiguration](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/ISlabConfiguration)&lt;BH.oM.Structure.SurfaceProperties.[ISurfaceProperty](/api/oM/Analytical/Structure/SurfaceProperties/ISurfaceProperty)&gt;


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Slab | [ISurfaceProperty](/api/oM/Analytical/Structure/SurfaceProperties/ISurfaceProperty) | Surface property defining the construction and thickness of the slab. | - |
| SlabReinforcement | [ISlabReinforcement](/api/oM/Analytical/Structure/FloorSystem/Detailing/ISlabReinforcement) | Reinforcement of the slab, defined either as an estimated density or as an explicit layout. Can be null if no slab reinforcement is to be accounted for. | - |
| PrimaryBeam | [ISteelSection](/api/oM/Analytical/Structure/SectionProperties/ISteelSection) | Section of the primary beams (girders) spanning between columns in the local X direction. | - |
| SecondaryBeam | [ISteelSection](/api/oM/Analytical/Structure/SectionProperties/ISteelSection) | Section of the secondary (infill) beams spanning between the primary beams in the local Y direction. | - |
| PrimaryBeamTopLevel | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Distance from top of slab to top of primary beam. Set to slab thickness for slab on top but set to zero for within depth of slab. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| SecondaryBeamTopLevel | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Distance from top of slab to top of secondary beam. Set to slab thickness for slab on top but set to zero for within depth of slab. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| NumSecondary | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Number of secondary (infill) beams in a bay, counting the beam on one edge of the bay but not the one on the opposite edge. Set to zero for no secondary beams. | - |
| IntumescentPaintThicknessPrimary | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Thickness of intumescent paint covering exposed primary beam steelwork. Allowance used for when computing takeoffs of the configuration. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| IntumescentPaintThicknessSecondary | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Thickness of intumescent paint covering exposed secondary beam steelwork. Allowance used for when computing takeoffs of the configuration. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| IntumescentPaintMaterial | [Material](/api/oM/Physical/Physical/Materials/Material) | Material of the intumescent paint. Used when computing material takeoffs of the configuration. | - |
| StudDiameter | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Diameter of shear studs in this floor system | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| StudHeight | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Height of shear studs in this floor system | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| StudHeadDiameter | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Diameter of the head of the shear studs in this floor system | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| StudHeadThickness | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Thickness of the head of the shear studs in this floor system | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| StudSpacingPrimary | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Spacing of shear studs on the girder | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| StudSpacingSecondary | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Spacing of shear studs on the infill beams | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| StudMaterial | [Steel](/api/oM/Analytical/Structure/MaterialFragments/Steel) | Material of the shear studs. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class CompositeSteelInfillBeams : BH.oM.Base.BHoMObject,
BH.oM.Base.IBHoMObject,
BH.oM.Base.IObject,
BH.oM.Structure.FloorSystem.IFloorConfiguration,
BH.oM.Structure.FloorSystem.ISteelFrameConfiguration,
BH.oM.Structure.FloorSystem.ISecondaryBeamConfiguration<BH.oM.Structure.SectionProperties.ISteelSection, BH.oM.Structure.SectionProperties.ISteelSection>,
BH.oM.Structure.FloorSystem.IPrimaryBeamConfiguration<BH.oM.Structure.SectionProperties.ISteelSection>,
BH.oM.Structure.FloorSystem.IConcreteSlabConfiguration<BH.oM.Structure.SurfaceProperties.ISurfaceProperty>,
BH.oM.Structure.FloorSystem.ISlabConfiguration<BH.oM.Structure.SurfaceProperties.ISurfaceProperty>
```

Assembly: Structure_oM.dll

The C# class definition is available on github:

- [CompositeSteelInfillBeams.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/FloorSystem\FloorConfigurations\CompositeSteelInfillBeams.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Structure_oM/FloorSystem/CompositeSteelInfillBeams.json"
}
```

The JSON Schema is available on github here:

- [CompositeSteelInfillBeams.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Structure_oM/FloorSystem/CompositeSteelInfillBeams.json)
