---
title: NoUpdateException
---

# <small>BH.oM.Versioning.</small>**NoUpdateException**



## Class structure

### Implemented interfaces and base types

???+ bhom "The NoUpdateException is inheriting from the following base type(s) and implements the following interfaces:"

    -  [Exception](https://learn.microsoft.com/en-us/dotnet/api/System.Exception?view=netstandard-2.0)
    -  [ISerializable](https://learn.microsoft.com/en-us/dotnet/api/System.Runtime.Serialization.ISerializable?view=netstandard-2.0)
    -  BH.oM.Base.[IImmutable](/api/oM/Framework/Base/Interface/IImmutable)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties

### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| TargetSite | [MethodBase](https://learn.microsoft.com/en-us/dotnet/api/System.Reflection.MethodBase?view=netstandard-2.0) | - | - |
| Message | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Data | [IDictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.IDictionary?view=netstandard-2.0) | - | - |
| InnerException | [Exception](https://learn.microsoft.com/en-us/dotnet/api/System.Exception?view=netstandard-2.0) | - | - |
| HelpLink | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Source | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| HResult | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | - | - |
| StackTrace | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class NoUpdateException : System.Exception, System.Runtime.Serialization.ISerializable, BH.oM.Base.IImmutable, BH.oM.Base.IObject
```

Assembly: Versioning_oM.dll

The C# class definition is available on github:

- [NoUpdateException.cs](https://github.com/BHoM/BHoM/blob/develop/Versioning_oM/NoUpdateException.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Versioning_oM/NoUpdateException.json"
}
```

The JSON Schema is available on github here:

- [NoUpdateException.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Versioning_oM/NoUpdateException.json)
