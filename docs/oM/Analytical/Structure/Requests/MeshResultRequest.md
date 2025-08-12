---
title: MeshResultRequest
---

# <small>BH.oM.Structure.Requests.</small>**MeshResultRequest**

Request for extracting mesh results from an adapter.

## Class structure

### Implemented interfaces and base types

???+ bhom "The MeshResultRequest is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Structure.Requests.[IStructuralResultRequest](/api/oM/Analytical/Structure/Requests/IStructuralResultRequest)
    -  BH.oM.Data.Requests.[IResultRequest](/api/oM/Framework/Data/Requests/IResultRequest)
    -  BH.oM.Data.Requests.[IRequest](/api/oM/Framework/Data/Requests/IRequest)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ResultType | [MeshResultType](/api/oM/Analytical/Structure/Results/Mesh/Enums/MeshResultType) | Request for extracting bar results from an adapter. | - |
| Smoothing | [MeshResultSmoothingType](/api/oM/Analytical/Structure/Results/Mesh/Enums/MeshResultSmoothingType) | - | - |
| Layer | [MeshResultLayer](/api/oM/Analytical/Structure/Results/Mesh/Enums/MeshResultLayer) | - | - |
| LayerPosition | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Position within the element thickness that result is extracted from, normalised to 1. I.e. 0 = lower surface, 0.5 = middle, 1 = top surface. | - |
| Orientation | [Basis](/api/oM/Dimensional/Geometry/Vector/Basis) | - | - |
| Cases | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | Defines which cases and/or combinations that results should be extracted for. Can generally be set to either Loadcase or Loadcombination objects, or identifiers matching the software. If nothing is provided, results for all cases will be assumed. | - |
| Modes | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Defines for which modes results should be extracted. Only applicable for some casetypes. If nothing is provided, results for all modes will be assumed. | - |
| ObjectIds | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | Defines which meshes that results should be extracted for. Can generally be set to either pulled Panel/FEMesh objects, or identifiers matching the software. If nothing is provided, results for all meshes will be assumed. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class MeshResultRequest : BH.oM.Structure.Requests.IStructuralResultRequest,
BH.oM.Data.Requests.IResultRequest,
BH.oM.Data.Requests.IRequest,
BH.oM.Base.IObject
```

Assembly: Structure_oM.dll

The C# class definition is available on github:

- [MeshResultRequest.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/Requests\MeshResultRequest.cs)

All history and changes of the class can be found by inspection the history.
