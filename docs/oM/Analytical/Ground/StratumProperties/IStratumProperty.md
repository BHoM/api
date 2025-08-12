---
title: IStratumProperty
---

# <small>BH.oM.Ground.</small>**IStratumProperty**

Base interface for stratum properties.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IStratumProperty is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Ground.[StratumReference](/api/oM/Analytical/Ground/StratumProperties/StratumReference)


## Properties

### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IsValid | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a IStratumProperties is valid and outputs relevant error message. | - | Ground_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IStratumProperty : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: Ground_oM.dll

The C# interface definition is available on github:

- [IStratumProperty.cs](https://github.com/BHoM/BHoM/blob/develop/Ground_oM/StratumProperties\IStratumProperty.cs)

All history and changes of the class can be found by inspection the history.
