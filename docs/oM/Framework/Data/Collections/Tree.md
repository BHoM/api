---
title: Tree&lt;T&gt;
---

# <small>BH.oM.Data.Collections.</small>**Tree&lt;T&gt;**



## Class structure

### Generic parameters

The Tree contains the following generic paramters:

#### T

Unconstrained generic type. Can be any type of object.

### Implemented interfaces and base types

???+ bhom "The Tree`1 is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Data.Collections.[IDataStructure](/api/oM/Framework/Data/Collections/IDataStructure)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Children | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [Tree](/api/oM/Framework/Data/Collections/Tree)&lt;[T](#t)&gt;&gt; | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Value | [T](#t) | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Children | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Tree](/api/oM/Framework/Data/Collections/Tree)&lt;T&gt;&gt; | Gets the child nodes of this node. | - | Data_Engine |
| Count | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Get the number of children contained by the tree. Takes the sum of the number of values each child of the tree has. | - | Data_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class Tree`1 : BH.oM.Data.Collections.IDataStructure, BH.oM.Base.IObject
```

Assembly: Data_oM.dll

The C# class definition is available on github:

- [Tree.cs](https://github.com/BHoM/BHoM/blob/develop/Data_oM/Collections\Tree.cs)

All history and changes of the class can be found by inspection the history.
