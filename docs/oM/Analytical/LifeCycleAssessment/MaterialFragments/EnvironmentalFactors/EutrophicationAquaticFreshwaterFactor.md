---
title: EutrophicationAquaticFreshwaterFactor
---

# <small>BH.oM.LifeCycleAssessment.MaterialFragments.</small>**EutrophicationAquaticFreshwaterFactor**

Single value indicator for Eutrophication - Aquatic Freshwater, measured in kg P eq, refers to the natural process that results from accumulation of nutrients in fresh bodies of water.

## Class structure

### Implemented interfaces and base types

???+ bhom "The EutrophicationAquaticFreshwaterFactor is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.LifeCycleAssessment.MaterialFragments.[IEnvironmentalFactor](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalFactors/IEnvironmentalFactor)
    -  BH.oM.LifeCycleAssessment.Interfaces.[ILifeCycleAssessmentIndicator](/api/oM/Analytical/LifeCycleAssessment/Interfaces/ILifeCycleAssessmentIndicator)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Value | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Value for this single factor indicator. | [EutrophicationAquaticFreshwaterPerQuantity](/api/oM/Dimensional/Quantities/Attributes/EutrophicationAquaticFreshwaterPerQuantity) [kg P eq per unit] |


## Code and Schema

### C# implementation

``` C# title="C#"
public class EutrophicationAquaticFreshwaterFactor : BH.oM.LifeCycleAssessment.MaterialFragments.IEnvironmentalFactor,
BH.oM.LifeCycleAssessment.Interfaces.ILifeCycleAssessmentIndicator,
BH.oM.Base.IObject
```

Assembly: LifeCycleAssessment_oM.dll

The C# class definition is available on github:

- [EutrophicationAquaticFreshwaterFactor.cs](https://github.com/BHoM/BHoM/blob/develop/LifeCycleAssessment_oM/MaterialFragments\EnvironmentalFactors\EutrophicationAquaticFreshwaterFactor.cs)

All history and changes of the class can be found by inspection the history.
