---
title: FormulaConditionReportingConfig
---

# <small>BH.oM.Verification.Reporting.</small>**FormulaConditionReportingConfig**

Config object containing settings for reporting results of checks against formula conditions.

## Class structure

### Implemented interfaces and base types

???+ bhom "The FormulaConditionReportingConfig is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Verification.Reporting.[IConditionReportingConfig](/api/oM/Framework/Verification/Reporting/Interfaces/IConditionReportingConfig)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ComponentConfigs | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [IValueConditionReportingConfig](/api/oM/Framework/Verification/Reporting/Interfaces/IValueConditionReportingConfig)&gt; | Dictionary of reporting configs (values) bound to the components, which values they are meant to format (keys). | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class FormulaConditionReportingConfig : BH.oM.Verification.Reporting.IConditionReportingConfig, BH.oM.Base.IObject
```

Assembly: Verification_oM.dll

The C# class definition is available on github:

- [FormulaConditionReportingConfig.cs](https://github.com/BHoM/BHoM/blob/develop/Verification_oM/Reporting\FormulaConditionReportingConfig.cs)

All history and changes of the class can be found by inspection the history.
