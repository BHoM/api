---
title: ConstantFramingProperty
---

# <small>BH.oM.Physical.FramingProperties.</small>**ConstantFramingProperty**



## Class structure

### Implemented interfaces and base types

???+ bhom "The ConstantFramingProperty is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Physical.FramingProperties.[IFramingElementProperty](/api/oM/Physical/Physical/FramingProperties/IFramingElementProperty)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Profile | [IProfile](/api/oM/Dimensional/Spatial/ShapeProfiles/IProfile) | - | - |
| Material | [Material](/api/oM/Physical/Physical/Materials/Material) | - | - |
| OrientationAngle | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |


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
| AverageProfileArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the average cross-section area of a ConstantFramingProperty in such a way that multiplying with the length of the element would give the volume | [Area](/api/oM/Dimensional/Quantities/Attributes/Area) [m²] | Physical_Engine |
| IAverageProfileArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the average cross-section area of a IFramingElementProperty in such a way that multiplying with the length of the element would give the volume | [Area](/api/oM/Dimensional/Quantities/Attributes/Area) [m²] | Physical_Engine |
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a IFramingElementProperty is null and outputs relevant error message. | - | Physical_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class ConstantFramingProperty : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.Physical.FramingProperties.IFramingElementProperty
```

Assembly: Physical_oM.dll

The C# class definition is available on github:

- [ConstantFramingProperty.cs](https://github.com/BHoM/BHoM/blob/develop/Physical_oM/FramingProperties\ConstantFramingProperty.cs)

All history and changes of the class can be found by inspection the history.
