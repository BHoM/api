---
title: Delta
---

# <small>BH.oM.Diffing.</small>**Delta**

Contains the Diff plus context information: parent Stream, Timestamp, etc.

## Class structure

### Implemented interfaces and base types

???+ bhom "The Delta is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Base.[IImmutable](/api/oM/Framework/Base/Interface/IImmutable)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| StreamID | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | The ID of the owning Stream. It must be the same for both the Revision that this Delta targets and the Revision that it will produce. | - |
| Diff | [Diff](/api/oM/Framework/Diffing/Diff) | Represent the differences between two sets of objects. | - |
| RevisionFrom | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | Revision ID that this Delta targets. | - |
| RevisionTo | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | Revision ID that this Delta produces. | - |
| Timestamp | [long](https://learn.microsoft.com/en-us/dotnet/api/System.Int64?view=netstandard-2.0) | In UTC ticks. | - |
| Author | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Any descriptive string identifying either the Author and/or the software used. | - |
| Comment | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class Delta : BH.oM.Base.IObject, BH.oM.Base.IImmutable
```

Assembly: Diffing_oM.dll

The C# class definition is available on github:

- [Delta.cs](https://github.com/BHoM/BHoM/blob/develop/Diffing_oM/Delta.cs)

All history and changes of the class can be found by inspection the history.
