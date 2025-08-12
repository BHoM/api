---
title: ITest
---

# <small>BH.oM.Ground.</small>**ITest**

Base interface for all ground tests.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The ITest is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Ground.[InSituVane](/api/oM/Analytical/Ground/InSituVane)
    - BH.oM.Ground.[SPT](/api/oM/Analytical/Ground/SPT)
    - BH.oM.Ground.[Triaxial](/api/oM/Analytical/Ground/Triaxial)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Id | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Location identifier relating the borehole to the test(LOCA_ID). | - |
| Top | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Depth to the top of the sample, measured from the top of the borehole (ISPT_TOP, IVAN_DEPTH, SAMP_TOP). | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| Properties | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ITestProperties](/api/oM/Analytical/Ground/ITestProperties/ITestProperties)&gt; | A list of different properties including references and results. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface ITest : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: Ground_oM.dll

The C# interface definition is available on github:

- [ITest.cs](https://github.com/BHoM/BHoM/blob/develop/Ground_oM/ITest.cs)

All history and changes of the class can be found by inspection the history.
