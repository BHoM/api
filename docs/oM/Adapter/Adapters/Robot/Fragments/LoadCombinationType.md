---
title: LoadCombinationType
---

# <small>BH.oM.Adapters.Robot.</small>**LoadCombinationType**



## Class structure

### Implemented interfaces and base types

???+ bhom "The LoadCombinationType is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| CombinationType | [CombinationType](/api/oM/Adapter/Adapters/Robot/Enums/CombinationType) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class LoadCombinationType : BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: Robot_oM.dll

The C# class definition is available on github:

- [LoadCombinationType.cs](https://github.com/BHoM/Robot_Toolkit/blob/develop/Robot_oM/Fragments\LoadCombinationType.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Robot_oM/LoadCombinationType.json"
}
```

The JSON Schema is available on github here:

- [LoadCombinationType.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Robot_oM/LoadCombinationType.json)
