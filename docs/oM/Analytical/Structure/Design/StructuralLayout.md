---
title: StructuralLayout
---

# <small>BH.oM.Structure.Design.</small>**StructuralLayout**



## Class structure

### Implemented interfaces and base types

???+ bhom "The StructuralLayout is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Structure.Design.[IDesignable](/api/oM/Analytical/Structure/Design/IDesignable)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| AnalyticBars | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Bar](/api/oM/Analytical/Structure/Elements/Bar)&gt; | - | - |
| MajorAxisSpans | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Span](/api/oM/Analytical/Structure/Design/Span)&gt; | - | - |
| MinorAxisSpans | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Span](/api/oM/Analytical/Structure/Design/Span)&gt; | - | - |
| LateralTorsionalSpans | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Span](/api/oM/Analytical/Structure/Design/Span)&gt; | - | - |
| StructuralUsage | [StructuralUsage1D](/api/oM/Analytical/Structure/Elements/Enums/StructuralUsage1d) | - | - |


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
public class StructuralLayout : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.Structure.Design.IDesignable
```

Assembly: Structure_oM.dll

The C# class definition is available on github:

- [StructuralLayout.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/Design\StructuralLayout.cs)

All history and changes of the class can be found by inspection the history.
