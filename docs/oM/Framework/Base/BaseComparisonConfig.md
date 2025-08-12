---
title: BaseComparisonConfig
---

# <small>BH.oM.Base.</small>**BaseComparisonConfig**

Settings to determine the uniqueness of an Object, i.e. when comparing and when computing the object Hash.

## Class structure

### Implemented interfaces and base types

???+ bhom "The BaseComparisonConfig is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes inheriting from this class

???+ bhom "The following classes are inheriting from this class:"

    - BH.oM.Base.[ComparisonConfig](/api/oM/Framework/Base/ComparisonConfig)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| PropertyExceptions | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Names of properties you want to disregard in defining the uniqueness of an object. You can specify the property name or the Full Name. Supports * wildcard.<br>Examples of valid values: `BHoM_Guid`, `StartNode`, `Bar.StartNode.Position.X`, `Bar.*.Position.Y`. See the wiki for more details. | - |
| PropertiesToConsider | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | If one or more entries are specified here, only objects/properties that match them will be considered in the hash.<br>E.g. Given input objects BH.oM.Structure.Elements.Bar, specifying `StartNode` will only check that property of the Bar.<br>Like for PropertyExceptions, you can specify the property name or the Full Name. Supports * wildcard.<br>Note that using this will incur in a general slowdown because it is computationally heavy. See the wiki for more details. | - |
| CustomdataKeysExceptions | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Keys of the BHoMObjects' CustomData dictionary that should be ignored.<br>By default it includes `RenderMesh`. <br>This does not support wildcard usage. See the wiki for more details. | - |
| CustomdataKeysToConsider | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Keys of the BHoMObjects' CustomData dictionary that should be included in the comparison.<br>Adding keys to this List will exclude any key that is not in this List.<br>I.e. for every object, if it has CustomData keys present in this List, we then exclude any other CustomData key found in it. | - |
| TypeExceptions | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=netstandard-2.0)&gt; | Any corresponding type is ignored. E.g. `typeof(Guid)`. | - |
| NamespaceExceptions | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Any corresponding namespace is ignored. E.g. `BH.oM.Structure`. Does not support wildcard. See the wiki for more details. | - |
| MaxNesting | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | If any property is nested into the object over that level, it is ignored. Useful to limit the runtime.<br>Defaults to unlimited. | - |
| MaxPropertyDifferences | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Sets the maximum number of property differences to be determined before stopping. Useful to limit the runtime.<br>Defaults to unlimited. | - |
| NumericTolerance | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Numeric tolerance for property values, applied to all numerical properties. Defaults to double.MinValue: no rounding applied.<br>Applies rounding for numbers smaller than this.<br>You can override on a per-property basis by using `PropertyNumericTolerances`.<br>If conflicting values/multiple matches are found among the Configurations on numerical precision, the largest approximation among all (least precise number) is registered. | - |
| PropertyNumericTolerances | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[NamedNumericTolerance](/api/oM/Framework/Base/NamedNumericTolerance)&gt; | Tolerance used for individual properties. When computing Hash or the property Diffing, if the analysed property name is found in this collection, the corresponding tolerance is applied.<br>Supports * wildcard in the property name matching. E.g. `StartNode.Point.*, 2`.<br>If a match is found, this take precedence over the global `NumericTolerance`.<br>If conflicting values/multiple matches are found among the Configurations on numerical precision, the largest approximation among all (least precise number) is registered. | - |
| SignificantFigures | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Number of significant figures allowed for numerical data.<br>Defaults to `int.MaxValue`: no approximation applied.<br>You can override on a per-property basis by using `PropertySignificantDigits`.<br>If conflicting values/multiple matches are found among the Configurations on numerical precision, the largest approximation among all (least precise number) is registered. | - |
| PropertySignificantFigures | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[NamedSignificantFigures](/api/oM/Framework/Base/NamedSignificantFigures)&gt; | Number of significant figures allowed for numerical data on a per-property base. <br>Supports * wildcard in the property name matching. E.g. `StartNode.Point.*, 2`.<br>If a match is found, this take precedence over the global `SignificantFigures`.<br>If conflicting values/multiple matches are found among the Configurations on numerical precision, the largest approximation among all (least precise number) is registered. | - |
| UseGeometryHash | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true, geometric types will be identified based on the GeometryHash function. This function reduces the identity of geometry down to its most basic components, and it is faster than scouring for all its properties. See its implementation in the Geometry_Engine for more details. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public abstract class BaseComparisonConfig : BH.oM.Base.IObject
```

Assembly: BHoM.dll

The C# abstract class definition is available on github:

- [BaseComparisonConfig.cs](https://github.com/BHoM/BHoM/blob/develop/BHoM/BaseComparisonConfig.cs)

All history and changes of the class can be found by inspection the history.
