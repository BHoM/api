---
title: Quantity&lt;T&gt;
---

# <small>BH.oM.Quantities.</small>**Quantity&lt;T&gt;**

Represents a numerical value with a quantity type attached to it. The quantity type includes dimensionality as well as SI unit.

## Class structure

### Generic parameters

The Quantity contains the following generic paramters:

#### T

Constrained by the following arguments:

- BH.oM.Quantities.Attributes.[QuantityAttribute](/api/oM/Dimensional/Quantities/Attributes/Abstract/QuantityAttribute)

### Implemented interfaces and base types

???+ bhom "The Quantity`1 is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Quantities.[IQuantity](/api/oM/Dimensional/Quantities/IQuantity)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Value | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class Quantity`1 : BH.oM.Quantities.IQuantity, BH.oM.Base.IObject
```

Assembly: Quantities_oM.dll

The C# class definition is available on github:

- [Quantity.cs](https://github.com/BHoM/BHoM/blob/develop/Quantities_oM/Quantity.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Quantities_oM/Quantity`1.json"
}
```

The JSON Schema is available on github here:

- [Quantity`1.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Quantities_oM/Quantity`1.json)
