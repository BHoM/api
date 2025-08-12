---
title: PhotochemicalOzoneCreationFactor
---

# <small>BH.oM.LifeCycleAssessment.MaterialFragments.</small>**PhotochemicalOzoneCreationFactor**

Single value indicator for Photochemical Ozone Formation, measured in kg NMVOC eq, refers to the formation of ozone at the ground level of the troposphere caused by photochemical oxidation of volatile organic compounds (VOCs) and carbon monoxide in the presence of sunlight.

## Class structure

### Implemented interfaces and base types

???+ bhom "The PhotochemicalOzoneCreationFactor is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.LifeCycleAssessment.MaterialFragments.[IEnvironmentalFactor](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalFactors/IEnvironmentalFactor)
    -  BH.oM.LifeCycleAssessment.Interfaces.[ILifeCycleAssessmentIndicator](/api/oM/Analytical/LifeCycleAssessment/Interfaces/ILifeCycleAssessmentIndicator)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Value | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Value for this single factor indicator. | [PhotochemicalOzoneCreationPerQuantity](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationPerQuantity) [kg NMVOC eq per unit] |


## Code and Schema

### C# implementation

``` C# title="C#"
public class PhotochemicalOzoneCreationFactor : BH.oM.LifeCycleAssessment.MaterialFragments.IEnvironmentalFactor,
BH.oM.LifeCycleAssessment.Interfaces.ILifeCycleAssessmentIndicator,
BH.oM.Base.IObject
```

Assembly: LifeCycleAssessment_oM.dll

The C# class definition is available on github:

- [PhotochemicalOzoneCreationFactor.cs](https://github.com/BHoM/BHoM/blob/develop/LifeCycleAssessment_oM/MaterialFragments\EnvironmentalFactors\PhotochemicalOzoneCreationFactor.cs)

All history and changes of the class can be found by inspection the history.
