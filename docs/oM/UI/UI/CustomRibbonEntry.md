---
title: CustomRibbonEntry
---

# <small>BH.oM.UI.</small>**CustomRibbonEntry**



## Class structure

### Implemented interfaces and base types

???+ bhom "The CustomRibbonEntry is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| CallerType | [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=netstandard-2.0) | - | - |
| ItemJson | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Icon | [Bitmap](https://learn.microsoft.com/en-us/dotnet/api/System.Drawing.Bitmap?view=netstandard-2.0) | - | - |
| TabName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Category | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| GroupIndex | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class CustomRibbonEntry : BH.oM.Base.IObject
```

Assembly: UI_oM.dll

The C# class definition is available on github:

- [CustomRibbonEntry.cs](https://github.com/BHoM/BHoM_UI/blob/develop/UI_oM/CustomRibbonEntry.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/UI_oM/CustomRibbonEntry.json"
}
```

The JSON Schema is available on github here:

- [CustomRibbonEntry.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/UI_oM/CustomRibbonEntry.json)
