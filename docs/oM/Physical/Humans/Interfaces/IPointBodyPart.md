---
title: IPointBodyPart
---

# <small>BH.oM.Humans.Interfaces.</small>**IPointBodyPart**



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IPointBodyPart is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Humans.BodyParts.[Eye](/api/oM/Physical/Humans/BodyParts/Eye)
    - BH.oM.Humans.BodyParts.[Head](/api/oM/Physical/Humans/BodyParts/Head)
    - BH.oM.Humans.BodyParts.[LeftHand](/api/oM/Physical/Humans/BodyParts/LeftHand)
    - BH.oM.Humans.BodyParts.[LeftThumb](/api/oM/Physical/Humans/BodyParts/LeftThumb)
    - BH.oM.Humans.BodyParts.[PairOfEyes](/api/oM/Physical/Humans/BodyParts/PairOfEyes)
    - BH.oM.Humans.BodyParts.[RightHand](/api/oM/Physical/Humans/BodyParts/RightHand)
    - BH.oM.Humans.BodyParts.[RightThumb](/api/oM/Physical/Humans/BodyParts/RightThumb)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| TrackingPoint | [Point](/api/oM/Dimensional/Geometry/Vector/Point) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IPointBodyPart : BH.oM.Base.IObject
```

Assembly: Humans_oM.dll

The C# interface definition is available on github:

- [IPointBodyPart.cs](https://github.com/BHoM/BHoM/blob/develop/Humans_oM/Interfaces\IPointBodyPart.cs)

All history and changes of the class can be found by inspection the history.
