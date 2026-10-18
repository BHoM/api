---
title: ISecondaryBeamConfiguration&lt;TPrimary,TSecondary&gt;
---

# <small>BH.oM.Structure.FloorSystem.</small>**ISecondaryBeamConfiguration&lt;TPrimary,TSecondary&gt;**

Base interface for framing systems containing primary beams spanning between columns and secondary beams spanning between primary beams.

## Interface structure

### Generic parameters

The ISecondaryBeamConfiguration contains the following generic paramters:

#### TPrimary

Constrained by the following arguments:

- BH.oM.Structure.SectionProperties.[IGeometricalSection](/api/oM/Analytical/Structure/SectionProperties/IGeometricalSection)

#### TSecondary

Constrained by the following arguments:

- BH.oM.Structure.SectionProperties.[IGeometricalSection](/api/oM/Analytical/Structure/SectionProperties/IGeometricalSection)

### Implemented interfaces and base types

???+ bhom "The ISecondaryBeamConfiguration`2 is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Structure.FloorSystem.[IPrimaryBeamConfiguration](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/IPrimaryBeamConfiguration)&lt;[TPrimary](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/IPrimaryBeamConfiguration#tprimary)&gt;
    -  BH.oM.Structure.FloorSystem.[IFloorConfiguration](/api/oM/Analytical/Structure/FloorSystem/IFloorConfiguration)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - BH.oM.Structure.FloorSystem.[IConcreteFrameConfiguration](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/IConcreteFrameConfiguration)
    - BH.oM.Structure.FloorSystem.[ISteelFrameConfiguration](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/ISteelFrameConfiguration)
    - BH.oM.Structure.FloorSystem.[ITertiaryBeamConfiguration](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/ITertiaryBeamConfiguration)&lt;[TPrimary](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/ITertiaryBeamConfiguration#tprimary), [TSecondary](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/ITertiaryBeamConfiguration#tsecondary), [TTertiary](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/ITertiaryBeamConfiguration#ttertiary)&gt;
    - BH.oM.Structure.FloorSystem.[ITimberFrameConfiguration](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/ITimberFrameConfiguration)
    - BH.oM.Structure.FloorSystem.[ITimberSecondaryBeamConfiguration](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/ITimberSecondaryBeamConfiguration)&lt;[TPrimary](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/ITimberSecondaryBeamConfiguration#tprimary)&gt;
    - BH.oM.Structure.FloorSystem.[ITimberTertiaryBeamFloorConfiguration](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/ITimberTertiaryBeamFloorConfiguration)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Structure.FloorSystem.[CompositeSteelInfillBeams](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/CompositeSteelInfillBeams)
    - BH.oM.Structure.FloorSystem.[InSituConcreteFrame](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/InSituConcreteFrame)
    - BH.oM.Structure.FloorSystem.[PrecastConcreteFrameBiscuit](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/PrecastConcreteFrameBiscuit)
    - BH.oM.Structure.FloorSystem.[PrecastConcreteFrameHollow](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/PrecastConcreteFrameHollow)
    - BH.oM.Structure.FloorSystem.[PrecastConcreteFrameRibbed](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/PrecastConcreteFrameRibbed)
    - BH.oM.Structure.FloorSystem.[SteelInfillBeams](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/SteelInfillBeams)
    - BH.oM.Structure.FloorSystem.[TimberInfillBeams](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/TimberInfillBeams)
    - BH.oM.Structure.FloorSystem.[TimberJoistFloor](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/TimberJoistFloor)
    - BH.oM.Structure.FloorSystem.FloorConfigurations.[HybridConcreteOnTimber](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/HybridConcreteOnTimber)
    - BH.oM.Structure.FloorSystem.FloorConfigurations.[HybridTimberOnConcrete](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/HybridTimberOnConcrete)
    - BH.oM.Structure.FloorSystem.FloorConfigurations.[HybridTimberOnConcreteAndTimber](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/HybridTimberOnConcreteAndTimber)
    - BH.oM.Structure.FloorSystem.FloorConfigurations.[HybridTimberOnSteel](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/HybridTimberOnSteel)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| SecondaryBeam | [TSecondary](#tsecondary) | Section of the secondary beams spanning between the primary beams. | - |
| NumSecondary | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Number of secondary (infill) beams in a bay, counting the beam on one edge of the bay but not the one on the opposite edge. Set to zero for no secondary beams. | - |
| SecondaryBeamTopLevel | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Distance from top of slab to top of secondary beam. Set to slab thickness for slab on top but set to zero for within depth of slab. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface ISecondaryBeamConfiguration`2 : BH.oM.Structure.FloorSystem.IPrimaryBeamConfiguration<>,
BH.oM.Structure.FloorSystem.IFloorConfiguration,
BH.oM.Base.IBHoMObject,
BH.oM.Base.IObject
```

Assembly: Structure_oM.dll

The C# interface definition is available on github:

- [ISecondaryBeamConfiguration.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/FloorSystem\FloorConfigurations\Interfaces\ISecondaryBeamConfiguration.cs)

All history and changes of the class can be found by inspection the history.
