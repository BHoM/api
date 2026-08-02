---
title: LoadType
---

# <small>BH.oM.Structure.Loads.</small>**LoadType**



## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| Selfweight |  -  |
| PointLoad |  -  |
| PointDisplacement |  -  |
| PointVelocity |  -  |
| PointAcceleration |  -  |
| BarPointLoad |  -  |
| BarUniformLoad |  -  |
| BarVaryingLoad |  -  |
| BarTemperature |  -  |
| AreaUniformLoad |  -  |
| AreaVaryingLoad |  -  |
| AreaTemperature |  -  |
| Pressure |  -  |
| Geometrical |  -  |
| TransientTimeHistoryLoad |  -  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum LoadType : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: Structure_oM.dll

The C# enum definition is available on github:

- [LoadType.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/Loads\Enums\LoadType.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Structure_oM/Loads/LoadType.json"
}
```

The JSON Schema is available on github here:

- [LoadType.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Structure_oM/Loads/LoadType.json)
