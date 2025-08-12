---
title: Relation
---

# <small>BH.oM.Analytical.Graph.</small>**Relation**

Base class for all Relation classes.

## Class structure

### Implemented interfaces and base types

???+ bhom "The Relation is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Analytical.Graph.[IRelation](/api/oM/Analytical/Analytical/Graph/IRelation)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Source | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | Reference Guid to source entity. | - |
| Target | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | Reference Guid to target entity. | - |
| Subgraph | [Graph](/api/oM/Analytical/Analytical/Graph/Graph) | This Relation's sub Graph. | - |
| Weight | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Weight of the Relation. | - |
| Curve | [ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve) | Curve that represents the link between the source and target entities. | - |


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
| RelationArrow | [CompositeGeometry](/api/oM/Dimensional/Geometry/Misc/CompositeGeometry) | Returns arrow geometry used to represent a Relation. | - | Analytical_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class Relation : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.Analytical.Graph.IRelation
```

Assembly: Analytical_oM.dll

The C# class definition is available on github:

- [Relation.cs](https://github.com/BHoM/BHoM/blob/develop/Analytical_oM/Graph\Relation.cs)

All history and changes of the class can be found by inspection the history.
