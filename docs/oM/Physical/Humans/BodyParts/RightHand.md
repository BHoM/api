---
title: RightHand
---

# <small>BH.oM.Humans.BodyParts.</small>**RightHand**



## Class structure

### Implemented interfaces and base types

???+ bhom "The RightHand is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Humans.Interfaces.[ILineBodyPart](/api/oM/Physical/Humans/Interfaces/ILineBodyPart)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Humans.Interfaces.[IPointBodyPart](/api/oM/Physical/Humans/Interfaces/IPointBodyPart)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| TrackingPoint | [Point](/api/oM/Dimensional/Geometry/Vector/Point) | - | - |
| TrackingLine | [Line](/api/oM/Dimensional/Geometry/Curve/Line) | - | - |
| State | [HandStateName](/api/oM/Physical/Humans/Enums/HandStateName) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class RightHand : BH.oM.Humans.Interfaces.ILineBodyPart, BH.oM.Base.IObject, BH.oM.Humans.Interfaces.IPointBodyPart
```

Assembly: Humans_oM.dll

The C# class definition is available on github:

- [RightHand.cs](https://github.com/BHoM/BHoM/blob/develop/Humans_oM/BodyParts\RightHand.cs)

All history and changes of the class can be found by inspection the history.
