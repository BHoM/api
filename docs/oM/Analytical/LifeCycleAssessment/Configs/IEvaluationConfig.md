---
title: IEvaluationConfig
---

# <small>BH.oM.LifeCycleAssessment.Configs.</small>**IEvaluationConfig**

Base interface for evaluation configs controling how metrics should be evaluated.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IEvaluationConfig is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.LifeCycleAssessment.Configs.[GlobalEmissionFactors](/api/oM/Analytical/LifeCycleAssessment/Configs/GlobalEmissionFactors)
    - BH.oM.LifeCycleAssessment.Configs.[IStructEEvaluationConfig](/api/oM/Analytical/LifeCycleAssessment/Configs/IStructEEvaluationConfig)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface IEvaluationConfig : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: LifeCycleAssessment_oM.dll

The C# interface definition is available on github:

- [IEvaluationConfig.cs](https://github.com/BHoM/BHoM/blob/develop/LifeCycleAssessment_oM/Configs\IEvaluationConfig.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/LifeCycleAssessment_oM/Configs/IEvaluationConfig.json"
}
```

The JSON Schema is available on github here:

- [IEvaluationConfig.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/LifeCycleAssessment_oM/Configs/IEvaluationConfig.json)
