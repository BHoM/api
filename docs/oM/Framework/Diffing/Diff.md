---
title: Diff
---

# <small>BH.oM.Diffing.</small>**Diff**

Represents the differences between two sets of objects.

## Class structure

### Implemented interfaces and base types

???+ bhom "The Diff is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Base.[IImmutable](/api/oM/Framework/Base/Interface/IImmutable)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| AddedObjects | [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netstandard-2.0)&lt;[object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | Objects present in the second set that are not present in the first set. | - |
| RemovedObjects | [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netstandard-2.0)&lt;[object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | Objects not present in the second set that were present in the first set. | - |
| ModifiedObjects | [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netstandard-2.0)&lt;[object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | Objects that are recognised as present both in the first set and the second set, but that have some property that is different.<br>The rules that were used to recognise modification are in the `DiffingConfig.ComparisonConfig`. | - |
| UnchangedObjects | [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netstandard-2.0)&lt;[object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | Objects that are recognised as the same in the first and second set. | - |
| ModifiedObjectsDifferences | [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netstandard-2.0)&lt;[ObjectDifferences](/api/oM/Framework/Diffing/ObjectDifferences)&gt; | - | - |
| DiffingConfig | [DiffingConfig](/api/oM/Framework/Diffing/DiffingConfig) | Default diffing settings for this Stream. Hashes of objects contained in this stream will be computed based on these configs. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class Diff : BH.oM.Base.IObject, BH.oM.Base.IImmutable
```

Assembly: Diffing_oM.dll

The C# class definition is available on github:

- [Diff.cs](https://github.com/BHoM/BHoM/blob/develop/Diffing_oM/Diff.cs)

All history and changes of the class can be found by inspection the history.
