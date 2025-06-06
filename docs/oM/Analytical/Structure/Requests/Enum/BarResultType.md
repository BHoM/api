---
title: BarResultType
---

# <small>BH.oM.Structure.Requests.</small>**BarResultType**

Defines the type of results that should be extracted for BarResultRequests.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| BarForce |  -  |
| BarDeformation |  Local deformation of the bar. All results given in local coordinates.  |
| BarStress |  -  |
| BarStrain |  -  |
| BarDisplacement |  Total displacement of the bar. All results given in global coordinates.  |
| BarModeShape |  Mode shape of the bar. All results given in global coordinates, normalised to 1.  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum BarResultType : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: Structure_oM.dll

The C# enum definition is available on github:

- [BarResultType.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/Requests\Enum\BarResultType.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Structure_oM/Requests/BarResultType.json"
}
```

The JSON Schema is available on github here:

- [BarResultType.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Structure_oM/Requests/BarResultType.json)
