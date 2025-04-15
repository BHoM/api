---
title: Graph
---

# Analytical.Graph.Graph

A set of IBHoMObject entities and the relations between them.

## Class structure

### Implemented interfaces and base types

???+ bhom "The Graph in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Entities | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0), [IBHoMObject](/documentation/oM/Framework/Base/IBHoMObject)&gt; | Dictionary of IBHoMObject entities. | - |
| Relations | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IRelation](/documentation/oM/Analytical/Analytical/Graph/IRelation)&gt; | Collection of relations between IBHoMObject entities. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/documentation/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Adjacency | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0), [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0)&gt;&gt; | Returns the adjacency dictionary for a Graph. | - | Analytical_Engine |
| Entities | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IBHoMObject](/documentation/oM/Framework/Base/IBHoMObject)&gt; | Returns all the entities in a Graph as collection. | - | Analytical_Engine |
| EntityNeighbourhood | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Graph](/documentation/oM/Analytical/Analytical/Graph/Graph)&gt; | Find all sub Graphs around all entities at maximum depth 1 within a Graph. | - | Analytical_Engine |
| Geometry | [CompositeGeometry](/documentation/oM/Dimensional/Geometry/CompositeGeometry) | Gets the geometry of a Graph as its relation curve arrows. For relations between entities of IElement0D types and outmatic curve is created if it does not exist. Method required for automatic display in UI packages. | - | Analytical_Engine |
| IsolatedEntities | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0)&gt; | Returns the collection of entity Guids that are never used as Relation targets or sources. | - | Analytical_Engine |
| NotSinks | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0)&gt; | Returns the collection of entity Guids that are used as at least one Relation source. | - | Analytical_Engine |
| Sinks | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0)&gt; | Returns the collection of entity Guids that are never used a Relation source. | - | Analytical_Engine |
| Sources | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0)&gt; | Returns the collection of entity Guids that are never used as Relation targets. | - | Analytical_Engine |
| SubGraphs | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Graph](/documentation/oM/Analytical/Analytical/Graph/Graph)&gt; | Find all disconnected sub Graphs within a Graph. | - | Analytical_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [Graph.cs](https://github.com/BHoM/BHoM/blob/develop/Analytical_oM/Graph\Graph.cs)

All history and changes of the class can be found by inspection the history.
