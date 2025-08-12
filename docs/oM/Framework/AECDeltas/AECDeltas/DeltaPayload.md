---
title: DeltaPayload
---

# <small>BH.oM.AECDeltas.</small>**DeltaPayload**

Class defined as per AECDeltas specification https://github.com/aecdeltas/aec-deltas-spec/wiki/Delta-Container-Specification#payload

## Class structure

### Implemented interfaces and base types

???+ bhom "The DeltaPayload is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Base.[IImmutable](/api/oM/Framework/Base/Interface/IImmutable)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| StreamID | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Diff | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |
| RevisionFrom | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| RevisionTo | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Timestamp | [long](https://learn.microsoft.com/en-us/dotnet/api/System.Int64?view=netstandard-2.0) | - | - |
| Signature | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Sender | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Comment | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class DeltaPayload : BH.oM.Base.IObject, BH.oM.Base.IImmutable
```

Assembly: Diffing_oM.dll

The C# class definition is available on github:

- [DeltaPayload.cs](https://github.com/BHoM/BHoM/blob/develop/Diffing_oM/AECDeltas\DeltaPayload.cs)

All history and changes of the class can be found by inspection the history.
