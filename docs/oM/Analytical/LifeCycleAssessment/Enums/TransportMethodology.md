---
title: TransportMethodology
---

# <small>BH.oM.LifeCycleAssessment.Enums.</small>**TransportMethodology**

Enum outlining the type of transport method to create.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| Undefined |  -  |
| DistanceTransportMode |  Factors computed based on one or more mades of transport over a user specified distance.  |
| TypicalTransportScenario |  A typical transport scenario using factors from a dataset.  |
| CustomTransportFactors |  User defined expicit values for A4 factors.  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum TransportMethodology : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: LifeCycleAssessment_oM.dll

The C# enum definition is available on github:

- [TransportMethodology.cs](https://github.com/BHoM/BHoM/blob/develop/LifeCycleAssessment_oM/Enums\TransportMethodology.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/LifeCycleAssessment_oM/Enums/TransportMethodology.json"
}
```

The JSON Schema is available on github here:

- [TransportMethodology.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/LifeCycleAssessment_oM/Enums/TransportMethodology.json)
