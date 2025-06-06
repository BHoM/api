---
title: ShapeColourUpdate
---

# <small>BH.oM.PowerPoint.</small>**ShapeColourUpdate**

Allows to update the colour of a shape

## Class structure

### Implemented interfaces and base types

???+ bhom "The ShapeColourUpdate is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.PowerPoint.[ISlideUpdate](/api/oM/Adapter/PowerPoint/Update/ISlideUpdate)
    -  BH.oM.PowerPoint.[IExcelModification](/api/oM/Adapter/PowerPoint/IExcelModification)
    -  BH.oM.PowerPoint.[IPowerPointModification](/api/oM/Adapter/PowerPoint/IPowerPointModification)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| SlideNumber | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Number of the slide where the update needs to happen. | - |
| ElementName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Name of the shape element that needs to be updated. | - |
| EdgeColour | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | New edge hex colour represenation of the element. | - |
| FillColour | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | New fill hex colour represenation of the element. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class ShapeColourUpdate : BH.oM.Base.BHoMObject,
BH.oM.Base.IBHoMObject,
BH.oM.Base.IObject,
BH.oM.PowerPoint.ISlideUpdate,
BH.oM.PowerPoint.IExcelModification,
BH.oM.PowerPoint.IPowerPointModification
```

Assembly: PowerPoint_oM.dll

The C# class definition is available on github:

- [ShapeColourUpdate.cs](https://github.com/BHoM/PowerPoint_Toolkit/blob/develop/PowerPoint_oM/Update\ShapeColourUpdate.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/PowerPoint_oM/ShapeColourUpdate.json"
}
```

The JSON Schema is available on github here:

- [ShapeColourUpdate.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/PowerPoint_oM/ShapeColourUpdate.json)
