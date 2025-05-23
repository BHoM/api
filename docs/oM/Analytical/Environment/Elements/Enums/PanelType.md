---
title: PanelType
---

# <small>BH.oM.Environment.Elements.</small>**PanelType**

The type of environmental surface (e.g. Wall, Floor, Roof)

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| Undefined |  -  |
| Adiabatic |  -  |
| Air |  -  |
| Ceiling |  -  |
| CurtainWall |  -  |
| Floor |  -  |
| FloorExposed |  -  |
| FloorInternal |  -  |
| FloorRaised |  -  |
| Roof |  -  |
| Shade |  -  |
| SlabOnGrade |  -  |
| SolarPanel |  -  |
| TranslucentShade |  -  |
| UndergroundCeiling |  -  |
| UndergroundSlab |  -  |
| UndergroundWall |  -  |
| Wall |  -  |
| WallExternal |  -  |
| WallInternal |  -  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum PanelType : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: Environment_oM.dll

The C# enum definition is available on github:

- [PanelType.cs](https://github.com/BHoM/BHoM/blob/develop/Environment_oM/Elements\Enums\PanelType.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Environment_oM/Elements/PanelType.json"
}
```

The JSON Schema is available on github here:

- [PanelType.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Environment_oM/Elements/PanelType.json)
