---
title: AcidificationFactor
---

# <small>BH.oM.LifeCycleAssessment.MaterialFragments.</small>**AcidificationFactor**

Single value indicator for Acidification, measured in moles of H+ (per EN 15804+A2, this was previously measured in SO2 per EN 15804+A1), it refers to compounds that contribute to acid rain.

## Class structure

### Implemented interfaces and base types

???+ bhom "The AcidificationFactor is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.LifeCycleAssessment.MaterialFragments.[IEnvironmentalFactor](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalFactors/IEnvironmentalFactor)
    -  BH.oM.LifeCycleAssessment.Interfaces.[ILifeCycleAssessmentIndicator](/api/oM/Analytical/LifeCycleAssessment/Interfaces/ILifeCycleAssessmentIndicator)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Value | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Value for this single factor indicator. | [AcidificationPerQuantity](/api/oM/Dimensional/Quantities/Attributes/AcidificationPerQuantity) [mol H+ eq per unit] |


## Code and Schema

### C# implementation

``` C# title="C#"
public class AcidificationFactor : BH.oM.LifeCycleAssessment.MaterialFragments.IEnvironmentalFactor,
BH.oM.LifeCycleAssessment.Interfaces.ILifeCycleAssessmentIndicator,
BH.oM.Base.IObject
```

Assembly: LifeCycleAssessment_oM.dll

The C# class definition is available on github:

- [AcidificationFactor.cs](https://github.com/BHoM/BHoM/blob/develop/LifeCycleAssessment_oM/MaterialFragments\EnvironmentalFactors\AcidificationFactor.cs)

All history and changes of the class can be found by inspection the history.
