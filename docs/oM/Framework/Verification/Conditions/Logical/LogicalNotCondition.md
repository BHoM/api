---
title: LogicalNotCondition
---

# <small>BH.oM.Verification.Conditions.</small>**LogicalNotCondition**

Condition that contains a nested condition that it inverses, i.e. the nested condition needs to fail for an object to be considered a pass.

## Class structure

### Implemented interfaces and base types

???+ bhom "The LogicalNotCondition is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Verification.Conditions.[ISingleLogicalCondition](/api/oM/Framework/Verification/Conditions/Interfaces/ISingleLogicalCondition)
    -  BH.oM.Verification.Conditions.[ILogicalCondition](/api/oM/Framework/Verification/Conditions/Interfaces/ILogicalCondition)
    -  BH.oM.Verification.Conditions.[ICondition](/api/oM/Framework/Verification/Conditions/Interfaces/ICondition)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Condition | [ICondition](/api/oM/Framework/Verification/Conditions/Interfaces/ICondition) | Condition to be inverted. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| INestedConditions | [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netstandard-2.0)&lt;[ICondition](/api/oM/Framework/Verification/Conditions/Interfaces/ICondition)&gt; | Extracts the conditions nested inside a given condition, e.g. conditions nested inside logical conditions. | - | Verification_Engine |
| NestedConditions | [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netstandard-2.0)&lt;[ICondition](/api/oM/Framework/Verification/Conditions/Interfaces/ICondition)&gt; | Extracts the conditions nested inside a given logical condition. | - | Verification_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class LogicalNotCondition : BH.oM.Verification.Conditions.ISingleLogicalCondition,
BH.oM.Verification.Conditions.ILogicalCondition,
BH.oM.Verification.Conditions.ICondition,
BH.oM.Base.IObject
```

Assembly: Verification_oM.dll

The C# class definition is available on github:

- [LogicalNotCondition.cs](https://github.com/BHoM/BHoM/blob/develop/Verification_oM/Conditions\Logical\LogicalNotCondition.cs)

All history and changes of the class can be found by inspection the history.
