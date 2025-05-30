---
title: BarInsertionPoint
---

# <small>BH.oM.Adapters.SAP2000.Elements.</small>**BarInsertionPoint**



## Class structure

### Implemented interfaces and base types

???+ bhom "The BarInsertionPoint is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| InsertionPoint | [BarInsertionPointLocation](/api/oM/Adapter/Adapters/SAP2000/Enums/BarInsertionPointLocation) | Bar insertion point based on cross section. | - |
| ModifyStiffness | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Transform frame stiffness for offsets from centroid. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class BarInsertionPoint : BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: SAP2000_oM.dll

The C# class definition is available on github:

- [BarInsertionPoint.cs](https://github.com/BHoM/SAP2000_Toolkit/blob/develop/SAP2000_oM/Fragments\BarInsertionPoint.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/SAP2000_oM/Elements/BarInsertionPoint.json"
}
```

The JSON Schema is available on github here:

- [BarInsertionPoint.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/SAP2000_oM/Elements/BarInsertionPoint.json)
