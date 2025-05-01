---
title: ContaminantReference
---

# <small>BH.oM.Ground.</small>**ContaminantReference**

References to associated files, remarks and batchcodes.

## Class structure

### Implemented interfaces and base types

???+ bhom "The ContaminantReference is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Ground.[IContaminantProperty](/api/oM/Analytical/Ground/ContaminantProperties/IContaminantProperty)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Reference | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Reference for the contaminant sample (SAMP_REF). | - |
| Id | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Unique identifier for the contaminant sample (SAMP_ID). | - |
| ReceiptDate | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/System.DateTime?view=netstandard-2.0) | Receipt date at the labratory for the contaminant sample (ERES_RDAT). | - |
| BatchCode | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Batch code for the contaminant sample (ERES_SGRP). | - |
| Files | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Associated file reference including instructions and photographs (FILE_FSET). | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IsValid | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a IContaminantProperty is valid and outputs relevant error message. | - | Ground_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class ContaminantReference : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.Ground.IContaminantProperty
```

Assembly: Ground_oM.dll

The class is defined in C#. The class definition is available on github:

- [ContaminantReference.cs](https://github.com/BHoM/BHoM/blob/develop/Ground_oM/ContaminantProperties\ContaminantReference.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Ground_oM/ContaminantReference.json"
}
```

The JSON Schema is available on github here:

- [ContaminantReference.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Ground_oM/ContaminantReference.json)
