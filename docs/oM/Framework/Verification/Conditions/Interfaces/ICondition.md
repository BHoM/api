---
title: ICondition
---

# <small>BH.oM.Verification.Conditions.</small>**ICondition**

Top level interface for conditions: lightweight objects describing a yes/no question to be asked against another object.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The ICondition is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - BH.oM.Verification.Conditions.[ILogicalCollectionCondition](/api/oM/Framework/Verification/Conditions/Interfaces/ILogicalCollectionCondition)
    - BH.oM.Verification.Conditions.[ILogicalCondition](/api/oM/Framework/Verification/Conditions/Interfaces/ILogicalCondition)
    - BH.oM.Verification.Conditions.[ISingleLogicalCondition](/api/oM/Framework/Verification/Conditions/Interfaces/ISingleLogicalCondition)
    - BH.oM.Verification.Conditions.[IValueCondition](/api/oM/Framework/Verification/Conditions/Interfaces/IValueCondition)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Verification.Conditions.[FormulaCondition](/api/oM/Framework/Verification/Conditions/FormulaCondition)
    - BH.oM.Verification.Conditions.[HasId](/api/oM/Framework/Verification/Conditions/HasId)
    - BH.oM.Verification.Conditions.[HasValue](/api/oM/Framework/Verification/Conditions/HasValue)
    - BH.oM.Verification.Conditions.[IsInDomain](/api/oM/Framework/Verification/Conditions/IsInDomain)
    - BH.oM.Verification.Conditions.[IsInSet](/api/oM/Framework/Verification/Conditions/IsInSet)
    - BH.oM.Verification.Conditions.[IsNotNull](/api/oM/Framework/Verification/Conditions/IsNotNull)
    - BH.oM.Verification.Conditions.[IsOfType](/api/oM/Framework/Verification/Conditions/IsOfType)
    - BH.oM.Verification.Conditions.[LogicalAndCondition](/api/oM/Framework/Verification/Conditions/Logical/LogicalAndCondition)
    - BH.oM.Verification.Conditions.[LogicalNotCondition](/api/oM/Framework/Verification/Conditions/Logical/LogicalNotCondition)
    - BH.oM.Verification.Conditions.[LogicalOrCondition](/api/oM/Framework/Verification/Conditions/Logical/LogicalOrCondition)
    - BH.oM.Verification.Conditions.[ValueCondition](/api/oM/Framework/Verification/Conditions/ValueCondition)


## Properties

### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| INestedConditions | [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netstandard-2.0)&lt;[ICondition](/api/oM/Framework/Verification/Conditions/Interfaces/ICondition)&gt; | Extracts the conditions nested inside a given condition, e.g. conditions nested inside logical conditions. | - | Verification_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface ICondition : BH.oM.Base.IObject
```

Assembly: Verification_oM.dll

The C# interface definition is available on github:

- [ICondition.cs](https://github.com/BHoM/BHoM/blob/develop/Verification_oM/Conditions\Interfaces\ICondition.cs)

All history and changes of the class can be found by inspection the history.
