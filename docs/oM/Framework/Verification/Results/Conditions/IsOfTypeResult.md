---
title: IsOfTypeResult
---

# <small>BH.oM.Verification.Results.</small>**IsOfTypeResult**

Object representing result of IsOfType condition.

## Class structure

### Implemented interfaces and base types

???+ bhom "The IsOfTypeResult is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Verification.Results.[IConditionResult](/api/oM/Framework/Verification/Results/Conditions/IConditionResult)
    -  BH.oM.Base.[IImmutable](/api/oM/Framework/Base/Interface/IImmutable)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Passed | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0)&gt; | Information whether the object passed or failed the condition. Null means inconclusive result. | - |
| ExtractedType | [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=netstandard-2.0) | Type of the checked object. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class IsOfTypeResult : BH.oM.Verification.Results.IConditionResult, BH.oM.Base.IImmutable, BH.oM.Base.IObject
```

Assembly: Verification_oM.dll

The C# class definition is available on github:

- [IsOfTypeResult.cs](https://github.com/BHoM/BHoM/blob/develop/Verification_oM/Results\Conditions\IsOfTypeResult.cs)

All history and changes of the class can be found by inspection the history.
