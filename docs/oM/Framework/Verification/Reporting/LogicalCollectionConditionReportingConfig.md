---
title: LogicalCollectionConditionReportingConfig
---

# <small>BH.oM.Verification.Reporting.</small>**LogicalCollectionConditionReportingConfig**

Config object containing settings for reporting results of checks against logical conditions with a collection of nested conditions.

## Class structure

### Implemented interfaces and base types

???+ bhom "The LogicalCollectionConditionReportingConfig is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Verification.Reporting.[IConditionReportingConfig](/api/oM/Framework/Verification/Reporting/Interfaces/IConditionReportingConfig)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| NestedConfigs | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[ICondition](/api/oM/Framework/Verification/Conditions/Interfaces/ICondition), [IConditionReportingConfig](/api/oM/Framework/Verification/Reporting/Interfaces/IConditionReportingConfig)&gt; | Dictionary of reporting configs (values) bound to the conditions, which results they are meant to format (keys). | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class LogicalCollectionConditionReportingConfig : BH.oM.Verification.Reporting.IConditionReportingConfig, BH.oM.Base.IObject
```

Assembly: Verification_oM.dll

The C# class definition is available on github:

- [LogicalCollectionConditionReportingConfig.cs](https://github.com/BHoM/BHoM/blob/develop/Verification_oM/Reporting\LogicalCollectionConditionReportingConfig.cs)

All history and changes of the class can be found by inspection the history.
