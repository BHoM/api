---
title: SectionProfile
---

# <small>BH.oM.MEP.System.SectionProperties.</small>**SectionProfile**



## Class structure

### Implemented interfaces and base types

???+ bhom "The SectionProfile is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Base.[IImmutable](/api/oM/Framework/Base/Interface/IImmutable)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ElementProfile | [IProfile](/api/oM/Dimensional/Spatial/ShapeProfiles/IProfile) | ShapeProfile of the element itself. This is the base ShapeProfile that determines the overall shape of the IFlow object. | - |
| LiningProfile | [IProfile](/api/oM/Dimensional/Spatial/ShapeProfiles/IProfile) | ShapeProfile of the element's interior lining. | - |
| InsulationProfile | [IProfile](/api/oM/Dimensional/Spatial/ShapeProfiles/IProfile) | ShapeProfile of the element's exterior insulation. | - |


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
public class SectionProfile : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.Base.IImmutable
```

Assembly: MEP_oM.dll

The C# class definition is available on github:

- [SectionProfile.cs](https://github.com/BHoM/BHoM/blob/develop/MEP_oM/System\SectionProperties\SectionProfile.cs)

All history and changes of the class can be found by inspection the history.
