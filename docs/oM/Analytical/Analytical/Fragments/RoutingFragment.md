---
title: RoutingFragment
---

# <small>BH.oM.Analytical.Fragments.</small>**RoutingFragment**

Fragment used in the computation of shortest paths.

## Class structure

### Implemented interfaces and base types

???+ bhom "The RoutingFragment is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| MinCostToSource | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0)&gt; | - | - |
| Cost | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0)&gt; | - | - |
| Visited | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - |
| NearestToSource | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| StraightLineDistanceToTarget | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class RoutingFragment : BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: Analytical_oM.dll

The C# class definition is available on github:

- [RoutingFragment.cs](https://github.com/BHoM/BHoM/blob/develop/Analytical_oM/Fragments\RoutingFragment.cs)

All history and changes of the class can be found by inspection the history.
