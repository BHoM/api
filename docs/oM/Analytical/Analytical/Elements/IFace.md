---
title: IFace
---

# <small>BH.oM.Analytical.Elements.</small>**IFace**



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IFace is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Analytical.[IAnalytical](/api/oM/Analytical/Analytical/IAnalytical)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Structure.Elements.[FEMeshFace](/api/oM/Analytical/Structure/Elements/FEMeshFace)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| NodeListIndices | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0)&gt; | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Geometry | [Face](/api/oM/Dimensional/Geometry/Mesh/Face) | Gets the geometry of a analytical IFace as a geometrical Mesh's Face. A geometrical mesh face only supports 3 and 4 nodes faces, while a FEMeshFace does not have this limitation. For FEMeshFaces with more than 4 nodes or less than 3 this operation is therefore not possible. Method required for automatic display in UI packages. | - | Analytical_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IFace : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.Analytical.IAnalytical
```

Assembly: Analytical_oM.dll

The C# interface definition is available on github:

- [IFace.cs](https://github.com/BHoM/BHoM/blob/develop/Analytical_oM/Elements\IFace.cs)

All history and changes of the class can be found by inspection the history.
