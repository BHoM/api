---
title: ITestInformation
---

# <small>BH.oM.Test.</small>**ITestInformation**



## Interface structure

### Implemented interfaces and base types

???+ bhom "The ITestInformation is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Test.Results.[EventMessage](/api/oM/Framework/Test/Results/EventMessage)
    - BH.oM.Test.Results.[TestResult](/api/oM/Framework/Test/Results/TestResult)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Message | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Status | [TestStatus](/api/oM/Framework/Test/TestStatus) | - | - |
| UTCTime | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/System.DateTime?view=netstandard-2.0) | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IFullMessage | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - | Test_Engine |
| INewResultAfterCrashFix | [ITestInformation](/api/oM/Framework/Test/ITestInformation) | Gets a ITestInformation back that correspond to a situation where the reference data was showing a crash no longer present.<br>Used when comparing to TestResults against each other and information in the reference can not be found in the new data. | - | InteroperabilityTest_Engine |
| INoReferenceFound | [ITestInformation](/api/oM/Framework/Test/ITestInformation) | Gets a ITestInformation back that correspond to no reference data was available that matching the result.<br>Used when comparing to TestResults against each other and information in the reference can not be found in the new data. | - | InteroperabilityTest_Engine |
| IOnlyReferenceFound | [ITestInformation](/api/oM/Framework/Test/ITestInformation) | Gets a TestInformation result back that correspond to an information only found in the reference set when compared to data just run.<br>Used when comparing to TestResults against each other and information in the reference can not be found in the new data. | - | InteroperabilityTest_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface ITestInformation : BH.oM.Base.IObject
```

Assembly: Test_oM.dll

The C# interface definition is available on github:

- [ITestInformation.cs](https://github.com/BHoM/BHoM/blob/develop/Test_oM/ITestInformation.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Test_oM/ITestInformation.json"
}
```

The JSON Schema is available on github here:

- [ITestInformation.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Test_oM/ITestInformation.json)
