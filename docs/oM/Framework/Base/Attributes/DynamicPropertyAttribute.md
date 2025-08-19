---
title: DynamicPropertyAttribute
---

# <small>BH.oM.Base.Attributes.</small>**DynamicPropertyAttribute**

Defines a property as a container for dynamic properties. This must be a dictionary where keys are enums.

## Class structure

### Implemented interfaces and base types

???+ bhom "The DynamicPropertyAttribute is inheriting from the following base type(s) and implements the following interfaces:"

    -  [Attribute](https://learn.microsoft.com/en-us/dotnet/api/System.Attribute?view=netstandard-2.0)
    -  BH.oM.Base.[IImmutable](/api/oM/Framework/Base/Interface/IImmutable)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties

### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| TypeId | [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class DynamicPropertyAttribute : System.Attribute, BH.oM.Base.IImmutable, BH.oM.Base.IObject
```

Assembly: BHoM.dll

The C# class definition is available on github:

- [DynamicPropertyAttribute.cs](https://github.com/BHoM/BHoM/blob/develop/BHoM/Attributes\DynamicPropertyAttribute.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/BHoM/Attributes/DynamicPropertyAttribute.json"
}
```

The JSON Schema is available on github here:

- [DynamicPropertyAttribute.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/BHoM/Attributes/DynamicPropertyAttribute.json)
