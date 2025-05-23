---
title: ExcelPushConfig
---

# <small>BH.oM.Adapters.Excel.</small>**ExcelPushConfig**

Configuration used for adapter interaction with Excel on Push action.

## Class structure

### Implemented interfaces and base types

???+ bhom "The ExcelPushConfig is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Adapter.[ActionConfig](/api/oM/Framework/Adapter/Settings-Config/ActionConfig)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Worksheet | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Name of the worksheet to write to. | - |
| StartingCell | [CellAddress](/api/oM/Adapter/Adapters/Excel/Address/CellAddress) | The first cell that will be filled with the pushed objects, i.e. top-left cell of the populated space in the spreadsheet. | - |
| ObjectProperties | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | List of object properties to push to the table. Those will form the columns of the created table. | - |
| PropertiesToIgnore | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | List of object properties that shouldn't be added to the table. | - |
| GoDeepInProperties | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true, non-primitive properties will be divided in multiple column. | - |
| TransposeObjectTable | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true, transpose the table so that each column is a separate object and each row is a different property. | - |
| IncludePropertyNames | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true, the property names will be shown as the first row (or column if transposed) | - |
| WorkbookProperties | [WorkbookProperties](/api/oM/Adapter/Adapters/Excel/ClosedXML/WorkbookProperties) | Properties to apply to workbook and contents. If not null, the meta information of the workbook will be updated on push. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| WrapNonBHoMObjects | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true, the Push action wraps any non-BHoM type into a BH.oM.Adapter.ObjectWrapper, allowing them to make use of the full Adapter workflow. | - |
| AllowHashForComparing | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true and if no specific EqualityComparer is found for the type, Diffing hashes are computed and used to compare the objects. | - |
| DiffingConfig | [DiffingConfig](/api/oM/Framework/Diffing/DiffingConfig) | Configurations for the Diffing hashing. Requires `AllowHashForComparing` to be set to true. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class ExcelPushConfig : BH.oM.Adapter.ActionConfig, BH.oM.Base.IObject
```

Assembly: Excel_oM.dll

The C# class definition is available on github:

- [ExcelPushConfig.cs](https://github.com/BHoM/Excel_Toolkit/blob/develop/Excel_oM/Config\ExcelPushConfig.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Excel_oM/ExcelPushConfig.json"
}
```

The JSON Schema is available on github here:

- [ExcelPushConfig.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Excel_oM/ExcelPushConfig.json)
