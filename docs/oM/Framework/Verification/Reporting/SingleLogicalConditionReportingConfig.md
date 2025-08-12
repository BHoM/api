---
title: SingleLogicalConditionReportingConfig
---

# <small>BH.oM.Verification.Reporting.</small>**SingleLogicalConditionReportingConfig**

Config object containing settings for reporting results of checks against logical conditions with a single nested condition.

## Class structure

### Implemented interfaces and base types

???+ bhom "The SingleLogicalConditionReportingConfig is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Verification.Reporting.[IConditionReportingConfig](/api/oM/Framework/Verification/Reporting/Interfaces/IConditionReportingConfig)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| NestedConfig | [IConditionReportingConfig](/api/oM/Framework/Verification/Reporting/Interfaces/IConditionReportingConfig) | Reporting config to be applied to format the check report of nested condition. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class SingleLogicalConditionReportingConfig : BH.oM.Verification.Reporting.IConditionReportingConfig, BH.oM.Base.IObject
```

Assembly: Verification_oM.dll

The C# class definition is available on github:

- [SingleLogicalConditionReportingConfig.cs](https://github.com/BHoM/BHoM/blob/develop/Verification_oM/Reporting\SingleLogicalConditionReportingConfig.cs)

All history and changes of the class can be found by inspection the history.
