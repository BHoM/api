---
title: IValueConditionReportingConfig
---

# <small>BH.oM.Verification.Reporting.</small>**IValueConditionReportingConfig**

Interface for all value condition reporting config objects.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IValueConditionReportingConfig is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Verification.Reporting.[IConditionReportingConfig](/api/oM/Framework/Verification/Reporting/Interfaces/IConditionReportingConfig)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Verification.Reporting.[NumberConditionReportingConfig](/api/oM/Framework/Verification/Reporting/NumberConditionReportingConfig)
    - BH.oM.Verification.Reporting.[ValueConditionReportingConfig](/api/oM/Framework/Verification/Reporting/ValueConditionReportingConfig)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ValueSourceLabelOverride | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IValueConditionReportingConfig : BH.oM.Verification.Reporting.IConditionReportingConfig, BH.oM.Base.IObject
```

Assembly: Verification_oM.dll

The C# interface definition is available on github:

- [IValueConditionReportingConfig.cs](https://github.com/BHoM/BHoM/blob/develop/Verification_oM/Reporting\Interfaces\IValueConditionReportingConfig.cs)

All history and changes of the class can be found by inspection the history.
