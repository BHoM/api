---
title: IQuantity
---

# <small>BH.oM.Quantities.</small>**IQuantity**

Represents a numerical value with a quantity type attached to it. The quantity type includes dimensionality as well as SI unit.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IQuantity is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Quantities.[Quantity](/api/oM/Dimensional/Quantities/Quantity)&lt;[T](/api/oM/Dimensional/Quantities/Quantity#t)&gt;


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Value | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IQuantity : BH.oM.Base.IObject
```

Assembly: Quantities_oM.dll

The C# interface definition is available on github:

- [IQuantity.cs](https://github.com/BHoM/BHoM/blob/develop/Quantities_oM/IQuantity.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Quantities_oM/IQuantity.json"
}
```

The JSON Schema is available on github here:

- [IQuantity.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Quantities_oM/IQuantity.json)
