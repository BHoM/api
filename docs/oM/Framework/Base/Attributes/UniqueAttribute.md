---
title: UniqueAttribute
---

# <small>BH.oM.Base.Attributes.</small>**UniqueAttribute**

Means that there can only be one instance of that type in a collection. This is currently used specifically for the case of fragments.

## Class structure

### Implemented interfaces and base types

???+ bhom "The UniqueAttribute is inheriting from the following base type(s) and implements the following interfaces:"

    -  [Attribute](https://learn.microsoft.com/en-us/dotnet/api/System.Attribute?view=netstandard-2.0)
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
public class UniqueAttribute : System.Attribute, BH.oM.Base.IObject
```

Assembly: BHoM.dll

The C# class definition is available on github:

- [UniqueAttribute.cs](https://github.com/BHoM/BHoM/blob/develop/BHoM/Attributes\UniqueAttribute.cs)

All history and changes of the class can be found by inspection the history.
