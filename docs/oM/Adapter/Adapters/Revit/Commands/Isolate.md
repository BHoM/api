---
title: Isolate
---

# <small>BH.oM.Adapters.Revit.Commands.</small>**Isolate**

Isolate action allows quick isolation of chosen Elements in External Application.

## Class structure

### Implemented interfaces and base types

???+ bhom "The Isolate is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Adapter.[IExecuteCommand](/api/oM/Framework/Adapter/ExecuteCommands/_IExecuteCommand)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Targets | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | Elements to be isolated, specified as either IBHoMObjects or integers representing ElementIds. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class Isolate : BH.oM.Adapter.IExecuteCommand, BH.oM.Base.IObject
```

Assembly: Revit_oM.dll

The C# class definition is available on github:

- [Isolate.cs](https://github.com/BHoM/Revit_Toolkit/blob/develop/Revit_oM/Commands\Isolate.cs)

All history and changes of the class can be found by inspection the history.
