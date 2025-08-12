---
title: RenderText
---

# <small>BH.oM.Graphics.</small>**RenderText**

Render text at a location and orientation in space with specified height, font and colour.

## Class structure

### Implemented interfaces and base types

???+ bhom "The RenderText is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Graphics.[IRender](/api/oM/Graphics/Graphics/Render/IRender)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Text | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The text to render. | - |
| Cartesian | [Cartesian](/api/oM/Dimensional/Geometry/CoordinateSystem/Cartesian) | Cartesian to locate and orientate the text. | - |
| Height | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Height of the text. Default is 1. Units will be determined by the setting of the user interface that renders the text. | - |
| FontName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Font used to render the text. Default is Arial. | - |
| Colour | [Color](https://learn.microsoft.com/en-us/dotnet/api/System.Drawing.Color?view=netstandard-2.0) | Colour used to render the text. Default is BHoM Coral with a subtle transparency (Color.FromArgb(80, 255, 41, 105)). | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IBounds | [BoundingBox](/api/oM/Dimensional/Geometry/Misc/BoundingBox) | Computes and returns the BoundingBox of the IRender. | - | Graphics_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class RenderText : BH.oM.Graphics.IRender, BH.oM.Base.IObject
```

Assembly: Graphics_oM.dll

The C# class definition is available on github:

- [RenderText.cs](https://github.com/BHoM/BHoM/blob/develop/Graphics_oM/Render\RenderText.cs)

All history and changes of the class can be found by inspection the history.
