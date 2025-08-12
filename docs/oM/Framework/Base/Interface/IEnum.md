---
title: IEnum
---

# <small>BH.oM.Base.</small>**IEnum**



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IEnum is inheriting from the following base type(s) and implements the following interfaces:"

    -  [IComparable](https://learn.microsoft.com/en-us/dotnet/api/System.IComparable-1?view=netstandard-2.0)&lt;BH.oM.Base.[IEnum](/api/oM/Framework/Base/Interface/IEnum)&gt;
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Base.[Enumeration](/api/oM/Framework/Base/Enumeration)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Value | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Description | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IEnum : System.IComparable<BH.oM.Base.IEnum>, BH.oM.Base.IObject
```

Assembly: BHoM.dll

The C# interface definition is available on github:

- [IEnum.cs](https://github.com/BHoM/BHoM/blob/develop/BHoM/Interface\IEnum.cs)

All history and changes of the class can be found by inspection the history.
