---
title: PhotochemicalOzoneCreationCMLFactor
---

# <small>BH.oM.LifeCycleAssessment.MaterialFragments.</small>**PhotochemicalOzoneCreationCMLFactor**

Single value indicator for Photochemical Ozone Creation as defined by the CML standard for a particular product or material.

## Class structure

### Implemented interfaces and base types

???+ bhom "The PhotochemicalOzoneCreationCMLFactor is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.LifeCycleAssessment.MaterialFragments.[IEnvironmentalFactor](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalFactors/IEnvironmentalFactor)
    -  BH.oM.LifeCycleAssessment.Interfaces.[ILifeCycleAssessmentIndicator](/api/oM/Analytical/LifeCycleAssessment/Interfaces/ILifeCycleAssessmentIndicator)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.LifeCycleAssessment.Interfaces.[IDeprecatedStandard](/api/oM/Analytical/LifeCycleAssessment/Interfaces/IDeprecatedStandard)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Value | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Value for this single factor indicator. | [PhotochemicalOzoneCreationCMLPerQuantity](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationCMLPerQuantity) [kg C₂H₄ eq per unit] |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IMetricType | [MetricType](/api/oM/Analytical/LifeCycleAssessment/Enums/MetricType) | - | - | LifeCycleAssessment_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class PhotochemicalOzoneCreationCMLFactor : BH.oM.LifeCycleAssessment.MaterialFragments.IEnvironmentalFactor,
BH.oM.LifeCycleAssessment.Interfaces.ILifeCycleAssessmentIndicator,
BH.oM.Base.IObject,
BH.oM.LifeCycleAssessment.Interfaces.IDeprecatedStandard
```

Assembly: LifeCycleAssessment_oM.dll

The C# class definition is available on github:

- [PhotochemicalOzoneCreationCMLFactor.cs](https://github.com/BHoM/BHoM/blob/develop/LifeCycleAssessment_oM/MaterialFragments\EnvironmentalFactors\PhotochemicalOzoneCreationCMLFactor.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/LifeCycleAssessment_oM/MaterialFragments/PhotochemicalOzoneCreationCMLFactor.json"
}
```

The JSON Schema is available on github here:

- [PhotochemicalOzoneCreationCMLFactor.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/LifeCycleAssessment_oM/MaterialFragments/PhotochemicalOzoneCreationCMLFactor.json)
