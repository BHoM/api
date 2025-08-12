---
title: UValueContinuous
---

# <small>BH.oM.Facade.Fragments.</small>**UValueContinuous**

A U-Value representing the effective U-Value of continuous insulation and/or layers (not affected by thermal bridging due to frame u-value).

## Class structure

### Implemented interfaces and base types

???+ bhom "The UValueContinuous is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| UValue | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The U-Value of the continuous layers. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class UValueContinuous : BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: Facade_oM.dll

The C# class definition is available on github:

- [UValueContinuous.cs](https://github.com/BHoM/BHoM/blob/develop/Facade_oM/Fragments\UValueContinuous.cs)

All history and changes of the class can be found by inspection the history.
