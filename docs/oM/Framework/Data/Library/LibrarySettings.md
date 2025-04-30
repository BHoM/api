---
title: LibrarySettings
---

# <small>BH.oM.Data.Library.</small>**LibrarySettings**

Settings object to be used by the Library_Engine for controling Dataset extraction.

## Class structure

### Implemented interfaces and base types

???+ bhom "The LibrarySettings is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[ISettings](/api/oM/Framework/Base/Interface/ISettings)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| UserLibraryPaths | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | List of folder paths to user-specified folder paths to be used by the Library_Engine when extracting Datasets. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class LibrarySettings : BH.oM.Base.ISettings, BH.oM.Base.IObject
```

Assembly: Data_oM.dll

The class is defined in C#. The class definition is available on github:

- [LibrarySettings.cs](https://github.com/BHoM/BHoM/blob/develop/Data_oM/Library\LibrarySettings.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` { .json .copy .select } title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Data_oM/Library/LibrarySettings.json}
```

The JSON Schema is available on github here:

- [LibrarySettings.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Data_oM/Library/LibrarySettings.json)
