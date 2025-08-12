---
title: TheatronFullProfile
---

# <small>BH.oM.Architecture.Theatron.</small>**TheatronFullProfile**



## Class structure

### Implemented interfaces and base types

???+ bhom "The TheatronFullProfile is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BaseTierProfiles | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[TierProfile](/api/oM/Analytical/Architecture/Theatron/Elements/TierProfile)&gt; | The set of tier profiles orientated in the world xz plane, the origin is the focal point for Cvalue calculations | - |
| MappedProfiles | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[TierProfile](/api/oM/Analytical/Architecture/Theatron/Elements/TierProfile)&gt; | The set of tier profiles orientated to the plane closest to the focal curve | - |
| Rounding | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| FullProfileOrigin | [ProfileOrigin](/api/oM/Analytical/Architecture/Theatron/Elements/ProfileOrigin) | The plane at the first surface point, x axis is horizontal and points away from the playing area, y axis points up | - |


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
| Geometry | [CompositeGeometry](/api/oM/Dimensional/Geometry/Misc/CompositeGeometry) | Extracts geometry of the given TheatronFullProfile. | - | Architecture_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class TheatronFullProfile : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: Architecture_oM.dll

The C# class definition is available on github:

- [TheatronFullProfile.cs](https://github.com/BHoM/BHoM/blob/develop/Architecture_oM/Theatron\Elements\TheatronFullProfile.cs)

All history and changes of the class can be found by inspection the history.
