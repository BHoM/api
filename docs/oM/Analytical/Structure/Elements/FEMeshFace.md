---
title: FEMeshFace
---

# <small>BH.oM.Structure.Elements.</small>**FEMeshFace**

Face of an FEMesh. The face is defined by the indices of its nodes in the node list. Geometrical information about position in space is stored on the host FEMesh.

## Class structure

### Implemented interfaces and base types

???+ bhom "The FEMeshFace is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Analytical.Elements.[IFace](/api/oM/Analytical/Analytical/Elements/IFace)
    -  BH.oM.Analytical.[IAnalytical](/api/oM/Analytical/Analytical/IAnalytical)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| NodeListIndices | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0)&gt; | List of which node indices in the host FEMesh node list that this face is connecting. | - |
| OrientationAngle | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Defines the angle that the local x and y axes are rotated around the normal (i.e. local z) of the FEMeshFace.<br>The normal of the FEMeshFace is determined by the curl right hand rule dictated by the order of the node list.<br>Local x is found by projecting the global X to the plane of the FEMeshFace and is then rotated with the OrientationAngle, except for the case when the Normal is parallel with the global X. For this case the local y is instead found by projecting global Y to the plane of the FEMeshFace and is then rotated with the OrientationAngle.<br>The remaining local axis is determined by the right hand rule. | [Angle](/api/oM/Dimensional/Quantities/Attributes/Angle) [rad] |


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
| Geometry | [Face](/api/oM/Dimensional/Geometry/Mesh/Face) | Gets the geometry of a analytical IFace as a geometrical Mesh's Face. A geometrical mesh face only supports 3 and 4 nodes faces, while a FEMeshFace does not have this limitation. For FEMeshFaces with more than 4 nodes or less than 3 this operation is therefore not possible. Method required for automatic display in UI packages. | - | Analytical_Engine |
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if an FEMeshFace or its defining properties are null and outputs relevant error message. | - | Structure_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class FEMeshFace : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.Analytical.Elements.IFace, BH.oM.Analytical.IAnalytical
```

Assembly: Structure_oM.dll

The C# class definition is available on github:

- [FEMeshFace.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/Elements\FEMeshFace.cs)

All history and changes of the class can be found by inspection the history.
