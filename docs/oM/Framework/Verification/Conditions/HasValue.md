---
title: HasValue
---

# <small>BH.oM.Verification.Conditions.</small>**HasValue**



## Class structure

### Implemented interfaces and base types

???+ bhom "The HasValue is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Verification.Conditions.[IValueCondition](/api/oM/Framework/Verification/Conditions/Interfaces/IValueCondition)
    -  BH.oM.Verification.Conditions.[ICondition](/api/oM/Framework/Verification/Conditions/Interfaces/ICondition)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ValueSource | [IValueSource](/api/oM/Framework/Verification/Conditions/Interfaces/IValueSource) | Object defining the source of a value to evaluate. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| INestedConditions | [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netstandard-2.0)&lt;[ICondition](/api/oM/Framework/Verification/Conditions/Interfaces/ICondition)&gt; | Extracts the conditions nested inside a given condition, e.g. conditions nested inside logical conditions. | - | Verification_Engine |
| ValueSourceLabel | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Generates a human readable label for a value source embedded in a value condition, based on provided value condition reporting config. | - | Verification_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class HasValue : BH.oM.Verification.Conditions.IValueCondition, BH.oM.Verification.Conditions.ICondition, BH.oM.Base.IObject
```

Assembly: Verification_oM.dll

The C# class definition is available on github:

- [HasValue.cs](https://github.com/BHoM/BHoM/blob/develop/Verification_oM/Conditions\HasValue.cs)

All history and changes of the class can be found by inspection the history.
