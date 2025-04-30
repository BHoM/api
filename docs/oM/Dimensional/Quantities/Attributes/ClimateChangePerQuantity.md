---
title: ClimateChangePerQuantity
---

# <small>BH.oM.Quantities.Attributes.</small>**ClimateChangePerQuantity**

Quantity type for climate change per quantity.

## Dimensions and units

### SI Unit [kg CO2 eq per unit]

ClimateChangePerQuantity is defined in [kg CO2 eq per unit] following the [International System of Units](https://en.wikipedia.org/wiki/International_System_of_Units) 

### Dimensions

The quantity is dimensionless.


## Class structure

### Implemented interfaces and base types

???+ bhom "The ClimateChangePerQuantity is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Quantities.Attributes.[QuantityAttribute](/api/oM/Dimensional/Quantities/Attributes/Abstract/QuantityAttribute)
    -  BH.oM.Base.Attributes.[ClassificationAttribute](/api/oM/Framework/Base/Attributes/ClassificationAttribute)
    -  [Attribute](https://learn.microsoft.com/en-us/dotnet/api/System.Attribute?view=netstandard-2.0)
    -  BH.oM.Base.[IImmutable](/api/oM/Framework/Base/Interface/IImmutable)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)




## Code and Schema

### C# implementation

``` C# title="C#"
public class ClimateChangePerQuantity : BH.oM.Quantities.Attributes.QuantityAttribute,
BH.oM.Base.Attributes.ClassificationAttribute,
System.Attribute,
BH.oM.Base.IImmutable,
BH.oM.Base.IObject
```

Assembly: Quantities_oM.dll

The class is defined in C#. The class definition is available on github:

- [ClimateChangePerQuantity.cs](https://github.com/BHoM/BHoM/blob/develop/Quantities_oM/Attributes\ClimateChangePerQuantity.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Quantities_oM/Attributes/ClimateChangePerQuantity.json}
```

The JSON Schema is available on github here:

- [ClimateChangePerQuantity.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Quantities_oM/Attributes/ClimateChangePerQuantity.json)
