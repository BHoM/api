---
title: ConcreteVolumeOverride
---

# <small>BH.oM.Structure.FloorSystem.</small>**ConcreteVolumeOverride**

Overrides the concrete volume per unit area of a slab on deck, instead of calculating it from the slab properties. The volume of the deck is still calculated from the slab on deck properties.

## Class structure

### Implemented interfaces and base types

???+ bhom "The ConcreteVolumeOverride is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| VolumePerArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Volume of concrete per unit area of the slab. Replaces the concrete volume otherwise derived from the slab on deck properties. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |


## Code and Schema

### C# implementation

``` C# title="C#"
public class ConcreteVolumeOverride : BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: Structure_oM.dll

The C# class definition is available on github:

- [ConcreteVolumeOverride.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/FloorSystem\Detailing\ConcreteVolumeOverride.cs)

All history and changes of the class can be found by inspection the history.
