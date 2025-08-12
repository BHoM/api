---
title: LocalData&lt;T&gt;
---

# <small>BH.oM.Data.Collections.</small>**LocalData&lt;T&gt;**



## Class structure

### Generic parameters

The LocalData contains the following generic paramters:

#### T

Unconstrained generic type. Can be any type of object.

### Implemented interfaces and base types

???+ bhom "The LocalData`1 is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Data.Collections.[IDataStructure](/api/oM/Framework/Data/Collections/IDataStructure)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Position | [Point](/api/oM/Dimensional/Geometry/Vector/Point) | - | - |
| Data | [T](#t) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class LocalData`1 : BH.oM.Data.Collections.IDataStructure, BH.oM.Base.IObject
```

Assembly: Data_oM.dll

The C# class definition is available on github:

- [LocalData.cs](https://github.com/BHoM/BHoM/blob/develop/Data_oM/Collections\LocalData.cs)

All history and changes of the class can be found by inspection the history.
