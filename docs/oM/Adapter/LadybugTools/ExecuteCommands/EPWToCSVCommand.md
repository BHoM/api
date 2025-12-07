---
title: EPWToCSVCommand
---

# <small>BH.oM.LadybugTools.</small>**EPWToCSVCommand**



## Class structure

### Implemented interfaces and base types

???+ bhom "The EPWToCSVCommand is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Adapter.[IExecuteCommand](/api/oM/Framework/Adapter/ExecuteCommands/_IExecuteCommand)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| EPWFile | [FileSettings](/api/oM/Framework/Adapter/FileSettings) | The epw file to convert to a csv file. | - |
| OutputDirectory | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The directory to place the output csv file. | - |
| IncludeAdditionalCalculated | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Whether to include additional calculated values (e.g. sun positions) in the output file. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class EPWToCSVCommand : BH.oM.Adapter.IExecuteCommand, BH.oM.Base.IObject
```

Assembly: LadybugTools_oM.dll

The C# class definition is available on github:

- [EPWToCSVCommand.cs](https://github.com/BHoM/LadybugTools_Toolkit/blob/develop/LadybugTools_oM/ExecuteCommands\EPWToCSVCommand.cs)

All history and changes of the class can be found by inspection the history.
