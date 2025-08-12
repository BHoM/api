---
title: IHashFragment
---

# <small>BH.oM.Base.</small>**IHashFragment**

Stores the hash of the parent BHoMObject.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IHashFragment is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Base.[HashFragment](/api/oM/Framework/Base/HashFragment)
    - BH.oM.Diffing.[RevisionFragment](/api/oM/Framework/Diffing/RevisionFragment)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Hash | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Hash of the parent BHoMObject. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IHashFragment : BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: BHoM.dll

The C# interface definition is available on github:

- [IHashFragment.cs](https://github.com/BHoM/BHoM/blob/develop/BHoM/Interface\IHashFragment.cs)

All history and changes of the class can be found by inspection the history.
