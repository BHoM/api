---
title: LadybugConfig
---

# <small>BH.oM.LadybugTools.</small>**LadybugConfig**

The action config for the LadybugTools Adapter.

## Class structure

### Implemented interfaces and base types

???+ bhom "The LadybugConfig is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Adapter.[ActionConfig](/api/oM/Framework/Adapter/Settings-Config/ActionConfig)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| JsonFile | [FileSettings](/api/oM/Framework/Adapter/FileSettings) | File settings for the json file to pull/push to. | - |
| CacheFileMaximumAge | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | The amount of time (in days) any files that have been created by the adapter for caching purposes should exist before being removed/recreated. <br> Files are only deleted/updated . <br> Set to 0 to force a recompute of a simulation that has a stored cache. | - |
| SkipEPWCheck | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Skips EPW file checks to allow epw files that are not on a drive accessible to the adapter. In general this should be set to false. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| WrapNonBHoMObjects | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true, the Push action wraps any non-BHoM type into a BH.oM.Adapter.ObjectWrapper, allowing them to make use of the full Adapter workflow. | - |
| AllowHashForComparing | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true and if no specific EqualityComparer is found for the type, Diffing hashes are computed and used to compare the objects. | - |
| DiffingConfig | [DiffingConfig](/api/oM/Framework/Diffing/DiffingConfig) | Configurations for the Diffing hashing. Requires `AllowHashForComparing` to be set to true. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class LadybugConfig : BH.oM.Adapter.ActionConfig, BH.oM.Base.IObject
```

Assembly: LadybugTools_oM.dll

The C# class definition is available on github:

- [LadybugConfig.cs](https://github.com/BHoM/LadybugTools_Toolkit/blob/develop/LadybugTools_oM/Config\LadybugConfig.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/LadybugTools_oM/LadybugConfig.json"
}
```

The JSON Schema is available on github here:

- [LadybugConfig.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/LadybugTools_oM/LadybugConfig.json)
