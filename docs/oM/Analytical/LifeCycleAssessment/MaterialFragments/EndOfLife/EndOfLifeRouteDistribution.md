---
title: EndOfLifeRouteDistribution
---

# <small>BH.oM.LifeCycleAssessment.MaterialFragments.EndOfLife.</small>**EndOfLifeRouteDistribution**

Class outlining the distribution between different end of life routes and scenarios for a particular material. All ratios should be between 0 and 1, and in total sum up to 1.

## Class structure

### Implemented interfaces and base types

???+ bhom "The EndOfLifeRouteDistribution is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Name of the scenario or material wo which this corresponds. | - |
| Reuse | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Proportion of the material that is resued. Should be a number betwen 0 and 1 where 0 means no reuse, and 1 means all is reused. | [Ratio](/api/oM/Dimensional/Quantities/Attributes/Ratio) [-] |
| Recycling | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Proportion of the material that is recycled. Should be a number betwen 0 and 1 where 0 means nothing is recyled, and 1 means all is recyled. | [Ratio](/api/oM/Dimensional/Quantities/Attributes/Ratio) [-] |
| Incineration | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Proportion of the material that is incinerated. Should be a number betwen 0 and 1 where 0 means nothing is incinerated, and 1 means all is incinerated. | [Ratio](/api/oM/Dimensional/Quantities/Attributes/Ratio) [-] |
| Waste | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Proportion of the material that is incinerated. Should be a number betwen 0 and 1 where 0 means nothing is incinerated, and 1 means all is incinerated. | [Ratio](/api/oM/Dimensional/Quantities/Attributes/Ratio) [-] |


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
public class EndOfLifeRouteDistribution : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: LifeCycleAssessment_oM.dll

The C# class definition is available on github:

- [EndOfLifeRouteDistribution.cs](https://github.com/BHoM/BHoM/blob/develop/LifeCycleAssessment_oM/MaterialFragments\EndOfLife\EndOfLifeRouteDistribution.cs)

All history and changes of the class can be found by inspection the history.
