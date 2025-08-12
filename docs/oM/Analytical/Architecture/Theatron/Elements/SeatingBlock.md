---
title: SeatingBlock
---

# <small>BH.oM.Architecture.Theatron.</small>**SeatingBlock**



## Class structure

### Implemented interfaces and base types

???+ bhom "The SeatingBlock is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Start | [ProfileOrigin](/api/oM/Analytical/Architecture/Theatron/Elements/ProfileOrigin) | - | - |
| Vomitory | [ProfileOrigin](/api/oM/Analytical/Architecture/Theatron/Elements/ProfileOrigin) | - | - |
| End | [ProfileOrigin](/api/oM/Analytical/Architecture/Theatron/Elements/ProfileOrigin) | - | - |
| Sections | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[TierProfile](/api/oM/Analytical/Architecture/Theatron/Elements/TierProfile)&gt; | - | - |
| Floor | [Mesh](/api/oM/Dimensional/Geometry/Mesh/Mesh) | - | - |
| Audience | [Audience](/api/oM/Physical/Humans/ViewQuality/Audience) | - | - |
| FrontRow | [Line](/api/oM/Dimensional/Geometry/Curve/Line) | - | - |
| SeatWidth | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| AisleWidth | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| TypeOfSeatingBlock | [SeatingBlockType](/api/oM/Analytical/Architecture/Theatron/Enums/SeatingBlockType) | - | - |


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
public class SeatingBlock : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: Architecture_oM.dll

The C# class definition is available on github:

- [SeatingBlock.cs](https://github.com/BHoM/BHoM/blob/develop/Architecture_oM/Theatron\Elements\SeatingBlock.cs)

All history and changes of the class can be found by inspection the history.
