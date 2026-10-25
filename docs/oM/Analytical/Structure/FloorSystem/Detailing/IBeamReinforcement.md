---
title: IBeamReinforcement
---

# <small>BH.oM.Structure.FloorSystem.</small>**IBeamReinforcement**

Base interface for the reinforcement definition of the beams in a floor configuration, for example EstimateBeamReinforcement.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IBeamReinforcement is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Structure.FloorSystem.[EstimateBeamReinforcement](/api/oM/Analytical/Structure/FloorSystem/Detailing/EstimateBeamReinforcement)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface IBeamReinforcement : BH.oM.Base.IObject
```

Assembly: Structure_oM.dll

The C# interface definition is available on github:

- [IBeamReinforcement.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/FloorSystem\Detailing\IBeamReinforcement.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Structure_oM/FloorSystem/IBeamReinforcement.json"
}
```

The JSON Schema is available on github here:

- [IBeamReinforcement.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Structure_oM/FloorSystem/IBeamReinforcement.json)
