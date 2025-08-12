---
title: ClimateChangeLandUseFactor
---

# <small>BH.oM.LifeCycleAssessment.MaterialFragments.</small>**ClimateChangeLandUseFactor**

Single value indicator for Climate Change - Land Use and Land Use Change, measured in kg CO2 eq (Carbon Dioxide equivalent, also referred to as embodied carbon), refers to the exploitation of land and its resources, which contributes to global warming.

## Class structure

### Implemented interfaces and base types

???+ bhom "The ClimateChangeLandUseFactor is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.LifeCycleAssessment.MaterialFragments.[IEnvironmentalFactor](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalFactors/IEnvironmentalFactor)
    -  BH.oM.LifeCycleAssessment.Interfaces.[ILifeCycleAssessmentIndicator](/api/oM/Analytical/LifeCycleAssessment/Interfaces/ILifeCycleAssessmentIndicator)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Value | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Value for this single factor indicator. | [ClimateChangePerQuantity](/api/oM/Dimensional/Quantities/Attributes/ClimateChangePerQuantity) [kg CO2 eq per unit] |


## Code and Schema

### C# implementation

``` C# title="C#"
public class ClimateChangeLandUseFactor : BH.oM.LifeCycleAssessment.MaterialFragments.IEnvironmentalFactor,
BH.oM.LifeCycleAssessment.Interfaces.ILifeCycleAssessmentIndicator,
BH.oM.Base.IObject
```

Assembly: LifeCycleAssessment_oM.dll

The C# class definition is available on github:

- [ClimateChangeLandUseFactor.cs](https://github.com/BHoM/BHoM/blob/develop/LifeCycleAssessment_oM/MaterialFragments\EnvironmentalFactors\ClimateChangeLandUseFactor.cs)

All history and changes of the class can be found by inspection the history.
