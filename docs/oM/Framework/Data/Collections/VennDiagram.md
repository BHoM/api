---
title: VennDiagram&lt;T&gt;
---

# <small>BH.oM.Data.Collections.</small>**VennDiagram&lt;T&gt;**



## Class structure

### Generic parameters

The VennDiagram contains the following generic paramters:

#### T

Unconstrained generic type. Can be any type of object.

### Implemented interfaces and base types

???+ bhom "The VennDiagram`1 is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Data.Collections.[IDataStructure](/api/oM/Framework/Data/Collections/IDataStructure)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Intersection | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Tuple](https://learn.microsoft.com/en-us/dotnet/api/System.Tuple-2?view=netstandard-2.0)&lt;[T](#t), [T](#t)&gt;&gt; | - | - |
| OnlySet1 | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[T](#t)&gt; | - | - |
| OnlySet2 | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[T](#t)&gt; | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class VennDiagram`1 : BH.oM.Data.Collections.IDataStructure, BH.oM.Base.IObject
```

Assembly: Data_oM.dll

The class is defined in C#. The class definition is available on github:

- [VennDiagram.cs](https://github.com/BHoM/BHoM/blob/develop/Data_oM/Collections\VennDiagram.cs)

All history and changes of the class can be found by inspection the history.
