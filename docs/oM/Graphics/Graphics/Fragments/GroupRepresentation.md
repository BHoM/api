---
title: GroupRepresentation
---

# <small>BH.oM.Graphics.Fragments.</small>**GroupRepresentation**

Fragment for group representation.

## Class structure

### Implemented interfaces and base types

???+ bhom "The GroupRepresentation is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Graphics.Fragments.[IRepresentationFragment](/api/oM/Graphics/Graphics/Fragments/IRepresentationFragment)
    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Boundary | [ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve) | - | - |
| Text | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| TextPosition | [Point](/api/oM/Dimensional/Geometry/Vector/Point) | - | - |
| TextDirection | [Vector](/api/oM/Dimensional/Geometry/Vector/Vector) | - | - |
| Colour | [Color](https://learn.microsoft.com/en-us/dotnet/api/System.Drawing.Color?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class GroupRepresentation : BH.oM.Graphics.Fragments.IRepresentationFragment, BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: Graphics_oM.dll

The C# class definition is available on github:

- [GroupRepresentation.cs](https://github.com/BHoM/BHoM/blob/develop/Graphics_oM/Fragments\GroupRepresentation.cs)

All history and changes of the class can be found by inspection the history.
