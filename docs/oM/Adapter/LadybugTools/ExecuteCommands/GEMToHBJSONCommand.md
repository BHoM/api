---
title: GEMToHBJSONCommand
---

# <small>BH.oM.LadybugTools.</small>**GEMToHBJSONCommand**



## Class structure

### Implemented interfaces and base types

???+ bhom "The GEMToHBJSONCommand is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Adapter.[IExecuteCommand](/api/oM/Framework/Adapter/ExecuteCommands/_IExecuteCommand)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| GEMFile | [FileSettings](/api/oM/Framework/Adapter/FileSettings) | The GEM file to convert to an HBJSON file. | - |
| OutputDirectory | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The directory to place the output HBJSON file. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class GEMToHBJSONCommand : BH.oM.Adapter.IExecuteCommand, BH.oM.Base.IObject
```

Assembly: LadybugTools_oM.dll

The C# class definition is available on github:

- [GEMToHBJSONCommand.cs](https://github.com/BHoM/LadybugTools_Toolkit/blob/develop/LadybugTools_oM/ExecuteCommands\GEMToHBJSONCommand.cs)

All history and changes of the class can be found by inspection the history.
