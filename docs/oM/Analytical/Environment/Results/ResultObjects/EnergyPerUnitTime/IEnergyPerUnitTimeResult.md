---
title: IEnergyPerUnitTimeResult
---

# <small>BH.oM.Environment.Results.</small>**IEnergyPerUnitTimeResult**

A results object containing energy per unit time data.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IEnergyPerUnitTimeResult is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Environment.Results.[IAnalysisResult](/api/oM/Analytical/Environment/Results/ResultObjects/IAnalysisResult)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Environment.Results.[PowerResult](/api/oM/Analytical/Environment/Results/ResultObjects/EnergyPerUnitTime/PowerResult)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface IEnergyPerUnitTimeResult : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.Environment.Results.IAnalysisResult
```

Assembly: Environment_oM.dll

The C# interface definition is available on github:

- [IEnergyPerUnitTimeResult.cs](https://github.com/BHoM/BHoM/blob/develop/Environment_oM/Results\ResultObjects\EnergyPerUnitTime\IEnergyPerUnitTimeResult.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Environment_oM/Results/IEnergyPerUnitTimeResult.json"
}
```

The JSON Schema is available on github here:

- [IEnergyPerUnitTimeResult.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Environment_oM/Results/IEnergyPerUnitTimeResult.json)
