---
title: MidasCivilId
---

# <small>BH.oM.Adapters.MidasCivil.</small>**MidasCivilId**



## Class structure

### Implemented interfaces and base types

???+ bhom "The MidasCivilId is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IAdapterId](/api/oM/Framework/Base/Interface/IAdapterId)
    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Id | [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0) | Id or multi-ids of the element as assigned in MidasCivil. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class MidasCivilId : BH.oM.Base.IAdapterId, BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: MidasCivil_oM.dll

The C# class definition is available on github:

- [MidasCivilId.cs](https://github.com/BHoM/MidasCivil_Toolkit/blob/develop/MidasCivil_oM/Fragments\MidasCivilId.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/MidasCivil_oM/MidasCivilId.json"
}
```

The JSON Schema is available on github here:

- [MidasCivilId.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/MidasCivil_oM/MidasCivilId.json)
