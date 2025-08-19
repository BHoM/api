---
title: InputFromDescription
---

# <small>BH.oM.Base.Attributes.</small>**InputFromDescription**

Attribute to define an input parameter for a method or constructor, using the description of a member (Type, MemberInfo, ParameterInfo or Enum).

## Class structure

### Implemented interfaces and base types

???+ bhom "The InputFromDescription is inheriting from the following base type(s) and implements the following interfaces:"

    -  [Attribute](https://learn.microsoft.com/en-us/dotnet/api/System.Attribute?view=netstandard-2.0)
    -  BH.oM.Base.[IImmutable](/api/oM/Framework/Base/Interface/IImmutable)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| InputName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Name of the method parameter this attribute corresponds to. | - |
| Member | [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0) | Member to grab the description from. Should be a Type, MemberInfo, ParameterInfo or Enum. | - |
| Classification | [ClassificationAttribute](/api/oM/Framework/Base/Attributes/ClassificationAttribute) | Classification of the correspondent input parameter, e.g. folder path, quantity etc. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| TypeId | [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class InputFromDescription : System.Attribute, BH.oM.Base.IImmutable, BH.oM.Base.IObject
```

Assembly: BHoM.dll

The C# class definition is available on github:

- [InputFromDescription.cs](https://github.com/BHoM/BHoM/blob/develop/BHoM/Attributes\InputFromDescription.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/BHoM/Attributes/InputFromDescription.json"
}
```

The JSON Schema is available on github here:

- [InputFromDescription.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/BHoM/Attributes/InputFromDescription.json)
