---
title: IRelation
---

# <small>BH.oM.Analytical.Graph.</small>**IRelation**

Interface common to all Relation objects.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IRelation is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Analytical.Graph.[Relation](/api/oM/Analytical/Analytical/Graph/Relation)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Source | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Target | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Subgraph | [Graph](/api/oM/Analytical/Analytical/Graph/Graph) | - | - |
| Weight | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| Curve | [ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve) | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| RelationArrow | [CompositeGeometry](/api/oM/Dimensional/Geometry/Misc/CompositeGeometry) | Returns arrow geometry used to represent a Relation. | - | Analytical_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IRelation : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: Analytical_oM.dll

The C# interface definition is available on github:

- [IRelation.cs](https://github.com/BHoM/BHoM/blob/develop/Analytical_oM/Graph\IRelation.cs)

All history and changes of the class can be found by inspection the history.
