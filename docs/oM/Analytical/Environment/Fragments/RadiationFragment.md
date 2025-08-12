---
title: RadiationFragment
---

# <small>BH.oM.Environment.Fragments.</small>**RadiationFragment**

Fragment containing the lighting, occupant and equipment radiation amount

## Class structure

### Implemented interfaces and base types

???+ bhom "The RadiationFragment is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| LightingRadiation | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| OccupantRadiation | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| EquipmentRadiation | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class RadiationFragment : BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: Environment_oM.dll

The C# class definition is available on github:

- [RadiationFragment.cs](https://github.com/BHoM/BHoM/blob/develop/Environment_oM/Fragments\RadiationFragment.cs)

All history and changes of the class can be found by inspection the history.
