---
title: Enumeration
---

# <small>BH.oM.Base.</small>**Enumeration**



## Class structure

### Implemented interfaces and base types

???+ bhom "The Enumeration is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Base.[IEnum](/api/oM/Framework/Base/Interface/IEnum)
    -  [IComparable](https://learn.microsoft.com/en-us/dotnet/api/System.IComparable-1?view=netstandard-2.0)&lt;BH.oM.Base.[IEnum](/api/oM/Framework/Base/Interface/IEnum)&gt;
    -  BH.oM.Base.[IImmutable](/api/oM/Framework/Base/Interface/IImmutable)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Value | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Description | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public abstract class Enumeration : BH.oM.Base.IObject, BH.oM.Base.IEnum, System.IComparable<BH.oM.Base.IEnum>, BH.oM.Base.IImmutable
```

Assembly: BHoM.dll

The abstract class is defined in C#. The class definition is available on github:

- [Enumeration.cs](https://github.com/BHoM/BHoM/blob/develop/BHoM/Enumeration.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/BHoM/Enumeration.json}
```

The JSON Schema is available on github here:

- [Enumeration.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/BHoM/Enumeration.json)
