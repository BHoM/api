---
title: GraphRepresentation
---

# <small>BH.oM.Graphics.Fragments.</small>**GraphRepresentation**

Fragment for graph representation.

## Class structure

### Implemented interfaces and base types

???+ bhom "The GraphRepresentation is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Graphics.Fragments.[IRepresentationFragment](/api/oM/Graphics/Graphics/Fragments/IRepresentationFragment)
    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Groups | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[GroupRepresentation](/api/oM/Graphics/Graphics/Fragments/GroupRepresentation)&gt; | - | - |
| Text | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| TextPosition | [Point](/api/oM/Dimensional/Geometry/Vector/Point) | - | - |
| TextDirection | [Vector](/api/oM/Dimensional/Geometry/Vector/Vector) | - | - |
| Colour | [Color](https://learn.microsoft.com/en-us/dotnet/api/System.Drawing.Color?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class GraphRepresentation : BH.oM.Graphics.Fragments.IRepresentationFragment, BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: Graphics_oM.dll

The C# class definition is available on github:

- [GraphRepresentation.cs](https://github.com/BHoM/BHoM/blob/develop/Graphics_oM/Fragments\GraphRepresentation.cs)

All history and changes of the class can be found by inspection the history.
