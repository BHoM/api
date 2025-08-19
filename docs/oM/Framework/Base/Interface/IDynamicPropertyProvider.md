---
title: IDynamicPropertyProvider
---

# <small>BH.oM.Base.</small>**IDynamicPropertyProvider**

Identifies objects that provide their own accessors to their dynamic properties. Those classes must implement the following methods: GetProperty, SetProperty, and GetProperties.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IDynamicPropertyProvider is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IDynamicObject](/api/oM/Framework/Base/Interface/IDynamicObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Base.[CustomObject](/api/oM/Framework/Base/CustomObject)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface IDynamicPropertyProvider : BH.oM.Base.IDynamicObject, BH.oM.Base.IObject
```

Assembly: BHoM.dll

The C# interface definition is available on github:

- [IDynamicPropertyProvider.cs](https://github.com/BHoM/BHoM/blob/develop/BHoM/Interface\IDynamicPropertyProvider.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/BHoM/IDynamicPropertyProvider.json"
}
```

The JSON Schema is available on github here:

- [IDynamicPropertyProvider.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/BHoM/IDynamicPropertyProvider.json)
