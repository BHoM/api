---
title: GlobalEmissionFactors
---

# <small>BH.oM.LifeCycleAssessment.Configs.</small>**GlobalEmissionFactors**



## Class structure

### Implemented interfaces and base types

???+ bhom "The GlobalEmissionFactors is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.LifeCycleAssessment.Configs.[IEvaluationConfig](/api/oM/Analytical/LifeCycleAssessment/Configs/IEvaluationConfig)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| PreConstructionDemolition | [PreConstructionDemolition](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/Construction/PreConstructionDemolition) | The demolition activities associated with the pre-construction process, which will increase the emissions associated with the construction phase of the building lifecycle. The impact on the final element will be scaled according to its part of the total mass of the building. | - |
| ConstructionActivities | [ConstructionActivities](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/Construction/ConstructionActivities) | The construction activities associated with the construction process, which will increase the emissions associated with the construction phase of the building lifecycle. The impact on the final element will be scaled according to its part of the total mass of the building. | - |
| TotalBuildingMass | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The total mass of the building. When evaluating an element, its part impact for pre-construction demolition as well as site activities will be scaled by this factor. | [Mass](/api/oM/Dimensional/Quantities/Attributes/Mass) [kg] |
| StructuresOnlyMass | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Boolean that indicates if the provided mass is only the mass of the structure (true) or the total mass of the building including non-structural elements (false). This is relevant for scaling the pre-construction demolition and construction activities emissions which are provided per unit area. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class GlobalEmissionFactors : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.LifeCycleAssessment.Configs.IEvaluationConfig
```

Assembly: LifeCycleAssessment_oM.dll

The C# class definition is available on github:

- [GlobalEmissionFactors.cs](https://github.com/BHoM/BHoM/blob/develop/LifeCycleAssessment_oM/Configs\GlobalEmissionFactors.cs)

All history and changes of the class can be found by inspection the history.
