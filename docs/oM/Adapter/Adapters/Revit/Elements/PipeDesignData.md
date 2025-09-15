---
title: PipeDesignData
---

# <small>BH.oM.Adapters.Revit.Elements.</small>**PipeDesignData**

A wrapper BHoM type for Revit MEPSize, used to create or update Revit MEPSize (on Push) and represent them as BHoMObjects (on Pull).

## Class structure

### Implemented interfaces and base types

???+ bhom "The PipeDesignData is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ScheduleType | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Revit identification of used Schedule in design dataset. | - |
| Material | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Revit identification of used Material in design dataset. | - |
| Description | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Revit description of Segment. | - |
| SizeSet | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[PipeSize](/api/oM/Adapter/Adapters/Revit/Elements/PipeSize)&gt; | All sizes in a design dataset. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class PipeDesignData : BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: Revit_oM.dll

The C# class definition is available on github:

- [PipeDesignData.cs](https://github.com/BHoM/Revit_Toolkit/blob/develop/Revit_oM/Elements\PipeDesignData.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Revit_oM/Elements/PipeDesignData.json"
}
```

The JSON Schema is available on github here:

- [PipeDesignData.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Revit_oM/Elements/PipeDesignData.json)
