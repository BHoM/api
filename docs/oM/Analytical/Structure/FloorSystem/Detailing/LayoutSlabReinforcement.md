---
title: LayoutSlabReinforcement
---

# <small>BH.oM.Structure.FloorSystem.</small>**LayoutSlabReinforcement**

Slab reinforcement for a floor configuration where the layout of the reinforcement has been explicitly defined.

## Class structure

### Implemented interfaces and base types

???+ bhom "The LayoutSlabReinforcement is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Structure.FloorSystem.[ISlabReinforcement](/api/oM/Analytical/Structure/FloorSystem/Detailing/ISlabReinforcement)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Reinforcement | [PanelRebarIntent](/api/oM/Analytical/Structure/Reinforcement/PanelRebarIntent) | Reinforcement intent for the slab, defining the layout of the reinforcement by region. Extents are normalized. | - |


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
public class LayoutSlabReinforcement : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.Structure.FloorSystem.ISlabReinforcement
```

Assembly: Structure_oM.dll

The C# class definition is available on github:

- [LayoutSlabReinforcement.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/FloorSystem\Detailing\LayoutSlabReinforcement.cs)

All history and changes of the class can be found by inspection the history.
