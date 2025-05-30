---
title: EPWKey
---

# <small>BH.oM.LadybugTools.</small>**EPWKey**

An enum for keys that frequently appear in epw files.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| Undefined |  -  |
| AerosolOpticalDepth |  -  |
| AtmosphericStationPressure |  -  |
| CeilingHeight |  -  |
| DaysSinceLastSnowfall |  -  |
| DewPointTemperature |  -  |
| DiffuseHorizontalIlluminance |  -  |
| DiffuseHorizontalRadiation |  -  |
| DirectNormalIlluminance |  -  |
| DirectNormalRadiation |  -  |
| DryBulbTemperature |  -  |
| ExtraterrestrialDirectNormalRadiation |  -  |
| ExtraterrestrialHorizontalRadiation |  -  |
| GlobalHorizontalIlluminance |  -  |
| GlobalHorizontalRadiation |  -  |
| HorizontalInfraredRadiationIntensity |  -  |
| OpaqueSkyCover |  -  |
| PrecipitableWater |  -  |
| PresentWeatherCodes |  -  |
| PresentWeatherObservation |  -  |
| RelativeHumidity |  -  |
| SnowDepth |  -  |
| TotalSkyCover |  -  |
| Visibility |  -  |
| WetBulbTemperature |  Wet bulb temperature is a calculated property of epw data.  |
| WindDirection |  -  |
| WindSpeed |  -  |
| ZenithLuminance |  -  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum EPWKey : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: LadybugTools_oM.dll

The C# enum definition is available on github:

- [EPWKey.cs](https://github.com/BHoM/LadybugTools_Toolkit/blob/develop/LadybugTools_oM/Enum\EPWKeys.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/LadybugTools_oM/EPWKey.json"
}
```

The JSON Schema is available on github here:

- [EPWKey.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/LadybugTools_oM/EPWKey.json)
