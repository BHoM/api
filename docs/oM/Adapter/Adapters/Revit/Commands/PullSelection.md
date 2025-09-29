---
title: PullSelection
---

# <small>BH.oM.Adapters.Revit.Commands.</small>**PullSelection**

Pull action allows quick retrieval of selected elements from External Application.

## Class structure

### Implemented interfaces and base types

???+ bhom "The PullSelection is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Adapter.[IExecuteCommand](/api/oM/Framework/Adapter/ExecuteCommands/_IExecuteCommand)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public class PullSelection : BH.oM.Adapter.IExecuteCommand, BH.oM.Base.IObject
```

Assembly: Revit_oM.dll

The C# class definition is available on github:

- [PullSelection.cs](https://github.com/BHoM/Revit_Toolkit/blob/develop/Revit_oM/Commands\PullSelection.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Revit_oM/Commands/PullSelection.json"
}
```

The JSON Schema is available on github here:

- [PullSelection.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Revit_oM/Commands/PullSelection.json)
