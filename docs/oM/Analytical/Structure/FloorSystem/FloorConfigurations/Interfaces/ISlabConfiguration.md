---
title: ISlabConfiguration&lt;T&gt;
---

# <small>BH.oM.Structure.FloorSystem.</small>**ISlabConfiguration&lt;T&gt;**

Base interface for floor configurations containing a slab.

## Interface structure

### Generic parameters

The ISlabConfiguration contains the following generic paramters:

#### T

Constrained by the following arguments:

- BH.oM.Structure.SurfaceProperties.[ISurfaceProperty](/api/oM/Analytical/Structure/SurfaceProperties/ISurfaceProperty)

### Implemented interfaces and base types

???+ bhom "The ISlabConfiguration`1 is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Structure.FloorSystem.[IFloorConfiguration](/api/oM/Analytical/Structure/FloorSystem/IFloorConfiguration)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - BH.oM.Structure.FloorSystem.[IConcreteDropheadSlabConfiguration](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/IConcreteDropheadSlabConfiguration)&lt;[T](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/IConcreteDropheadSlabConfiguration#t)&gt;
    - BH.oM.Structure.FloorSystem.[IConcreteSlabConfiguration](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/IConcreteSlabConfiguration)&lt;[T](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/IConcreteSlabConfiguration#t)&gt;
    - BH.oM.Structure.FloorSystem.[ITimberSlabConfiguration](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/ITimberSlabConfiguration)&lt;[T](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/ITimberSlabConfiguration#t)&gt;


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
    - BH.oM.Structure.FloorSystem.[RCFlatSlab](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/RCFlatSlab)
    - BH.oM.Structure.FloorSystem.[RCVoidedFlatSlab](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/RCVoidedFlatSlab)
    - BH.oM.Structure.FloorSystem.[SteelInfillBeams](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/SteelInfillBeams)
    - BH.oM.Structure.FloorSystem.[TimberInfillBeams](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/TimberInfillBeams)
    - BH.oM.Structure.FloorSystem.[TimberJoistFloor](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/TimberJoistFloor)
    - BH.oM.Structure.FloorSystem.[WaffleSlab](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/WaffleSlab)
    - BH.oM.Structure.FloorSystem.FloorConfigurations.[HybridConcreteOnTimber](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/HybridConcreteOnTimber)
    - BH.oM.Structure.FloorSystem.FloorConfigurations.[HybridTimberOnConcrete](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/HybridTimberOnConcrete)
    - BH.oM.Structure.FloorSystem.FloorConfigurations.[HybridTimberOnConcreteAndTimber](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/HybridTimberOnConcreteAndTimber)
    - BH.oM.Structure.FloorSystem.FloorConfigurations.[HybridTimberOnSteel](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/HybridTimberOnSteel)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Slab | [T](#t) | Surface property defining the construction and thickness of the slab. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface ISlabConfiguration`1 : BH.oM.Structure.FloorSystem.IFloorConfiguration, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: Structure_oM.dll

The C# interface definition is available on github:

- [ISlabConfiguration.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/FloorSystem\FloorConfigurations\Interfaces\ISlabConfiguration.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Structure_oM/FloorSystem/ISlabConfiguration`1.json"
}
```

The JSON Schema is available on github here:

- [ISlabConfiguration`1.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Structure_oM/FloorSystem/ISlabConfiguration`1.json)
