---
title: EdgeCondition
---

# <small>BH.oM.Structure.FloorSystem.</small>**EdgeCondition**

Position of a floor bay within the floor plate, which affects the design of the bay.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| Interior |  Bay with neighbouring bays on all sides.  |
| Edge |  Bay on the edge of the floor plate, with no neighbouring bay on one side.  |
| Corner |  Bay at a corner of the floor plate, with no neighbouring bays on two adjacent sides.  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum EdgeCondition : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: Structure_oM.dll

The C# enum definition is available on github:

- [EdgeCondition.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/FloorSystem\Enums\EdgeCondition.cs)

All history and changes of the class can be found by inspection the history.
