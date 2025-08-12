---
title: Confidence
---

# <small>BH.oM.Data.Library.</small>**Confidence**

Level of confidence for the serialized DataSet, outlining both the reliability of the source and the fidelity of the dataset to that source.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| Undefined |  Default value - assume no fidelity and no source.  |
| None |  The Dataset may not have a reliable source and/or fidelity to the source has not been tested  |
| Low |  The Dataset comes from an unreliable source and matches the source based on initial checks.  |
| Medium |  The Dataset comes from a reliable source and matches the source based on initial checks.  |
| High |  The Dataset comes from a reliable source and matches the source based on extensive review and testing.  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum Confidence : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: Data_oM.dll

The C# enum definition is available on github:

- [Confidence.cs](https://github.com/BHoM/BHoM/blob/develop/Data_oM/Library\Confidence.cs)

All history and changes of the class can be found by inspection the history.
