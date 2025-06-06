---
title: GSAId
---

# <small>BH.oM.Adapters.GSA.</small>**GSAId**



## Class structure

### Implemented interfaces and base types

???+ bhom "The GSAId is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IAdapterId](/api/oM/Framework/Base/Interface/IAdapterId)
    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Id | [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class GSAId : BH.oM.Base.IAdapterId, BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: GSA_oM.dll

The C# class definition is available on github:

- [GSAId.cs](https://github.com/BHoM/GSA_Toolkit/blob/develop/GSA_oM/Fragments\GSAId.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/GSA_oM/GSAId.json"
}
```

The JSON Schema is available on github here:

- [GSAId.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/GSA_oM/GSAId.json)
