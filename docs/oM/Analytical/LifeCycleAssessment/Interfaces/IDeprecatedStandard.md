---
title: IDeprecatedStandard
---

# <small>BH.oM.LifeCycleAssessment.Interfaces.</small>**IDeprecatedStandard**

Base interface for all classes classes storing indicator factors or results of a deprecated standard.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IDeprecatedStandard is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.LifeCycleAssessment.Interfaces.[ILifeCycleAssessmentIndicator](/api/oM/Analytical/LifeCycleAssessment/Interfaces/ILifeCycleAssessmentIndicator)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.LifeCycleAssessment.Results.[EutrophicationCMLElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/EutrophicationCMLElementResult)
    - BH.oM.LifeCycleAssessment.Results.[EutrophicationTRACIElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/EutrophicationTRACIElementResult)
    - BH.oM.LifeCycleAssessment.Results.[PhotochemicalOzoneCreationCMLElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/PhotochemicalOzoneCreationCMLElementResult)
    - BH.oM.LifeCycleAssessment.Results.[EutrophicationCMLMaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/MaterialResults/EutrophicationCMLMaterialResult)
    - BH.oM.LifeCycleAssessment.Results.[PhotochemicalOzoneCreationCMLMaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/MaterialResults/PhotochemicalOzoneCreationCMLMaterialResult)
    - BH.oM.LifeCycleAssessment.Results.[PhotochemicalOzoneCreationTRACIMaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/MaterialResults/PhotochemicalOzoneCreationTRACIMaterialResult)
    - BH.oM.LifeCycleAssessment.MaterialFragments.[EutrophicationCMLFactor](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalFactors/EutrophicationCMLFactor)
    - BH.oM.LifeCycleAssessment.MaterialFragments.[EutrophicationTRACIFactor](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalFactors/EutrophicationTRACIFactor)
    - BH.oM.LifeCycleAssessment.MaterialFragments.[PhotochemicalOzoneCreationCMLFactor](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalFactors/PhotochemicalOzoneCreationCMLFactor)
    - BH.oM.LifeCycleAssessment.MaterialFragments.[PhotochemicalOzoneCreationTRACIFactor](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalFactors/PhotochemicalOzoneCreationTRACIFactor)
    - BH.oM.LifeCycleAssessment.MaterialFragments.[EutrophicationCMLMetric](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalMetrics/EutrophicationCMLMetric)
    - BH.oM.LifeCycleAssessment.MaterialFragments.[EutrophicationTRACIMetric](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalMetrics/EutrophicationTRACIMetric)
    - BH.oM.LifeCycleAssessment.MaterialFragments.[PhotochemicalOzoneCreationCMLMetric](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalMetrics/PhotochemicalOzoneCreationCMLMetric)
    - BH.oM.LifeCycleAssessment.MaterialFragments.[PhotochemicalOzoneCreationTRACIMetric](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalMetrics/PhotochemicalOzoneCreationTRACIMetric)


## Properties

### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IMetricType | [MetricType](/api/oM/Analytical/LifeCycleAssessment/Enums/MetricType) | - | - | LifeCycleAssessment_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IDeprecatedStandard : BH.oM.LifeCycleAssessment.Interfaces.ILifeCycleAssessmentIndicator, BH.oM.Base.IObject
```

Assembly: LifeCycleAssessment_oM.dll

The C# interface definition is available on github:

- [IDeprecatedStandard.cs](https://github.com/BHoM/BHoM/blob/develop/LifeCycleAssessment_oM/Interfaces\IDeprecatedStandard.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/LifeCycleAssessment_oM/Interfaces/IDeprecatedStandard.json"
}
```

The JSON Schema is available on github here:

- [IDeprecatedStandard.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/LifeCycleAssessment_oM/Interfaces/IDeprecatedStandard.json)
