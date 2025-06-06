---
title: SteppedGradient
---

# <small>BH.oM.Graphics.</small>**SteppedGradient**

Gradient for extracting colours in specific range bands, this is, a single colour for a specific range.

## Class structure

### Implemented interfaces and base types

???+ bhom "The SteppedGradient is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Graphics.[IGradient](/api/oM/Graphics/Graphics/Colours/IGradient)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Markers | [SortedDictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.SortedDictionary-2?view=netstandard-2.0)&lt;[decimal](https://learn.microsoft.com/en-us/dotnet/api/System.Decimal?view=netstandard-2.0), [Color](https://learn.microsoft.com/en-us/dotnet/api/System.Drawing.Color?view=netstandard-2.0)&gt; | A SortedDictionary of 'Color's using a 'decimal' between 0 and 1 as Key. Decimal of marker indicates the lower limit for the range of that colour. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| GradientLegend | [RenderMesh](/api/oM/Graphics/Graphics/Render/RenderMesh) | Constructs a RenderMesh corresponding to the gradient. | - | Graphics_Engine |
| IGradientLegend | [RenderMesh](/api/oM/Graphics/Graphics/Render/RenderMesh) | Constructs a RenderMesh corresponding to the gradient. | - | Graphics_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class SteppedGradient : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.Graphics.IGradient
```

Assembly: Graphics_oM.dll

The C# class definition is available on github:

- [SteppedGradient.cs](https://github.com/BHoM/BHoM/blob/develop/Graphics_oM/Colours\SteppedGradient.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Graphics_oM/SteppedGradient.json"
}
```

The JSON Schema is available on github here:

- [SteppedGradient.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Graphics_oM/SteppedGradient.json)
