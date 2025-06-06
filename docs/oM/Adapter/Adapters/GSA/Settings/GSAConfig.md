---
title: GSAConfig
---

# <small>BH.oM.Adapters.GSA.</small>**GSAConfig**

Configurations specific for an Adapter Action (Push, Pull, etc).
Consider that your tookit might have a more specific implementation available. Try to look for [your toolkit name]ActionConfig.

## Class structure

### Implemented interfaces and base types

???+ bhom "The GSAConfig is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Adapter.[ActionConfig](/api/oM/Framework/Adapter/Settings-Config/ActionConfig)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| SteelDesign | [SteelDesignSpecification](/api/oM/Adapter/Adapters/GSA/Enum/SteelDesignSpecification) | - | - |
| ConcreteDesign | [ConcreteDesignSpecification](/api/oM/Adapter/Adapters/GSA/Enum/ConcreteDesignSpecification) | - | - |
| Country | [Country](/api/oM/Adapter/Adapters/GSA/Enum/Country) | - | - |


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
public class GSAConfig : BH.oM.Adapter.ActionConfig, BH.oM.Base.IObject
```

Assembly: GSA_oM.dll

The C# class definition is available on github:

- [GSAConfig.cs](https://github.com/BHoM/GSA_Toolkit/blob/develop/GSA_oM/Settings\GSAConfig.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/GSA_oM/GSAConfig.json"
}
```

The JSON Schema is available on github here:

- [GSAConfig.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/GSA_oM/GSAConfig.json)
