---
title: IRender
---

# <small>BH.oM.Graphics.</small>**IRender**

Base interface for rendered objects.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IRender is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Graphics.[RenderCurve](/api/oM/Graphics/Graphics/Render/RenderCurve)
    - BH.oM.Graphics.[RenderGeometry](/api/oM/Graphics/Graphics/Render/RenderGeometry)
    - BH.oM.Graphics.[RenderPoint](/api/oM/Graphics/Graphics/Render/RenderPoint)
    - BH.oM.Graphics.[RenderText](/api/oM/Graphics/Graphics/Render/RenderText)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Colour | [Color](https://learn.microsoft.com/en-us/dotnet/api/System.Drawing.Color?view=netstandard-2.0) | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IBounds | [BoundingBox](/api/oM/Dimensional/Geometry/Misc/BoundingBox) | Computes and returns the BoundingBox of the IRender. | - | Graphics_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IRender : BH.oM.Base.IObject
```

Assembly: Graphics_oM.dll

The C# interface definition is available on github:

- [IRender.cs](https://github.com/BHoM/BHoM/blob/develop/Graphics_oM/Render\IRender.cs)

All history and changes of the class can be found by inspection the history.
