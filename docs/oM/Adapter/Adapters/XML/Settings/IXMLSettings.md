---
title: IXMLSettings
---

# <small>BH.oM.Adapters.XML.Settings.</small>**IXMLSettings**



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IXMLSettings is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Adapters.XML.Settings.[GBXMLSettings](/api/oM/Adapter/Adapters/XML/Settings/GBXMLSettings)
    - BH.oM.Adapters.XML.Settings.[KMLSettings](/api/oM/Adapter/Adapters/XML/Settings/KMLSettings)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface IXMLSettings : BH.oM.Base.IObject
```

Assembly: XML_oM.dll

The C# interface definition is available on github:

- [IXMLSettings.cs](https://github.com/BHoM/XML_Toolkit/blob/develop/XML_oM/Settings\IXMLSettings.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/XML_oM/Settings/IXMLSettings.json"
}
```

The JSON Schema is available on github here:

- [IXMLSettings.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/XML_oM/Settings/IXMLSettings.json)
