---
title: SPT
---

# <small>BH.oM.</small>**SPT**

A set of data related to Standard Penetration Tests (SPT) carried out.

## Class structure

### Implemented interfaces and base types

???+ bhom "The SPT is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Ground.[ITest](/api/oM/Analytical/Ground/ITest)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Id | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Location identifier relating the borehole to the strata (LOCA_ID). | - |
| Top | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Depth to the top of the sample, measured from the top of the borehole (ISPT_TOP). | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| NumberofBlows | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | SPT Number of Blows during main drive (ISPT_NVAL). | - |
| EnergyRatio | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Energy Ratio of Hammer (ISPT_ERAT). | [Ratio](/api/oM/Dimensional/Quantities/Attributes/Ratio) [-] |
| MainTestDrive | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Number of blows for main test drive (ISPT_MAIN). | - |
| TotalPenetration | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Total Penetration for seating drive and test drive (ISPT_NPEN). | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| Properties | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ITestProperties](/api/oM/Analytical/Ground/ITestProperties/ITestProperties)&gt; | A list of different properties including references, tests, analysis, results and detection. | - |


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
public class SPT : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.Ground.ITest
```

Assembly: Ground_oM.dll

The class is defined in C#. The class definition is available on github:

- [SPT.cs](https://github.com/BHoM/BHoM/blob/develop/Ground_oM/SPT.cs)

All history and changes of the class can be found by inspection the history.
