---
title: DensityExtractionType
---

# <small>BH.oM.Matter.Options.</small>**DensityExtractionType**

Specifies how the density should be extracted from a list of IDensityProvider.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| AllMatching |  Require all densities across all IDensityProviders extracted to be equal within tolerance. If within tolerance, the average is computed.  |
| Average |  Compute and return the average value of all densities found, independent of difference between them.  |
| Maximum |  Return the maximum value of all densities found.  |
| Minimum |  Return the minimum value of all densities found.  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum DensityExtractionType : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: Matter_oM.dll

The C# enum definition is available on github:

- [DensityExtractionType.cs](https://github.com/BHoM/BHoM/blob/develop/Matter_oM/Options\Enums\DensityExtractionType.cs)

All history and changes of the class can be found by inspection the history.
