---
title: INode
---

# <small>BH.oM.Programming.</small>**INode**

Interface common to all syntax nodes

## Interface structure

### Implemented interfaces and base types

???+ bhom "The INode is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Programming.[BlockNode](/api/oM/Framework/Programming/Nodes/BlockNode)
    - BH.oM.Programming.[ClusterNode](/api/oM/Framework/Programming/Nodes/ClusterNode)
    - BH.oM.Programming.[ConstructorNode](/api/oM/Framework/Programming/Nodes/ConstructorNode)
    - BH.oM.Programming.[CustomObjectNode](/api/oM/Framework/Programming/Nodes/CustomObjectNode)
    - BH.oM.Programming.[ExplodeNode](/api/oM/Framework/Programming/Nodes/ExplodeNode)
    - BH.oM.Programming.[GetPropertyNode](/api/oM/Framework/Programming/Nodes/GetPropertyNode)
    - BH.oM.Programming.[InitialiserNode](/api/oM/Framework/Programming/Nodes/InitialiserNode)
    - BH.oM.Programming.[LibraryNode](/api/oM/Framework/Programming/Nodes/LibraryNode)
    - BH.oM.Programming.[LoopNode](/api/oM/Framework/Programming/Nodes/LoopNode)
    - BH.oM.Programming.[MethodNode](/api/oM/Framework/Programming/Nodes/MethodNode)
    - BH.oM.Programming.[ParamNode](/api/oM/Framework/Programming/Nodes/ParamNode)
    - BH.oM.Programming.[SetPropertyNode](/api/oM/Framework/Programming/Nodes/SetPropertyNode)
    - BH.oM.Programming.[TypeNode](/api/oM/Framework/Programming/Nodes/TypeNode)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Inputs | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ReceiverParam](/api/oM/Framework/Programming/Params/ReceiverParam)&gt; | - | - |
| Outputs | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[DataParam](/api/oM/Framework/Programming/Params/DataParam)&gt; | - | - |
| Description | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| IsInline | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - |
| IsDeclaration | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IDataTypePerParam | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0), [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=netstandard-2.0)&gt; | Collect the data type for each parameter in the input syntax node. | - | Programming_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface INode : BH.oM.Base.IObject
```

Assembly: Programming_oM.dll

The C# interface definition is available on github:

- [INode.cs](https://github.com/BHoM/BHoM/blob/develop/Programming_oM/Nodes\INode.cs)

All history and changes of the class can be found by inspection the history.
