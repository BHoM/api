---
title: ModelInstance
---

# <small>BH.oM.Adapters.Revit.Elements.</small>**ModelInstance**

A generic wrapper BHoM type corresponding to any view-independent Revit element (model elements, e.g. duct or beam). On Push it can be used to generate or update Revit model elements that do not have a correspondent BHoM type, on Pull all Revit model elements that do not have explicit Convert method for given discipline will be converted to ModelInstance.

## Class structure

### Implemented interfaces and base types

???+ bhom "The ModelInstance is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Adapters.Revit.Elements.[IInstance](/api/oM/Adapter/Adapters/Revit/Elements/IInstance)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Properties | [InstanceProperties](/api/oM/Adapter/Adapters/Revit/Properties/InstanceProperties) | Information about Revit family type of the instance. | - |
| Location | [IGeometry](/api/oM/Dimensional/Geometry/Interface/IGeometry) | Location of the instance in in three dimensional space. | - |
| Orientation | [Basis](/api/oM/Dimensional/Geometry/Vector/Basis) | Orientation of the instance in 3 dimensional space. Applicable only to point-based ModelInstances. If null, a default orientation will be applied. | - |


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
public class ModelInstance : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.Adapters.Revit.Elements.IInstance
```

Assembly: Revit_oM.dll

The C# class definition is available on github:

- [ModelInstance.cs](https://github.com/BHoM/Revit_Toolkit/blob/develop/Revit_oM/Elements\ModelInstance.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Revit_oM/Elements/ModelInstance.json"
}
```

The JSON Schema is available on github here:

- [ModelInstance.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Revit_oM/Elements/ModelInstance.json)
