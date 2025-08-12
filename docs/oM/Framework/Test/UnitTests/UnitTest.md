---
title: UnitTest
---

# <small>BH.oM.Test.UnitTests.</small>**UnitTest**

Defines a data-driven unit test for a specific method. Class defines inputs, method to be run and expected output.

## Class structure

### Implemented interfaces and base types

???+ bhom "The UnitTest is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Method | [MethodBase](https://learn.microsoft.com/en-us/dotnet/api/System.Reflection.MethodBase?view=netstandard-2.0) | The method to be tested. For BHoM methods this can be extracted from the BHoMMethodList method in the Reflection_Engine. | - |
| Data | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[TestData](/api/oM/Framework/Test/UnitTests/TestData)&gt; | List of input/output pairs to test the method for. Each TestData item corresponds to one run of the method. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class UnitTest : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: Test_oM.dll

The C# class definition is available on github:

- [UnitTest.cs](https://github.com/BHoM/BHoM/blob/develop/Test_oM/UnitTests\UnitTest.cs)

All history and changes of the class can be found by inspection the history.
