---
title: IPanelAutoMesh
---

# <small>BH.oM.Adapters.SAP2000.Fragments.</small>**IPanelAutoMesh**

Base interface for panel auto mesh settings in SAP2000. Contains the type of auto mesh and the properties common to all types.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IPanelAutoMesh is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Adapters.SAP2000.Fragments.[PanelAutoMeshByCookieCutLines](/api/oM/Adapter/Adapters/SAP2000/Fragments/PanelAutoMeshByCookieCutLines)
    - BH.oM.Adapters.SAP2000.Fragments.[PanelAutoMeshByCookieCutPoints](/api/oM/Adapter/Adapters/SAP2000/Fragments/PanelAutoMeshByCookieCutPoints)
    - BH.oM.Adapters.SAP2000.Fragments.[PanelAutoMeshByGeneralDivide](/api/oM/Adapter/Adapters/SAP2000/Fragments/PanelAutoMeshByGeneralDivide)
    - BH.oM.Adapters.SAP2000.Fragments.[PanelAutoMeshByMaximumSize](/api/oM/Adapter/Adapters/SAP2000/Fragments/PanelAutoMeshByMaximumSize)
    - BH.oM.Adapters.SAP2000.Fragments.[PanelAutoMeshByNumberOfObjects](/api/oM/Adapter/Adapters/SAP2000/Fragments/PanelAutoMeshByNumberOfObjects)
    - BH.oM.Adapters.SAP2000.Fragments.[PanelAutoMeshByPointsOnEdges](/api/oM/Adapter/Adapters/SAP2000/Fragments/PanelAutoMeshByPointsOnEdges)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| LocalAxesOnEdge | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If this item is True, and if both points along an edge of the original area object have the same local axes, the program makes the local axes for added points along the edge the same as the edge end points. | - |
| LocalAxesOnFace | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If this item is True, and if all points around the perimeter of the original area object have the same local axes, the program makes the local axes for all added points the same as the perimeter points. | - |
| RestraintsOnEdge | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If this item is True, and if both points along an edge of the original area object have the same restraint/constraint, then, if the added point and the adjacent corner points have the same local axes definition, the program includes the restraint/constraint for added points along the edge. | - |
| RestraintsOnFace | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If this item is True, and if all points around the perimeter of the original area object have the same restraint/constraint, then, if an added point and the perimeter points have the same local axes definition, the program includes the restraint/constraint for the added point. | - |
| Group | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The name of a defined group. Some of the meshing options make use of point and line objects included in this group. | - |
| SubMesh | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If this item is True, after initial meshing, the program further meshes any area objects that have an edge longer than the length specified by the SubMeshSize item. | - |
| SubMeshSize | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | This item applies when the SubMesh item is True. It is the maximum size of area objects to remain when the auto meshing is complete. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IPanelAutoMesh : BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: SAP2000_oM.dll

The C# interface definition is available on github:

- [IPanelAutoMesh.cs](https://github.com/BHoM/SAP2000_Toolkit/blob/develop/SAP2000_oM/Fragments\IPanelAutoMesh.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/SAP2000_oM/Fragments/IPanelAutoMesh.json"
}
```

The JSON Schema is available on github here:

- [IPanelAutoMesh.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/SAP2000_oM/Fragments/IPanelAutoMesh.json)
