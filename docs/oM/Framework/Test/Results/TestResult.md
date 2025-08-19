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


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| ExceptionProperties | [Output](/api/oM/Framework/Base/Output)&lt;[List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt;, [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt;, [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt;&gt; | Finds all properties reported and dispatches to output corresponding to error, warning and passes. | - | InteroperabilityTest_Engine |
| ExceptionProperties | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Finds all properties reported and groups them by status level and returns a string containing all reported properties. | - | InteroperabilityTest_Engine |
| FullMessage | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Returns a full concatenated message for a test result and its inner result to the target max depth, only giving messages worse or equal to the provided severity level. | - | Test_Engine |
| IFullMessage | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - | Test_Engine |
| INewResultAfterCrashFix | [ITestInformation](/api/oM/Framework/Test/ITestInformation) | Gets a ITestInformation back that correspond to a situation where the reference data was showing a crash no longer present.<br>Used when comparing to TestResults against each other and information in the reference can not be found in the new data. | - | InteroperabilityTest_Engine |
| INoReferenceFound | [ITestInformation](/api/oM/Framework/Test/ITestInformation) | Gets a ITestInformation back that correspond to no reference data was available that matching the result.<br>Used when comparing to TestResults against each other and information in the reference can not be found in the new data. | - | InteroperabilityTest_Engine |
| IOnlyReferenceFound | [ITestInformation](/api/oM/Framework/Test/ITestInformation) | Gets a TestInformation result back that correspond to an information only found in the reference set when compared to data just run.<br>Used when comparing to TestResults against each other and information in the reference can not be found in the new data. | - | InteroperabilityTest_Engine |
| NewResultAfterCrashFix | [TestResult](/api/oM/Framework/Test/Results/TestResult) | Gets a ComparisonDifference back that correspond to a situation where the reference data was showing a crash no longer present.<br>Used when comparing to TestResults against each other and information in the reference can not be found in the new data.<br>This is generally a good situation, but the data now able to be pushed needs to be validated.<br>Recursivly adds any inner TestInformation as NewResultAfterCrashFix. | - | InteroperabilityTest_Engine |
| NonEventMessageInformation | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ITestInformation](/api/oM/Framework/Test/ITestInformation)&gt; | Gets all inner information from the result that is not null and not of type EventMessage. Used for recursive comparison between two TestResults. | - | InteroperabilityTest_Engine |
| NoReferenceFound | [TestResult](/api/oM/Framework/Test/Results/TestResult) | Gets a TestResult back that correspond to no reference data was available that matching the result.<br>Used when comparing to TestResults against each other and information in the reference can not be found in the new data.<br>Recursivly adds any inner TestInformation as no reference found. | - | InteroperabilityTest_Engine |
| OnlyReferenceFound | [TestResult](/api/oM/Framework/Test/Results/TestResult) | Gets a TestResult result back that correspond to an information only found in the reference set when compared to data just run.<br>Used when comparing to TestResults against each other and information in the reference can not be found in the new data.<br>Recursivly adds any inner TestInformation as data only found in reference. | - | InteroperabilityTest_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class TestResult : BH.oM.Test.ITestInformation, BH.oM.Base.IObject
```

Assembly: Test_oM.dll

The C# class definition is available on github:

- [TestResult.cs](https://github.com/BHoM/BHoM/blob/develop/Test_oM/Results\TestResult.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Test_oM/Results/TestResult.json"
}
```

The JSON Schema is available on github here:

- [TestResult.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Test_oM/Results/TestResult.json)
