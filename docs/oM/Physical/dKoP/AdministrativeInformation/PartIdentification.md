---
title: PartIdentification
---

# <small>BH.oM.dKoP.</small>**PartIdentification**



## Class structure

### Implemented interfaces and base types

???+ bhom "The PartIdentification is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.dKoP.[IdKoPObject](/api/oM/Physical/dKoP/IdKoPObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BuildingReference | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| ProjectUniquePartReference | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class PartIdentification : BH.oM.dKoP.IdKoPObject, BH.oM.Base.IObject
```

Assembly: dKoP_oM.dll

The C# class definition is available on github:

- [PartIdentification.cs](https://github.com/BHoM/dKoP_Toolkit/blob/develop/dKoP_oM/AdministrativeInformation\PartIdentification.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/dKoP_oM/PartIdentification.json"
}
```

The JSON Schema is available on github here:

- [PartIdentification.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/dKoP_oM/PartIdentification.json)
