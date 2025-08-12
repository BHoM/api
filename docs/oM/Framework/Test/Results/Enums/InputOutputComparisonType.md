---
title: InputOutputComparisonType
---

# <small>BH.oM.Test.Results.</small>**InputOutputComparisonType**

Type of difference or error of the result.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| Equal |  Pulled object is identical to pushed obejct  |
| Exception |  Something in the process went wrong, making it impossible to compare the object before and after. For example an exception  |
| Difference |  Difference between a pushed and pulled property.  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum InputOutputComparisonType : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: Test_oM.dll

The C# enum definition is available on github:

- [InputOutputComparisonType.cs](https://github.com/BHoM/BHoM/blob/develop/Test_oM/Results\Enums\InputOutputComparisonType.cs)

All history and changes of the class can be found by inspection the history.
