---
title: VersioningTargetAttribute
---

# <small>BH.oM.Versioning.</small>**VersioningTargetAttribute**

Attribute defining the specific type a versioning method is targeting. The target type needs to be specified including the full namespace. This attribute can be used multiple times if a method is targeting more than one element. 

## Class structure

### Implemented interfaces and base types

???+ bhom "The VersioningTargetAttribute is inheriting from the following base type(s) and implements the following interfaces:"

    -  [Attribute](https://learn.microsoft.com/en-us/dotnet/api/System.Attribute?view=netstandard-2.0)
    -  BH.oM.Base.[IImmutable](/api/oM/Framework/Base/Interface/IImmutable)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Target | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| TypeId | [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class VersioningTargetAttribute : System.Attribute, BH.oM.Base.IImmutable, BH.oM.Base.IObject
```

Assembly: Versioning_oM.dll

The C# class definition is available on github:

- [VersioningTargetAttribute.cs](https://github.com/BHoM/BHoM/blob/develop/Versioning_oM/Attributes\VersioningTargetAttribute.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Versioning_oM/VersioningTargetAttribute.json"
}
```

The JSON Schema is available on github here:

- [VersioningTargetAttribute.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Versioning_oM/VersioningTargetAttribute.json)
