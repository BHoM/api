---
title: WalkabilityPlotCommand
---

# <small>BH.oM.LadybugTools.</small>**WalkabilityPlotCommand**



## Class structure

### Implemented interfaces and base types

???+ bhom "The WalkabilityPlotCommand is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.LadybugTools.[ISimulationCommand](/api/oM/Adapter/LadybugTools/ExecuteCommands/ISimulationCommand)
    -  BH.oM.Adapter.[IExecuteCommand](/api/oM/Framework/Adapter/ExecuteCommands/_IExecuteCommand)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| EPWFile | [FileSettings](/api/oM/Framework/Adapter/FileSettings) | The EPW file to use for analysis. | - |
| ExternalComfort | [ExternalComfort](/api/oM/Adapter/LadybugTools/Simulation/ExternalComfort) | The external comfort object containing the UTCI data to plot. If the UTCI collection is null or empty, then a simulation will be run before plotting to get these values. | - |
| OutputLocation | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The location to place any images generated by the command. Leave empty to return a base64 string representation of the image. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class WalkabilityPlotCommand : BH.oM.LadybugTools.ISimulationCommand, BH.oM.Adapter.IExecuteCommand, BH.oM.Base.IObject
```

Assembly: LadybugTools_oM.dll

The C# class definition is available on github:

- [WalkabilityPlotCommand.cs](https://github.com/BHoM/LadybugTools_Toolkit/blob/develop/LadybugTools_oM/ExecuteCommands\WalkabilityPlotCommand.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/LadybugTools_oM/WalkabilityPlotCommand.json"
}
```

The JSON Schema is available on github here:

- [WalkabilityPlotCommand.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/LadybugTools_oM/WalkabilityPlotCommand.json)
