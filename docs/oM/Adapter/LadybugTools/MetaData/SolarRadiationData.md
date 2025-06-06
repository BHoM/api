---
title: SolarRadiationData
---

# <small>BH.oM.LadybugTools.</small>**SolarRadiationData**



## Class structure

### Implemented interfaces and base types

???+ bhom "The SolarRadiationData is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.LadybugTools.[ISimulationData](/api/oM/Adapter/LadybugTools/MetaData/ISimulationData)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| MaxValue | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The maximum incoming solar radiation. | - |
| MinValue | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The minimum incoming solar radiation. | - |
| MaxDirection | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The direction, in degrees(°) clockwise from north that the maximum incoming solar radiation is coming from. | - |
| MinDirection | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The direction, in degrees(°) clockwise from north that the minimum incoming solar radiation is coming from. | - |
| MaxTilt | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The angle, in degrees(°) above the horizon that the maximum incoming solar radiation is coming from. | - |
| MinTilt | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The angle, in degrees(°) above the horizon that the minimum incoming solar radiation is coming from. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class SolarRadiationData : BH.oM.LadybugTools.ISimulationData, BH.oM.Base.IObject
```

Assembly: LadybugTools_oM.dll

The C# class definition is available on github:

- [SolarRadiationData.cs](https://github.com/BHoM/LadybugTools_Toolkit/blob/develop/LadybugTools_oM/MetaData\SolarRadiationData.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/LadybugTools_oM/SolarRadiationData.json"
}
```

The JSON Schema is available on github here:

- [SolarRadiationData.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/LadybugTools_oM/SolarRadiationData.json)
