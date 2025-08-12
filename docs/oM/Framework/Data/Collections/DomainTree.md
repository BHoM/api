---
title: DomainTree&lt;T&gt;
---

# <small>BH.oM.Data.Collections.</small>**DomainTree&lt;T&gt;**

A data tree which is traversed through DomainBoxes. Each node's DomainBox is assumed to be enclosed by its parent's DomainBox and to enclose its own data. All the tree's data is stored in its leaves.

## Class structure

### Generic parameters

The DomainTree contains the following generic paramters:

#### T

Unconstrained generic type. Can be any type of object.

### Implemented interfaces and base types

???+ bhom "The DomainTree`1 is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Data.Collections.[INode](/api/oM/Framework/Data/Collections/Node)&lt;[T](/api/oM/Framework/Data/Collections/Node#t)&gt;
    -  BH.oM.Data.Collections.[IDataStructure](/api/oM/Framework/Data/Collections/IDataStructure)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Children | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[DomainTree](/api/oM/Framework/Data/Collections/DomainTree)&lt;[T](#t)&gt;&gt; | The child nodes of this node. All child nodes DomainBoxes are assumed to be enclosed by this nodes DomainBox. An empty list indicates this node as a leaf node | - |
| Values | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[T](#t)&gt; | The data values stored on this node. The DomainTree assumes that only nodes with an empty list of children have values. | - |
| DomainBox | [DomainBox](/api/oM/Framework/Data/Collections/DomainBox) | This nodes DomainBox, enclosing either all the child nodes' DomainBoxes or this node's Values. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Children | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[DomainTree](/api/oM/Framework/Data/Collections/DomainTree)&lt;T&gt;&gt; | Gets the child nodes of this node. | - | Data_Engine |
| IValues | [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netstandard-2.0)&lt;T&gt; | Gets the data values contained in this node. | - | Data_Engine |
| Values | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;T&gt; | Gets the data values contained in this node. | - | Data_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class DomainTree`1 : BH.oM.Data.Collections.INode<>, BH.oM.Data.Collections.IDataStructure, BH.oM.Base.IObject
```

Assembly: Data_oM.dll

The C# class definition is available on github:

- [DomainTree.cs](https://github.com/BHoM/BHoM/blob/develop/Data_oM/Collections\DomainTree.cs)

All history and changes of the class can be found by inspection the history.
