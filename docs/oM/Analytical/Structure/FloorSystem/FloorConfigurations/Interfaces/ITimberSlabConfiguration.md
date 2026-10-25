---
title: ITimberSlabConfiguration&lt;T&gt;
---

# <small>BH.oM.Structure.FloorSystem.</small>**ITimberSlabConfiguration&lt;T&gt;**

Interface for floor configurations with a timber slab.

## Interface structure

### Generic parameters

The ITimberSlabConfiguration contains the following generic paramters:

#### T

Constrained by the following arguments:

- BH.oM.Structure.SurfaceProperties.[ISurfaceProperty](/api/oM/Analytical/Structure/SurfaceProperties/ISurfaceProperty)

### Implemented interfaces and base types

???+ bhom "The ITimberSlabConfiguration`1 is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Structure.FloorSystem.[ISlabConfiguration](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/ISlabConfiguration)&lt;[T](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/ISlabConfiguration#t)&gt;
    -  BH.oM.Structure.FloorSystem.[IFloorConfiguration](/api/oM/Analytical/Structure/FloorSystem/IFloorConfiguration)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Structure.FloorSystem.[TimberInfillBeams](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/TimberInfillBeams)
    - BH.oM.Structure.FloorSystem.[TimberJoistFloor](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/TimberJoistFloor)
    - BH.oM.Structure.FloorSystem.FloorConfigurations.[HybridTimberOnConcrete](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/HybridTimberOnConcrete)
    - BH.oM.Structure.FloorSystem.FloorConfigurations.[HybridTimberOnConcreteAndTimber](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/HybridTimberOnConcreteAndTimber)
    - BH.oM.Structure.FloorSystem.FloorConfigurations.[HybridTimberOnSteel](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/HybridTimberOnSteel)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface ITimberSlabConfiguration`1 : BH.oM.Structure.FloorSystem.ISlabConfiguration<>,
BH.oM.Structure.FloorSystem.IFloorConfiguration,
BH.oM.Base.IBHoMObject,
BH.oM.Base.IObject
```

Assembly: Structure_oM.dll

The C# interface definition is available on github:

- [ITimberSlabConfiguration.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/FloorSystem\FloorConfigurations\Interfaces\ITimberSlabConfiguration.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Structure_oM/FloorSystem/ITimberSlabConfiguration`1.json"
}
```

The JSON Schema is available on github here:

- [ITimberSlabConfiguration`1.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Structure_oM/FloorSystem/ITimberSlabConfiguration`1.json)
