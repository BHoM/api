---
title: ProfileResultType
---

# <small>BH.oM.Environment.Results.</small>**ProfileResultType**



## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| Undefined |  -  |
| ApertureFlowIn |  -  |
| ApertureFlowOut |  -  |
| ApertureOpening |  -  |
| CloudCover |  -  |
| CondensationExternal |  -  |
| CondensationInternal |  -  |
| CondensationInterstitial |  -  |
| ConductionExternal |  -  |
| ConductionExternalGlazing |  -  |
| ConductionExternalOpaque |  -  |
| ConductionInternal |  -  |
| ConvectionExternal |  -  |
| ConvectionInternal |  -  |
| GainAirMovement |  -  |
| GainEquipmentLatent |  -  |
| GainEquipmentSensible |  -  |
| GainInfiltrationVentilation |  -  |
| GainInternalSolar |  -  |
| GainLighting |  -  |
| GainOccupancyLatent |  -  |
| GainOccupantSensible |  -  |
| GainSolar |  -  |
| HeatTransferBuilding |  -  |
| HumidityExternal |  -  |
| HumidityRatio |  -  |
| HumidityRelative |  -  |
| Infiltration |  -  |
| IZAMIn |  -  |
| IZAMOut |  -  |
| LoadCooling |  -  |
| LoadHeating |  -  |
| LoadLatent |  -  |
| LoadLatentAddition |  -  |
| LoadLatentRemoval |  -  |
| LoadSensible |  -  |
| LongWaveExternal |  -  |
| LongWaveInternal |  -  |
| Pollutant |  -  |
| PressureRelative |  -  |
| PressureVapour |  -  |
| RadiationDiffuse |  -  |
| RadiationGlobal |  -  |
| TemperatureDryBulb |  -  |
| TemperatureExternal |  -  |
| TemperatureMeanRadiant |  -  |
| TemperatureResultant |  -  |
| Ventilation |  -  |
| WindDirection |  -  |
| WindSpeed |  -  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum ProfileResultType : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: Environment_oM.dll

The enum is defined in C#. The class definition is available on github:

- [ProfileResultType.cs](https://github.com/BHoM/BHoM/blob/develop/Environment_oM/Results\Enums\ProfileResultType.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Environment_oM/Results/ProfileResultType.json"
}
```

The JSON Schema is available on github here:

- [ProfileResultType.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Environment_oM/Results/ProfileResultType.json)
