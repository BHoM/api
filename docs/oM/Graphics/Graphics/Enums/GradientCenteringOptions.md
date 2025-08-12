---
title: GradientCenteringOptions
---

# <small>BH.oM.Graphics.Enums.</small>**GradientCenteringOptions**

Either do not centre the range of the gradient, extend the range to be centred around 0, or make 0 the midpoint of the gradient while keeping UpperBound and LowerBound as the ends.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| None |  No change to the gradient range.  |
| Asymmetric |  Make 0 the midpoint of the gradient while keeping UpperBound and LowerBound as the ends.  |
| Symmetric |  Extend range to be centred around 0.  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum GradientCenteringOptions : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: Graphics_oM.dll

The C# enum definition is available on github:

- [GradientCenteringOptions.cs](https://github.com/BHoM/BHoM/blob/develop/Graphics_oM/Enums\GradientCenteringOptions.cs)

All history and changes of the class can be found by inspection the history.
