---
title: CustomObject
---

# <small>BH.oM.Base.</small>**CustomObject**

Allows the user to define their own objects with a custom set of properties.

## Class structure

### Implemented interfaces and base types

???+ bhom "The CustomObject is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Base.[IDynamicPropertyProvider](/api/oM/Framework/Base/Interface/IDynamicPropertyProvider)
    -  BH.oM.Base.[IDynamicObject](/api/oM/Framework/Base/Interface/IDynamicObject)


## Properties

### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Geometry | [IGeometry](/api/oM/Dimensional/Geometry/Interface/IGeometry) | - | - | BHoM_Engine |
| Geometry3D | [IGeometry](/api/oM/Dimensional/Geometry/Interface/IGeometry) | Queries a three-dimensional geometry out of each value stored in a CustomObject's CustomData dictionary.If multiple geometries are obtained, they are combined into a single CompositeGeometry. | - | BHoM_Engine |
| GetProperties | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Property](/api/oM/Framework/Base/Reflection/Property)&gt; | Extract the list of properties found in a custom object. | - | BHoM_Engine |
| PropertyDictionary | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - | Reflection_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class CustomObject : BH.oM.Base.BHoMObject,
BH.oM.Base.IBHoMObject,
BH.oM.Base.IObject,
BH.oM.Base.IDynamicPropertyProvider,
BH.oM.Base.IDynamicObject
```

Assembly: BHoM.dll

The C# class definition is available on github:

- [CustomObject.cs](https://github.com/BHoM/BHoM/blob/develop/BHoM/CustomObject.cs)

All history and changes of the class can be found by inspection the history.
