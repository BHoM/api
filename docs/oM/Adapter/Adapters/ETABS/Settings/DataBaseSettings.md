---
title: DatabaseSettings
---

# <small>BH.oM.Adapters.ETABS.</small>**DatabaseSettings**



## Class structure

### Implemented interfaces and base types

???+ bhom "The DatabaseSettings is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| SectionDatabase | [SectionDatabase](/api/oM/Adapter/Adapters/ETABS/Enums/SectionDatabase) | The ETABS defined section database to read sections from if the name of the sections you push share a name with one avalible in the database | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class DatabaseSettings : BH.oM.Base.IObject
```

Assembly: ETABS_oM.dll

The class is defined in C#. The class definition is available on github:

- [DatabaseSettings.cs](https://github.com/BHoM/ETABS_Toolkit/blob/develop/ETABS_oM/Settings\DataBaseSettings.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/ETABS_oM/DatabaseSettings.json"
}
```

The JSON Schema is available on github here:

- [DatabaseSettings.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/ETABS_oM/DatabaseSettings.json)
