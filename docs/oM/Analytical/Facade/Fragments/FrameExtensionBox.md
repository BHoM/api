---
title: FrameExtensionBox
---

# <small>BH.oM.Facade.Fragments.</small>**FrameExtensionBox**

Fragment containing a curve enclosing the portion of a mullion cross section that will be extruded by Facade_Engine method that changes mullion profile depth.

## Class structure

### Implemented interfaces and base types

???+ bhom "The FrameExtensionBox is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BoundingBoxCurve | [ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve) | ICurve representing the mullion bounding box. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class FrameExtensionBox : BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: Facade_oM.dll

The C# class definition is available on github:

- [FrameExtensionBox.cs](https://github.com/BHoM/BHoM/blob/develop/Facade_oM/Fragments\FrameExtensionBox.cs)

All history and changes of the class can be found by inspection the history.
