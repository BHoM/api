---
title: ComparisonFunctions
---

# <small>BH.oM.Base.</small>**ComparisonFunctions**

Additional functions that can be specified as delegates and that will be executed while determining the uniqueness of an object, i.e. when comparing and when computing the object Hash.

## Class structure

### Implemented interfaces and base types

???+ bhom "The ComparisonFunctions is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| PropertyFullNameModifier | [Func](https://learn.microsoft.com/en-us/dotnet/api/System.Func-3?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0), [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | This function is executed every time a 'property full name' is considered, and it modifies it.<br>A `property full name` is the full property path, e.g. for a property named `Position`, the full name could be `BH.oM.Structure.Elements.Node.Position` or `BH.oM.Structure.Elements.Bar.StartNode.Position`, etc., depending on the object being considered.<br>First parameter (`string`): property full name. Second parameter (`object`): the object holding this property. Return value (`string`): the modified property name.<br>Example of property path: if interested in the property `Position`, the property path can be specified as `BH.oM.Structure.Elements.Node.Position` or `BH.oM.Structure.Elements.Bar.StartNode.Position`, etc., depending on the object being considered, or simply as `Position` if any property named as such is to be matched. | - |
| PropertyFullNameFilter | [Func](https://learn.microsoft.com/en-us/dotnet/api/System.Func-3?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0), [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0)&gt; | A filter function on each 'property full name' being considered during comparison.<br>A `property full name` is the full property path, e.g. for a property named `Position`, the full name could be `BH.oM.Structure.Elements.Node.Position` or `BH.oM.Structure.Elements.Bar.StartNode.Position`, etc., depending on the object being considered.<br>If the Func returns true, the property is skipped (not considered when comparing or computing the Hash).<br>First parameter (`string`): property full name. Second parameter (`object`): the object holding this property. Return value (`bool`): true if the property is to be skipped, false otherwise. | - |
| CustomDataKeyFilter | [Func](https://learn.microsoft.com/en-us/dotnet/api/System.Func-3?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0), [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0)&gt; | A filter function on CustomData keys. If the Func returns true, the key is skipped (not considered when comparing or computing the Hash).<br>First parameter (`string`): Custom Data key. Second parameter (`object`): the CustomData dictionary. Return value (`bool`): true if the key is to be skipped, false otherwise. | - |
| PropertyDisplayNameModifier | [Func](https://learn.microsoft.com/en-us/dotnet/api/System.Func-3?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0), [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | This function is executed before a 'property full name' is returned as a difference, and it modifies it.<br>A `property full name` is the full property path, e.g. for a property named `Position`, the full name could be `BH.oM.Structure.Elements.Node.Position` or `BH.oM.Structure.Elements.Bar.StartNode.Position`, etc., depending on the object being considered.<br>First parameter (`string`): property full name. Second parameter (`object`): the object holding this property. Return value (`string`): the modified property name.<br>Example of property path: if interested in the property `Position`, the property path can be specified as `BH.oM.Structure.Elements.Node.Position` or `BH.oM.Structure.Elements.Bar.StartNode.Position`, etc., depending on the object being considered, or simply as `Position` if any property named as such is to be matched. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class ComparisonFunctions : BH.oM.Base.IObject
```

Assembly: BHoM.dll

The C# class definition is available on github:

- [ComparisonFunctions.cs](https://github.com/BHoM/BHoM/blob/develop/BHoM/ComparisonFunctions.cs)

All history and changes of the class can be found by inspection the history.
