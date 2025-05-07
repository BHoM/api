---
title: AbioticDepletionMineralsAndMetals
---

# <small>BH.oM.Quantities.Attributes.</small>**AbioticDepletionMineralsAndMetals**

Quantity type for Abiotic depletion potential (ADP) for minerals and metals (non-fossil resources).

## Dimensions and units

### SI Unit [kg Sb eq]

AbioticDepletionMineralsAndMetals is defined in [kg Sb eq] following the [International System of Units](https://en.wikipedia.org/wiki/International_System_of_Units) 

### Dimensions

The quantity is made up of the following [SI base units](https://en.wikipedia.org/wiki/SI_base_unit)

| Measure        | Dimension symbol | Quantity |
|------------------|--------|----------|
| Mass dimension |  M  |1  |

## Class structure

### Implemented interfaces and base types

???+ bhom "The AbioticDepletionMineralsAndMetals is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Quantities.Attributes.[QuantityAttribute](/api/oM/Dimensional/Quantities/Attributes/Abstract/QuantityAttribute)
    -  BH.oM.Base.Attributes.[ClassificationAttribute](/api/oM/Framework/Base/Attributes/ClassificationAttribute)
    -  [Attribute](https://learn.microsoft.com/en-us/dotnet/api/System.Attribute?view=netstandard-2.0)
    -  BH.oM.Base.[IImmutable](/api/oM/Framework/Base/Interface/IImmutable)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)




## Code and Schema

### C# implementation

``` C# title="C#"
public class AbioticDepletionMineralsAndMetals : BH.oM.Quantities.Attributes.QuantityAttribute,
BH.oM.Base.Attributes.ClassificationAttribute,
System.Attribute,
BH.oM.Base.IImmutable,
BH.oM.Base.IObject
```

Assembly: Quantities_oM.dll

The C# class definition is available on github:

- [AbioticDepletionMineralsAndMetals.cs](https://github.com/BHoM/BHoM/blob/develop/Quantities_oM/Attributes\AbioticDepletionMineralsAndMetals.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Quantities_oM/Attributes/AbioticDepletionMineralsAndMetals.json"
}
```

The JSON Schema is available on github here:

- [AbioticDepletionMineralsAndMetals.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Quantities_oM/Attributes/AbioticDepletionMineralsAndMetals.json)
