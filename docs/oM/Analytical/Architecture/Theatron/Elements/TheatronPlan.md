---
title: TheatronPlan
---

# <small>BH.oM.Architecture.Theatron.</small>**TheatronPlan**



## Class structure

### Implemented interfaces and base types

???+ bhom "The TheatronPlan is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| SectionOrigins | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ProfileOrigin](/api/oM/Analytical/Architecture/Theatron/Elements/ProfileOrigin)&gt; | - | - |
| ActivityArea | [ActivityArea](/api/oM/Analytical/Architecture/Theatron/Elements/ActivityArea) | Activity area is used for evaluating Avalue and Evalues | - |
| FocalCurve | [Polyline](/api/oM/Dimensional/Geometry/Curve/Polyline) | Focal curve is used for defining Cvalue focal points | - |
| VomitoryOrigins | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ProfileOrigin](/api/oM/Analytical/Architecture/Theatron/Elements/ProfileOrigin)&gt; | - | - |
| CombinedOrigins | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ProfileOrigin](/api/oM/Analytical/Architecture/Theatron/Elements/ProfileOrigin)&gt; | - | - |
| StructBayType | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[BayType](/api/oM/Analytical/Architecture/Theatron/Enums/BayType)&gt; | - | - |
| SectionClosestToFocalCurve | [ProfileOrigin](/api/oM/Analytical/Architecture/Theatron/Elements/ProfileOrigin) | - | - |
| MinDistToFocalCurve | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| CValueFocalPoint | [Point](/api/oM/Dimensional/Geometry/Vector/Point) | - | - |
| TheatronFront | [ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve) | - | - |
| SeatingBlockType | [SeatingBlockType](/api/oM/Analytical/Architecture/Theatron/Enums/SeatingBlockType) | - | - |


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
public class TheatronPlan : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: Architecture_oM.dll

The C# class definition is available on github:

- [TheatronPlan.cs](https://github.com/BHoM/BHoM/blob/develop/Architecture_oM/Theatron\Elements\TheatronPlan.cs)

All history and changes of the class can be found by inspection the history.
