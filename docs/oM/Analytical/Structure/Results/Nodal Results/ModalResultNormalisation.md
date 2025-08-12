---
title: ModalResultNormalisation
---

# <small>BH.oM.Structure.Results.</small>**ModalResultNormalisation**



## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| EigenvectorComponent |  Results normalised so that the absolute value of the maximum component of the mode shape for the mode and case is equal to 1.  |
| EigenvectorTotal |  Results normalised so that the square root sum of squares for the displacement of the mode and case is equal to 1.  |
| MassComponent |  Results normalised so that the absolute value of the maximum component of the mass for the mode and case is equal to 1.  |
| MassTotal |  Results normalised so that the square root sum of squares for mass of the mode and case is equal to 1.  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum ModalResultNormalisation : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: Structure_oM.dll

The C# enum definition is available on github:

- [ModalResultNormalisation.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/Results\Nodal Results\ModalResultNormalisation.cs)

All history and changes of the class can be found by inspection the history.
