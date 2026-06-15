---
title: ISettings
---

# <small>BH.oM.Base.</small>**ISettings**

Toolkit Settings that need to be saved permanently.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The ISettings is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Data.Library.[LibrarySettings](/api/oM/Framework/Data/Library/LibrarySettings)
    - BH.oM.Grasshopper.[UISettings](/api/oM/UI/Grasshopper/UISettings)
    - BH.oM.Adapters.SQL.[SqlClientAssemblyFixSettings](/api/oM/Adapter/Adapters/SQL/ToolkitSettings/SqlClientAssemblyFixSettings)
    - BH.oM.UI.[CustomRibbonSettings](/api/oM/UI/UI/CustomRibbonSettings)
    - BH.oM.UI.[SearchSettings](/api/oM/UI/UI/Settings/SearchSettings)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface ISettings : BH.oM.Base.IObject
```

Assembly: BHoM.dll

The C# interface definition is available on github:

- [ISettings.cs](https://github.com/BHoM/BHoM/blob/develop/BHoM/Interface\ISettings.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/BHoM/ISettings.json"
}
```

The JSON Schema is available on github here:

- [ISettings.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/BHoM/ISettings.json)
