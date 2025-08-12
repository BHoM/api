---
title: Reinforcement
---

# <small>BH.oM.Physical.Reinforcement.</small>**Reinforcement**

The physical reinforcement object containing the ShapeCode(and it's parameters), the diameter and coodinate system. This can be used with a number of Engine methods suchas Centreline and Length.

## Class structure

### Implemented interfaces and base types

???+ bhom "The Reinforcement is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| CoordinateSystem | [Cartesian](/api/oM/Dimensional/Geometry/CoordinateSystem/Cartesian) | Position and orientation of the Reinforcement in Space. Refer to the description of the shape codes for how they relate to the coordinate system. | - |
| ShapeCode | [IShapeCode](/api/oM/Physical/Physical/Reinforcement/IShapeCode) | The ShapeCode object containing the geometrical parameters of the reinforcement bar. | - |


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
| Centreline | [ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve) | Computes the centreline for a Reinforcement using the standard as determined by the ShapeCode namespace. The curve will be oriented to the coordinate system. | - | Physical_Engine |
| GeneralEndProjection | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the minimum end projection for general bends (bobs) or links where the bend is greater than or equal to 150 degrees.This is based on the diameter of the reinforcement bar and the standard is determined from the ShapeCode namespace. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] | Physical_Engine |
| HookDiameter | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the hook diameter based on the diameter of the reinforcement bar, the shape code and the bend radius. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] | Physical_Engine |
| IsCompliant | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Verifies the dimensions to the standard as determined by the ShapeCode namespace. | - | Physical_Engine |
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a Reinforcement is null and outputs relevant error message. | - | Physical_Engine |
| IsValid | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Verifies whether the reinforcement is valid by performing null checks. | - | Physical_Engine |
| Length | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the total length of the Reinforcement with ShapeCode00 using the formulation in BS 8666:2020 Table 5. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] | Physical_Engine |
| LinksEndProjection | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the minimum end projection for links where the bend is less than 150 degrees.This is based on the diameter of the reinforcement bar and the standard is determined from the ShapeCode namespace. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] | Physical_Engine |
| MaximumRadius | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the maximum radius based on the diameter of the reinforcement bar. The standard is determined from the namespace of the ShapeCode. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] | Physical_Engine |
| SchedulingRadius | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the minimum scheduling radius based on the diameter of the reinforcement bar. The standard is determined from the namespace of the ShapeCode. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] | Physical_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class Reinforcement : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: Physical_oM.dll

The C# class definition is available on github:

- [Reinforcement.cs](https://github.com/BHoM/BHoM/blob/develop/Physical_oM/Reinforcement\Reinforcement.cs)

All history and changes of the class can be found by inspection the history.
