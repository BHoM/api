---
title: Illuminance
---

# <small>BH.oM.Quantities.Attributes.</small>**Illuminance**

Dimensional quantity as defined by the International System of Quantities

## Dimensions and units

### SI Unit [lux]

Illuminance is defined in [lux] following the [International System of Units](https://en.wikipedia.org/wiki/International_System_of_Units) 

### Dimensions

The quantity is made up of the following [SI base units](https://en.wikipedia.org/wiki/SI_base_unit)

| Measure        | Dimension symbol | Quantity |
|------------------|--------|----------|
| Length dimension |  L  |-2  |
| Luminous intensity dimension |  J  |1  |

## Class structure

### Implemented interfaces and base types

???+ bhom "The Illuminance is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Quantities.Attributes.[QuantityAttribute](/api/oM/Dimensional/Quantities/Attributes/Abstract/QuantityAttribute)
    -  BH.oM.Base.Attributes.[ClassificationAttribute](/api/oM/Framework/Base/Attributes/ClassificationAttribute)
    -  [Attribute](https://learn.microsoft.com/en-us/dotnet/api/System.Attribute?view=netstandard-2.0)
    -  BH.oM.Base.[IImmutable](/api/oM/Framework/Base/Interface/IImmutable)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)




## Code and Schema

### C# implementation

``` C# title="C#"
public class Illuminance : BH.oM.Quantities.Attributes.QuantityAttribute,
BH.oM.Base.Attributes.ClassificationAttribute,
System.Attribute,
BH.oM.Base.IImmutable,
BH.oM.Base.IObject
```

Assembly: Quantities_oM.dll

The class is defined in C#. The class definition is available on github:

- [Illuminance.cs](https://github.com/BHoM/BHoM/blob/develop/Quantities_oM/Attributes\Illuminance.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` { .json .copy .select } title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Quantities_oM/Attributes/Illuminance.json}
```

The JSON Schema is available on github here:

- [Illuminance.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Quantities_oM/Attributes/Illuminance.json)
