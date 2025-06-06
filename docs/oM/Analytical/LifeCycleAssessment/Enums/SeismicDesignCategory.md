---
title: SeismicDesignCategory
---

# <small>BH.oM.LifeCycleAssessment.</small>**SeismicDesignCategory**

Seismic Design Category is a classification assigned to a structure based on it's occupancy category, and the severity of the design earthquake ground motion. These categories are in reference to ASCE 7-05.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| Undefined |  -  |
| A |  -  |
| B |  -  |
| C |  -  |
| D |  -  |
| E |  -  |
| F |  -  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum SeismicDesignCategory : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: LifeCycleAssessment_oM.dll

The C# enum definition is available on github:

- [SeismicDesignCategory.cs](https://github.com/BHoM/BHoM/blob/develop/LifeCycleAssessment_oM/Enums\SeismicDesignCategory.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/LifeCycleAssessment_oM/SeismicDesignCategory.json"
}
```

The JSON Schema is available on github here:

- [SeismicDesignCategory.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/LifeCycleAssessment_oM/SeismicDesignCategory.json)
