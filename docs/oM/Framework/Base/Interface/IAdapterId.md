---
title: IAdapterId
---

# <small>BH.oM.Base.</small>**IAdapterId**



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IAdapterId is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Test.Adapter.[TestAdapterId](/api/oM/Framework/Test/Adapter/TestAdapterId)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Id | [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0) | Identifier of the object in the external software. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IAdapterId : BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: BHoM.dll

The C# interface definition is available on github:

- [IAdapterId.cs](https://github.com/BHoM/BHoM/blob/develop/BHoM/Interface\IAdapterId.cs)

All history and changes of the class can be found by inspection the history.
