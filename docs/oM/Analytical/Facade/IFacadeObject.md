---
title: IFacadeObject
---

# <small>BH.oM.Facade.</small>**IFacadeObject**



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IFacadeObject is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Facade.Elements.[CurtainWall](/api/oM/Analytical/Facade/Elements/CurtainWall)
    - BH.oM.Facade.Elements.[Opening](/api/oM/Analytical/Facade/Elements/Opening)
    - BH.oM.Facade.Elements.[Panel](/api/oM/Analytical/Facade/Elements/Panel)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface IFacadeObject : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: Facade_oM.dll

The C# interface definition is available on github:

- [IFacadeObject.cs](https://github.com/BHoM/BHoM/blob/develop/Facade_oM/IFacadeObject.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Facade_oM/IFacadeObject.json"
}
```

The JSON Schema is available on github here:

- [IFacadeObject.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Facade_oM/IFacadeObject.json)
