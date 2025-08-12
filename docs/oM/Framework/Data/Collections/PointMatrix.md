---
title: PointMatrix&lt;T&gt;
---

# <small>BH.oM.Data.Collections.</small>**PointMatrix&lt;T&gt;**



## Class structure

### Generic parameters

The PointMatrix contains the following generic paramters:

#### T

Unconstrained generic type. Can be any type of object.

### Implemented interfaces and base types

???+ bhom "The PointMatrix`1 is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Data.Collections.[IDataStructure](/api/oM/Framework/Data/Collections/IDataStructure)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| CellSize | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| Data | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[DiscretePoint](/api/oM/Framework/Data/Collections/DiscretePoint), [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[LocalData](/api/oM/Framework/Data/Collections/LocalData)&lt;[T](#t)&gt;&gt;&gt; | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class PointMatrix`1 : BH.oM.Data.Collections.IDataStructure, BH.oM.Base.IObject
```

Assembly: Data_oM.dll

The C# class definition is available on github:

- [PointMatrix.cs](https://github.com/BHoM/BHoM/blob/develop/Data_oM/Collections\PointMatrix.cs)

All history and changes of the class can be found by inspection the history.
