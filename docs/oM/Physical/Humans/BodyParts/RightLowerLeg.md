---
title: RightLowerLeg
---

# <small>BH.oM.Humans.BodyParts.</small>**RightLowerLeg**



## Class structure

### Implemented interfaces and base types

???+ bhom "The RightLowerLeg is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Humans.Interfaces.[ILineBodyPart](/api/oM/Physical/Humans/Interfaces/ILineBodyPart)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| TrackingLine | [Line](/api/oM/Dimensional/Geometry/Curve/Line) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class RightLowerLeg : BH.oM.Humans.Interfaces.ILineBodyPart, BH.oM.Base.IObject
```

Assembly: Humans_oM.dll

The C# class definition is available on github:

- [RightLowerLeg.cs](https://github.com/BHoM/BHoM/blob/develop/Humans_oM/BodyParts\RightLowerLeg.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Humans_oM/BodyParts/RightLowerLeg.json"
}
```

The JSON Schema is available on github here:

- [RightLowerLeg.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Humans_oM/BodyParts/RightLowerLeg.json)
