---
title: GradientOptions
---

# <small>BH.oM.Graphics.Colours.</small>**GradientOptions**

Defines options for range and centering for a Gradient.

## Class structure

### Implemented interfaces and base types

???+ bhom "The GradientOptions is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Name of the GradientOption. Will be displayed for Gradient legends. | - |
| Gradient | [IGradient](/api/oM/Graphics/Graphics/Colours/IGradient) | The Gradient to colour by. | - |
| LowerBound | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The lower bound of the Gradient. Leave empty to allow other methods to set automatically. | - |
| UpperBound | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The upper bound of the Gradient. Leave empty to allow other methods to set automatically. | - |
| GradientCenteringOptions | [GradientCenteringOptions](/api/oM/Graphics/Graphics/Enums/GradientCenteringOptions) | A GradientCenteringOptions enum to set centering options. Defaults to no centering. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| GradientLegend | [Output](/api/oM/Framework/Base/Output)&lt;[RenderMesh](/api/oM/Graphics/Graphics/Render/RenderMesh), [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[RenderText](/api/oM/Graphics/Graphics/Render/RenderText)&gt;, [RenderText](/api/oM/Graphics/Graphics/Render/RenderText)&gt; | Constructs a RenderMesh corresponding to the GradientOption with text markers corresponding to the numbers on the gradient markers. | - | Graphics_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class GradientOptions : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: Graphics_oM.dll

The C# class definition is available on github:

- [GradientOptions.cs](https://github.com/BHoM/BHoM/blob/develop/Graphics_oM/Colours\GradientOptions.cs)

All history and changes of the class can be found by inspection the history.
