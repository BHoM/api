---
title: EutrophicationCMLFactor
---

# <small>BH.oM.LifeCycleAssessment.MaterialFragments.</small>**EutrophicationCMLFactor**

Single value indicator for Eutrophication (refers to EN 15804+A1), measured in kg [PO₄]³⁻ eq, and refers to the natural process that results from accumulation of nutrients.

## Class structure

### Implemented interfaces and base types

???+ bhom "The EutrophicationCMLFactor is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.LifeCycleAssessment.MaterialFragments.[IEnvironmentalFactor](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalFactors/IEnvironmentalFactor)
    -  BH.oM.LifeCycleAssessment.Interfaces.[ILifeCycleAssessmentIndicator](/api/oM/Analytical/LifeCycleAssessment/Interfaces/ILifeCycleAssessmentIndicator)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.LifeCycleAssessment.Interfaces.[IDeprecatedStandard](/api/oM/Analytical/LifeCycleAssessment/Interfaces/IDeprecatedStandard)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Value | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Value for this single factor indicator. | [EutrophicationCMLPerQuantity](/api/oM/Dimensional/Quantities/Attributes/EutrophicationCMLPerQuantity) [kg [PO₄]³⁻ eq per unit] |


## Code and Schema

### C# implementation

``` C# title="C#"
public class EutrophicationCMLFactor : BH.oM.LifeCycleAssessment.MaterialFragments.IEnvironmentalFactor,
BH.oM.LifeCycleAssessment.Interfaces.ILifeCycleAssessmentIndicator,
BH.oM.Base.IObject,
BH.oM.LifeCycleAssessment.Interfaces.IDeprecatedStandard
```

Assembly: LifeCycleAssessment_oM.dll

The C# class definition is available on github:

- [EutrophicationCMLFactor.cs](https://github.com/BHoM/BHoM/blob/develop/LifeCycleAssessment_oM/MaterialFragments\EnvironmentalFactors\EutrophicationCMLFactor.cs)

All history and changes of the class can be found by inspection the history.
