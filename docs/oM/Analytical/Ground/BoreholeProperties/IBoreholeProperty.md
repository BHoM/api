---
title: IBoreholeProperty
---

# <small>BH.oM.Ground.</small>**IBoreholeProperty**

Base interface for borehole properties.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IBoreholeProperty is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Ground.[BoreholeReference](/api/oM/Analytical/Ground/BoreholeProperties/BoreholeReference)
    - BH.oM.Ground.[Location](/api/oM/Analytical/Ground/BoreholeProperties/Location)
    - BH.oM.Ground.[Methodology](/api/oM/Analytical/Ground/BoreholeProperties/Methodology)


## Properties

### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IsValid | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a IBoreholeProperty is valid and outputs relevant error message. | - | Ground_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IBoreholeProperty : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: Ground_oM.dll

The C# interface definition is available on github:

- [IBoreholeProperty.cs](https://github.com/BHoM/BHoM/blob/develop/Ground_oM/BoreholeProperties\IBoreholeProperty.cs)

All history and changes of the class can be found by inspection the history.
