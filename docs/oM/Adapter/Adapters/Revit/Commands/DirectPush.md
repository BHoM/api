---
title: DirectPush
---

# <small>BH.oM.Adapters.Revit.Commands.</small>**DirectPush**

Push action allows quick transfer of selected objects on current UI to External Application.

## Class structure

### Implemented interfaces and base types

???+ bhom "The DirectPush is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Adapter.[IExecuteCommand](/api/oM/Framework/Adapter/ExecuteCommands/_IExecuteCommand)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ObjectsToPush | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IObject](/api/oM/Framework/Base/Interface/IObject)&gt; | Source objects to be pushed | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class DirectPush : BH.oM.Adapter.IExecuteCommand, BH.oM.Base.IObject
```

Assembly: Revit_oM.dll

The C# class definition is available on github:

- [DirectPush.cs](https://github.com/BHoM/Revit_Toolkit/blob/develop/Revit_oM/Commands\DirectPush.cs)

All history and changes of the class can be found by inspection the history.
