---
title: FacadeCondensationRiskCommand
---

# <small>BH.oM.LadybugTools.</small>**FacadeCondensationRiskCommand**

Command that, when executed with the LadybugToolsAdapter, simulates Condensation Risk and outputs a heatmap.
Output is a string of either the path to the image (if OutputLocation is not set) or the base 64 string representation of it.

## Class structure

### Implemented interfaces and base types

???+ bhom "The FacadeCondensationRiskCommand is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.LadybugTools.[ISimulationCommand](/api/oM/Adapter/LadybugTools/ExecuteCommands/ISimulationCommand)
    -  BH.oM.Adapter.[IExecuteCommand](/api/oM/Framework/Adapter/ExecuteCommands/_IExecuteCommand)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| EPWFile | [FileSettings](/api/oM/Framework/Adapter/FileSettings) | The path to an EPW file. | - |
| Thresholds | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0)&gt; | The list of thresholds to use. If no values are provided, default values of [10,7,4,1,-2,-5] will be used. | - |
| Heatmap | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Set to true to return a heatmap, or set to false to return a chart and table. | - |
| OutputLocation | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Full file path (with file name) to save the plot to. Leave blank to output a base 64 string representation of the image instead. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class FacadeCondensationRiskCommand : BH.oM.LadybugTools.ISimulationCommand, BH.oM.Adapter.IExecuteCommand, BH.oM.Base.IObject
```

Assembly: LadybugTools_oM.dll

The C# class definition is available on github:

- [FacadeCondensationRiskCommand.cs](https://github.com/BHoM/LadybugTools_Toolkit/blob/develop/LadybugTools_oM/ExecuteCommands\FacadeCondensationRiskCommand.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/LadybugTools_oM/FacadeCondensationRiskCommand.json"
}
```

The JSON Schema is available on github here:

- [FacadeCondensationRiskCommand.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/LadybugTools_oM/FacadeCondensationRiskCommand.json)
