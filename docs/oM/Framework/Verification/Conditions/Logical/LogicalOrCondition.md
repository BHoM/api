---
title: LogicalOrCondition
---

# <small>BH.oM.Verification.</small>**LogicalOrCondition**

Condition that contains a collection of nested conditions, of which at least one needs to be met for an object to be considered a pass.

## Class structure

### Implemented interfaces and base types

???+ bhom "The LogicalOrCondition is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Verification.Conditions.[ILogicalCollectionCondition](/api/oM/Framework/Verification/Conditions/Interfaces/ILogicalCollectionCondition)
    -  BH.oM.Verification.Conditions.[ILogicalCondition](/api/oM/Framework/Verification/Conditions/Interfaces/ILogicalCondition)
    -  BH.oM.Verification.Conditions.[ICondition](/api/oM/Framework/Verification/Conditions/Interfaces/ICondition)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Conditions | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICondition](/api/oM/Framework/Verification/Conditions/Interfaces/ICondition)&gt; | A collection of conditions to be evaluated in combination. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| INestedConditions | [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netstandard-2.0)&lt;[ICondition](/api/oM/Framework/Verification/Conditions/Interfaces/ICondition)&gt; | Extracts the conditions nested inside a given condition, e.g. conditions nested inside logical conditions. | - | Verification_Engine |
| NestedConditions | [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netstandard-2.0)&lt;[ICondition](/api/oM/Framework/Verification/Conditions/Interfaces/ICondition)&gt; | Extracts the conditions nested inside a given logical condition. | - | Verification_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class LogicalOrCondition : BH.oM.Verification.Conditions.ILogicalCollectionCondition,
BH.oM.Verification.Conditions.ILogicalCondition,
BH.oM.Verification.Conditions.ICondition,
BH.oM.Base.IObject
```

Assembly: Verification_oM.dll

The class is defined in C#. The class definition is available on github:

- [LogicalOrCondition.cs](https://github.com/BHoM/BHoM/blob/develop/Verification_oM/Conditions\Logical\LogicalOrCondition.cs)

All history and changes of the class can be found by inspection the history.
