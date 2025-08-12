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
