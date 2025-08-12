---
title: AnalysisGrid
---

# <small>BH.oM.Lighting.Analysis.</small>**AnalysisGrid**

An AnalysisGrid is used to define an area in 3D space that should be analysed for a given set of results, e.g. daylighting levels, wind levels, heat indexes, etc. - an AnalysisGrid can be used to represent a measurable bit of the environment, including a void in a space, or it can be used to represent a mesh on a panel for analysis

## Class structure

### Implemented interfaces and base types

???+ bhom "The AnalysisGrid is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Base.[IImmutable](/api/oM/Framework/Base/Interface/IImmutable)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BoundaryCurve | [Polyline](/api/oM/Dimensional/Geometry/Curve/Polyline) | The BoundaryCurve is the outer-most edges of the AnalysisGrid. Nodes should not fall outside of this curve | - |
| InnerCurves | [ReadOnlyCollection](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1?view=netstandard-2.0)&lt;[Polyline](/api/oM/Dimensional/Geometry/Curve/Polyline)&gt; | The InnerCurves define any openings within the AnalysisGrid which should not be analysed or included in results, such as windows, doors, or atriums | - |
| Nodes | [ReadOnlyCollection](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1?view=netstandard-2.0)&lt;[Node](/api/oM/Analytical/Lighting/Analysis/Node)&gt; | The Nodes define the geometric points in 3D space that form the analysis points of this grid. Each node in the Nodes property will be analysed in the analysis package | - |
| ID | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | The ID of the AnalysisGrid. This should be unique for AnalysisGrids in a collection and is used to refer to result objects in the ObjectId property of result objects | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The name for the AnalysisGrid to identify it for users | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class AnalysisGrid : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.Base.IImmutable
```

Assembly: Lighting_oM.dll

The C# class definition is available on github:

- [AnalysisGrid.cs](https://github.com/BHoM/BHoM/blob/develop/Lighting_oM/Analysis\AnalysisGrid.cs)

All history and changes of the class can be found by inspection the history.
