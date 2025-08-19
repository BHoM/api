---
title: MetricType
---

# <small>BH.oM.LifeCycleAssessment.</small>**MetricType**

Enum of all available environmental indicators. Used for filtering metrics and results.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| Undefined |  -  |
| AbioticDepletionFossilResources |  -  |
| AbioticDepletionMineralsAndMetals |  -  |
| Acidification |  -  |
| ClimateChangeBiogenic |  -  |
| ClimateChangeFossil |  -  |
| ClimateChangeLandUse |  -  |
| ClimateChangeTotal |  -  |
| ClimateChangeTotalNoBiogenic |  -  |
| EutrophicationCML |  -  |
| EutrophicationAquaticFreshwater |  -  |
| EutrophicationAquaticMarine |  -  |
| EutrophicationTerrestrial |  -  |
| EutrophicationTRACI |  -  |
| OzoneDepletion |  -  |
| PhotochemicalOzoneCreation |  -  |
| PhotochemicalOzoneCreationCML |  -  |
| PhotochemicalOzoneCreationTRACI |  -  |
| WaterDeprivation |  -  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum MetricType : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: LifeCycleAssessment_oM.dll

The C# enum definition is available on github:

- [MetricType.cs](https://github.com/BHoM/BHoM/blob/develop/LifeCycleAssessment_oM/Enums\MetricType.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/LifeCycleAssessment_oM/MetricType.json"
}
```

The JSON Schema is available on github here:

- [MetricType.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/LifeCycleAssessment_oM/MetricType.json)
