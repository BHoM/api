---
title: RevitIdentifiers
---

# <small>BH.oM.Adapters.Revit.Parameters.</small>**RevitIdentifiers**

An entity containing identifiers of Revit element correspondent to the BHoM object that carries it.

## Class structure

### Implemented interfaces and base types

???+ bhom "The RevitIdentifiers is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IPersistentAdapterId](/api/oM/Framework/Base/Interface/IPersistentAdapterId)
    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Base.[IImmutable](/api/oM/Framework/Base/Interface/IImmutable)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| PersistentId | [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0) | The PersistentId property stores the UniqueId of the Revit element correspondent to the BHoM object that owns this fragment. The PersistentId can be used for Diffing purposes. | - |
| ElementId | [long](https://learn.microsoft.com/en-us/dotnet/api/System.Int64?view=netstandard-2.0) | ElementId of the Revit element correspondent to the BHoM object that carries this fragment. | - |
| CategoryName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Category of the Revit element correspondent to the BHoM object that carries this fragment. | - |
| FamilyName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Family of the Revit element correspondent to the BHoM object that carries this fragment. | - |
| FamilyTypeName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Family type of the Revit element correspondent to the BHoM object that carries this fragment. | - |
| FamilyTypeId | [long](https://learn.microsoft.com/en-us/dotnet/api/System.Int64?view=netstandard-2.0) | ElementId of family type of the Revit element correspondent to the BHoM object that carries this fragment. | - |
| Workset | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Name of the parent workset of the Revit element correspondent to the BHoM object that carries this fragment. Empty if the Revit model is not shared. | - |
| OwnerViewId | [long](https://learn.microsoft.com/en-us/dotnet/api/System.Int64?view=netstandard-2.0) | ElementId of view that owns the Revit element correspondent to the BHoM object that carries this fragment. -1 if the Revit element is not view-dependent. | - |
| ParentElementId | [long](https://learn.microsoft.com/en-us/dotnet/api/System.Int64?view=netstandard-2.0) | ElementId of the parent element of the Revit element correspondent to the BHoM object that carries this fragment. -1 if the Revit element is not a nested element. | - |
| LinkDocument | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Name of the link document containing the Revit element correspondent to the BHoM object that carries this fragment. Empty if the Revit element is not a link element. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class RevitIdentifiers : BH.oM.Base.IPersistentAdapterId, BH.oM.Base.IFragment, BH.oM.Base.IObject, BH.oM.Base.IImmutable
```

Assembly: Revit_oM.dll

The C# class definition is available on github:

- [RevitIdentifiers.cs](https://github.com/BHoM/Revit_Toolkit/blob/develop/Revit_oM/Parameters\RevitIdentifiers.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Revit_oM/Parameters/RevitIdentifiers.json"
}
```

The JSON Schema is available on github here:

- [RevitIdentifiers.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Revit_oM/Parameters/RevitIdentifiers.json)
