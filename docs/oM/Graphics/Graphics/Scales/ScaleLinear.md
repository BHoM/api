---
title: ScaleLinear
---

# <small>BH.oM.Graphics.Scales.</small>**ScaleLinear**

Scale for mapping a continuous, quantitative input domain to a continuous output range.

## Class structure

### Implemented interfaces and base types

???+ bhom "The ScaleLinear is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Graphics.Scales.[IScale](/api/oM/Graphics/Graphics/Scales/IScale)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Domain | [Domain](/api/oM/Framework/Data/Collections/Domain) | - | - |
| Range | [Domain](/api/oM/Framework/Data/Collections/Domain) | - | - |
| Clamp | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - |
| Nice | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class ScaleLinear : BH.oM.Graphics.Scales.IScale, BH.oM.Base.IObject
```

Assembly: Graphics_oM.dll

The C# class definition is available on github:

- [ScaleLinear.cs](https://github.com/BHoM/BHoM/blob/develop/Graphics_oM/Scales\ScaleLinear.cs)

All history and changes of the class can be found by inspection the history.
