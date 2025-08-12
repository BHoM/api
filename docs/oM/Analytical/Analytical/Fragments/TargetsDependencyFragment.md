---
title: TargetsDependencyFragment
---

# <small>BH.oM.Analytical.Fragments.</small>**TargetsDependencyFragment**

Dependency fragment used to define one or more Relations that terminate at the specified targets and use the IBHoMObject owning this fragment as the source.

## Class structure

### Implemented interfaces and base types

???+ bhom "The TargetsDependencyFragment is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Analytical.Fragments.[IDependencyFragment](/api/oM/Analytical/Analytical/Fragments/IDependencyFragment)
    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Targets | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0)&gt; | Collection of Guids of entities that are targets for Relations where the IBHoMObject owning this fragment is the source. | - |
| Curves | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve)&gt; | Collection of ICurves used to represent the Relations. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class TargetsDependencyFragment : BH.oM.Analytical.Fragments.IDependencyFragment, BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: Analytical_oM.dll

The C# class definition is available on github:

- [TargetsDependencyFragment.cs](https://github.com/BHoM/BHoM/blob/develop/Analytical_oM/Fragments\TargetsDependencyFragment.cs)

All history and changes of the class can be found by inspection the history.
