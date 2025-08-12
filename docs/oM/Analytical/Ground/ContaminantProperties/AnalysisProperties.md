---
title: AnalysisProperties
---

# <small>BH.oM.Ground.</small>**AnalysisProperties**

Properties related to the analysis undertaken on the contaminant.

## Class structure

### Implemented interfaces and base types

???+ bhom "The AnalysisProperties is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Ground.[IContaminantProperty](/api/oM/Analytical/Ground/ContaminantProperties/IContaminantProperty)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| TotalOrDissolved | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Whether the specimen is total or dissolved (ERES_TORD). | - |
| AccreditingBody | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Accrediting body and reference number (when appropriate) (ERES_CRED). | - |
| LabName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Name of testing labratory or organisation (ERES_LAB). | - |
| PercentageRemoved | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Percentage of material removed (ERES_PERP). | - |
| SizeRemoved | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Size of material removed prior to test. Value represents lowest sized material removed (ERES_SIZE). | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| InstrumentReference | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Instrument reference number or identifier (ERES_IREF). | - |
| LeachateDate | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/System.DateTime?view=netstandard-2.0) | Leachate preperation date and time (ERES_LDTM). | - |
| LeachateMethod | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Leachate preperation method (ERES_LMTH). | - |
| DilutionFactor | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Dilution factor (ERES_DIL). | - |
| Basis | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Basis (ERES_BAS). | - |
| Location | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Analysis location (ERES_LOCN). | - |


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
public class AnalysisProperties : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.Ground.IContaminantProperty
```

Assembly: Ground_oM.dll

The C# class definition is available on github:

- [AnalysisProperties.cs](https://github.com/BHoM/BHoM/blob/develop/Ground_oM/ContaminantProperties\AnalysisProperties.cs)

All history and changes of the class can be found by inspection the history.
