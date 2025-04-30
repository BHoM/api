---
title: MeshVonMises
---

# <small>BH.oM.Structure.Results.</small>**MeshVonMises**

von Mises stress, force and moment at a discrete location in the Panel/FEMesh.

## Class structure

### Implemented interfaces and base types

???+ bhom "The MeshVonMises is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Structure.Results.[MeshElementResult](/api/oM/Analytical/Structure/Results/Mesh/MeshElementResult)
    -  BH.oM.Analytical.Results.[IMeshElementResult](/api/oM/Analytical/Analytical/Results/IMeshElementResult)
    -  BH.oM.Analytical.Results.[IResult](/api/oM/Analytical/Analytical/Results/IResult)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  [IComparable](https://learn.microsoft.com/en-us/dotnet/api/System.IComparable-1?view=netstandard-2.0)&lt;BH.oM.Analytical.Results.[IResult](/api/oM/Analytical/Analytical/Results/IResult)&gt;
    -  BH.oM.Base.[IImmutable](/api/oM/Framework/Base/Interface/IImmutable)
    -  BH.oM.Structure.Results.[IStructuralResult](/api/oM/Analytical/Structure/Results/IStructuralResult)
    -  BH.oM.Analytical.Results.[IObjectIdResult](/api/oM/Analytical/Analytical/Results/IObjectIdResult)
    -  BH.oM.Analytical.Results.[ICasedResult](/api/oM/Analytical/Analytical/Results/ICasedResult)
    -  BH.oM.Analytical.Results.[ITimeStepResult](/api/oM/Analytical/Analytical/Results/ITimeStepResult)
    -  BH.oM.Analytical.Results.[IResultItem](/api/oM/Analytical/Analytical/Results/IResultItem)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| S | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | von Mises Stress. | [Stress](/api/oM/Dimensional/Quantities/Attributes/Stress) [Pa] |
| N | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | von Mises normal/membrane forces. | [ForcePerUnitLength](/api/oM/Dimensional/Quantities/Attributes/ForcePerUnitLength) [N/m] |
| M | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | von Mises moments. | [MomentPerUnitLength](/api/oM/Dimensional/Quantities/Attributes/MomentPerUnitLength) [N.m/m] |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ObjectId | [IComparable](https://learn.microsoft.com/en-us/dotnet/api/System.IComparable?view=netstandard-2.0) | Id of the FEMesh/Panel that this result belongs to. When extracted from an analysis package, the object id will match the format and value used in that particular package. | - |
| NodeId | [IComparable](https://learn.microsoft.com/en-us/dotnet/api/System.IComparable?view=netstandard-2.0) | Id of the Node in the mesh that this result belongs to. Will be empty for smoothing types not relating to Nodes. When extracted from an analysis package, the Node id will correspond to the node id in the software and match the format and value used in that particular package. | - |
| MeshFaceId | [IComparable](https://learn.microsoft.com/en-us/dotnet/api/System.IComparable?view=netstandard-2.0) | Id of the FEFace that this result belongs to. Will be empty for smoothing types not relating to Faces. When extracted from an analysis package, the face id will correspond to the face id in the software and match the format and value used in that particular package. | - |
| ResultCase | [IComparable](https://learn.microsoft.com/en-us/dotnet/api/System.IComparable?view=netstandard-2.0) | Identifier for the Loadcase or LoadCombination that the result belongs to. Is generally name or number of the loadcase, depending on the analysis package. | - |
| ModeNumber | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Positive index, starting at one. Only set for cases with modal outputs such as dynamic cases. | - |
| TimeStep | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Time step for time history results. | - |
| MeshResultLayer | [MeshResultLayer](/api/oM/Analytical/Structure/Results/Mesh/Enums/MeshResultLayer) | - | - |
| LayerPosition | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Position within the element thickness that result is extracted from, normalised to 1. I.e. 0 = lower surface, 0.5 = middle, 1 = top surface. | - |
| Smoothing | [MeshResultSmoothingType](/api/oM/Analytical/Structure/Results/Mesh/Enums/MeshResultSmoothingType) | - | - |
| Orientation | [Basis](/api/oM/Dimensional/Geometry/Vector/Basis) | Vector basis required in order to report results in a particular direction, for example, for anisotropic materials. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| AllIdentifierProperties | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Gets the name of all properties of the result that are of identifier types. This is all properties tagged with any IdentifierAttribute. | - | Results_Engine |
| ObjectIdentifierProperties | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Gets the name of all properties of the result that are of ObjectIdentifier types. This is all properties tagged with the ObjectIdentifierAttribute. | - | Results_Engine |
| ResultPropertyKeys | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Returns the result value carrying properties available for the result type provided. Currently only supported for IResultItem and IResultCollection&lt;IResultItem&gt; type results. | - | Results_Engine |
| ScenarioIdentifierProperties | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Gets the name of all properties of the result that are of Scenario types. This is all properties tagged with the ScenarioIdentifierAttribute. | - | Results_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class MeshVonMises : BH.oM.Structure.Results.MeshElementResult,
BH.oM.Analytical.Results.IMeshElementResult,
BH.oM.Analytical.Results.IResult,
BH.oM.Base.IObject,
System.IComparable<BH.oM.Analytical.Results.IResult>,
BH.oM.Base.IImmutable,
BH.oM.Structure.Results.IStructuralResult,
BH.oM.Analytical.Results.IObjectIdResult,
BH.oM.Analytical.Results.ICasedResult,
BH.oM.Analytical.Results.ITimeStepResult,
BH.oM.Analytical.Results.IResultItem
```

Assembly: Structure_oM.dll

The class is defined in C#. The class definition is available on github:

- [MeshVonMises.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/Results\Mesh\MeshVonMises.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` { .json .copy .select } title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Structure_oM/Results/MeshVonMises.json}
```

The JSON Schema is available on github here:

- [MeshVonMises.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Structure_oM/Results/MeshVonMises.json)
