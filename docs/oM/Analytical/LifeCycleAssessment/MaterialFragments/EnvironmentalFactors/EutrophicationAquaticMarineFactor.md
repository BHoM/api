---
title: EutrophicationAquaticMarineFactor
---

# <small>BH.oM.LifeCycleAssessment.MaterialFragments.</small>**EutrophicationAquaticMarineFactor**

Single value indicator for Eutrophication - Aquatic Marine, measured in kg N eq, refers to the natural process that results from accumulation of nutrients in bodies of marine water.

## Class structure

### Implemented interfaces and base types

???+ bhom "The EutrophicationAquaticMarineFactor is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.LifeCycleAssessment.MaterialFragments.[IEnvironmentalFactor](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalFactors/IEnvironmentalFactor)
    -  BH.oM.LifeCycleAssessment.Interfaces.[ILifeCycleAssessmentIndicator](/api/oM/Analytical/LifeCycleAssessment/Interfaces/ILifeCycleAssessmentIndicator)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Value | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Value for this single factor indicator. | [EutrophicationAquaticMarinePerQuantity](/api/oM/Dimensional/Quantities/Attributes/EutrophicationAquaticMarinePerQuantity) [kg N eq per unit] |


## Code and Schema

### C# implementation

``` C# title="C#"
public class EutrophicationAquaticMarineFactor : BH.oM.LifeCycleAssessment.MaterialFragments.IEnvironmentalFactor,
BH.oM.LifeCycleAssessment.Interfaces.ILifeCycleAssessmentIndicator,
BH.oM.Base.IObject
```

Assembly: LifeCycleAssessment_oM.dll

The C# class definition is available on github:

- [EutrophicationAquaticMarineFactor.cs](https://github.com/BHoM/BHoM/blob/develop/LifeCycleAssessment_oM/MaterialFragments\EnvironmentalFactors\EutrophicationAquaticMarineFactor.cs)

All history and changes of the class can be found by inspection the history.
