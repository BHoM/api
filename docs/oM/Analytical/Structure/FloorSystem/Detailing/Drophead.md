---
title: Drophead
---

# <small>BH.oM.Structure.FloorSystem.</small>**Drophead**

Drophead on a flat slab, i.e. a local thickening of the slab over a column. Thickness is additional to the thickness of the main slab. The material of the drophead is taken from the main slab property.
Also applicable to be used with waffle slabs for a solid zone over dropheads.

## Class structure

### Implemented interfaces and base types

???+ bhom "The Drophead is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Thickness | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Thickness of the drophead. The total thickness of the slab in the drophead zone will be the slab thickness + drophead thickness. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| XDimension | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Extent of the drophead in the local x (primary) direction. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| YDimension | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Extent of the drophead in the local y (secondary) direction. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| Reinforcement | [ReinforcementDensity](/api/oM/Analytical/Structure/Fragments/ReinforcementDensity) | Amount of reinforcement in the dropheads. Will be null if handled by the general Reinforcement layout. | - |


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
public class Drophead : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: Structure_oM.dll

The C# class definition is available on github:

- [Drophead.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/FloorSystem\Detailing\Drophead.cs)

All history and changes of the class can be found by inspection the history.
