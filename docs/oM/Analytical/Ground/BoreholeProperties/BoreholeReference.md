---
title: BoreholeReference
---

# <small>BH.oM.Ground.</small>**BoreholeReference**

References to associated files, storage links or previous boreholes.

## Class structure

### Implemented interfaces and base types

???+ bhom "The BoreholeReference is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Ground.[IBoreholeProperty](/api/oM/Analytical/Ground/BoreholeProperties/IBoreholeProperty)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| StartDate | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/System.DateTime?view=netstandard-2.0) | Start date of the activity (LOCA_STAR). | - |
| EndDate | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/System.DateTime?view=netstandard-2.0) | End date of the activity (LOCA_ENDD). | - |
| File | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Associated file reference including instructions and photographs (FILE_FSET). | - |
| URL | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Link to storage of borehole data. | - |
| OriginalId | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Original hole id (LOCA_ORID). | - |
| OriginalReference | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Original job reference (LOCA_ORJO). | - |
| OriginalCompany | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Originating company (LOCA_ORCO). | - |


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
| IsValid | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a IBoreholeProperty is valid and outputs relevant error message. | - | Ground_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class BoreholeReference : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.Ground.IBoreholeProperty
```

Assembly: Ground_oM.dll

The C# class definition is available on github:

- [BoreholeReference.cs](https://github.com/BHoM/BHoM/blob/develop/Ground_oM/BoreholeProperties\BoreholeReference.cs)

All history and changes of the class can be found by inspection the history.
