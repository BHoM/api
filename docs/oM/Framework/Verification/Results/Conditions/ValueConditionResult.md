---
title: ValueConditionResult
---

# <small>BH.oM.Verification.Results.</small>**ValueConditionResult**

Object representing result of IValueCondition.

## Class structure

### Implemented interfaces and base types

???+ bhom "The ValueConditionResult is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Verification.Results.[IConditionResult](/api/oM/Framework/Verification/Results/Conditions/IConditionResult)
    -  BH.oM.Base.[IImmutable](/api/oM/Framework/Base/Interface/IImmutable)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Passed | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0)&gt; | Information whether the object passed or failed the condition. Null means inconclusive result. | - |
| ExtractedValue | [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0) | Value extracted from the object and checked against condition requirements. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class ValueConditionResult : BH.oM.Verification.Results.IConditionResult, BH.oM.Base.IImmutable, BH.oM.Base.IObject
```

Assembly: Verification_oM.dll

The C# class definition is available on github:

- [ValueConditionResult.cs](https://github.com/BHoM/BHoM/blob/develop/Verification_oM/Results\Conditions\ValueConditionResult.cs)

All history and changes of the class can be found by inspection the history.
