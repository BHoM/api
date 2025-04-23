---
title: ValueCondition
---

# Verification.Conditions.ValueCondition



## Class structure

### Implemented interfaces and base types

???+ bhom "The ValueCondition in inheriting from the following base type(s) and implements the following interfaces:"

    -  Verification.Conditions.[IValueCondition](/api/oM/Framework/Verification/Conditions/IValueCondition)
    -  Verification.Conditions.[ICondition](/api/oM/Framework/Verification/Conditions/ICondition)
    -  Base.[IObject](/api/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ValueSource | [IValueSource](/api/oM/Framework/Verification/Conditions/IValueSource) | Object defining the source of a value to evaluate. | - |
| ReferenceValue | [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0) | Reference value to compare the extracted value against. | - |
| ComparisonType | [ValueComparisonType](/api/oM/Framework/Verification/ValueComparisonType) | Specifies whether the extracted value should be smaller, greater, etc. than the reference value. | - |
| Tolerance | [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0) | If applicable, tolerance to be considered in the comparison. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| INestedConditions | [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netstandard-2.0)&lt;[ICondition](/api/oM/Framework/Verification/Conditions/ICondition)&gt; | Extracts the conditions nested inside a given condition, e.g. conditions nested inside logical conditions. | - | Verification_Engine |
| ValueSourceLabel | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Generates a human readable label for a value source embedded in a value condition, based on provided value condition reporting config. | - | Verification_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [ValueCondition.cs](https://github.com/BHoM/BHoM/blob/develop/Verification_oM/Conditions\ValueCondition.cs)

All history and changes of the class can be found by inspection the history.
