---
title: IInitialisationSettings
---

# <small>BH.oM.Base.</small>**IInitialisationSettings**

Toolkit Settings that contain an initialisation method to be ran when the UI starts.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IInitialisationSettings is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IImmutable](/api/oM/Framework/Base/Interface/IImmutable)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| InitialisationMethod | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Method used to intialise the toolkit. It has to be written has follows: '&lt;Full namespace&gt;.&lt;Declaring type&gt;.&lt;Method name&gt;' | - |
| InitialisationAssembly | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Name of the method containing teh initialisation assembly. Only provide the name of the assembly itself, no file path or extension. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IInitialisationSettings : BH.oM.Base.IImmutable, BH.oM.Base.IObject
```

Assembly: BHoM.dll

The C# interface definition is available on github:

- [IInitialisationSettings.cs](https://github.com/BHoM/BHoM/blob/develop/BHoM/Interface\IInitialisationSettings.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/BHoM/IInitialisationSettings.json"
}
```

The JSON Schema is available on github here:

- [IInitialisationSettings.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/BHoM/IInitialisationSettings.json)
