---
title: OzoneDepletionFactor
---

# <small>BH.oM.LifeCycleAssessment.MaterialFragments.</small>**OzoneDepletionFactor**

Single value indicator for Ozone Depletion, measured in kg CFC-11 eq, refers to the substances that destroy ozone molecules.

## Class structure

### Implemented interfaces and base types

???+ bhom "The OzoneDepletionFactor is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.LifeCycleAssessment.MaterialFragments.[IEnvironmentalFactor](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalFactors/IEnvironmentalFactor)
    -  BH.oM.LifeCycleAssessment.Interfaces.[ILifeCycleAssessmentIndicator](/api/oM/Analytical/LifeCycleAssessment/Interfaces/ILifeCycleAssessmentIndicator)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Value | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Value for this single factor indicator. | [OzoneDepletionPerQuantity](/api/oM/Dimensional/Quantities/Attributes/OzoneDepletionPerQuantity) [kg CFC11 eq per unit] |


## Code and Schema

### C# implementation

``` C# title="C#"
public class OzoneDepletionFactor : BH.oM.LifeCycleAssessment.MaterialFragments.IEnvironmentalFactor,
BH.oM.LifeCycleAssessment.Interfaces.ILifeCycleAssessmentIndicator,
BH.oM.Base.IObject
```

Assembly: LifeCycleAssessment_oM.dll

The C# class definition is available on github:

- [OzoneDepletionFactor.cs](https://github.com/BHoM/BHoM/blob/develop/LifeCycleAssessment_oM/MaterialFragments\EnvironmentalFactors\OzoneDepletionFactor.cs)

All history and changes of the class can be found by inspection the history.
