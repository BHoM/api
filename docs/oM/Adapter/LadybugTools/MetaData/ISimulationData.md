---
title: ISimulationData
---

# <small>BH.oM.LadybugTools.</small>**ISimulationData**



## Interface structure

### Implemented interfaces and base types

???+ bhom "The ISimulationData is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.LadybugTools.[CollectionData](/api/oM/Adapter/LadybugTools/MetaData/CollectionData)
    - BH.oM.LadybugTools.[NoData](/api/oM/Adapter/LadybugTools/MetaData/NoData)
    - BH.oM.LadybugTools.[SolarRadiationData](/api/oM/Adapter/LadybugTools/MetaData/SolarRadiationData)
    - BH.oM.LadybugTools.[SunPathData](/api/oM/Adapter/LadybugTools/MetaData/SunPathData)
    - BH.oM.LadybugTools.[UTCIData](/api/oM/Adapter/LadybugTools/MetaData/UTCIData)
    - BH.oM.LadybugTools.[WindroseData](/api/oM/Adapter/LadybugTools/MetaData/WindroseData)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface ISimulationData : BH.oM.Base.IObject
```

Assembly: LadybugTools_oM.dll

The C# interface definition is available on github:

- [ISimulationData.cs](https://github.com/BHoM/LadybugTools_Toolkit/blob/develop/LadybugTools_oM/MetaData\ISimulationData.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/LadybugTools_oM/ISimulationData.json"
}
```

The JSON Schema is available on github here:

- [ISimulationData.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/LadybugTools_oM/ISimulationData.json)
