---
title: ILogicalCollectionCondition
---

# <small>BH.oM.Verification.Conditions.</small>**ILogicalCollectionCondition**

Interface for logical conditions consisting of a collection of nested conditions to be evaluated in combination (AND, OR etc.).

## Interface structure

### Implemented interfaces and base types

???+ bhom "The ILogicalCollectionCondition is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Verification.Conditions.[ILogicalCondition](/api/oM/Framework/Verification/Conditions/Interfaces/ILogicalCondition)
    -  BH.oM.Verification.Conditions.[ICondition](/api/oM/Framework/Verification/Conditions/Interfaces/ICondition)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Verification.Conditions.[LogicalAndCondition](/api/oM/Framework/Verification/Conditions/Logical/LogicalAndCondition)
    - BH.oM.Verification.Conditions.[LogicalOrCondition](/api/oM/Framework/Verification/Conditions/Logical/LogicalOrCondition)


## Properties



### Defining properties

The following properties are defined on the interface

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
public interface ILogicalCollectionCondition : BH.oM.Verification.Conditions.ILogicalCondition, BH.oM.Verification.Conditions.ICondition, BH.oM.Base.IObject
```

Assembly: Verification_oM.dll

The C# interface definition is available on github:

- [ILogicalCollectionCondition.cs](https://github.com/BHoM/BHoM/blob/develop/Verification_oM/Conditions\Interfaces\ILogicalCollectionCondition.cs)

All history and changes of the class can be found by inspection the history.
