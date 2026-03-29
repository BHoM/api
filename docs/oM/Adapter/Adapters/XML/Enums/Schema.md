---
title: Schema
---

# <small>BH.oM.Adapters.XML.Enums.</small>**Schema**

Defines the XML Schema that is being used within the context of the XML Toolkit.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| Undefined |  -  |
| Bluebeam |  Bluebeam markup files with data pulled through for specific workflows.  |
| CSProject |  CSProject files are used to work out compiling information for code projects. Typically seen in Visual Studio solution files.  |
| EnergyPlusLoads |  EnergyPlusLoads is the XML schema for load results calculated using the EnergyPlus software.  |
| GBXML |  gbXML Schema is the Green Building XML Schema, used by environment modelling software for the transfer of building geometry and data to tools such as IES, TAS, and more.  |
| KML |  KML is a file format used to display geographic data in an Earth browser such as Google Earth.  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum Schema : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: XML_oM.dll

The C# enum definition is available on github:

- [Schema.cs](https://github.com/BHoM/XML_Toolkit/blob/develop/XML_oM/Enums\Schema.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/XML_oM/Enums/Schema.json"
}
```

The JSON Schema is available on github here:

- [Schema.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/XML_oM/Enums/Schema.json)
