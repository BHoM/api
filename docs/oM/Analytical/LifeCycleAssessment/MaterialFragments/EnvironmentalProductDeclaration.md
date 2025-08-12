---
title: EnvironmentalProductDeclaration
---

# <small>BH.oM.LifeCycleAssessment.MaterialFragments.</small>**EnvironmentalProductDeclaration**

An Environmental Product Declaration or EPD is an independently verified and registered document that communicates transparent and comparable information about the life-cycle environmental impact of products in a credible way. 
More information can be found on the Environdec website (environdec.com/all-about-epds0/all-about-epds.) 
All EPDs within the BHoM have been provided for general use and are updated as frequently as possible, but by using any supplied EPDs you assume all responsibility for the data used on any applications. 
For additional comments, questions, or feature requests, please visit the LifeCycleAssessment_Toolkit at github.com/BHoM/LifeCycleAssessment_Toolkit.

## Class structure

### Implemented interfaces and base types

???+ bhom "The EnvironmentalProductDeclaration is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.LifeCycleAssessment.MaterialFragments.[IEnvironmentalFactorsProvider](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/IEnvironmentalFactorsProvider)
    -  BH.oM.Physical.Materials.[IMaterialProperties](/api/oM/Physical/Physical/Materials/IMaterialProperties)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Type | [EPDType](/api/oM/Analytical/LifeCycleAssessment/Enums/EPDType) | The Type of Environmental Product Declaration. | - |
| EnvironmentalMetrics | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IEnvironmentalMetric](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalMetrics/IEnvironmentalMetric)&gt; | An Environmental Module Factors contains EnvironmentalFactors of a particular quantity for one or more modules. These factors are used in all LCA calculations. | - |
| QuantityType | [QuantityType](/api/oM/Analytical/LifeCycleAssessment/Enums/QuantityType) | Note that any EPD that does not contain this parameter will not be evaluated. <br>This metric is based on the declared unit of the reference EPD, i.e. a declared unit of kg refers to QuantityType of mass, a declared unit of m3 refers to a QuantityType of volume, etc. <br>All data should be normalized to metric declared units before integration in the BHoM. <br>The quantity type is a key metric for evaluation methods to function. <br>This property determines how the material is to be evaluated, based on Mass, Volume, Area, Item, or Length. | - |


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
public class EnvironmentalProductDeclaration : BH.oM.Base.BHoMObject,
BH.oM.Base.IBHoMObject,
BH.oM.Base.IObject,
BH.oM.LifeCycleAssessment.MaterialFragments.IEnvironmentalFactorsProvider,
BH.oM.Physical.Materials.IMaterialProperties
```

Assembly: LifeCycleAssessment_oM.dll

The C# class definition is available on github:

- [EnvironmentalProductDeclaration.cs](https://github.com/BHoM/BHoM/blob/develop/LifeCycleAssessment_oM/MaterialFragments\EnvironmentalProductDeclaration.cs)

All history and changes of the class can be found by inspection the history.
