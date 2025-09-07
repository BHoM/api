---
title: ActionConfig
---

# <small>BH.oM.Adapter.</small>**ActionConfig**

Configurations specific for an Adapter Action (Push, Pull, etc).
Consider that your tookit might have a more specific implementation available. Try to look for [your toolkit name]ActionConfig.

## Class structure

### Implemented interfaces and base types

???+ bhom "The ActionConfig is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes inheriting from this class

???+ bhom "The following classes are inheriting from this class:"

    - BH.oM.Adapters.CarbonQueryDatabase.[CQDConfig](/api/oM/Adapter/Adapters/CarbonQueryDatabase/Adapter/CQDConfig)
    - BH.oM.Adapters.Excel.[ExcelPushConfig](/api/oM/Adapter/Adapters/Excel/Config/ExcelPushConfig)
    - BH.oM.Adapters.File.[ExecuteConfig](/api/oM/Adapter/Adapters/File/Config/ExecuteConfig)
    - BH.oM.Adapters.File.[PullConfig](/api/oM/Adapter/Adapters/File/Config/PullConfig)
    - BH.oM.Adapters.File.[PushConfig](/api/oM/Adapter/Adapters/File/Config/PushConfig)
    - BH.oM.Adapters.File.[RemoveConfig](/api/oM/Adapter/Adapters/File/Config/RemoveConfig)
    - BH.oM.Adapters.GSA.[GSAConfig](/api/oM/Adapter/Adapters/GSA/Settings/GSAConfig)
    - BH.oM.Adapters.HTTP.[HTTPConfig](/api/oM/Adapter/Adapters/HTTP/HTTPAdapterConfig)
    - BH.oM.Adapters.iAuditor.[iAuditorConfig](/api/oM/Adapter/Adapters/iAuditor/Adapter/iAuditorConfig)
    - BH.oM.Environment.IES.[PullConfigIES](/api/oM/Adapter/Environment/PullConfigIES)
    - BH.oM.Environment.IES.[PushConfigIES](/api/oM/Adapter/Environment/PushConfigIES)
    - BH.oM.LadybugTools.[LadybugConfig](/api/oM/Adapter/LadybugTools/Config/LadybugConfig)
    - BH.oM.Adapters.Revit.[RevitExecutionConfig](/api/oM/Adapter/Adapters/Revit/Config/RevitExecutionConfig)
    - BH.oM.Adapters.Revit.[RevitPullConfig](/api/oM/Adapter/Adapters/Revit/Config/RevitPullConfig)
    - BH.oM.Adapters.Revit.[RevitPushConfig](/api/oM/Adapter/Adapters/Revit/Config/RevitPushConfig)
    - BH.oM.Adapters.Revit.[RevitRemoveConfig](/api/oM/Adapter/Adapters/Revit/Config/RevitRemoveConfig)
    - BH.oM.Adapters.SAP2000.[SAP2000PushConfig](/api/oM/Adapter/Adapters/SAP2000/Config/SAP2000PushConfig)
    - BH.oM.Environment.SAP.[SAPMarkUpPullConfig](/api/oM/Adapter/Environment/Config/SAPMarkUpPullConfig)
    - BH.oM.Environment.SAP.[SAPPushConfig](/api/oM/Adapter/Environment/Config/SAPPushConfig)
    - BH.oM.Environment.SAP.[SAPReportPullConfig](/api/oM/Adapter/Environment/Config/SAPReportPullConfig)
    - BH.oM.Adapters.SQL.[PushConfig](/api/oM/Adapter/Adapters/SQL/Configs/PushConfig)
    - BH.oM.Adapters.XML.[XMLConfig](/api/oM/Adapter/Adapters/XML/Config/XMLConfig)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| WrapNonBHoMObjects | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true, the Push action wraps any non-BHoM type into a BH.oM.Adapter.ObjectWrapper, allowing them to make use of the full Adapter workflow. | - |
| AllowHashForComparing | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true and if no specific EqualityComparer is found for the type, Diffing hashes are computed and used to compare the objects. | - |
| DiffingConfig | [DiffingConfig](/api/oM/Framework/Diffing/DiffingConfig) | Configurations for the Diffing hashing. Requires `AllowHashForComparing` to be set to true. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class ActionConfig : BH.oM.Base.IObject
```

Assembly: Adapter_oM.dll

The C# class definition is available on github:

- [ActionConfig.cs](https://github.com/BHoM/BHoM_Adapter/blob/develop/Adapter_oM/Settings-Config\ActionConfig.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Adapter_oM/ActionConfig.json"
}
```

The JSON Schema is available on github here:

- [ActionConfig.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Adapter_oM/ActionConfig.json)
