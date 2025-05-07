---
title: IPersistentAdapterId
---

# <small>BH.oM.Base.</small>**IPersistentAdapterId**

Requires a Fragment to contain a PersistentId, imported through an Adapter, that can be used to track an object.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IPersistentAdapterId is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Adapters.ETABS.[ETABSId](/api/oM/Adapter/Adapters/ETABS/Fragments/ETABSId)
    - BH.oM.Adapters.Revit.Parameters.[RevitIdentifiers](/api/oM/Adapter/Adapters/Revit/Parameters/RevitIdentifiers)
    - BH.oM.Adapters.SAP2000.[SAP2000Id](/api/oM/Adapter/Adapters/SAP2000/Fragments/SAP2000Id)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| PersistentId | [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0) | Persistent identifier of the object in the external software, imported through an Adapter.'Persistent' means that the identifier must be: globally unique and referring to exactly one object in the external software; generated once upon object creation in the external software; never changing throughout the life of the object in the external software.If all these requirements are satisfied, the PersistentId imported from the external software can be used for Diffing purposes. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IPersistentAdapterId : BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: BHoM.dll

The C# interface definition is available on github:

- [IPersistentAdapterId.cs](https://github.com/BHoM/BHoM/blob/develop/BHoM/Interface\IPersistentAdapterId.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/BHoM/IPersistentAdapterId.json"
}
```

The JSON Schema is available on github here:

- [IPersistentAdapterId.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/BHoM/IPersistentAdapterId.json)
