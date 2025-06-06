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
