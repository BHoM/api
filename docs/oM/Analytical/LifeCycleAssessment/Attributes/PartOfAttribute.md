---
title: PartOfAttribute
---

# <small>BH.oM.LifeCycleAssessment.</small>**PartOfAttribute**

Attribute applied to a Module to define that it is a part of a combination module, where the value of the combination module is the sum of the values of its parts.
Only the combination module that the module is directly a part of is to be specified. Combination modules can in turn be parts of other combination modules, which makes the combinations recursive, e.g. B1 is part of B1toB3, which in turn is part of B1toB5.

## Class structure

### Implemented interfaces and base types

???+ bhom "The PartOfAttribute is inheriting from the following base type(s) and implements the following interfaces:"

    -  [Attribute](https://learn.microsoft.com/en-us/dotnet/api/System.Attribute?view=netstandard-2.0)
    -  BH.oM.Base.[IImmutable](/api/oM/Framework/Base/Interface/IImmutable)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| PartOf | [Module](/api/oM/Analytical/LifeCycleAssessment/Enums/Module) | The combination module that the module is directly a part of. The value of this combination module is the sum of the values of all its parts. | - |
| IsRequired | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Defines whether the module is required to have a value for the combination module to be computed.<br>If true, the combination module can only be computed if this module has a value.<br>If false, this module is included in the combination module if it has a value, but the combination module can be computed without it. A combination module made up of only non-required parts can only be computed if at least one of its parts has a value. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| TypeId | [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class PartOfAttribute : System.Attribute, BH.oM.Base.IImmutable, BH.oM.Base.IObject
```

Assembly: LifeCycleAssessment_oM.dll

The C# class definition is available on github:

- [PartOfAttribute.cs](https://github.com/BHoM/BHoM/blob/develop/LifeCycleAssessment_oM/Attributes\PartOfAttribute.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/LifeCycleAssessment_oM/PartOfAttribute.json"
}
```

The JSON Schema is available on github here:

- [PartOfAttribute.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/LifeCycleAssessment_oM/PartOfAttribute.json)
