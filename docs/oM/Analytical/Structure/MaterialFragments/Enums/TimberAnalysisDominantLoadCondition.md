---
title: TimberAnalysisDominantLoadCondition
---

# <small>BH.oM.Structure.MaterialFragments.</small>**TimberAnalysisDominantLoadCondition**

Enum for controlling if analysis parameters of the Timber material should be assigned based on values for bending or axial stiffness.
Only relevant for some engineered timber products.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| Undefined |  Default value. For some timber types where the stiffness values are independant on load condition this can be used..  |
| Axial |  The element with the Timber material will have loads resulting in axial stresses as the predominant load condition.  |
| Bending |  The element with the Timber material will have loads resulting in bending stresses as the predominant load condition.  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum TimberAnalysisDominantLoadCondition : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: Structure_oM.dll

The C# enum definition is available on github:

- [TimberAnalysisDominantLoadCondition.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/MaterialFragments\Enums\TimberAnalysisDominantLoadCondition.cs)

All history and changes of the class can be found by inspection the history.
