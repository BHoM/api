---
title: AdditionalEPDData
---

# <small>BH.oM.LifeCycleAssessment.Fragments.</small>**AdditionalEPDData**

A data fragment containing other optional information regarding the production and documentation of any Environmental Product Declaration. 
Use AddFragment() to combine this information with any EPD for continuous integration.

## Class structure

### Implemented interfaces and base types

???+ bhom "The AdditionalEPDData is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Description | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Brief summary of the EPD from the data source. | - |
| EndOfLifeTreatment | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Description of the material's treatment after its useful life. | - |
| Id | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Unique identifier of the EPD from the source of the information. | - |
| IndustryStandards | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Industry Standards referenced in creating the product. | - |
| Jurisdiction | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Jurisdiction within which the sector based product EPD originates. | - |
| LifeSpan | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | The period of useful life of the product measured in years. | - |
| Manufacturer | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Manufacturer name responsible for the product being documented. | - |
| PlantName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Manufacturing facility name within which the product was created. | - |
| PostalCode | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Postal Code within which the product was created. | - |
| Publisher | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Publisher responsible for recording and presenting all EPD information. | - |
| ReferenceYear | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Year in which the EPD was created. Default set to the current year, please override if creating an EPD from legacy information. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class AdditionalEPDData : BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: LifeCycleAssessment_oM.dll

The C# class definition is available on github:

- [AdditionalEPDData.cs](https://github.com/BHoM/BHoM/blob/develop/LifeCycleAssessment_oM/Fragments\AdditionalEPDData.cs)

All history and changes of the class can be found by inspection the history.
