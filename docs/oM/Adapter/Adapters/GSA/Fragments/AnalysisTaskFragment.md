---
title: AnalysisTaskFragment
---

# <small>BH.oM.Adapters.GSA.</small>**AnalysisTaskFragment**

Fragment to be put on a LoadCombination to help you control the analysis task type to use in GSA and for which stage the combination should be run.

## Class structure

### Implemented interfaces and base types

???+ bhom "The AnalysisTaskFragment is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| AnalysisType | [AnalysisType](/api/oM/Adapter/Adapters/GSA/Enum/AnalysisType) | - | - |
| Stage | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | The stage number for the combination to be run on. | - |
| ResidualForce | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Allowed residual Force for convergence, only used for Non-linear analysis. | - |
| ResidualMoment | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Allowed residual Moment for convergence, only used for Non-linear analysis. | - |
| BeamSlendernessEffect | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Reduce beam stiffness when in compression, only used for Non-linear analysis. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class AnalysisTaskFragment : BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: GSA_oM.dll

The C# class definition is available on github:

- [AnalysisTaskFragment.cs](https://github.com/BHoM/GSA_Toolkit/blob/develop/GSA_oM/Fragments\AnalysisTaskFragment.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/GSA_oM/AnalysisTaskFragment.json"
}
```

The JSON Schema is available on github here:

- [AnalysisTaskFragment.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/GSA_oM/AnalysisTaskFragment.json)
