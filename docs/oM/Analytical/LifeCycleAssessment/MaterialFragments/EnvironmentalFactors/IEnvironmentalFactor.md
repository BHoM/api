---
title: IEnvironmentalFactor
---

# <small>BH.oM.LifeCycleAssessment.MaterialFragments.</small>**IEnvironmentalFactor**

Single value indicator for enviromental indicators. Used by for example Transport factors.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IEnvironmentalFactor is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.LifeCycleAssessment.Interfaces.[ILifeCycleAssessmentIndicator](/api/oM/Analytical/LifeCycleAssessment/Interfaces/ILifeCycleAssessmentIndicator)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.LifeCycleAssessment.MaterialFragments.[AbioticDepletionFossilResourcesFactor](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalFactors/AbioticDepletionFossilResourcesFactor)
    - BH.oM.LifeCycleAssessment.MaterialFragments.[AbioticDepletionMineralsAndMetalsFactor](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalFactors/AbioticDepletionMineralsAndMetalsFactor)
    - BH.oM.LifeCycleAssessment.MaterialFragments.[AcidificationFactor](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalFactors/AcidificationFactor)
    - BH.oM.LifeCycleAssessment.MaterialFragments.[ClimateChangeBiogenicFactor](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalFactors/ClimateChangeBiogenicFactor)
    - BH.oM.LifeCycleAssessment.MaterialFragments.[ClimateChangeFossilFactor](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalFactors/ClimateChangeFossilFactor)
    - BH.oM.LifeCycleAssessment.MaterialFragments.[ClimateChangeLandUseFactor](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalFactors/ClimateChangeLandUseFactor)
    - BH.oM.LifeCycleAssessment.MaterialFragments.[ClimateChangeTotalFactor](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalFactors/ClimateChangeTotalFactor)
    - BH.oM.LifeCycleAssessment.MaterialFragments.[ClimateChangeTotalNoBiogenicFactor](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalFactors/ClimateChangeTotalNoBiogenicFactor)
    - BH.oM.LifeCycleAssessment.MaterialFragments.[EutrophicationAquaticFreshwaterFactor](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalFactors/EutrophicationAquaticFreshwaterFactor)
    - BH.oM.LifeCycleAssessment.MaterialFragments.[EutrophicationAquaticMarineFactor](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalFactors/EutrophicationAquaticMarineFactor)
    - BH.oM.LifeCycleAssessment.MaterialFragments.[EutrophicationCMLFactor](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalFactors/EutrophicationCMLFactor)
    - BH.oM.LifeCycleAssessment.MaterialFragments.[EutrophicationTerrestrialFactor](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalFactors/EutrophicationTerrestrialFactor)
    - BH.oM.LifeCycleAssessment.MaterialFragments.[EutrophicationTRACIFactor](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalFactors/EutrophicationTRACIFactor)
    - BH.oM.LifeCycleAssessment.MaterialFragments.[OzoneDepletionFactor](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalFactors/OzoneDepletionFactor)
    - BH.oM.LifeCycleAssessment.MaterialFragments.[PhotochemicalOzoneCreationCMLFactor](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalFactors/PhotochemicalOzoneCreationCMLFactor)
    - BH.oM.LifeCycleAssessment.MaterialFragments.[PhotochemicalOzoneCreationFactor](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalFactors/PhotochemicalOzoneCreationFactor)
    - BH.oM.LifeCycleAssessment.MaterialFragments.[PhotochemicalOzoneCreationTRACIFactor](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalFactors/PhotochemicalOzoneCreationTRACIFactor)
    - BH.oM.LifeCycleAssessment.MaterialFragments.[WaterDeprivationFactor](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalFactors/WaterDeprivationFactor)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Value | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Value of the indicator. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IMetricType | [MetricType](/api/oM/Analytical/LifeCycleAssessment/Enums/MetricType) | - | - | LifeCycleAssessment_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IEnvironmentalFactor : BH.oM.LifeCycleAssessment.Interfaces.ILifeCycleAssessmentIndicator, BH.oM.Base.IObject
```

Assembly: LifeCycleAssessment_oM.dll

The C# interface definition is available on github:

- [IEnvironmentalFactor.cs](https://github.com/BHoM/BHoM/blob/develop/LifeCycleAssessment_oM/MaterialFragments\EnvironmentalFactors\IEnvironmentalFactor.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/LifeCycleAssessment_oM/MaterialFragments/IEnvironmentalFactor.json"
}
```

The JSON Schema is available on github here:

- [IEnvironmentalFactor.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/LifeCycleAssessment_oM/MaterialFragments/IEnvironmentalFactor.json)
