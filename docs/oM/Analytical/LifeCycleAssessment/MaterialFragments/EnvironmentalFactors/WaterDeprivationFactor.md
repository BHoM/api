---
title: WaterDeprivationFactor
---

# <small>BH.oM.LifeCycleAssessment.MaterialFragments.</small>**WaterDeprivationFactor**

Single value indicator for Water use for a particular product or material.

## Class structure

### Implemented interfaces and base types

???+ bhom "The WaterDeprivationFactor is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.LifeCycleAssessment.MaterialFragments.[IEnvironmentalFactor](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalFactors/IEnvironmentalFactor)
    -  BH.oM.LifeCycleAssessment.Interfaces.[ILifeCycleAssessmentIndicator](/api/oM/Analytical/LifeCycleAssessment/Interfaces/ILifeCycleAssessmentIndicator)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Value | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Value for this single factor indicator. | [VolumePerQuantity](/api/oM/Dimensional/Quantities/Attributes/VolumePerQuantity) [m³ per unit] |


## Code and Schema

### C# implementation

``` C# title="C#"
public class WaterDeprivationFactor : BH.oM.LifeCycleAssessment.MaterialFragments.IEnvironmentalFactor,
BH.oM.LifeCycleAssessment.Interfaces.ILifeCycleAssessmentIndicator,
BH.oM.Base.IObject
```

Assembly: LifeCycleAssessment_oM.dll

The C# class definition is available on github:

- [WaterDeprivationFactor.cs](https://github.com/BHoM/BHoM/blob/develop/LifeCycleAssessment_oM/MaterialFragments\EnvironmentalFactors\WaterDeprivationFactor.cs)

All history and changes of the class can be found by inspection the history.
