---
title: LogicalCollectionConditionResult
---

# <small>BH.oM.Verification.Results.</small>**LogicalCollectionConditionResult**

Object representing result of ILogicalCollectionCondition.

## Class structure

### Implemented interfaces and base types

???+ bhom "The LogicalCollectionConditionResult is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Verification.Results.[IConditionResult](/api/oM/Framework/Verification/Results/Conditions/IConditionResult)
    -  BH.oM.Base.[IImmutable](/api/oM/Framework/Base/Interface/IImmutable)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Passed | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0)&gt; | Information whether the object passed or failed the condition. Null means inconclusive result. | - |
| Results | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IConditionResult](/api/oM/Framework/Verification/Results/Conditions/IConditionResult)&gt; | Results of all nested conditions. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class LogicalCollectionConditionResult : BH.oM.Verification.Results.IConditionResult, BH.oM.Base.IImmutable, BH.oM.Base.IObject
```

Assembly: Verification_oM.dll

The C# class definition is available on github:

- [LogicalCollectionConditionResult.cs](https://github.com/BHoM/BHoM/blob/develop/Verification_oM/Results\Conditions\LogicalCollectionConditionResult.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Verification_oM/Results/LogicalCollectionConditionResult.json"
}
```

The JSON Schema is available on github here:

- [LogicalCollectionConditionResult.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Verification_oM/Results/LogicalCollectionConditionResult.json)
