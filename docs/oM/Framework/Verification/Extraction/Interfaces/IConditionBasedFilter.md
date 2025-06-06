---
title: IConditionBasedFilter
---

# <small>BH.oM.Verification.Extraction.</small>**IConditionBasedFilter**

Interface for all extraction workflows based on 'filter by' modes.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IConditionBasedFilter is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Verification.Extraction.[IExtraction](/api/oM/Framework/Verification/Extraction/Interfaces/IExtraction)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Verification.Extraction.[ConditionBasedFilter](/api/oM/Framework/Verification/Extraction/ConditionBasedFilter)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Condition | [ICondition](/api/oM/Framework/Verification/Conditions/Interfaces/ICondition) | Filtering condition to be met for objects to be returned. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IConditionBasedFilter : BH.oM.Verification.Extraction.IExtraction, BH.oM.Base.IObject
```

Assembly: Verification_oM.dll

The C# interface definition is available on github:

- [IConditionBasedFilter.cs](https://github.com/BHoM/BHoM/blob/develop/Verification_oM/Extraction\Interfaces\IConditionBasedFilter.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Verification_oM/Extraction/IConditionBasedFilter.json"
}
```

The JSON Schema is available on github here:

- [IConditionBasedFilter.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Verification_oM/Extraction/IConditionBasedFilter.json)
