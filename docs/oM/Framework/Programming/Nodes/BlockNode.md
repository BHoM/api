---
title: BlockNode
---

# <small>BH.oM.Programming.</small>**BlockNode**

Represents a group of syntax nodes covered by a common description. This is equivalent to a block of code inside a method.

## Class structure

### Implemented interfaces and base types

???+ bhom "The BlockNode is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Programming.[INode](/api/oM/Framework/Programming/Nodes/INode)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| InternalNodes | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[INode](/api/oM/Framework/Programming/Nodes/INode)&gt; | - | - |
| Description | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Outputs | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[DataParam](/api/oM/Framework/Programming/Params/DataParam)&gt; | - | - |
| Inputs | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ReceiverParam](/api/oM/Framework/Programming/Params/ReceiverParam)&gt; | - | - |
| IsInline | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - |
| IsDeclaration | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IDataTypePerParam | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0), [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=netstandard-2.0)&gt; | Collect the data type for each parameter in the input syntax node. | - | Programming_Engine |
| IReturnType | TypeSyntax | Get the C# type syntax corresponding to the first output of a node. | - | CSharp_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class BlockNode : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.Programming.INode
```

Assembly: Programming_oM.dll

The class is defined in C#. The class definition is available on github:

- [BlockNode.cs](https://github.com/BHoM/BHoM/blob/develop/Programming_oM/Nodes\BlockNode.cs)

All history and changes of the class can be found by inspection the history.
