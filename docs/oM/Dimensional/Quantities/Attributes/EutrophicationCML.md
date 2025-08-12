---
title: EutrophicationCML
---

# <small>BH.oM.Quantities.Attributes.</small>**EutrophicationCML**

Quantity type for Eutrophication Potential for version 1 of list of indicators as defined in EN 15804+A1.

## Dimensions and units

### SI Unit [kg [PO₄]³⁻ eq]

EutrophicationCML is defined in [kg [PO₄]³⁻ eq] following the [International System of Units](https://en.wikipedia.org/wiki/International_System_of_Units) 

### Dimensions

The quantity is made up of the following [SI base units](https://en.wikipedia.org/wiki/SI_base_unit)

| Measure        | Dimension symbol | Quantity |
|------------------|--------|----------|
| Mass dimension |  M  |1  |

## Class structure

### Implemented interfaces and base types

???+ bhom "The EutrophicationCML is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Quantities.Attributes.[QuantityAttribute](/api/oM/Dimensional/Quantities/Attributes/Abstract/QuantityAttribute)
    -  BH.oM.Base.Attributes.[ClassificationAttribute](/api/oM/Framework/Base/Attributes/ClassificationAttribute)
    -  [Attribute](https://learn.microsoft.com/en-us/dotnet/api/System.Attribute?view=netstandard-2.0)
    -  BH.oM.Base.[IImmutable](/api/oM/Framework/Base/Interface/IImmutable)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)




## Code and Schema

### C# implementation

``` C# title="C#"
public class EutrophicationCML : BH.oM.Quantities.Attributes.QuantityAttribute,
BH.oM.Base.Attributes.ClassificationAttribute,
System.Attribute,
BH.oM.Base.IImmutable,
BH.oM.Base.IObject
```

Assembly: Quantities_oM.dll

The C# class definition is available on github:

- [EutrophicationCML.cs](https://github.com/BHoM/BHoM/blob/develop/Quantities_oM/Attributes\EutrophicationCML.cs)

All history and changes of the class can be found by inspection the history.
