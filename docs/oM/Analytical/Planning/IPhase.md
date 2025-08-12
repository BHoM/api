---
title: IPhase
---

# <small>BH.oM.Planning.</small>**IPhase**



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IPhase is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Planning.[ConstructionPhase](/api/oM/Analytical/Planning/Construction/ConstructionPhase)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| StartTime | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/System.DateTime?view=netstandard-2.0) | - | - |
| EndTime | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/System.DateTime?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IPhase : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: Planning_oM.dll

The C# interface definition is available on github:

- [IPhase.cs](https://github.com/BHoM/BHoM/blob/develop/Planning_oM/IPhase.cs)

All history and changes of the class can be found by inspection the history.
