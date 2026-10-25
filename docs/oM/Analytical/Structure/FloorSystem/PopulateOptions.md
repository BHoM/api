---
title: PopulateOptions
---

# <small>BH.oM.Structure.FloorSystem.</small>**PopulateOptions**

Options controlling how a floor design is populated as structural elements in space.

## Class structure

### Implemented interfaces and base types

???+ bhom "The PopulateOptions is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| AtCenterLine | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Output all objects in one plane, best for FE. Defaults to false; objects will be output at their physical elevations. | - |
| IncludeSGirder | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Include south primary girder; true by default. | - |
| IncludeWGirder | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Include west secondary girder; true by default. | - |
| IncludeNGirder | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Include north primary girder; false by default. | - |
| IncludeEGirder | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Include east secondary girder; false by default. | - |
| OffsetBarsFromConnectingElements | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true, bar centrelines are offset based on the element they are connecting to. For Primary beams, and secondary end beams, this relates to the column size. For other secondary beams, relates to thickness of Primary beams, and tertiary beams cutoff by secondary beams. | - |
| IncludeColumns | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Include Columns; false by default. | - |
| NumberOfStories | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | The number of stories that the column data should be evaluated for. If a negative value is provided, the median configuration will be assumed ordered by number of stories. | - |
| FloorHeight | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The height of a populated column. By default, the value on the picked column configuration will be used. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |


## Code and Schema

### C# implementation

``` C# title="C#"
public class PopulateOptions : BH.oM.Base.IObject
```

Assembly: Structure_oM.dll

The C# class definition is available on github:

- [PopulateOptions.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/FloorSystem\PopulateOptions.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Structure_oM/FloorSystem/PopulateOptions.json"
}
```

The JSON Schema is available on github here:

- [PopulateOptions.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Structure_oM/FloorSystem/PopulateOptions.json)
