---
title: IReinforcingBar
---

# <small>BH.oM.Physical.Reinforcement.</small>**IReinforcingBar**

Base interface for all reinforcement bars.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IReinforcingBar is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Physical.Reinforcement.[PrimaryReinforcingBar](/api/oM/Physical/Physical/Reinforcement/PrimaryReinforcingBar)
    - BH.oM.Physical.Reinforcement.[Stirrup](/api/oM/Physical/Physical/Reinforcement/Stirrup)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| CentreCurve | [ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve) | Centreline of the reinforcement bar in three-dimensional space. When the BendRadius is sufficient for any kinks in the rebar, this can be defined as a polyline, ommiting any arcs in corners. | - |
| Diameter | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| Material | [Material](/api/oM/Physical/Physical/Materials/Material) | - | - |
| BendRadius | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Bend radius used for any discontinuities in the CentreCurve. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IReinforcingBar : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: Physical_oM.dll

The C# interface definition is available on github:

- [IReinforcingBar.cs](https://github.com/BHoM/BHoM/blob/develop/Physical_oM/Reinforcement\IReinforcingBar.cs)

All history and changes of the class can be found by inspection the history.
