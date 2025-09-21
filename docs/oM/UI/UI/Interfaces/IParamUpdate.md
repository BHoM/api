---
title: IParamUpdate
---

# <small>BH.oM.UI.</small>**IParamUpdate**



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IParamUpdate is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.UI.[IUpdate](/api/oM/UI/UI/Interfaces/IUpdate)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.UI.[ParamAdded](/api/oM/UI/UI/Updates/ParamAdded)
    - BH.oM.UI.[ParamMoved](/api/oM/UI/UI/Updates/ParamMoved)
    - BH.oM.UI.[ParamRemoved](/api/oM/UI/UI/Updates/ParamRemoved)
    - BH.oM.UI.[ParamUpdated](/api/oM/UI/UI/Updates/ParamReplaced)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Param | [ParamInfo](/api/oM/UI/UI/ParamInfo) | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IToText | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Converts a parameter update to text representation. | - | UI_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IParamUpdate : BH.oM.UI.IUpdate, BH.oM.Base.IObject
```

Assembly: UI_oM.dll

The C# interface definition is available on github:

- [IParamUpdate.cs](https://github.com/BHoM/BHoM_UI/blob/develop/UI_oM/Interfaces\IParamUpdate.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/UI_oM/IParamUpdate.json"
}
```

The JSON Schema is available on github here:

- [IParamUpdate.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/UI_oM/IParamUpdate.json)
