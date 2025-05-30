---
title: TriggerLogUsageArgs
---

# <small>BH.oM.UI.</small>**TriggerLogUsageArgs**



## Class structure

### Implemented interfaces and base types

???+ bhom "The TriggerLogUsageArgs is inheriting from the following base type(s) and implements the following interfaces:"

    -  [EventArgs](https://learn.microsoft.com/en-us/dotnet/api/System.EventArgs?view=netstandard-2.0)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| SelectedItem | [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0) | - | - |
| CallerName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| UIName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| UIVersion | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| ComponentID | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| FileID | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| FileName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| ProjectID | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class TriggerLogUsageArgs : System.EventArgs, BH.oM.Base.IObject
```

Assembly: UI_oM.dll

The C# class definition is available on github:

- [TriggerLogUsageArgs.cs](https://github.com/BHoM/BHoM_UI/blob/develop/UI_oM/TriggerLogUsageArgs.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/UI_oM/TriggerLogUsageArgs.json"
}
```

The JSON Schema is available on github here:

- [TriggerLogUsageArgs.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/UI_oM/TriggerLogUsageArgs.json)
