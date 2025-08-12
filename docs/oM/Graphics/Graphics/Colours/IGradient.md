---
title: IGradient
---

# <small>BH.oM.Graphics.</small>**IGradient**



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IGradient is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Graphics.[Gradient](/api/oM/Graphics/Graphics/Colours/Gradient)
    - BH.oM.Graphics.[SteppedGradient](/api/oM/Graphics/Graphics/Colours/SteppedGradient)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Markers | [SortedDictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.SortedDictionary-2?view=netstandard-2.0)&lt;[decimal](https://learn.microsoft.com/en-us/dotnet/api/System.Decimal?view=netstandard-2.0), [Color](https://learn.microsoft.com/en-us/dotnet/api/System.Drawing.Color?view=netstandard-2.0)&gt; | A SortedDictionary of 'Color's using a 'decimal' between 0 and 1 as Key. Used to get a 'Color' from a value between 0 and 1 | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IGradientLegend | [RenderMesh](/api/oM/Graphics/Graphics/Render/RenderMesh) | Constructs a RenderMesh corresponding to the gradient. | - | Graphics_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IGradient : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: Graphics_oM.dll

The C# interface definition is available on github:

- [IGradient.cs](https://github.com/BHoM/BHoM/blob/develop/Graphics_oM/Colours\IGradient.cs)

All history and changes of the class can be found by inspection the history.
