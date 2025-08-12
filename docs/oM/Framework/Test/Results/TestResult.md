---
title: TestResult
---

# <small>BH.oM.Test.Results.</small>**TestResult**



## Class structure

### Implemented interfaces and base types

???+ bhom "The TestResult is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Test.[ITestInformation](/api/oM/Framework/Test/ITestInformation)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Description | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Describes the focus of the test that this Test Result answers. This is typically for CI processes but should be human readable for ease of use. | - |
| Status | [TestStatus](/api/oM/Framework/Test/TestStatus) | States whether the test was a success or not. Defaults to Error to ensure any defaults are investigated appropriately. | - |
| Information | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ITestInformation](/api/oM/Framework/Test/ITestInformation)&gt; | Information generated during the test. | - |
| Message | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | A human readable message explaining why this Test Result has turned out the way it has, with potential solutions or links to associated wiki pages. | - |
| UTCTime | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/System.DateTime?view=netstandard-2.0) | Provides the UTC time of when the Test Result was executed. | - |
| ID | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Machine readable identifier for the Test Result. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class TestResult : BH.oM.Test.ITestInformation, BH.oM.Base.IObject
```

Assembly: Test_oM.dll

The C# class definition is available on github:

- [TestResult.cs](https://github.com/BHoM/BHoM/blob/develop/Test_oM/Results\TestResult.cs)

All history and changes of the class can be found by inspection the history.
