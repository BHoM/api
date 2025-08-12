---
title: RenderGeometry
---

# <small>BH.oM.Graphics.</small>**RenderGeometry**

Render geometry with a specific colour.

## Class structure

### Implemented interfaces and base types

???+ bhom "The RenderGeometry is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Graphics.[IRender](/api/oM/Graphics/Graphics/Render/IRender)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Geometry | [IGeometry](/api/oM/Dimensional/Geometry/Interface/IGeometry) | A geometry (or many geometry objects collected into a single `CompositeGeometry` object). | - |
| Colour | [Color](https://learn.microsoft.com/en-us/dotnet/api/System.Drawing.Color?view=netstandard-2.0) | Colour used to render the edges of the Geometry. If texture is not set, this colour will also be used to render any meshes and surfaces of the Geometry. Default is BHoM Coral with a subtle transparency (Color.FromArgb(80, 255, 41, 105)). | - |
| SurfaceColour | [Texture](/api/oM/Graphics/Graphics/Render/Texture) | Optional texture or colour to be used for mesh and surface geometry. If null, the colour will be used for mesh and surface rendering instead. | - |
| EdgeThickness | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | The thickness of the curve. Should be a value greater or equal to 1. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Bounds | [BoundingBox](/api/oM/Dimensional/Geometry/Misc/BoundingBox) | Computes and returns the BoundingBox of the RenderGeometry as the bounding box of the its Geometry. | - | Graphics_Engine |
| IBounds | [BoundingBox](/api/oM/Dimensional/Geometry/Misc/BoundingBox) | Computes and returns the BoundingBox of the IRender. | - | Graphics_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class RenderGeometry : BH.oM.Graphics.IRender, BH.oM.Base.IObject
```

Assembly: Graphics_oM.dll

The C# class definition is available on github:

- [RenderGeometry.cs](https://github.com/BHoM/BHoM/blob/develop/Graphics_oM/Render\RenderGeometry.cs)

All history and changes of the class can be found by inspection the history.
