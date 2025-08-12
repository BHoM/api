---
title: Domain
---

# <small>BH.oM.Data.Collections.</small>**Domain**

A numerical domain defined by a minimum and maximum value.

## Class structure

### Implemented interfaces and base types

???+ bhom "The Domain is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Base.[IImmutable](/api/oM/Framework/Base/Interface/IImmutable)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Min | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The lowest bound of the domain. | - |
| Max | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The highest bound of the domain. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class Domain : BH.oM.Base.IObject, BH.oM.Base.IImmutable
```

Assembly: Data_oM.dll

The C# class definition is available on github:

- [Domain.cs](https://github.com/BHoM/BHoM/blob/develop/Data_oM/Collections\Domain.cs)

All history and changes of the class can be found by inspection the history.
