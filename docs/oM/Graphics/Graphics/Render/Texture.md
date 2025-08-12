---
title: Texture
---

# <small>BH.oM.Graphics.</small>**Texture**

Texture material for rendering of geometry.

## Class structure

### Implemented interfaces and base types

???+ bhom "The Texture is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Name of the Texture | - |
| Diffuse | [Color](https://learn.microsoft.com/en-us/dotnet/api/System.Drawing.Color?view=netstandard-2.0) | The governing colour of the texture. The colour under direct illumination in white light. Alpha channel is generally ignored. Default is BHoM Coral (Color.FromArgb(255, 255, 41, 105)). | - |
| Ambient | [Color](https://learn.microsoft.com/en-us/dotnet/api/System.Drawing.Color?view=netstandard-2.0) | The colour under ambient lighting conditions. Alpha channel is generally ignored. Default is Gray. | - |
| Specular | [Color](https://learn.microsoft.com/en-us/dotnet/api/System.Drawing.Color?view=netstandard-2.0) | Controls shine and highlights. Alpha channel is generally ignored. Default is White. | - |
| Emission | [Color](https://learn.microsoft.com/en-us/dotnet/api/System.Drawing.Color?view=netstandard-2.0) | Self-illumination colour. Alpha channel is generally ignored. Default is a darker BHoM Coral (Color.FromArgb(255, 77, 12, 32)) | - |
| Transparency | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Level of transparency of the material. Should be a value between 0 and 1, where 0.0 is opaque and 1.0 is transparent. Defaults to fully opaque. | - |
| Shine | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Shine factor of the material. Should be a value between 0 and 1, where 0 is no shine and 1 is full shine. | - |
| BitmapTexture | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Optional file path to a image file to use as bitmap texture for the material. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class Texture : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: Graphics_oM.dll

The C# class definition is available on github:

- [Texture.cs](https://github.com/BHoM/BHoM/blob/develop/Graphics_oM/Render\Texture.cs)

All history and changes of the class can be found by inspection the history.
