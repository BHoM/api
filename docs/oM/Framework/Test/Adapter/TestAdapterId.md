---
title: TestAdapterId
---

# <small>BH.oM.Test.Adapter.</small>**TestAdapterId**

Class to use for tests requiring an IAdapterId to be assigned to objects being tested.

## Class structure

### Implemented interfaces and base types

???+ bhom "The TestAdapterId is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IAdapterId](/api/oM/Framework/Base/Interface/IAdapterId)
    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Id | [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0) | The Id of the object to use for the test. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class TestAdapterId : BH.oM.Base.IAdapterId, BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: Test_oM.dll

The C# class definition is available on github:

- [TestAdapterId.cs](https://github.com/BHoM/BHoM/blob/develop/Test_oM/Adapter\TestAdapterId.cs)

All history and changes of the class can be found by inspection the history.
