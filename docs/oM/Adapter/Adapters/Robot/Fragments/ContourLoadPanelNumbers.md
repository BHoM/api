---
title: ContourLoadPanelNumbers
---

# <small>BH.oM.Adapters.Robot.</small>**ContourLoadPanelNumbers**



## Class structure

### Implemented interfaces and base types

???+ bhom "The ContourLoadPanelNumbers is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| PanelNumbers | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class ContourLoadPanelNumbers : BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: Robot_oM.dll

The C# class definition is available on github:

- [ContourLoadPanelNumbers.cs](https://github.com/BHoM/Robot_Toolkit/blob/develop/Robot_oM/Fragments\ContourLoadPanelNumbers.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Robot_oM/ContourLoadPanelNumbers.json"
}
```

The JSON Schema is available on github here:

- [ContourLoadPanelNumbers.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Robot_oM/ContourLoadPanelNumbers.json)
