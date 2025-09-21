---
title: ParamMoved
---

# <small>BH.oM.UI.</small>**ParamMoved**



## Class structure

### Implemented interfaces and base types

???+ bhom "The ParamMoved is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.UI.[IParamUpdate](/api/oM/UI/UI/Interfaces/IParamUpdate)
    -  BH.oM.UI.[IUpdate](/api/oM/UI/UI/Interfaces/IUpdate)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Index | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | - | - |
| Param | [ParamInfo](/api/oM/UI/UI/ParamInfo) | - | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IToText | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Converts a parameter update to text representation. | - | UI_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class ParamMoved : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.UI.IParamUpdate, BH.oM.UI.IUpdate
```

Assembly: UI_oM.dll

The C# class definition is available on github:

- [ParamMoved.cs](https://github.com/BHoM/BHoM_UI/blob/develop/UI_oM/Updates\ParamMoved.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/UI_oM/ParamMoved.json"
}
```

The JSON Schema is available on github here:

- [ParamMoved.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/UI_oM/ParamMoved.json)
