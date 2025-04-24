---
title: OzoneDepletion
---

# <small>BH.oM.Quantities.</small>**OzoneDepletion**

Quantity type for Ozone Depletion Potential.

## Dimensions and units

### [kg CFC11 eq]

Pressure is defined in the [SI unit](https://bhom.xyz/documentation/BHoM_oM/BHoM-Units-conventions/) [kg CFC11 eq]

### Dimensions

The quantity is made up of the following [SI base units](https://en.wikipedia.org/wiki/SI_base_unit)

| Measure        | Dimension symbol | Quantity |
|------------------|--------|----------|
| Mass dimension |  M  |1  |


## Class structure

### Implemented interfaces and base types

???+ bhom "The OzoneDepletion is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Quantities.Attributes.[QuantityAttribute](/api/oM/Dimensional/Quantities/Attributes/Abstract/QuantityAttribute)
    -  BH.oM.Base.Attributes.[ClassificationAttribute](/api/oM/Framework/Base/Attributes/ClassificationAttribute)
    -  [Attribute](https://learn.microsoft.com/en-us/dotnet/api/System.Attribute?view=netstandard-2.0)
    -  BH.oM.Base.[IImmutable](/api/oM/Framework/Base/Interface/IImmutable)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)




## Code and Schema

### C# implementation

``` C# title="C#"
public class OzoneDepletion : BH.oM.Quantities.Attributes.QuantityAttribute,
BH.oM.Base.Attributes.ClassificationAttribute,
System.Attribute,
BH.oM.Base.IImmutable,
BH.oM.Base.IObject
```

Assembly: Quantities_oM.dll

The class is defined in C#. The class definition is available on github:

- [OzoneDepletion.cs](https://github.com/BHoM/BHoM/blob/develop/Quantities_oM/Attributes\OzoneDepletion.cs)

All history and changes of the class can be found by inspection the history.
