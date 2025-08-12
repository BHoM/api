---
title: HashFragment
---

# <small>BH.oM.Base.</small>**HashFragment**

Stores the hash of the parent BHoMObject.

## Class structure

### Implemented interfaces and base types

???+ bhom "The HashFragment is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IHashFragment](/api/oM/Framework/Base/Interface/IHashFragment)
    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Hash | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Hash of the parent BHoMObject. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class HashFragment : BH.oM.Base.IHashFragment, BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: BHoM.dll

The C# class definition is available on github:

- [HashFragment.cs](https://github.com/BHoM/BHoM/blob/develop/BHoM/HashFragment.cs)

All history and changes of the class can be found by inspection the history.
