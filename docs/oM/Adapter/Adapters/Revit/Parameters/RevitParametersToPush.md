---
title: RevitParametersToPush
---

# <small>BH.oM.Adapters.Revit.Parameters.</small>**RevitParametersToPush**

An entity containing parameters attached to the BHoM object that will be set to a correspondent Revit element on push.

## Class structure

### Implemented interfaces and base types

???+ bhom "The RevitParametersToPush is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Adapters.Revit.Parameters.[IRevitParameterFragment](/api/oM/Adapter/Adapters/Revit/Parameters/IRevitParameterFragment)
    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Parameters | [IList](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1?view=netstandard-2.0)&lt;[RevitParameter](/api/oM/Adapter/Adapters/Revit/Parameters/RevitParameter)&gt; | Collection of parameters to be pushed to a Revit element. | - |


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
public class RevitParametersToPush : BH.oM.Base.BHoMObject,
BH.oM.Base.IBHoMObject,
BH.oM.Base.IObject,
BH.oM.Adapters.Revit.Parameters.IRevitParameterFragment,
BH.oM.Base.IFragment
```

Assembly: Revit_oM.dll

The C# class definition is available on github:

- [RevitParametersToPush.cs](https://github.com/BHoM/Revit_Toolkit/blob/develop/Revit_oM/Parameters\RevitParametersToPush.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Revit_oM/Parameters/RevitParametersToPush.json"
}
```

The JSON Schema is available on github here:

- [RevitParametersToPush.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Revit_oM/Parameters/RevitParametersToPush.json)
