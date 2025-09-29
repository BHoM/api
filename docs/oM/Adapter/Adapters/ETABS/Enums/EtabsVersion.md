---
title: EtabsVersion
---

# <small>BH.oM.Adapters.ETABS.</small>**EtabsVersion**

The ETABS version number used in the adapter to select the path of the corresponding executable.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| v18 |  -  |
| v20 |  -  |
| v21 |  -  |
| v22 |  -  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum EtabsVersion : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: ETABS_oM.dll

The C# enum definition is available on github:

- [EtabsVersion.cs](https://github.com/BHoM/ETABS_Toolkit/blob/develop/ETABS_oM/Enums\EtabsVersion.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/ETABS_oM/EtabsVersion.json"
}
```

The JSON Schema is available on github here:

- [EtabsVersion.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/ETABS_oM/EtabsVersion.json)
