---
title: InternalWall
---

# <small>BH.oM.dKoP.</small>**InternalWall**



## Class structure

### Implemented interfaces and base types

???+ bhom "The InternalWall is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.dKoP.[IdKoPObject](/api/oM/Physical/dKoP/IdKoPObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| AdministrativeInformation | [AdministrativeInformation](/api/oM/Physical/dKoP/AdministrativeInformation/AdministrativeInformation) | - | - |
| QualityAndCertification | [QualityAndCertification](/api/oM/Physical/dKoP/QualityAndCertification/QualityAndCertification) | - | - |
| HealthAndSafety | [HealthAndSafety](/api/oM/Physical/dKoP/HealthAndSafety/HealthAndSafety) | - | - |
| Geometry | [WallGeometry](/api/oM/Physical/dKoP/Geometry/WallGeometry) | - | - |
| Performance | [InternalWallPerformance](/api/oM/Physical/dKoP/Performance/InternalWallPerformance) | - | - |
| Assembly | [Assembly](/api/oM/Physical/dKoP/Assembly/Assembly) | - | - |
| Interfaces | [WallInterfaces](/api/oM/Physical/dKoP/Interfaces/WallInterfaces) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class InternalWall : BH.oM.dKoP.IdKoPObject, BH.oM.Base.IObject
```

Assembly: dKoP_oM.dll

The C# class definition is available on github:

- [InternalWall.cs](https://github.com/BHoM/dKoP_Toolkit/blob/develop/dKoP_oM/Parts\InternalWall.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/dKoP_oM/InternalWall.json"
}
```

The JSON Schema is available on github here:

- [InternalWall.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/dKoP_oM/InternalWall.json)
