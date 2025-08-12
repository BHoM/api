---
title: CombinedLifeCycleAssessmentFactors
---

# <small>BH.oM.LifeCycleAssessment.MaterialFragments.</small>**CombinedLifeCycleAssessmentFactors**

An Combined Life Cycle Assessment Factors is aggregate class to compute final impact factors.
This object is commonly created based on a EPD for cradle to gate metrics (A1 - A3) with addional project and site specific data added for relevant stages beyond the product stage.

## Class structure

### Implemented interfaces and base types

???+ bhom "The CombinedLifeCycleAssessmentFactors is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Physical.Materials.[IMaterialProperties](/api/oM/Physical/Physical/Materials/IMaterialProperties)
    -  BH.oM.LifeCycleAssessment.MaterialFragments.[IEnvironmentalFactorsProvider](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/IEnvironmentalFactorsProvider)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| EnvironmentalProductDeclaration | [EnvironmentalProductDeclaration](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalProductDeclaration) | THe Environmental Product Declaration as the basis for the life cycle assessment. Commnly outlines the metrics for A1-A3 modules, but might contain metrics beyond those modules. | - |
| A4TransportFactors | [ITransportFactors](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/Transport/ITransportFactors) | Factors for computing the emissions relating to Module A4 which captures the impacts associated with the transportation of the materials and components from the factory gate to and from the project site. | - |
| C2TransportFactors | [ITransportFactors](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/Transport/ITransportFactors) | Factors for computing the emissions relating to Module C2. Module C2 Transport impacts consists of any carbon impacts associated with the transportation of material from deconstruction and demolition to the appropriate final location, including any interim stations. | - |


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
public class CombinedLifeCycleAssessmentFactors : BH.oM.Base.BHoMObject,
BH.oM.Base.IBHoMObject,
BH.oM.Base.IObject,
BH.oM.Physical.Materials.IMaterialProperties,
BH.oM.LifeCycleAssessment.MaterialFragments.IEnvironmentalFactorsProvider
```

Assembly: LifeCycleAssessment_oM.dll

The C# class definition is available on github:

- [CombinedLifeCycleAssessmentFactors.cs](https://github.com/BHoM/BHoM/blob/develop/LifeCycleAssessment_oM/MaterialFragments\CombinedLifeCycleAssessmentFactors.cs)

All history and changes of the class can be found by inspection the history.
