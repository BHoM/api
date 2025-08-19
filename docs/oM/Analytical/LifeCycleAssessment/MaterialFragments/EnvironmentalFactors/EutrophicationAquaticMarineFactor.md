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


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IMetricType | [MetricType](/api/oM/Analytical/LifeCycleAssessment/Enums/MetricType) | - | - | LifeCycleAssessment_Engine |


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
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/LifeCycleAssessment_oM/MaterialFragments/EutrophicationAquaticMarineFactor.json"
}
```

The JSON Schema is available on github here:

- [EutrophicationAquaticMarineFactor.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/LifeCycleAssessment_oM/MaterialFragments/EutrophicationAquaticMarineFactor.json)
