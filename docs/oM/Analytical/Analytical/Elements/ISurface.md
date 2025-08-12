---
title: ISurface
---

# <small>BH.oM.Analytical.Elements.</small>**ISurface**



## Interface structure

### Implemented interfaces and base types

???+ bhom "The ISurface is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Analytical.[IAnalytical](/api/oM/Analytical/Analytical/IAnalytical)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Structure.Elements.[Surface](/api/oM/Analytical/Structure/Elements/Surface)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Extents | [ISurface](/api/oM/Dimensional/Geometry/Surface/ISurface) | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Geometry | [IGeometry](/api/oM/Dimensional/Geometry/Interface/IGeometry) | Gets the geometry of a analytical ISurface at its centre. Method required for automatic display in UI packages. | - | Analytical_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface ISurface : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.Analytical.IAnalytical
```

Assembly: Analytical_oM.dll

The C# interface definition is available on github:

- [ISurface.cs](https://github.com/BHoM/BHoM/blob/develop/Analytical_oM/Elements\ISurface.cs)

All history and changes of the class can be found by inspection the history.
