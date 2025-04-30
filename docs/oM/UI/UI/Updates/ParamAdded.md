---
title: ParamAdded
---

# <small>BH.oM.UI.</small>**ParamAdded**



## Class structure

### Implemented interfaces and base types

???+ bhom "The ParamAdded is inheriting from the following base type(s) and implements the following interfaces:"

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
| IToText | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - | UI_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class ParamAdded : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.UI.IParamUpdate, BH.oM.UI.IUpdate
```

Assembly: UI_oM.dll

The class is defined in C#. The class definition is available on github:

- [ParamAdded.cs](https://github.com/BHoM/BHoM_UI/blob/develop/UI_oM/Updates\ParamAdded.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` { .json .copy .select } title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/UI_oM/ParamAdded.json}
```

The JSON Schema is available on github here:

- [ParamAdded.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/UI_oM/ParamAdded.json)
