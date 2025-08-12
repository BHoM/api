---
title: RenderCurve
---

# <small>BH.oM.Graphics.</small>**RenderCurve**

Render a curve with specified colour and thickness.

## Class structure

### Implemented interfaces and base types

???+ bhom "The RenderCurve is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Graphics.[IRender](/api/oM/Graphics/Graphics/Render/IRender)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Curve | [ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve) | The curve to render. | - |
| Thickness | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | The thickness of the curve. Should be a value greater or equal to 1. | - |
| Colour | [Color](https://learn.microsoft.com/en-us/dotnet/api/System.Drawing.Color?view=netstandard-2.0) | Colour used to render the Geometry. Default is BHoM Coral with a subtle transparency (Color.FromArgb(80, 255, 41, 105)). | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IBounds | [BoundingBox](/api/oM/Dimensional/Geometry/Misc/BoundingBox) | Computes and returns the BoundingBox of the IRender. | - | Graphics_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class RenderCurve : BH.oM.Graphics.IRender, BH.oM.Base.IObject
```

Assembly: Graphics_oM.dll

The C# class definition is available on github:

- [RenderCurve.cs](https://github.com/BHoM/BHoM/blob/develop/Graphics_oM/Render\RenderCurve.cs)

All history and changes of the class can be found by inspection the history.
