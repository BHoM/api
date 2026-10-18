---
title: IConcretePrimaryBeamConfiguration
---

# <small>BH.oM.Structure.FloorSystem.</small>**IConcretePrimaryBeamConfiguration**

Interface for floor configurations with concrete primary beams.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IConcretePrimaryBeamConfiguration is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Structure.FloorSystem.[IPrimaryBeamConfiguration](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/IPrimaryBeamConfiguration)&lt;BH.oM.Structure.SectionProperties.[ConcreteSection](/api/oM/Analytical/Structure/SectionProperties/ConcreteSection)&gt;
    -  BH.oM.Structure.FloorSystem.[IFloorConfiguration](/api/oM/Analytical/Structure/FloorSystem/IFloorConfiguration)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - BH.oM.Structure.FloorSystem.[IConcreteFrameConfiguration](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/IConcreteFrameConfiguration)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Structure.FloorSystem.[InSituConcreteFrame](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/InSituConcreteFrame)
    - BH.oM.Structure.FloorSystem.[OneWayBiscuitSlab](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/OneWayBiscuitSlab)
    - BH.oM.Structure.FloorSystem.[OneWayHollowcoreSlab](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/OneWayHollowcoreSlab)
    - BH.oM.Structure.FloorSystem.[OneWayRCFlatSlab](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/OneWayRCFlatSlab)
    - BH.oM.Structure.FloorSystem.[OneWayRCRibbedSlab](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/OneWayRCRibbedSlab)
    - BH.oM.Structure.FloorSystem.[PrecastConcreteFrameBiscuit](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/PrecastConcreteFrameBiscuit)
    - BH.oM.Structure.FloorSystem.[PrecastConcreteFrameHollow](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/PrecastConcreteFrameHollow)
    - BH.oM.Structure.FloorSystem.[PrecastConcreteFrameRibbed](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/PrecastConcreteFrameRibbed)
    - BH.oM.Structure.FloorSystem.FloorConfigurations.[HybridTimberOnConcrete](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/HybridTimberOnConcrete)
    - BH.oM.Structure.FloorSystem.FloorConfigurations.[HybridTimberOnConcreteAndTimber](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/HybridTimberOnConcreteAndTimber)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BeamReinforcement | [IBeamReinforcement](/api/oM/Analytical/Structure/FloorSystem/Detailing/IBeamReinforcement) | Reinforcement applied to the beams. Can be left null if more detailed reinforcement is applied to the ConcreteSections of the beams. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IConcretePrimaryBeamConfiguration : BH.oM.Structure.FloorSystem.IPrimaryBeamConfiguration<BH.oM.Structure.SectionProperties.ConcreteSection>,
BH.oM.Structure.FloorSystem.IFloorConfiguration,
BH.oM.Base.IBHoMObject,
BH.oM.Base.IObject
```

Assembly: Structure_oM.dll

The C# interface definition is available on github:

- [IConcretePrimaryBeamConfiguration.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/FloorSystem\FloorConfigurations\Interfaces\IConcretePrimaryBeamConfiguration.cs)

All history and changes of the class can be found by inspection the history.
