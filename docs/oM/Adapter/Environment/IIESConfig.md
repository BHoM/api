---
title: IIESConfig
---

# <small>BH.oM.Environment.IES.</small>**IIESConfig**



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IIESConfig is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Environment.IES.[PullConfigIES](/api/oM/Adapter/Environment/PullConfigIES)
    - BH.oM.Environment.IES.[PushConfigIES](/api/oM/Adapter/Environment/PushConfigIES)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface IIESConfig : BH.oM.Base.IObject
```

Assembly: IES_oM.dll

The C# interface definition is available on github:

- [IIESConfig.cs](https://github.com/BHoM/IES_Toolkit/blob/develop/IES_oM/IIESConfig.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/IES_oM/IES/IIESConfig.json"
}
```

The JSON Schema is available on github here:

- [IIESConfig.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/IES_oM/IES/IIESConfig.json)
