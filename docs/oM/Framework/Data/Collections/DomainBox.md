---
title: DomainBox
---

# <small>BH.oM.Data.Collections.</small>**DomainBox**

A multidimensional domain, defined by the minimum and maximum values in each dimension, enclosing a hypercube.

## Class structure

### Implemented interfaces and base types

???+ bhom "The DomainBox is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Domains | [Domain](/api/oM/Framework/Data/Collections/Domain)[] | Array containing the domain for each dimension. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class DomainBox : BH.oM.Base.IObject
```

Assembly: Data_oM.dll

The C# class definition is available on github:

- [DomainBox.cs](https://github.com/BHoM/BHoM/blob/develop/Data_oM/Collections\DomainBox.cs)

All history and changes of the class can be found by inspection the history.
