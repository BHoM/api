---
title: SearchSettings
---

# <small>BH.oM.UI.</small>**SearchSettings**



## Class structure

### Implemented interfaces and base types

???+ bhom "The SearchSettings is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[ISettings](/api/oM/Framework/Base/Interface/ISettings)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ExcludedToolkits | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class SearchSettings : BH.oM.Base.ISettings, BH.oM.Base.IObject
```

Assembly: UI_oM.dll

The C# class definition is available on github:

- [SearchSettings.cs](https://github.com/BHoM/BHoM_UI/blob/develop/UI_oM/Settings\SearchSettings.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/UI_oM/SearchSettings.json"
}
```

The JSON Schema is available on github here:

- [SearchSettings.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/UI_oM/SearchSettings.json)
