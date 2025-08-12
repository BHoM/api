---
title: IFixtureUsage
---

# <small>BH.oM.MEP.Fixtures.</small>**IFixtureUsage**

Base interface for all Fixture objects. These objects are capable of containing a material or element that flows through the object.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IFixtureUsage is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Base.[IImmutable](/api/oM/Framework/Base/Interface/IImmutable)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.MEP.Fixtures.[CommercialFixtureUsage](/api/oM/Analytical/MEP/Fixtures/CommercialFixtureUsage)
    - BH.oM.MEP.Fixtures.[ResidentialFixtureUsage](/api/oM/Analytical/MEP/Fixtures/ResidentialFixtureUsage)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface IFixtureUsage : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.Base.IImmutable
```

Assembly: MEP_oM.dll

The C# interface definition is available on github:

- [IFixtureUsage.cs](https://github.com/BHoM/BHoM/blob/develop/MEP_oM/Fixtures\IFixtureUsage.cs)

All history and changes of the class can be found by inspection the history.
