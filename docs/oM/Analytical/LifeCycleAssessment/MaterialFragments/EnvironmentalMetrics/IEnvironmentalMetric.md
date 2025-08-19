---
title: IEnvironmentalMetric
---

# <small>BH.oM.LifeCycleAssessment.MaterialFragments.</small>**IEnvironmentalMetric**

Base interface for class storing Environmental Impact Factors of a specific type relating to modules.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IEnvironmentalMetric is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.LifeCycleAssessment.Interfaces.[ILifeCycleAssessmentModuleData](/api/oM/Analytical/LifeCycleAssessment/Interfaces/ILifeCycleAssessmentModuleData)&lt;[Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;BH.oM.LifeCycleAssessment.[Module](/api/oM/Analytical/LifeCycleAssessment/Enums/Module), [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0)&gt;&gt;
    -  BH.oM.LifeCycleAssessment.Interfaces.[ILifeCycleAssessmentIndicator](/api/oM/Analytical/LifeCycleAssessment/Interfaces/ILifeCycleAssessmentIndicator)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.LifeCycleAssessment.MaterialFragments.[AbioticDepletionFossilResourcesMetric](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalMetrics/AbioticDepletionFossilResourcesMetric)
    - BH.oM.LifeCycleAssessment.MaterialFragments.[AbioticDepletionMineralsAndMetalsMetric](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalMetrics/AbioticDepletionMineralsAndMetalsMetric)
    - BH.oM.LifeCycleAssessment.MaterialFragments.[AcidificationMetric](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalMetrics/AcidificationMetric)
    - BH.oM.LifeCycleAssessment.MaterialFragments.[ClimateChangeBiogenicMetric](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalMetrics/ClimateChangeBiogenicMetric)
    - BH.oM.LifeCycleAssessment.MaterialFragments.[ClimateChangeFossilMetric](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalMetrics/ClimateChangeFossilMetric)
    - BH.oM.LifeCycleAssessment.MaterialFragments.[ClimateChangeLandUseMetric](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalMetrics/ClimateChangeLandUseMetric)
    - BH.oM.LifeCycleAssessment.MaterialFragments.[ClimateChangeTotalMetric](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalMetrics/ClimateChangeTotalMetric)
    - BH.oM.LifeCycleAssessment.MaterialFragments.[ClimateChangeTotalNoBiogenicMetric](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalMetrics/ClimateChangeTotalNoBiogenicMetric)
    - BH.oM.LifeCycleAssessment.MaterialFragments.[EutrophicationAquaticFreshwaterMetric](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalMetrics/EutrophicationAquaticFreshwaterMetric)
    - BH.oM.LifeCycleAssessment.MaterialFragments.[EutrophicationAquaticMarineMetric](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalMetrics/EutrophicationAquaticMarineMetric)
    - BH.oM.LifeCycleAssessment.MaterialFragments.[EutrophicationCMLMetric](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalMetrics/EutrophicationCMLMetric)
    - BH.oM.LifeCycleAssessment.MaterialFragments.[EutrophicationTerrestrialMetric](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalMetrics/EutrophicationTerrestrialMetric)
    - BH.oM.LifeCycleAssessment.MaterialFragments.[EutrophicationTRACIMetric](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalMetrics/EutrophicationTRACIMetric)
    - BH.oM.LifeCycleAssessment.MaterialFragments.[OzoneDepletionMetric](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalMetrics/OzoneDepletionMetric)
    - BH.oM.LifeCycleAssessment.MaterialFragments.[PhotochemicalOzoneCreationCMLMetric](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalMetrics/PhotochemicalOzoneCreationCMLMetric)
    - BH.oM.LifeCycleAssessment.MaterialFragments.[PhotochemicalOzoneCreationMetric](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalMetrics/PhotochemicalOzoneCreationMetric)
    - BH.oM.LifeCycleAssessment.MaterialFragments.[PhotochemicalOzoneCreationTRACIMetric](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalMetrics/PhotochemicalOzoneCreationTRACIMetric)
    - BH.oM.LifeCycleAssessment.MaterialFragments.[WaterDeprivationMetric](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalMetrics/WaterDeprivationMetric)


## Properties

### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| ATotal | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the total sum of values from all A-modules (A1-A5) with a set value (all values not NaN). | - | LifeCycleAssessment_Engine |
| BTotal | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the total sum of values from all B-modules (B1-B7) with a set value (all values not NaN). | - | LifeCycleAssessment_Engine |
| CTotal | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the total sum of values from all C-modules (C1-C4) with a set value (all values not NaN). | - | LifeCycleAssessment_Engine |
| IMetricType | [MetricType](/api/oM/Analytical/LifeCycleAssessment/Enums/MetricType) | - | - | LifeCycleAssessment_Engine |
| Total | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the total sum of values from all modules with a set value (all values not NaN). | - | LifeCycleAssessment_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IEnvironmentalMetric : BH.oM.Base.IBHoMObject,
BH.oM.Base.IObject,
BH.oM.LifeCycleAssessment.Interfaces.ILifeCycleAssessmentModuleData<System.Collections.Generic.Dictionary<BH.oM.LifeCycleAssessment.Module, System.Double>>,
BH.oM.LifeCycleAssessment.Interfaces.ILifeCycleAssessmentIndicator
```

Assembly: LifeCycleAssessment_oM.dll

The C# interface definition is available on github:

- [IEnvironmentalMetric.cs](https://github.com/BHoM/BHoM/blob/develop/LifeCycleAssessment_oM/MaterialFragments\EnvironmentalMetrics\IEnvironmentalMetric.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/LifeCycleAssessment_oM/MaterialFragments/IEnvironmentalMetric.json"
}
```

The JSON Schema is available on github here:

- [IEnvironmentalMetric.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/LifeCycleAssessment_oM/MaterialFragments/IEnvironmentalMetric.json)
