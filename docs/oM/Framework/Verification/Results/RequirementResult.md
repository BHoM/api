---
title: RequirementResult
---

# <small>BH.oM.Verification.Results.</small>**RequirementResult**

Object representing result of verification of an object against a Requirement.

## Class structure

### Implemented interfaces and base types

???+ bhom "The RequirementResult is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IImmutable](/api/oM/Framework/Base/Interface/IImmutable)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| RequirementId | [IComparable](https://learn.microsoft.com/en-us/dotnet/api/System.IComparable?view=netstandard-2.0) | BHoM_Guid of Requirement object this result was based on. | - |
| ObjectId | [IComparable](https://learn.microsoft.com/en-us/dotnet/api/System.IComparable?view=netstandard-2.0) | Identifier of an object this result was based on. In case of IBHoMObjects it is their BHoM_Guid. | - |
| VerificationResult | [IConditionResult](/api/oM/Framework/Verification/Results/Conditions/IConditionResult) | Result of object verification against the condition specified in the Requirement. | - |
| Events | [ReadOnlyCollection](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1?view=netstandard-2.0)&lt;[Event](/api/oM/Framework/Base/Debugging/Event)&gt; | List of events that occurred during the verification process. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class RequirementResult : BH.oM.Base.IImmutable, BH.oM.Base.IObject
```

Assembly: Verification_oM.dll

The C# class definition is available on github:

- [RequirementResult.cs](https://github.com/BHoM/BHoM/blob/develop/Verification_oM/Results\RequirementResult.cs)

All history and changes of the class can be found by inspection the history.
