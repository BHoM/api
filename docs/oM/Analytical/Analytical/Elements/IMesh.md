---
title: IMesh&lt;TNode,TFace&gt;
---

# <small>BH.oM.Analytical.Elements.</small>**IMesh&lt;TNode,TFace&gt;**



## Interface structure

### Generic parameters

The IMesh contains the following generic paramters:

#### TNode

Constrained by the following arguments:

- BH.oM.Analytical.Elements.[INode](/api/oM/Analytical/Analytical/Elements/INode)

#### TFace

Constrained by the following arguments:

- BH.oM.Analytical.Elements.[IFace](/api/oM/Analytical/Analytical/Elements/IFace)

### Implemented interfaces and base types

???+ bhom "The IMesh`2 is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Analytical.[IAnalytical](/api/oM/Analytical/Analytical/IAnalytical)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Structure.Elements.[FEMesh](/api/oM/Analytical/Structure/Elements/FEMesh)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Nodes | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[TNode](#tnode)&gt; | - | - |
| Faces | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[TFace](#tface)&gt; | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Geometry | [Mesh](/api/oM/Dimensional/Geometry/Mesh/Mesh) | Gets the geometry of a analytical IMesh as a geometrical Mesh. A geometrical mesh only supports 3 and 4 nodes faces, while a FEMesh does not have this limitation. For FEMeshFaces with more than 4 nodes or less than 3 this operation is therefore not possible. Method required for automatic display in UI packages. | - | Analytical_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IMesh`2 : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.Analytical.IAnalytical
```

Assembly: Analytical_oM.dll

The C# interface definition is available on github:

- [IMesh.cs](https://github.com/BHoM/BHoM/blob/develop/Analytical_oM/Elements\IMesh.cs)

All history and changes of the class can be found by inspection the history.
