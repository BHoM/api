---
title: EnvironmentConstructionFragment
---

# <small>BH.oM.Environment.Fragments.</small>**EnvironmentConstructionFragment**

Fragment containing the F-factor and additional heat transfer construction property

## Class structure

### Implemented interfaces and base types

???+ bhom "The EnvironmentConstructionFragment is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| FFactor | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The perimeter heat loss factor for slab-on-grade floors | - |
| AdditionalHeatTransfer | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class EnvironmentConstructionFragment : BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: Environment_oM.dll

The C# class definition is available on github:

- [EnvironmentConstructionFragment.cs](https://github.com/BHoM/BHoM/blob/develop/Environment_oM/Fragments\EnvironmentConstructionFragment.cs)

All history and changes of the class can be found by inspection the history.
