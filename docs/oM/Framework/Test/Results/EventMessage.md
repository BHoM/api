---
title: EventMessage
---

# <small>BH.oM.Test.Results.</small>**EventMessage**

Class to store an event raised during the execution on a TestResult.

## Class structure

### Implemented interfaces and base types

???+ bhom "The EventMessage is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Test.[ITestInformation](/api/oM/Framework/Test/ITestInformation)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Message | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Message raised during the execution. | - |
| Status | [TestStatus](/api/oM/Framework/Test/TestStatus) | Severity of the message. | - |
| UTCTime | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/System.DateTime?view=netstandard-2.0) | Provides the UTC time of when the event was raised. | - |
| StackTrace | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Original location where the event was generated. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class EventMessage : BH.oM.Test.ITestInformation, BH.oM.Base.IObject
```

Assembly: Test_oM.dll

The C# class definition is available on github:

- [EventMessage.cs](https://github.com/BHoM/BHoM/blob/develop/Test_oM/Results\EventMessage.cs)

All history and changes of the class can be found by inspection the history.
