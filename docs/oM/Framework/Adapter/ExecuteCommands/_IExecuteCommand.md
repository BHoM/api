---
title: IExecuteCommand
---

# <small>BH.oM.Adapter.</small>**IExecuteCommand**

Classes implementing IExecuteCommand are commands compatible with the `Execute` Adapter Action.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IExecuteCommand is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - BH.oM.Adapters.File.[IMRCCommand](/api/oM/Adapter/Adapters/File/Commands/IMRCCommand)
    - BH.oM.LadybugTools.[ISimulationCommand](/api/oM/Adapter/LadybugTools/ExecuteCommands/ISimulationCommand)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Adapter.Commands.[Analyse](/api/oM/Framework/Adapter/ExecuteCommands/Analyse)
    - BH.oM.Adapter.Commands.[AnalyseLoadCases](/api/oM/Framework/Adapter/ExecuteCommands/AnalyseLoadCases)
    - BH.oM.Adapter.Commands.[ClearResults](/api/oM/Framework/Adapter/ExecuteCommands/ClearResults)
    - BH.oM.Adapter.Commands.[Close](/api/oM/Framework/Adapter/ExecuteCommands/Close)
    - BH.oM.Adapter.Commands.[CustomCommand](/api/oM/Framework/Adapter/ExecuteCommands/CustomCommand)
    - BH.oM.Adapter.Commands.[Exit](/api/oM/Framework/Adapter/ExecuteCommands/Exit)
    - BH.oM.Adapter.Commands.[ImportFile](/api/oM/Framework/Adapter/ExecuteCommands/Import)
    - BH.oM.Adapter.Commands.[NewModel](/api/oM/Framework/Adapter/ExecuteCommands/NewModel)
    - BH.oM.Adapter.Commands.[Open](/api/oM/Framework/Adapter/ExecuteCommands/Open)
    - BH.oM.Adapter.Commands.[Save](/api/oM/Framework/Adapter/ExecuteCommands/Save)
    - BH.oM.Adapter.Commands.[SaveAs](/api/oM/Framework/Adapter/ExecuteCommands/SaveAs)
    - BH.oM.Adapters.File.[CopyCommand](/api/oM/Adapter/Adapters/File/Commands/CopyCommand)
    - BH.oM.Adapters.File.[MoveCommand](/api/oM/Adapter/Adapters/File/Commands/MoveCommand)
    - BH.oM.Adapters.File.[RenameCommand](/api/oM/Adapter/Adapters/File/Commands/RenameCommand)
    - BH.oM.LadybugTools.[DiurnalPlotCommand](/api/oM/Adapter/LadybugTools/ExecuteCommands/DiurnalPlotCommand)
    - BH.oM.LadybugTools.[FacadeCondensationRiskCommand](/api/oM/Adapter/LadybugTools/ExecuteCommands/FacadeCondensationRiskCommand)
    - BH.oM.LadybugTools.[GetMaterialCommand](/api/oM/Adapter/LadybugTools/ExecuteCommands/GetMaterialCommand)
    - BH.oM.LadybugTools.[GetTypologyCommand](/api/oM/Adapter/LadybugTools/ExecuteCommands/GetTypologyCommand)
    - BH.oM.LadybugTools.[HeatPlotCommand](/api/oM/Adapter/LadybugTools/ExecuteCommands/HeatPlotCommand)
    - BH.oM.LadybugTools.[RunExternalComfortCommand](/api/oM/Adapter/LadybugTools/ExecuteCommands/RunExternalComfortCommand)
    - BH.oM.LadybugTools.[RunSimulationCommand](/api/oM/Adapter/LadybugTools/ExecuteCommands/RunSimulationCommand)
    - BH.oM.LadybugTools.[SolarRadiationPlotCommand](/api/oM/Adapter/LadybugTools/ExecuteCommands/SolarRadiationPlotCommand)
    - BH.oM.LadybugTools.[SunPathPlotCommand](/api/oM/Adapter/LadybugTools/ExecuteCommands/SunPathPlotCommand)
    - BH.oM.LadybugTools.[UTCIHeatPlotCommand](/api/oM/Adapter/LadybugTools/ExecuteCommands/UTCIHeatPlotCommand)
    - BH.oM.LadybugTools.[WalkabilityPlotCommand](/api/oM/Adapter/LadybugTools/ExecuteCommands/WalkabilityPlotCommand)
    - BH.oM.LadybugTools.[WindroseCommand](/api/oM/Adapter/LadybugTools/ExecuteCommands/WindroseCommand)
    - BH.oM.Adapters.Mongo.Commands.[Transfer](/api/oM/Adapter/Adapters/Mongo/Commands/Transfer)
    - BH.oM.Adapters.Revit.Commands.[DirectPush](/api/oM/Adapter/Adapters/Revit/Commands/DirectPush)
    - BH.oM.Adapters.Revit.Commands.[Isolate](/api/oM/Adapter/Adapters/Revit/Commands/Isolate)
    - BH.oM.Adapters.Revit.Commands.[PullSelection](/api/oM/Adapter/Adapters/Revit/Commands/PullSelection)
    - BH.oM.Adapters.Revit.Commands.[Select](/api/oM/Adapter/Adapters/Revit/Commands/Select)
    - BH.oM.Environment.SAP.[ProcessResultsCommand](/api/oM/Adapter/Environment/Config/ProcessResultsCommand)
    - BH.oM.Environment.SAP.[RunAnalysisCommand](/api/oM/Adapter/Environment/Config/RunAnalysisCommand)
    - BH.oM.Adapters.SQL.[UpdateCommand](/api/oM/Adapter/Adapters/SQL/Commands/UpdateCommand)
    - BH.oM.Adapters.SQL.[UpsertCommand](/api/oM/Adapter/Adapters/SQL/Commands/UpsertCommand)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface IExecuteCommand : BH.oM.Base.IObject
```

Assembly: Adapter_oM.dll

The C# interface definition is available on github:

- [IExecuteCommand.cs](https://github.com/BHoM/BHoM_Adapter/blob/develop/Adapter_oM/ExecuteCommands\_IExecuteCommand.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Adapter_oM/IExecuteCommand.json"
}
```

The JSON Schema is available on github here:

- [IExecuteCommand.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Adapter_oM/IExecuteCommand.json)
