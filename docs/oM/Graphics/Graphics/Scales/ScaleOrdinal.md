---
title: ScaleOrdinal
---

# <small>BH.oM.Graphics.Scales.</small>**ScaleOrdinal**

Scale for mapping from a discrete input domain to a discrete output range.

## Class structure

### Implemented interfaces and base types

???+ bhom "The ScaleOrdinal is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Graphics.Scales.[IScale](/api/oM/Graphics/Graphics/Scales/IScale)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Domain | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| Range | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class ScaleOrdinal : BH.oM.Graphics.Scales.IScale, BH.oM.Base.IObject
```

Assembly: Graphics_oM.dll

The C# class definition is available on github:

- [ScaleOrdinal.cs](https://github.com/BHoM/BHoM/blob/develop/Graphics_oM/Scales\ScaleOrdinal.cs)

All history and changes of the class can be found by inspection the history.
