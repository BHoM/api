---
title: DiffingConfig
---

# <small>BH.oM.Diffing.</small>**DiffingConfig**

General configurations for the Diffing process, including settings for the Hash computation.

## Class structure

### Implemented interfaces and base types

???+ bhom "The DiffingConfig is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ComparisonConfig | [BaseComparisonConfig](/api/oM/Framework/Base/BaseComparisonConfig) | Settings to determine the uniqueness of an Object. | - |
| EnablePropertyDiffing | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Enables the property-level diffing: differences in object properties are stored in the `ModifiedPropsPerObject` dictionary of the Diff object.<br>WARNING: may be slow.<br>For large object collections, if you are not interested in what properties changed, you can turn this to false to speed up. | - |
| IncludeUnchangedObjects | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If enabled, the Diff includes also the objects that did not change (`Unchanged`).<br>When dealing with very large sets, you can keep this on `false` to improve performance: the UnchangedObjects can be derived from the original set, minus the Deleted and Modified objects. | - |
| AllowDuplicateIDs | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | By default, duplicate IDs are not allowed and Diffing will not consider them. If you want to be able to specify duplicate IDs, set this to true. | - |
| CustomObjectDifferencesComparers | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Func](https://learn.microsoft.com/en-us/dotnet/api/System.Func-4?view=netstandard-2.0)&lt;[object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0), [BaseComparisonConfig](/api/oM/Framework/Base/BaseComparisonConfig), [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IPropertyDifference](/api/oM/Framework/Diffing/IPropertyDifference)&gt;&gt;&gt; | List of Delegate functions that can be assigned to customise the ObjectDifferences computation of the Diffing.The method delegate must have three inputs: the past_object, the following_object, and a BaseComparisonConfig; it must return a List&lt;PropertyDifference&gt;.The Differences found in the ObjectDifferences object will be added to any other difference found between the two objects.For this reason, make sure that you also set relevant PropertyExceptions in your ComparisonConfig to avoid finding duplicate Differences.See RevitDiffing for an example usage. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class DiffingConfig : BH.oM.Base.IObject
```

Assembly: Diffing_oM.dll

The C# class definition is available on github:

- [DiffingConfig.cs](https://github.com/BHoM/BHoM/blob/develop/Diffing_oM/DiffingConfig.cs)

All history and changes of the class can be found by inspection the history.
