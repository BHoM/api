---
title: IRatioResult
---

# <small>BH.oM.Environment.Results.</small>**IRatioResult**

A results object containing ratio data.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IRatioResult is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Environment.Results.[IAnalysisResult](/api/oM/Analytical/Environment/Results/ResultObjects/IAnalysisResult)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Environment.Results.[HumidityRatioResult](/api/oM/Analytical/Environment/Results/ResultObjects/Ratio/HumidityRatioResult)
    - BH.oM.Environment.Results.[RelativeHumidityResult](/api/oM/Analytical/Environment/Results/ResultObjects/Ratio/RelativeHumidityResult)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface IRatioResult : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.Environment.Results.IAnalysisResult
```

Assembly: Environment_oM.dll

The C# interface definition is available on github:

- [IRatioResult.cs](https://github.com/BHoM/BHoM/blob/develop/Environment_oM/Results\ResultObjects\Ratio\IRatioResult.cs)

All history and changes of the class can be found by inspection the history.
