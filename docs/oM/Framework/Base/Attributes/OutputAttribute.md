---
title: OutputAttribute
---

# <small>BH.oM.Base.Attributes.</small>**OutputAttribute**

Attribute providing information about an output parameter of a method.
To be applied to all methods that do not return void nor BH.oM.Base.Output types.

## Class structure

### Implemented interfaces and base types

???+ bhom "The OutputAttribute is inheriting from the following base type(s) and implements the following interfaces:"

    -  [Attribute](https://learn.microsoft.com/en-us/dotnet/api/System.Attribute?view=netstandard-2.0)
    -  BH.oM.Base.[IImmutable](/api/oM/Framework/Base/Interface/IImmutable)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Name of the correspondent output parameter (to be used in the UI). | - |
| Description | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Description of the correspondent output parameter. | - |
| Classification | [ClassificationAttribute](/api/oM/Framework/Base/Attributes/ClassificationAttribute) | Classification of the correspondent output parameter, e.g. folder path, quantity etc. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| TypeId | [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class OutputAttribute : System.Attribute, BH.oM.Base.IImmutable, BH.oM.Base.IObject
```

Assembly: BHoM.dll

The class is defined in C#. The class definition is available on github:

- [OutputAttribute.cs](https://github.com/BHoM/BHoM/blob/develop/BHoM/Attributes\OutputAttribute.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/BHoM/Attributes/OutputAttribute.json"
}
```

The JSON Schema is available on github here:

- [OutputAttribute.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/BHoM/Attributes/OutputAttribute.json)
