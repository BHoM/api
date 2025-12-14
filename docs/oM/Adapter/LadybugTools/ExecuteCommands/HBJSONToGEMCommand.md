---
title: HBJSONToGEMCommand
---

# <small>BH.oM.LadybugTools.</small>**HBJSONToGEMCommand**



## Class structure

### Implemented interfaces and base types

???+ bhom "The HBJSONToGEMCommand is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Adapter.[IExecuteCommand](/api/oM/Framework/Adapter/ExecuteCommands/_IExecuteCommand)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| HBJSONFile | [FileSettings](/api/oM/Framework/Adapter/FileSettings) | The HBJSON file to convert to a GEM file. | - |
| OutputDirectory | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The directory to place the output GEM file. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class HBJSONToGEMCommand : BH.oM.Adapter.IExecuteCommand, BH.oM.Base.IObject
```

Assembly: LadybugTools_oM.dll

The C# class definition is available on github:

- [HBJSONToGEMCommand.cs](https://github.com/BHoM/LadybugTools_Toolkit/blob/develop/LadybugTools_oM/ExecuteCommands\HBJSONToGEMCommand.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/LadybugTools_oM/HBJSONToGEMCommand.json"
}
```

The JSON Schema is available on github here:

- [HBJSONToGEMCommand.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/LadybugTools_oM/HBJSONToGEMCommand.json)
