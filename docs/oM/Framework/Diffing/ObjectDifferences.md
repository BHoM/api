---
title: ObjectDifferences
---

# <small>BH.oM.Diffing.</small>**ObjectDifferences**

Represents all the differences found between a Previous and Following version of an object.

## Class structure

### Implemented interfaces and base types

???+ bhom "The ObjectDifferences is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| PastObject | [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0) | Older version of the object (created or modified before `FollowingObject`). | - |
| FollowingObject | [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0) | Newer version of the object (created or modified after `PastObject`). | - |
| Differences | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IPropertyDifference](/api/oM/Framework/Diffing/IPropertyDifference)&gt; | List of all the differences found between the `past` and `following` versions of the object (under a given ComparisonConfig). | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class ObjectDifferences : BH.oM.Base.IObject
```

Assembly: Diffing_oM.dll

The C# class definition is available on github:

- [ObjectDifferences.cs](https://github.com/BHoM/BHoM/blob/develop/Diffing_oM/ObjectDifferences.cs)

All history and changes of the class can be found by inspection the history.
