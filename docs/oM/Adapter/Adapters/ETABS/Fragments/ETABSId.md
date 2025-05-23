---
title: ETABSId
---

# <small>BH.oM.Adapters.ETABS.</small>**ETABSId**



## Class structure

### Implemented interfaces and base types

???+ bhom "The ETABSId is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IAdapterId](/api/oM/Framework/Base/Interface/IAdapterId)
    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Base.[IPersistentAdapterId](/api/oM/Framework/Base/Interface/IPersistentAdapterId)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Id | [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0) | Id or multi-ids of the element as assigned in ETABS. | - |
| Label | [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0) | Label of the element in Etabs. Only populated for Element-type objects. | - |
| Story | [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0) | Name of the story of the element in Etabs. Only populated for Element-type objects. | - |
| PersistentId | [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0) | Persistent GUID assigned by ETABS upon element creation. This does not vary when the element is modified. Only populated for Element-type objects. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class ETABSId : BH.oM.Base.IAdapterId, BH.oM.Base.IFragment, BH.oM.Base.IObject, BH.oM.Base.IPersistentAdapterId
```

Assembly: ETABS_oM.dll

The C# class definition is available on github:

- [ETABSId.cs](https://github.com/BHoM/ETABS_Toolkit/blob/develop/ETABS_oM/Fragments\ETABSId.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/ETABS_oM/ETABSId.json"
}
```

The JSON Schema is available on github here:

- [ETABSId.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/ETABS_oM/ETABSId.json)
