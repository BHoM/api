---
title: ISlabReinforcement
---

# <small>BH.oM.Structure.FloorSystem.</small>**ISlabReinforcement**

Base interface for the reinforcement definition of the slab in a floor configuration, for example estimated as a density (EstimateSlabReinforcement) or explicitly laid out (LayoutSlabReinforcement).

## Interface structure

### Implemented interfaces and base types

???+ bhom "The ISlabReinforcement is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Structure.FloorSystem.[EstimateSlabReinforcement](/api/oM/Analytical/Structure/FloorSystem/Detailing/EstimateSlabReinforcement)
    - BH.oM.Structure.FloorSystem.[LayoutSlabReinforcement](/api/oM/Analytical/Structure/FloorSystem/Detailing/LayoutSlabReinforcement)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface ISlabReinforcement : BH.oM.Base.IObject
```

Assembly: Structure_oM.dll

The C# interface definition is available on github:

- [ISlabReinforcement.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/FloorSystem\Detailing\ISlabReinforcement.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Structure_oM/FloorSystem/ISlabReinforcement.json"
}
```

The JSON Schema is available on github here:

- [ISlabReinforcement.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Structure_oM/FloorSystem/ISlabReinforcement.json)
