---
title: OriginContextFragment
---

# <small>BH.oM.Environment.Fragments.</small>**OriginContextFragment**

Fragment containing the origin context property such as Element ID or Type

## Class structure

### Implemented interfaces and base types

???+ bhom "The OriginContextFragment is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Origin | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| ElementID | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The original ID of the element from the origin software | - |
| Description | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| TypeName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class OriginContextFragment : BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: Environment_oM.dll

The C# class definition is available on github:

- [OriginContextFragment.cs](https://github.com/BHoM/BHoM/blob/develop/Environment_oM/Fragments\OriginContextFragment.cs)

All history and changes of the class can be found by inspection the history.
