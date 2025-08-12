---
title: UValueCavity
---

# <small>BH.oM.Facade.Fragments.</small>**UValueCavity**

A U-Value representing the effective U-Value of cavity insulation. This does not include derating effects from any frame u-values but should be derated for any thermal bridges not modeled.

## Class structure

### Implemented interfaces and base types

???+ bhom "The UValueCavity is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| UValue | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The U-Value of the cavity insulation. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class UValueCavity : BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: Facade_oM.dll

The C# class definition is available on github:

- [UValueCavity.cs](https://github.com/BHoM/BHoM/blob/develop/Facade_oM/Fragments\UValueCavity.cs)

All history and changes of the class can be found by inspection the history.
