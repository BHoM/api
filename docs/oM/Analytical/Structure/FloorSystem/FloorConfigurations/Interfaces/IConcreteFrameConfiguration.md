---
title: IConcreteFrameConfiguration
---

# <small>BH.oM.Structure.FloorSystem.</small>**IConcreteFrameConfiguration**

Interface for floor configurations with a frame of concrete primary beams and concrete secondary beams.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IConcreteFrameConfiguration is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Structure.FloorSystem.[ISecondaryBeamConfiguration](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/ISecondaryBeamConfiguration)&lt;BH.oM.Structure.SectionProperties.[ConcreteSection](/api/oM/Analytical/Structure/SectionProperties/ConcreteSection), BH.oM.Structure.SectionProperties.[ConcreteSection](/api/oM/Analytical/Structure/SectionProperties/ConcreteSection)&gt;
    -  BH.oM.Structure.FloorSystem.[IPrimaryBeamConfiguration](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/IPrimaryBeamConfiguration)&lt;BH.oM.Structure.SectionProperties.[ConcreteSection](/api/oM/Analytical/Structure/SectionProperties/ConcreteSection)&gt;
    -  BH.oM.Structure.FloorSystem.[IFloorConfiguration](/api/oM/Analytical/Structure/FloorSystem/IFloorConfiguration)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Structure.FloorSystem.[IConcretePrimaryBeamConfiguration](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/IConcretePrimaryBeamConfiguration)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Structure.FloorSystem.[InSituConcreteFrame](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/InSituConcreteFrame)
    - BH.oM.Structure.FloorSystem.[PrecastConcreteFrameBiscuit](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/PrecastConcreteFrameBiscuit)
    - BH.oM.Structure.FloorSystem.[PrecastConcreteFrameHollow](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/PrecastConcreteFrameHollow)
    - BH.oM.Structure.FloorSystem.[PrecastConcreteFrameRibbed](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/PrecastConcreteFrameRibbed)
    - BH.oM.Structure.FloorSystem.FloorConfigurations.[HybridTimberOnConcrete](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/HybridTimberOnConcrete)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface IConcreteFrameConfiguration : BH.oM.Structure.FloorSystem.ISecondaryBeamConfiguration<BH.oM.Structure.SectionProperties.ConcreteSection, BH.oM.Structure.SectionProperties.ConcreteSection>,
BH.oM.Structure.FloorSystem.IPrimaryBeamConfiguration<BH.oM.Structure.SectionProperties.ConcreteSection>,
BH.oM.Structure.FloorSystem.IFloorConfiguration,
BH.oM.Base.IBHoMObject,
BH.oM.Base.IObject,
BH.oM.Structure.FloorSystem.IConcretePrimaryBeamConfiguration
```

Assembly: Structure_oM.dll

The C# interface definition is available on github:

- [IConcreteFrameConfiguration.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/FloorSystem\FloorConfigurations\Interfaces\IConcreteFrameConfiguration.cs)

All history and changes of the class can be found by inspection the history.
