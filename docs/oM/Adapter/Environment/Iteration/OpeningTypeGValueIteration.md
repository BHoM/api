---
title: OpeningTypeGValueIteration
---

# <small>BH.oM.Environment.SAP.</small>**OpeningTypeGValueIteration**

Describe a single iteration of U and G Values for opening types. If both values are provided, then both values will be updated. This will not blend the iteration (i.e. it will not be one iteration with updated UValue, one iteration with updated GValue, and one iteration with both).

## Class structure

### Implemented interfaces and base types

???+ bhom "The OpeningTypeGValueIteration is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Environment.SAP.[IOpeningTypeIteration](/api/oM/Adapter/Environment/Iteration/IOpeningTypeIteration)
    -  BH.oM.Environment.SAP.[IIteration](/api/oM/Adapter/Environment/Iteration/IIteration)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| GValue | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | New GValue to use for the Opening Type. Must be a positive number between 0-1 as a ratio of how much of the total light is transmitted through the opening construction. If no value is provided, no changes to GValue will be made. | - |
| Include | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | A list of Opening Types to make changes to. If this is left blank, then all opening types will be updated within the SAP Report for the U and G Values provided. | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Provide the name of this iteration. The name should be unique across all iterations in your model, and should match any coordination with other models (over heating, daylighting, etc.) you may be running parametrics on. | - |
| Prefix | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | What value should be used to prefix the name of this iteration when combining with other iterations. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class OpeningTypeGValueIteration : BH.oM.Base.BHoMObject,
BH.oM.Base.IBHoMObject,
BH.oM.Base.IObject,
BH.oM.Environment.SAP.IOpeningTypeIteration,
BH.oM.Environment.SAP.IIteration
```

Assembly: SAP_oM.dll

The C# class definition is available on github:

- [OpeningTypeGValueIteration.cs](https://github.com/BHoM/SAP_Toolkit/blob/develop/SAP_oM/Iteration\OpeningTypeGValueIteration.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/SAP_oM/SAP/OpeningTypeGValueIteration.json"
}
```

The JSON Schema is available on github here:

- [OpeningTypeGValueIteration.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/SAP_oM/SAP/OpeningTypeGValueIteration.json)
