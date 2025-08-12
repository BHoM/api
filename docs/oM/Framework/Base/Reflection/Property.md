---
title: Property
---

# <small>BH.oM.Base.Reflection.</small>**Property**

Metadata related to a C# property

## Class structure

### Implemented interfaces and base types

???+ bhom "The Property is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Type | [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=netstandard-2.0) | - | - |
| Description | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class Property : BH.oM.Base.IObject
```

Assembly: BHoM.dll

The C# class definition is available on github:

- [Property.cs](https://github.com/BHoM/BHoM/blob/develop/BHoM/Reflection\Property.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/BHoM/Reflection/Property.json"
}
```

The JSON Schema is available on github here:

- [Property.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/BHoM/Reflection/Property.json)
