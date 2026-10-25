---
title: TimberJoistFloor
---

# <small>BH.oM.Structure.FloorSystem.</small>**TimberJoistFloor**

Floor configuration of timber primary and secondary beams with tertiary beams (joists) spanning between the secondary beams, supporting a timber slab of constant thickness.

## Class structure

### Implemented interfaces and base types

???+ bhom "The TimberJoistFloor is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Structure.FloorSystem.[IFloorConfiguration](/api/oM/Analytical/Structure/FloorSystem/IFloorConfiguration)
    -  BH.oM.Structure.FloorSystem.[ITimberTertiaryBeamFloorConfiguration](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/ITimberTertiaryBeamFloorConfiguration)
    -  BH.oM.Structure.FloorSystem.[ITimberFrameConfiguration](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/ITimberFrameConfiguration)
    -  BH.oM.Structure.FloorSystem.[ITimberPrimaryBeamConfiguration](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/ITimberPrimaryBeamConfiguration)
    -  BH.oM.Structure.FloorSystem.[IPrimaryBeamConfiguration](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/IPrimaryBeamConfiguration)&lt;BH.oM.Structure.SectionProperties.[TimberSection](/api/oM/Analytical/Structure/SectionProperties/TimberSection)&gt;
    -  BH.oM.Structure.FloorSystem.[ITimberSecondaryBeamConfiguration](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/ITimberSecondaryBeamConfiguration)&lt;BH.oM.Structure.SectionProperties.[TimberSection](/api/oM/Analytical/Structure/SectionProperties/TimberSection)&gt;
    -  BH.oM.Structure.FloorSystem.[ISecondaryBeamConfiguration](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/ISecondaryBeamConfiguration)&lt;BH.oM.Structure.SectionProperties.[TimberSection](/api/oM/Analytical/Structure/SectionProperties/TimberSection), BH.oM.Structure.SectionProperties.[TimberSection](/api/oM/Analytical/Structure/SectionProperties/TimberSection)&gt;
    -  BH.oM.Structure.FloorSystem.[ITertiaryBeamConfiguration](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/ITertiaryBeamConfiguration)&lt;BH.oM.Structure.SectionProperties.[TimberSection](/api/oM/Analytical/Structure/SectionProperties/TimberSection), BH.oM.Structure.SectionProperties.[TimberSection](/api/oM/Analytical/Structure/SectionProperties/TimberSection), BH.oM.Structure.SectionProperties.[TimberSection](/api/oM/Analytical/Structure/SectionProperties/TimberSection)&gt;
    -  BH.oM.Structure.FloorSystem.[ITimberSlabConfiguration](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/ITimberSlabConfiguration)&lt;BH.oM.Structure.SurfaceProperties.[ConstantThickness](/api/oM/Analytical/Structure/SurfaceProperties/ConstantThickness)&gt;
    -  BH.oM.Structure.FloorSystem.[ISlabConfiguration](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/ISlabConfiguration)&lt;BH.oM.Structure.SurfaceProperties.[ConstantThickness](/api/oM/Analytical/Structure/SurfaceProperties/ConstantThickness)&gt;


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Slab | [ConstantThickness](/api/oM/Analytical/Structure/SurfaceProperties/ConstantThickness) | Surface property defining the construction and thickness of the slab. | - |
| PrimaryBeam | [TimberSection](/api/oM/Analytical/Structure/SectionProperties/TimberSection) | Section of the primary beams (girders) spanning between columns in the local X direction. | - |
| SecondaryBeam | [TimberSection](/api/oM/Analytical/Structure/SectionProperties/TimberSection) | Section of the secondary (infill) beams spanning between the primary beams in the local Y direction. | - |
| TertiaryBeam | [TimberSection](/api/oM/Analytical/Structure/SectionProperties/TimberSection) | Section of the tertiary beams spanning between the secondary beams in the local X direction. | - |
| PrimaryBeamTopLevel | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Distance from top of slab to top of primary beam. Set to slab thickness for slab on top but set to zero for within depth of slab. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| SecondaryBeamTopLevel | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Distance from top of slab to top of secondary beam. Set to slab thickness for slab on top but set to zero for within depth of slab. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| TertiaryBeamTopLevel | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Distance from top of slab to top of tertiary beam. Set to slab thickness for slab on top but set to zero for within depth of slab. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| NumSecondary | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Number of secondary (infill) beams in a bay, counting the beam on one edge of the bay but not the one on the opposite edge. Set to zero for no secondary beams. | - |
| NumTertiary | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Number of tertiary beams, evenly spaced across the bay in the local Y direction and spanning in the local X direction between the secondary beams. | - |


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
public class TimberJoistFloor : BH.oM.Base.BHoMObject,
BH.oM.Base.IBHoMObject,
BH.oM.Base.IObject,
BH.oM.Structure.FloorSystem.IFloorConfiguration,
BH.oM.Structure.FloorSystem.ITimberTertiaryBeamFloorConfiguration,
BH.oM.Structure.FloorSystem.ITimberFrameConfiguration,
BH.oM.Structure.FloorSystem.ITimberPrimaryBeamConfiguration,
BH.oM.Structure.FloorSystem.IPrimaryBeamConfiguration<BH.oM.Structure.SectionProperties.TimberSection>,
BH.oM.Structure.FloorSystem.ITimberSecondaryBeamConfiguration<BH.oM.Structure.SectionProperties.TimberSection>,
BH.oM.Structure.FloorSystem.ISecondaryBeamConfiguration<BH.oM.Structure.SectionProperties.TimberSection, BH.oM.Structure.SectionProperties.TimberSection>,
BH.oM.Structure.FloorSystem.ITertiaryBeamConfiguration<BH.oM.Structure.SectionProperties.TimberSection, BH.oM.Structure.SectionProperties.TimberSection, BH.oM.Structure.SectionProperties.TimberSection>,
BH.oM.Structure.FloorSystem.ITimberSlabConfiguration<BH.oM.Structure.SurfaceProperties.ConstantThickness>,
BH.oM.Structure.FloorSystem.ISlabConfiguration<BH.oM.Structure.SurfaceProperties.ConstantThickness>
```

Assembly: Structure_oM.dll

The C# class definition is available on github:

- [TimberJoistFloor.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/FloorSystem\FloorConfigurations\TimberJoistFloor.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Structure_oM/FloorSystem/TimberJoistFloor.json"
}
```

The JSON Schema is available on github here:

- [TimberJoistFloor.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Structure_oM/FloorSystem/TimberJoistFloor.json)
