---
title: ILifeCycleAssessmentModuleData&lt;T&gt;
---

# <small>BH.oM.LifeCycleAssessment.Interfaces.</small>**ILifeCycleAssessmentModuleData&lt;T&gt;**

Base interface for all envirnmental factors and results storing indicators for multiple modules..

## Interface structure

### Generic parameters

The ILifeCycleAssessmentModuleData contains the following generic paramters:

#### T

Constrained by the following arguments:

- [IDictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2?view=netstandard-2.0)&lt;BH.oM.LifeCycleAssessment.[Module](/api/oM/Analytical/LifeCycleAssessment/Enums/Module), [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0)&gt;

### Implemented interfaces and base types

???+ bhom "The ILifeCycleAssessmentModuleData`1 is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.LifeCycleAssessment.Interfaces.[ILifeCycleAssessmentIndicator](/api/oM/Analytical/LifeCycleAssessment/Interfaces/ILifeCycleAssessmentIndicator)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - BH.oM.LifeCycleAssessment.Results.[IElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/IElementResult)&lt;[T](/api/oM/Analytical/LifeCycleAssessment/Results/IElementResult#t)&gt;
    - BH.oM.LifeCycleAssessment.Results.[IEnvironmentalResult](/api/oM/Analytical/LifeCycleAssessment/Results/IEnvironmentalResult)
    - BH.oM.LifeCycleAssessment.MaterialFragments.[IEnvironmentalMetric](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalMetrics/IEnvironmentalMetric)


### Classes implementing this interface

??? bhom "The following classes are implementing this interface:"

    - BH.oM.LifeCycleAssessment.Results.[AbioticDepletionFossilResourcesElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/AbioticDepletionFossilResourcesElementResult)
    - BH.oM.LifeCycleAssessment.Results.[AbioticDepletionMineralsAndMetalsElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/AbioticDepletionMineralsAndMetalsElementResult)
    - BH.oM.LifeCycleAssessment.Results.[AcidificationElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/AcidificationElementResult)
    - BH.oM.LifeCycleAssessment.Results.[ClimateChangeBiogenicElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/ClimateChangeBiogenicElementResult)
    - BH.oM.LifeCycleAssessment.Results.[ClimateChangeFossilElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/ClimateChangeFossilElementResult)
    - BH.oM.LifeCycleAssessment.Results.[ClimateChangeLandUseElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/ClimateChangeLandUseElementResult)
    - BH.oM.LifeCycleAssessment.Results.[ClimateChangeTotalElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/ClimateChangeTotalElementResult)
    - BH.oM.LifeCycleAssessment.Results.[ClimateChangeTotalNoBiogenicElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/ClimateChangeTotalNoBiogenicElementResult)
    - BH.oM.LifeCycleAssessment.Results.[ElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/ElementResult)&lt;[T](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/ElementResult#t)&gt;
    - BH.oM.LifeCycleAssessment.Results.[EutrophicationAquaticFreshwaterElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/EutrophicationAquaticFreshwaterElementResult)
    - BH.oM.LifeCycleAssessment.Results.[EutrophicationAquaticMarineElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/EutrophicationAquaticMarineElementResult)
    - BH.oM.LifeCycleAssessment.Results.[EutrophicationCMLElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/EutrophicationCMLElementResult)
    - BH.oM.LifeCycleAssessment.Results.[EutrophicationTerrestrialElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/EutrophicationTerrestrialElementResult)
    - BH.oM.LifeCycleAssessment.Results.[EutrophicationTRACIElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/EutrophicationTRACIElementResult)
    - BH.oM.LifeCycleAssessment.Results.[OzoneDepletionElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/OzoneDepletionElementResult)
    - BH.oM.LifeCycleAssessment.Results.[PhotochemicalOzoneCreationCMLElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/PhotochemicalOzoneCreationCMLElementResult)
    - BH.oM.LifeCycleAssessment.Results.[PhotochemicalOzoneCreationElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/PhotochemicalOzoneCreationElementResult)
    - BH.oM.LifeCycleAssessment.Results.[PhotochemicalOzoneCreationTRACIElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/PhotochemicalOzoneCreationTRACIElementResult)
    - BH.oM.LifeCycleAssessment.Results.[WaterDeprivationElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/WaterDeprivationElementResult)
    - BH.oM.LifeCycleAssessment.Results.[AbioticDepletionFossilResourcesMaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/MaterialResults/AbioticDepletionFossilResourcesMaterialResult)
    - BH.oM.LifeCycleAssessment.Results.[AbioticDepletionMineralsAndMetalsMaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/MaterialResults/AbioticDepletionMineralsAndMetalsMaterialResult)
    - BH.oM.LifeCycleAssessment.Results.[AcidificationMaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/MaterialResults/AcidificationMaterialResult)
    - BH.oM.LifeCycleAssessment.Results.[ClimateChangeBiogenicMaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/MaterialResults/ClimateChangeBiogenicMaterialResult)
    - BH.oM.LifeCycleAssessment.Results.[ClimateChangeFossilMaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/MaterialResults/ClimateChangeFossilMaterialResult)
    - BH.oM.LifeCycleAssessment.Results.[ClimateChangeLandUseMaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/MaterialResults/ClimateChangeLandUseMaterialResult)
    - BH.oM.LifeCycleAssessment.Results.[ClimateChangeTotalMaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/MaterialResults/ClimateChangeTotalMaterialResult)
    - BH.oM.LifeCycleAssessment.Results.[ClimateChangeTotalNoBiogenicMaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/MaterialResults/ClimateChangeTotalNoBiogenicMaterialResult)
    - BH.oM.LifeCycleAssessment.Results.[EutrophicationAquaticFreshwaterMaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/MaterialResults/EutrophicationAquaticFreshwaterMaterialResult)
    - BH.oM.LifeCycleAssessment.Results.[EutrophicationAquaticMarineMaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/MaterialResults/EutrophicationAquaticMarineMaterialResult)
    - BH.oM.LifeCycleAssessment.Results.[EutrophicationCMLMaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/MaterialResults/EutrophicationCMLMaterialResult)
    - BH.oM.LifeCycleAssessment.Results.[EutrophicationTerrestrialMaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/MaterialResults/EutrophicationTerrestrialMaterialResult)
    - BH.oM.LifeCycleAssessment.Results.[EutrophicationTRACIMaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/MaterialResults/EutrophicationTRACIMaterialResult)
    - BH.oM.LifeCycleAssessment.Results.[MaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/MaterialResults/MaterialResult)
    - BH.oM.LifeCycleAssessment.Results.[OzoneDepletionMaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/MaterialResults/OzoneDepletionMaterialResult)
    - BH.oM.LifeCycleAssessment.Results.[PhotochemicalOzoneCreationCMLMaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/MaterialResults/PhotochemicalOzoneCreationCMLMaterialResult)
    - BH.oM.LifeCycleAssessment.Results.[PhotochemicalOzoneCreationMaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/MaterialResults/PhotochemicalOzoneCreationMaterialResult)
    - BH.oM.LifeCycleAssessment.Results.[PhotochemicalOzoneCreationTRACIMaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/MaterialResults/PhotochemicalOzoneCreationTRACIMaterialResult)
    - BH.oM.LifeCycleAssessment.Results.[WaterDeprivationMaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/MaterialResults/WaterDeprivationMaterialResult)
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



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Indicators | [T](#t) | Set of indicators per module. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IMetricType | [MetricType](/api/oM/Analytical/LifeCycleAssessment/Enums/MetricType) | - | - | LifeCycleAssessment_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface ILifeCycleAssessmentModuleData`1 : BH.oM.LifeCycleAssessment.Interfaces.ILifeCycleAssessmentIndicator, BH.oM.Base.IObject
```

Assembly: LifeCycleAssessment_oM.dll

The C# interface definition is available on github:

- [ILifeCycleAssessmentModuleData.cs](https://github.com/BHoM/BHoM/blob/develop/LifeCycleAssessment_oM/Interfaces\ILifeCycleAssessmentModuleData.cs)

All history and changes of the class can be found by inspection the history.
