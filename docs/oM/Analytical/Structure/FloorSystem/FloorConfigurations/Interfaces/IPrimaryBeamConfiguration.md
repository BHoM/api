---
title: IPrimaryBeamConfiguration&lt;TPrimary&gt;
---

# <small>BH.oM.Structure.FloorSystem.</small>**IPrimaryBeamConfiguration&lt;TPrimary&gt;**

Base interface for framing systems containing a Primary beam.

## Interface structure

### Generic parameters

The IPrimaryBeamConfiguration contains the following generic paramters:

#### TPrimary

Constrained by the following arguments:

- BH.oM.Structure.SectionProperties.[IGeometricalSection](/api/oM/Analytical/Structure/SectionProperties/IGeometricalSection)

### Implemented interfaces and base types

???+ bhom "The IPrimaryBeamConfiguration`1 is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Structure.FloorSystem.[IFloorConfiguration](/api/oM/Analytical/Structure/FloorSystem/IFloorConfiguration)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - BH.oM.Structure.FloorSystem.[IConcreteFrameConfiguration](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/IConcreteFrameConfiguration)
    - BH.oM.Structure.FloorSystem.[IConcretePrimaryBeamConfiguration](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/IConcretePrimaryBeamConfiguration)
    - BH.oM.Structure.FloorSystem.[ISecondaryBeamConfiguration](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/ISecondaryBeamConfiguration)&lt;[TPrimary](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/ISecondaryBeamConfiguration#tprimary), [TSecondary](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/ISecondaryBeamConfiguration#tsecondary)&gt;
    - BH.oM.Structure.FloorSystem.[ISteelFrameConfiguration](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/ISteelFrameConfiguration)
    - BH.oM.Structure.FloorSystem.[ITertiaryBeamConfiguration](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/ITertiaryBeamConfiguration)&lt;[TPrimary](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/ITertiaryBeamConfiguration#tprimary), [TSecondary](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/ITertiaryBeamConfiguration#tsecondary), [TTertiary](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/ITertiaryBeamConfiguration#ttertiary)&gt;
    - BH.oM.Structure.FloorSystem.[ITimberFrameConfiguration](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/ITimberFrameConfiguration)
    - BH.oM.Structure.FloorSystem.[ITimberPrimaryBeamConfiguration](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/ITimberPrimaryBeamConfiguration)
    - BH.oM.Structure.FloorSystem.[ITimberSecondaryBeamConfiguration](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/ITimberSecondaryBeamConfiguration)&lt;[TPrimary](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/ITimberSecondaryBeamConfiguration#tprimary)&gt;
    - BH.oM.Structure.FloorSystem.[ITimberTertiaryBeamFloorConfiguration](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/ITimberTertiaryBeamFloorConfiguration)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Structure.FloorSystem.[CompositeSteelInfillBeams](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/CompositeSteelInfillBeams)
    - BH.oM.Structure.FloorSystem.[InSituConcreteFrame](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/InSituConcreteFrame)
    - BH.oM.Structure.FloorSystem.[OneWayBiscuitSlab](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/OneWayBiscuitSlab)
    - BH.oM.Structure.FloorSystem.[OneWayHollowcoreSlab](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/OneWayHollowcoreSlab)
    - BH.oM.Structure.FloorSystem.[OneWayRCFlatSlab](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/OneWayRCFlatSlab)
    - BH.oM.Structure.FloorSystem.[OneWayRCRibbedSlab](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/OneWayRCRibbedSlab)
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
| PrimaryBeam | [TPrimary](#tprimary) | Section for the primary beams spanning between columns. | - |
| PrimaryBeamTopLevel | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Distance from top of slab to top of primary beam. Set to slab thickness for slab on top but set to zero for within depth of slab. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IPrimaryBeamConfiguration`1 : BH.oM.Structure.FloorSystem.IFloorConfiguration, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: Structure_oM.dll

The C# interface definition is available on github:

- [IPrimaryBeamConfiguration.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/FloorSystem\FloorConfigurations\Interfaces\IPrimaryBeamConfiguration.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Structure_oM/FloorSystem/IPrimaryBeamConfiguration`1.json"
}
```

The JSON Schema is available on github here:

- [IPrimaryBeamConfiguration`1.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Structure_oM/FloorSystem/IPrimaryBeamConfiguration`1.json)
