---
title: ITransportFactors
---

# <small>BH.oM.LifeCycleAssessment.MaterialFragments.Transport.</small>**ITransportFactors**

Base interface for transport factor calculations.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The ITransportFactors is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.LifeCycleAssessment.MaterialFragments.Transport.[DistanceTransportModeScenario](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/Transport/DistanceTransportModeScenario)
    - BH.oM.LifeCycleAssessment.MaterialFragments.Transport.[FullTransportScenario](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/Transport/FullTransportScenario)
    - BH.oM.LifeCycleAssessment.MaterialFragments.Transport.[SingleTransportModeImpact](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/Transport/SingleTransportModeImpact)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface ITransportFactors : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: LifeCycleAssessment_oM.dll

The C# interface definition is available on github:

- [ITransportFactors.cs](https://github.com/BHoM/BHoM/blob/develop/LifeCycleAssessment_oM/MaterialFragments\Transport\ITransportFactors.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/LifeCycleAssessment_oM/MaterialFragments/Transport/ITransportFactors.json"
}
```

The JSON Schema is available on github here:

- [ITransportFactors.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/LifeCycleAssessment_oM/MaterialFragments/Transport/ITransportFactors.json)
