---
title: RepresentationOptions
---

# <small>BH.oM.Graphics.</small>**RepresentationOptions**

Defines options for the Representation of BHoM Objects.

## Class structure

### Implemented interfaces and base types

???+ bhom "The RepresentationOptions is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Detailed0DElements | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true, 0D elements are detailed.<br>If `true`, Points are represented by Spheres.<br>For discipline-specific objects, `true` may correspond to e.g. a composite geometry computed based on their properties. | - |
| Element0DScale | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Scale the Element0D representation. | - |
| Detailed1DElements | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true, 1D elements are detailed.<br>If `true`, Lines are represented by Pipes. For discipline-specific objects, `true` may correspond to e.g. an Extrusion using a cross section property; `false` to pipe using a centreline. | - |
| Element1DScale | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Scale the Element1D representation, if applicable.<br>For Lines, this increases the Pipe size.<br>Discipline-specific representations might not be affected by this parameter. | - |
| Cap1DElements | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Cap 1D elements, if applicable.<br>E.g. for a Line, this caps the computed Pipe.<br>For discipline-specific objects, it may e.g. cap the Extrusions of their cross section. | - |
| Detailed2DElements | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true, 2D elements are detailed.<br>For discipline-specific objects, `true` may correspond to e.g. a box-like geometry representing the 2D element with their thickness, based on its cross section; `false` to e.g. their the middle surface. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class RepresentationOptions : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: Graphics_oM.dll

The C# class definition is available on github:

- [RepresentationOptions.cs](https://github.com/BHoM/BHoM/blob/develop/Graphics_oM/Render\RepresentationOptions.cs)

All history and changes of the class can be found by inspection the history.
