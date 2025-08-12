---
title: Formula
---

# <small>BH.oM.Verification.Conditions.</small>**Formula**

Formula in a form of a string in a specific convention, used to calculate values in verification workflows.

## Class structure

### Implemented interfaces and base types

???+ bhom "The Formula is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Equation | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Equation in a form of a string, resulting in either numerical, string or Boolean values.<br>Only basic mathematical operators are currently supported.<br>Strings need to be wrapped in single quotation marks (').<br>Enum values need to stay unwrapped and expressed only with the value itself (e.g. MyValue instead of MyEnum.MyValue).<br>Examples of valid formule:<br>(a + b) * 2<br>a == b * 2<br>a == 'StringValue'<br>a == EnumValue<br>a == 'StringValueA' or (a == 'StringValueB' and b == 'StringValueC')<br>if a == 0: 'zero', else if a == 1: 'one', else if a == 2: 'two', else: 'not supported'<br>if a == b and a == c: 'all values equal', else: 'values not equal' | - |
| Tolerance | [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0) | Tolerance to be applied when evaluating the formula. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class Formula : BH.oM.Base.IObject
```

Assembly: Verification_oM.dll

The C# class definition is available on github:

- [Formula.cs](https://github.com/BHoM/BHoM/blob/develop/Verification_oM/Conditions\Formula.cs)

All history and changes of the class can be found by inspection the history.
