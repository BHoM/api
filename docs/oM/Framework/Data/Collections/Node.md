---
title: INode&lt;T&gt;
---

# <small>BH.oM.Data.Collections.</small>**INode&lt;T&gt;**

The base interface for data tree nodes. Exposes generic helper Create and Query methods for working with data trees. Objects implementing this interface will be required to implement Values() &amp; Children() methods for getting data from an INode.

## Interface structure

### Generic parameters

The INode contains the following generic paramters:

#### T

Unconstrained generic type. Can be any type of object.

### Implemented interfaces and base types

???+ bhom "The INode`1 is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Data.Collections.[IDataStructure](/api/oM/Framework/Data/Collections/IDataStructure)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Data.Collections.[DomainTree](/api/oM/Framework/Data/Collections/DomainTree)&lt;[T](/api/oM/Framework/Data/Collections/DomainTree#t)&gt;


## Properties

### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IValues | [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netstandard-2.0)&lt;T&gt; | Gets the data values contained in this node. | - | Data_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface INode`1 : BH.oM.Data.Collections.IDataStructure, BH.oM.Base.IObject
```

Assembly: Data_oM.dll

The C# interface definition is available on github:

- [INode.cs](https://github.com/BHoM/BHoM/blob/develop/Data_oM/Collections\Node.cs)

All history and changes of the class can be found by inspection the history.
