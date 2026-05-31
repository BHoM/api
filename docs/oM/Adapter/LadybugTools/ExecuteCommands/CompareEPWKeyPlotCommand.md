---
title: CompareEPWKeyPlotCommand
---

# <small>BH.oM.LadybugTools.</small>**CompareEPWKeyPlotCommand**



## Class structure

### Implemented interfaces and base types

???+ bhom "The CompareEPWKeyPlotCommand is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.LadybugTools.[ISimulationCommand](/api/oM/Adapter/LadybugTools/ExecuteCommands/ISimulationCommand)
    -  BH.oM.Adapter.[IExecuteCommand](/api/oM/Framework/Adapter/ExecuteCommands/_IExecuteCommand)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| EPWFile | [FileSettings](/api/oM/Framework/Adapter/FileSettings) | The EPW file that acts as the base for comparisons. | - |
| EPWKey | [EPWKey](/api/oM/Adapter/LadybugTools/Enum/EPWKeys) | Key (e.g. Dry Bulb Temperature) to compare. | - |
| EPWCompareFiles | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[FileSettings](/api/oM/Framework/Adapter/FileSettings)&gt; | The list of EPW files to be compared with the base file (or each other). | - |
| PlotTimeseries | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Whether to plot a time series chart. If set to false, plots data as a histogram instead. | - |
| OutputLocation | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The location to place the image file once complete. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class CompareEPWKeyPlotCommand : BH.oM.LadybugTools.ISimulationCommand, BH.oM.Adapter.IExecuteCommand, BH.oM.Base.IObject
```

Assembly: LadybugTools_oM.dll

The C# class definition is available on github:

- [CompareEPWKeyPlotCommand.cs](https://github.com/BHoM/LadybugTools_Toolkit/blob/develop/LadybugTools_oM/ExecuteCommands\CompareEPWKeyPlotCommand.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/LadybugTools_oM/CompareEPWKeyPlotCommand.json"
}
```

The JSON Schema is available on github here:

- [CompareEPWKeyPlotCommand.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/LadybugTools_oM/CompareEPWKeyPlotCommand.json)
