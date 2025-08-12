---
title: TestProperties
---

# <small>BH.oM.Ground.</small>**TestProperties**

Properties related to the tests undertaken on the contaminant.

## Class structure

### Implemented interfaces and base types

???+ bhom "The TestProperties is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Ground.[IContaminantProperty](/api/oM/Analytical/Ground/ContaminantProperties/IContaminantProperty)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| LabTestName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Labratory test name for the contaminant sample (ERES_TNAM). | - |
| Reference | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Test reference (TEST_TESN). | - |
| RunType | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Run type description, i.e. initial or reanalysis (ERES_RTYP). | - |
| TestMatrix | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Labratory test matrix (ERES_MATX). | - |
| Method | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Test method (ERES_METH). | - |
| AnalysisDate | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/System.DateTime?view=netstandard-2.0) | Analysis time and date for the contaminant sample (ERES_DTIM). | - |
| Description | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Description of the specimen from the contaminant sample (SPEC_DESC). | - |
| Remarks | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Remarks about the test or specimen from the contaminant sample (ERES_REM). | - |
| TestStatus | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The status of the test (TEST_STAT). | - |


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
public class TestProperties : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.Ground.IContaminantProperty
```

Assembly: Ground_oM.dll

The C# class definition is available on github:

- [TestProperties.cs](https://github.com/BHoM/BHoM/blob/develop/Ground_oM/ContaminantProperties\TestProperties.cs)

All history and changes of the class can be found by inspection the history.
