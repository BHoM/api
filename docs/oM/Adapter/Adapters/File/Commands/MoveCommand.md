---
title: MoveCommand
---

# <small>BH.oM.Adapters.File.</small>**MoveCommand**



## Class structure

### Implemented interfaces and base types

???+ bhom "The MoveCommand is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Adapters.File.[IMRCCommand](/api/oM/Adapter/Adapters/File/Commands/IMRCCommand)
    -  BH.oM.Adapter.[IExecuteCommand](/api/oM/Framework/Adapter/ExecuteCommands/_IExecuteCommand)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| FullPath | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Full paths of the items to be Moved. | - |
| TargetFullPath | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The new Full paths of the Files. Files will be Moved there. | - |
| CreateDirectoryIfNotExist | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Whether to create the target Directory if it doesn't exist. | - |
| OverwriteTarget | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Whether to override the target. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class MoveCommand : BH.oM.Adapters.File.IMRCCommand, BH.oM.Adapter.IExecuteCommand, BH.oM.Base.IObject
```

Assembly: File_oM.dll

The C# class definition is available on github:

- [MoveCommand.cs](https://github.com/BHoM/File_Toolkit/blob/develop/File_oM/Commands\MoveCommand.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/File_oM/MoveCommand.json"
}
```

The JSON Schema is available on github here:

- [MoveCommand.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/File_oM/MoveCommand.json)
