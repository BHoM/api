---
title: IAnalysisResult
---

# <small>BH.oM.Environment.Results.</small>**IAnalysisResult**

Interface for all AnalysisResult objects.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IAnalysisResult is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - BH.oM.Environment.Results.[IAngleResult](/api/oM/Analytical/Environment/Results/ResultObjects/Angle/IAngleResult)
    - BH.oM.Environment.Results.[IEnergyPerUnitAreaResult](/api/oM/Analytical/Environment/Results/ResultObjects/EnergyPerUnitArea/IEnergyPerUnitAreaResult)
    - BH.oM.Environment.Results.[IEnergyPerUnitTimeResult](/api/oM/Analytical/Environment/Results/ResultObjects/EnergyPerUnitTime/IEnergyPerUnitTimeResult)
    - BH.oM.Environment.Results.[IEnergyResult](/api/oM/Analytical/Environment/Results/ResultObjects/Energy/IEnergyResult)
    - BH.oM.Environment.Results.[IPressureResult](/api/oM/Analytical/Environment/Results/ResultObjects/Pressure/IPressureResult)
    - BH.oM.Environment.Results.[IRatioResult](/api/oM/Analytical/Environment/Results/ResultObjects/Ratio/IRatioResult)
    - BH.oM.Environment.Results.[ISpecificEnergyResult](/api/oM/Analytical/Environment/Results/ResultObjects/SpecificEnergy/ISpecificEnergyResult)
    - BH.oM.Environment.Results.[ITemperatureResult](/api/oM/Analytical/Environment/Results/ResultObjects/Temperature/ITemperatureResult)
    - BH.oM.Environment.Results.[IVelocityResult](/api/oM/Analytical/Environment/Results/ResultObjects/Velocity/IVelocityResult)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Environment.Results.[WindDirectionResult](/api/oM/Analytical/Environment/Results/ResultObjects/Angle/WindDirectionResult)
    - BH.oM.Environment.Results.[DiffuseHorizontalRadiationResult](/api/oM/Analytical/Environment/Results/ResultObjects/EnergyPerUnitArea/DiffuseHorizontalRadiationResult)
    - BH.oM.Environment.Results.[DirectNormalRadiationResult](/api/oM/Analytical/Environment/Results/ResultObjects/EnergyPerUnitArea/DirectNormalRadiationResult)
    - BH.oM.Environment.Results.[GlobalHorizontalRadiationResult](/api/oM/Analytical/Environment/Results/ResultObjects/EnergyPerUnitArea/GlobalHorizontalRadiationResult)
    - BH.oM.Environment.Results.[InsolationResult](/api/oM/Analytical/Environment/Results/ResultObjects/EnergyPerUnitArea/InsolationResult)
    - BH.oM.Environment.Results.[PowerResult](/api/oM/Analytical/Environment/Results/ResultObjects/EnergyPerUnitTime/PowerResult)
    - BH.oM.Environment.Results.[IlluminanceResult](/api/oM/Analytical/Environment/Results/ResultObjects/Illuminance/IlluminanceResult)
    - BH.oM.Environment.Results.[AtmosphericPressureResult](/api/oM/Analytical/Environment/Results/ResultObjects/Pressure/AtmosphericPressureResult)
    - BH.oM.Environment.Results.[HumidityRatioResult](/api/oM/Analytical/Environment/Results/ResultObjects/Ratio/HumidityRatioResult)
    - BH.oM.Environment.Results.[RelativeHumidityResult](/api/oM/Analytical/Environment/Results/ResultObjects/Ratio/RelativeHumidityResult)
    - BH.oM.Environment.Results.[EnthalpyResult](/api/oM/Analytical/Environment/Results/ResultObjects/SpecificEnergy/EnthalpyResult)
    - BH.oM.Environment.Results.[DewPointTemperatureResult](/api/oM/Analytical/Environment/Results/ResultObjects/Temperature/DewPointTemperatureResult)
    - BH.oM.Environment.Results.[DryBulbTemperatureResult](/api/oM/Analytical/Environment/Results/ResultObjects/Temperature/DryBulbTemperatureResult)
    - BH.oM.Environment.Results.[MeanRadiantTemperatureResult](/api/oM/Analytical/Environment/Results/ResultObjects/Temperature/MeanRadiantTemperatureResult)
    - BH.oM.Environment.Results.[SkyTemperatureResult](/api/oM/Analytical/Environment/Results/ResultObjects/Temperature/SkyTemperatureResult)
    - BH.oM.Environment.Results.[SurfaceTemperatureResult](/api/oM/Analytical/Environment/Results/ResultObjects/Temperature/SurfaceTemperatureResult)
    - BH.oM.Environment.Results.[UniversalThermalClimateIndexResult](/api/oM/Analytical/Environment/Results/ResultObjects/Temperature/UniversalThermalClimateIndexResult)
    - BH.oM.Environment.Results.[WetBulbTemperatureResult](/api/oM/Analytical/Environment/Results/ResultObjects/Temperature/WetBulbTemperatureResult)
    - BH.oM.Environment.Results.[WindSpeedResult](/api/oM/Analytical/Environment/Results/ResultObjects/Velocity/WindSpeedResult)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Result | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IAnalysisResult : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: Environment_oM.dll

The C# interface definition is available on github:

- [IAnalysisResult.cs](https://github.com/BHoM/BHoM/blob/develop/Environment_oM/Results\ResultObjects\IAnalysisResult.cs)

All history and changes of the class can be found by inspection the history.
