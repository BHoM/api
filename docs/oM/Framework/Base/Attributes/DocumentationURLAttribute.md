---
title: DocumentationURLAttribute
---

# <small>BH.oM.Base.Attributes.</small>**DocumentationURLAttribute**



## Class structure

### Implemented interfaces and base types

???+ bhom "The DocumentationURLAttribute is inheriting from the following base type(s) and implements the following interfaces:"

    -  [Attribute](https://learn.microsoft.com/en-us/dotnet/api/System.Attribute?view=netstandard-2.0)
    -  BH.oM.Base.[IImmutable](/api/oM/Framework/Base/Interface/IImmutable)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| DocumentationURL | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Type | [DocumentationType](/api/oM/Framework/Base/Attributes/Enums/DocumentationType) | - | - |
| Description | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| TypeId | [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class DocumentationURLAttribute : System.Attribute, BH.oM.Base.IImmutable, BH.oM.Base.IObject
```

Assembly: BHoM.dll

The class is defined in C#. The class definition is available on github:

- [DocumentationURLAttribute.cs](https://github.com/BHoM/BHoM/blob/develop/BHoM/Attributes\DocumentationURLAttribute.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/BHoM/Attributes/DocumentationURLAttribute.json}
```

The JSON Schema is available on github here:

- [DocumentationURLAttribute.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/BHoM/Attributes/DocumentationURLAttribute.json)
