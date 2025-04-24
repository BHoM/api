---
title: ElectricConductance
---

# <small>BH.oM.Quantities.</small>**ElectricConductance**

Dimensional quantity as defined by the International System of Quantities

## Dimensions and units

### [S]

Pressure is defined in the [SI unit](https://bhom.xyz/documentation/BHoM_oM/BHoM-Units-conventions/) [S]

### Dimensions

The quantity is made up of the following [SI base units](https://en.wikipedia.org/wiki/SI_base_unit)

| Measure        | Dimension symbol | Quantity |
|------------------|--------|----------|
| Mass dimension |  M  |-1  |
| Length dimension |  L  |-2  |
| Time dimension |  T  |3  |
| Electric current dimension |  I  |2  |


## Class structure

### Implemented interfaces and base types

???+ bhom "The ElectricConductance is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Quantities.Attributes.[QuantityAttribute](/api/oM/Dimensional/Quantities/Attributes/Abstract/QuantityAttribute)
    -  BH.oM.Base.Attributes.[ClassificationAttribute](/api/oM/Framework/Base/Attributes/ClassificationAttribute)
    -  [Attribute](https://learn.microsoft.com/en-us/dotnet/api/System.Attribute?view=netstandard-2.0)
    -  BH.oM.Base.[IImmutable](/api/oM/Framework/Base/Interface/IImmutable)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)




## Code and Schema

### C# implementation

``` C# title="C#"
public class ElectricConductance : BH.oM.Quantities.Attributes.QuantityAttribute,
BH.oM.Base.Attributes.ClassificationAttribute,
System.Attribute,
BH.oM.Base.IImmutable,
BH.oM.Base.IObject
```

Assembly: Quantities_oM.dll

The class is defined in C#. The class definition is available on github:

- [ElectricConductance.cs](https://github.com/BHoM/BHoM/blob/develop/Quantities_oM/Attributes\ElectricConductance.cs)

All history and changes of the class can be found by inspection the history.
