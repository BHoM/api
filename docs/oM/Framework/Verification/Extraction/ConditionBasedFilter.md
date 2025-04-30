---
title: ConditionBasedFilter
---

# <small>BH.oM.Verification.Extraction.</small>**ConditionBasedFilter**

Basic object defining a condition-based 'filter from' workflow.

## Class structure

### Implemented interfaces and base types

???+ bhom "The ConditionBasedFilter is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Verification.Extraction.[IConditionBasedFilter](/api/oM/Framework/Verification/Extraction/Interfaces/IConditionBasedFilter)
    -  BH.oM.Verification.Extraction.[IExtraction](/api/oM/Framework/Verification/Extraction/Interfaces/IExtraction)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Condition | [ICondition](/api/oM/Framework/Verification/Conditions/Interfaces/ICondition) | Filtering condition to be met for objects to be returned. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class ConditionBasedFilter : BH.oM.Verification.Extraction.IConditionBasedFilter, BH.oM.Verification.Extraction.IExtraction, BH.oM.Base.IObject
```

Assembly: Verification_oM.dll

The class is defined in C#. The class definition is available on github:

- [ConditionBasedFilter.cs](https://github.com/BHoM/BHoM/blob/develop/Verification_oM/Extraction\ConditionBasedFilter.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` { .json .copy .select } title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Verification_oM/Extraction/ConditionBasedFilter.json}
```

The JSON Schema is available on github here:

- [ConditionBasedFilter.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Verification_oM/Extraction/ConditionBasedFilter.json)
