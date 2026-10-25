---
title: ITimberPrimaryBeamConfiguration
---

# <small>BH.oM.Structure.FloorSystem.</small>**ITimberPrimaryBeamConfiguration**

Interface for floor configurations with timber primary beams.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The ITimberPrimaryBeamConfiguration is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Structure.FloorSystem.[IPrimaryBeamConfiguration](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/IPrimaryBeamConfiguration)&lt;BH.oM.Structure.SectionProperties.[TimberSection](/api/oM/Analytical/Structure/SectionProperties/TimberSection)&gt;
    -  BH.oM.Structure.FloorSystem.[IFloorConfiguration](/api/oM/Analytical/Structure/FloorSystem/IFloorConfiguration)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - BH.oM.Structure.FloorSystem.[ITimberFrameConfiguration](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/ITimberFrameConfiguration)
    - BH.oM.Structure.FloorSystem.[ITimberTertiaryBeamFloorConfiguration](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/ITimberTertiaryBeamFloorConfiguration)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Structure.FloorSystem.[TimberInfillBeams](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/TimberInfillBeams)
    - BH.oM.Structure.FloorSystem.[TimberJoistFloor](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/TimberJoistFloor)
    - BH.oM.Structure.FloorSystem.FloorConfigurations.[HybridConcreteOnTimber](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/HybridConcreteOnTimber)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface ITimberPrimaryBeamConfiguration : BH.oM.Structure.FloorSystem.IPrimaryBeamConfiguration<BH.oM.Structure.SectionProperties.TimberSection>,
BH.oM.Structure.FloorSystem.IFloorConfiguration,
BH.oM.Base.IBHoMObject,
BH.oM.Base.IObject
```

Assembly: Structure_oM.dll

The C# interface definition is available on github:

- [ITimberPrimaryBeamConfiguration.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/FloorSystem\FloorConfigurations\Interfaces\ITimberPrimaryBeamConfiguration.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Structure_oM/FloorSystem/ITimberPrimaryBeamConfiguration.json"
}
```

The JSON Schema is available on github here:

- [ITimberPrimaryBeamConfiguration.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Structure_oM/FloorSystem/ITimberPrimaryBeamConfiguration.json)
