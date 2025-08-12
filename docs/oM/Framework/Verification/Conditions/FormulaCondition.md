---
title: FormulaCondition
---

# <small>BH.oM.Verification.Conditions.</small>**FormulaCondition**

Condition that verifies an object based on a given formula.

## Class structure

### Implemented interfaces and base types

???+ bhom "The FormulaCondition is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Verification.Conditions.[ICondition](/api/oM/Framework/Verification/Conditions/Interfaces/ICondition)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Inputs | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [IValueSource](/api/oM/Framework/Verification/Conditions/Interfaces/IValueSource)&gt; | Initial values to be extracted from the verified object.<br>Keys are the names of variables to be used in the calculations.<br>Values are value sources to extract the values from. | - |
| CalculationFormulae | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [Formula](/api/oM/Framework/Verification/Conditions/Formula)&gt; | Formulae to calculate the variables to be verified in the verification formula.<br>Formulae can be chained, i.e. one calculated variable can be derived from the previously calculated ones.<br>Keys are the names of variables to be used in the calculations.<br>Values are the formulae correspondent to each given variable name. | - |
| VerificationFormula | [Formula](/api/oM/Framework/Verification/Conditions/Formula) | Final formula to verify, needs to return a Boolean value, e.g. 'a &gt; b'. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| INestedConditions | [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netstandard-2.0)&lt;[ICondition](/api/oM/Framework/Verification/Conditions/Interfaces/ICondition)&gt; | Extracts the conditions nested inside a given condition, e.g. conditions nested inside logical conditions. | - | Verification_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class FormulaCondition : BH.oM.Verification.Conditions.ICondition, BH.oM.Base.IObject
```

Assembly: Verification_oM.dll

The C# class definition is available on github:

- [FormulaCondition.cs](https://github.com/BHoM/BHoM/blob/develop/Verification_oM/Conditions\FormulaCondition.cs)

All history and changes of the class can be found by inspection the history.
