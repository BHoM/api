---
title: CodeElementRecord
---

# <small>BH.oM.UI.</small>**CodeElementRecord**



## Class structure

### Implemented interfaces and base types

???+ bhom "The CodeElementRecord is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| AssemblyName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| AssemblyModifiedTime | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/System.DateTime?view=netstandard-2.0) | - | - |
| Type | [CodeElementType](/api/oM/UI/UI/CodeElementType) | - | - |
| DisplayText | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Json | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class CodeElementRecord : BH.oM.Base.IObject
```

Assembly: UI_oM.dll

The C# class definition is available on github:

- [CodeElementRecord.cs](https://github.com/BHoM/BHoM_UI/blob/develop/UI_oM/CodeElementRecord.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/UI_oM/CodeElementRecord.json"
}
```

The JSON Schema is available on github here:

- [CodeElementRecord.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/UI_oM/CodeElementRecord.json)
