---
title: Requirement
---

# Verification.Requirements.Requirement

Object representing a single, condition-based requirement to run against each object in a set filtered based on Specification.ExtractionAlso contains the config required to represent the verification results in a human friendly form.

## Class structure

### Implemented interfaces and base types

???+ bhom "The Requirement in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/api/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api/oM/Framework/Base/IObject)
    -  Verification.Requirements.[IRequirement](/api/oM/Framework/Verification/Requirements/IRequirement)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Clause | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Human readable identifier to reference the Requirement. | - |
| Source | [Source](/api/oM/Framework/Data/Library/Source) | Source material for this Requirement. E.g. Codes, best practices, guidelines, etc. | - |
| Comment | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Any additional notes. | - |
| FailureMessage | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | General, human-readable message explaining what does the failure mean to the user. | - |
| Severity | [FailureSeverity](/api/oM/Framework/Verification/FailureSeverity) | Severity of Requirement failure, originating from the concept that not all conditions are necessarily errors. | - |
| Condition | [ICondition](/api/oM/Framework/Verification/Conditions/ICondition) | Condition to be met for an object to pass a Requirement. | - |
| ReportingConfig | [IConditionReportingConfig](/api/oM/Framework/Verification/Reporting/IConditionReportingConfig) | Reporting config containing settings needed to present the verification results in a human friendly form. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [Requirement.cs](https://github.com/BHoM/BHoM/blob/develop/Verification_oM/Requirements\Requirement.cs)

All history and changes of the class can be found by inspection the history.
