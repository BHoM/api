---
title: PrecastConcreteFrameBiscuit
---

# <small>BH.oM.Structure.FloorSystem.</small>**PrecastConcreteFrameBiscuit**

Floor configuration of a topped biscuit slab supported on a precast concrete frame of primary and secondary beams.

## Class structure

### Implemented interfaces and base types

???+ bhom "The PrecastConcreteFrameBiscuit is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Structure.FloorSystem.[IFloorConfiguration](/api/oM/Analytical/Structure/FloorSystem/IFloorConfiguration)
    -  BH.oM.Structure.FloorSystem.[IConcreteFrameConfiguration](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/IConcreteFrameConfiguration)
    -  BH.oM.Structure.FloorSystem.[ISecondaryBeamConfiguration](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/ISecondaryBeamConfiguration)&lt;BH.oM.Structure.SectionProperties.[ConcreteSection](/api/oM/Analytical/Structure/SectionProperties/ConcreteSection), BH.oM.Structure.SectionProperties.[ConcreteSection](/api/oM/Analytical/Structure/SectionProperties/ConcreteSection)&gt;
    -  BH.oM.Structure.FloorSystem.[IPrimaryBeamConfiguration](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/IPrimaryBeamConfiguration)&lt;BH.oM.Structure.SectionProperties.[ConcreteSection](/api/oM/Analytical/Structure/SectionProperties/ConcreteSection)&gt;
    -  BH.oM.Structure.FloorSystem.[IConcretePrimaryBeamConfiguration](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/IConcretePrimaryBeamConfiguration)
    -  BH.oM.Structure.FloorSystem.[IConcreteSlabConfiguration](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/IConcreteSlabConfiguration)&lt;BH.oM.Structure.SurfaceProperties.[ToppedSlab](/api/oM/Analytical/Structure/SurfaceProperties/ToppedSlab)&gt;
    -  BH.oM.Structure.FloorSystem.[ISlabConfiguration](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/ISlabConfiguration)&lt;BH.oM.Structure.SurfaceProperties.[ToppedSlab](/api/oM/Analytical/Structure/SurfaceProperties/ToppedSlab)&gt;


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Slab | [ToppedSlab](/api/oM/Analytical/Structure/SurfaceProperties/ToppedSlab) | Surface property defining the construction and thickness of the slab. | - |
| SlabReinforcement | [ISlabReinforcement](/api/oM/Analytical/Structure/FloorSystem/Detailing/ISlabReinforcement) | Reinforcement of the slab, defined either as an estimated density or as an explicit layout. Can be null if no slab reinforcement is to be accounted for. | - |
| PrimaryBeam | [ConcreteSection](/api/oM/Analytical/Structure/SectionProperties/ConcreteSection) | Section of the primary beams spanning between columns in the local X direction. | - |
| SecondaryBeam | [ConcreteSection](/api/oM/Analytical/Structure/SectionProperties/ConcreteSection) | Section of the secondary beams spanning between the primary beams in the local Y direction. | - |
| BeamReinforcement | [IBeamReinforcement](/api/oM/Analytical/Structure/FloorSystem/Detailing/IBeamReinforcement) | Reinforcement applied to the beams. Can be left null if more detailed reinforcement is applied to the ConcreteSections for Primary and Secondary beams. | - |
| NumSecondary | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Number of secondary (infill) beams in a bay, counting the beam on one edge of the bay but not the one on the opposite edge. Set to zero for no secondary beams. | - |
| PrimaryBeamTopLevel | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Distance from top of slab to top of primary beam. Set to slab thickness for slab on top but set to zero for within depth of slab. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| SecondaryBeamTopLevel | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Distance from top of slab to top of secondary beam. Set to slab thickness for slab on top but set to zero for within depth of slab. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |


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
public class PrecastConcreteFrameBiscuit : BH.oM.Base.BHoMObject,
BH.oM.Base.IBHoMObject,
BH.oM.Base.IObject,
BH.oM.Structure.FloorSystem.IFloorConfiguration,
BH.oM.Structure.FloorSystem.IConcreteFrameConfiguration,
BH.oM.Structure.FloorSystem.ISecondaryBeamConfiguration<BH.oM.Structure.SectionProperties.ConcreteSection, BH.oM.Structure.SectionProperties.ConcreteSection>,
BH.oM.Structure.FloorSystem.IPrimaryBeamConfiguration<BH.oM.Structure.SectionProperties.ConcreteSection>,
BH.oM.Structure.FloorSystem.IConcretePrimaryBeamConfiguration,
BH.oM.Structure.FloorSystem.IConcreteSlabConfiguration<BH.oM.Structure.SurfaceProperties.ToppedSlab>,
BH.oM.Structure.FloorSystem.ISlabConfiguration<BH.oM.Structure.SurfaceProperties.ToppedSlab>
```

Assembly: Structure_oM.dll

The C# class definition is available on github:

- [PrecastConcreteFrameBiscuit.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/FloorSystem\FloorConfigurations\PrecastConcreteFrameBiscuit.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Structure_oM/FloorSystem/PrecastConcreteFrameBiscuit.json"
}
```

The JSON Schema is available on github here:

- [PrecastConcreteFrameBiscuit.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Structure_oM/FloorSystem/PrecastConcreteFrameBiscuit.json)
