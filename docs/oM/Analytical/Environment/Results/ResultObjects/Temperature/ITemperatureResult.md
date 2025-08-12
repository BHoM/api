---
title: ITemperatureResult
---

# <small>BH.oM.Environment.Results.</small>**ITemperatureResult**

A results object containing temperature data.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The ITemperatureResult is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Environment.Results.[IAnalysisResult](/api/oM/Analytical/Environment/Results/ResultObjects/IAnalysisResult)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Environment.Results.[DewPointTemperatureResult](/api/oM/Analytical/Environment/Results/ResultObjects/Temperature/DewPointTemperatureResult)
    - BH.oM.Environment.Results.[DryBulbTemperatureResult](/api/oM/Analytical/Environment/Results/ResultObjects/Temperature/DryBulbTemperatureResult)
    - BH.oM.Environment.Results.[MeanRadiantTemperatureResult](/api/oM/Analytical/Environment/Results/ResultObjects/Temperature/MeanRadiantTemperatureResult)
    - BH.oM.Environment.Results.[SkyTemperatureResult](/api/oM/Analytical/Environment/Results/ResultObjects/Temperature/SkyTemperatureResult)
    - BH.oM.Environment.Results.[SurfaceTemperatureResult](/api/oM/Analytical/Environment/Results/ResultObjects/Temperature/SurfaceTemperatureResult)
    - BH.oM.Environment.Results.[UniversalThermalClimateIndexResult](/api/oM/Analytical/Environment/Results/ResultObjects/Temperature/UniversalThermalClimateIndexResult)
    - BH.oM.Environment.Results.[WetBulbTemperatureResult](/api/oM/Analytical/Environment/Results/ResultObjects/Temperature/WetBulbTemperatureResult)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface ITemperatureResult : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.Environment.Results.IAnalysisResult
```

Assembly: Environment_oM.dll

The C# interface definition is available on github:

- [ITemperatureResult.cs](https://github.com/BHoM/BHoM/blob/develop/Environment_oM/Results\ResultObjects\Temperature\ITemperatureResult.cs)

All history and changes of the class can be found by inspection the history.
