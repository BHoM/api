---
title: RightThumb
---

# <small>BH.oM.Humans.BodyParts.</small>**RightThumb**



## Class structure

### Implemented interfaces and base types

???+ bhom "The RightThumb is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Humans.Interfaces.[ILineBodyPart](/api/oM/Physical/Humans/Interfaces/ILineBodyPart)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Humans.Interfaces.[IPointBodyPart](/api/oM/Physical/Humans/Interfaces/IPointBodyPart)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| TrackingPoint | [Point](/api/oM/Dimensional/Geometry/Vector/Point) | - | - |
| TrackingLine | [Line](/api/oM/Dimensional/Geometry/Curve/Line) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class RightThumb : BH.oM.Humans.Interfaces.ILineBodyPart, BH.oM.Base.IObject, BH.oM.Humans.Interfaces.IPointBodyPart
```

Assembly: Humans_oM.dll

The C# class definition is available on github:

- [RightThumb.cs](https://github.com/BHoM/BHoM/blob/develop/Humans_oM/BodyParts\RightThumb.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Humans_oM/BodyParts/RightThumb.json"
}
```

The JSON Schema is available on github here:

- [RightThumb.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Humans_oM/BodyParts/RightThumb.json)
