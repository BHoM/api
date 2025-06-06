---
title: XMLConfig
---

# <small>BH.oM.Adapters.XML.</small>**XMLConfig**

Define configuration settings for pushing and pulling XML files using the XML Adapter.

## Class structure

### Implemented interfaces and base types

???+ bhom "The XMLConfig is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Adapter.[ActionConfig](/api/oM/Framework/Adapter/Settings-Config/ActionConfig)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Adapters.XML.[IXMLConfig](/api/oM/Adapter/Adapters/XML/Config/IXMLConfig)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| File | [FileSettings](/api/oM/Framework/Adapter/FileSettings) | File settings for the file to push to or pull from. | - |
| Schema | [Schema](/api/oM/Adapter/Adapters/XML/Enums/Schema) | Define the schema which the XML Adapter should be operating with. | - |
| Settings | [IXMLSettings](/api/oM/Adapter/Adapters/XML/Settings/IXMLSettings) | Set optional settings to use when pushing or pulling XML based on the chosen schema. | - |
| RemoveNils | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Determine whether 'nil' XML attributes should be removed when pushing to an XML file. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| WrapNonBHoMObjects | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true, the Push action wraps any non-BHoM type into a BH.oM.Adapter.ObjectWrapper, allowing them to make use of the full Adapter workflow. | - |
| AllowHashForComparing | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true and if no specific EqualityComparer is found for the type, Diffing hashes are computed and used to compare the objects. | - |
| DiffingConfig | [DiffingConfig](/api/oM/Framework/Diffing/DiffingConfig) | Configurations for the Diffing hashing. Requires `AllowHashForComparing` to be set to true. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class XMLConfig : BH.oM.Adapter.ActionConfig, BH.oM.Base.IObject, BH.oM.Adapters.XML.IXMLConfig
```

Assembly: XML_oM.dll

The C# class definition is available on github:

- [XMLConfig.cs](https://github.com/BHoM/XML_Toolkit/blob/develop/XML_oM/Config\XMLConfig.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/XML_oM/XMLConfig.json"
}
```

The JSON Schema is available on github here:

- [XMLConfig.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/XML_oM/XMLConfig.json)
