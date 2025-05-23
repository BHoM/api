---
title: IParameterLink
---

# <small>BH.oM.Adapters.Revit.Mapping.</small>**IParameterLink**

An interface for classes defining the relationship between property names of an object (or names of RevitParameters attached to it) and sets of their correspondent Revit parameter names.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IParameterLink is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Adapters.Revit.Mapping.[ElementParameterLink](/api/oM/Adapter/Adapters/Revit/Mapping/ElementParameterLink)
    - BH.oM.Adapters.Revit.Mapping.[ElementTypeParameterLink](/api/oM/Adapter/Adapters/Revit/Mapping/ElementTypeParameterLink)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| PropertyName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Name of the property (or RevitParameter) to be linked with Revit parameters. | - |
| ParameterNames | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | A collecation of Revit parameter names to be linked with the type property. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IParameterLink : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: Revit_oM.dll

The C# interface definition is available on github:

- [IParameterLink.cs](https://github.com/BHoM/Revit_Toolkit/blob/develop/Revit_oM/Mapping\IParameterLink.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Revit_oM/Mapping/IParameterLink.json"
}
```

The JSON Schema is available on github here:

- [IParameterLink.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Revit_oM/Mapping/IParameterLink.json)
