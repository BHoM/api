---
title: IShapeCode
---

# <small>BH.oM.Physical.Reinforcement.</small>**IShapeCode**

Base interface for all ShapeCode objects.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IShapeCode is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Physical.Reinforcement.BS8666.[ShapeCode00](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode00)
    - BH.oM.Physical.Reinforcement.BS8666.[ShapeCode11](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode11)
    - BH.oM.Physical.Reinforcement.BS8666.[ShapeCode12](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode12)
    - BH.oM.Physical.Reinforcement.BS8666.[ShapeCode13](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode13)
    - BH.oM.Physical.Reinforcement.BS8666.[ShapeCode14](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode14)
    - BH.oM.Physical.Reinforcement.BS8666.[ShapeCode15](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode15)
    - BH.oM.Physical.Reinforcement.BS8666.[ShapeCode21](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode21)
    - BH.oM.Physical.Reinforcement.BS8666.[ShapeCode22](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode22)
    - BH.oM.Physical.Reinforcement.BS8666.[ShapeCode23](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode23)
    - BH.oM.Physical.Reinforcement.BS8666.[ShapeCode24](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode24)
    - BH.oM.Physical.Reinforcement.BS8666.[ShapeCode25](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode25)
    - BH.oM.Physical.Reinforcement.BS8666.[ShapeCode26](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode26)
    - BH.oM.Physical.Reinforcement.BS8666.[ShapeCode27](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode27)
    - BH.oM.Physical.Reinforcement.BS8666.[ShapeCode28](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode28)
    - BH.oM.Physical.Reinforcement.BS8666.[ShapeCode29](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode29)
    - BH.oM.Physical.Reinforcement.BS8666.[ShapeCode31](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode31)
    - BH.oM.Physical.Reinforcement.BS8666.[ShapeCode32](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode32)
    - BH.oM.Physical.Reinforcement.BS8666.[ShapeCode33](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode33)
    - BH.oM.Physical.Reinforcement.BS8666.[ShapeCode34](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode34)
    - BH.oM.Physical.Reinforcement.BS8666.[ShapeCode35](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode35)
    - BH.oM.Physical.Reinforcement.BS8666.[ShapeCode36](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode36)
    - BH.oM.Physical.Reinforcement.BS8666.[ShapeCode41](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode41)
    - BH.oM.Physical.Reinforcement.BS8666.[ShapeCode44](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode44)
    - BH.oM.Physical.Reinforcement.BS8666.[ShapeCode46](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode46)
    - BH.oM.Physical.Reinforcement.BS8666.[ShapeCode47](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode47)
    - BH.oM.Physical.Reinforcement.BS8666.[ShapeCode48](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode48)
    - BH.oM.Physical.Reinforcement.BS8666.[ShapeCode51](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode51)
    - BH.oM.Physical.Reinforcement.BS8666.[ShapeCode52](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode52)
    - BH.oM.Physical.Reinforcement.BS8666.[ShapeCode56](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode56)
    - BH.oM.Physical.Reinforcement.BS8666.[ShapeCode63](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode63)
    - BH.oM.Physical.Reinforcement.BS8666.[ShapeCode64](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode64)
    - BH.oM.Physical.Reinforcement.BS8666.[ShapeCode67](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode67)
    - BH.oM.Physical.Reinforcement.BS8666.[ShapeCode75](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode75)
    - BH.oM.Physical.Reinforcement.BS8666.[ShapeCode77](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode77)
    - BH.oM.Physical.Reinforcement.BS8666.[ShapeCode98](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode98)
    - BH.oM.Physical.Reinforcement.BS8666.[ShapeCode99](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode99)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Diameter | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The diameter of the reinforcement bar. | - |
| BendRadius | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Bend radius used for any discontinuities in the CentreCurve. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| GeneralEndProjection | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the minimum end projection for general bends (bobs) or links where the bend is greater than or equal to 150 degrees.This is based on the diameter of the reinforcement bar and the standard is determined from the ShapeCode namespace. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] | Physical_Engine |
| HookDiameter | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the hook diameter based on the diameter of the reinforcement bar, the shape code and the bend radius. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] | Physical_Engine |
| ICentreline | [ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve) | Computes the centreline for a Reinforcement using the standard as determined by the ShapeCode namespace. The curve will be in the XY Plane - refer to the ShapeCode description for specifics on the orientation. | - | Physical_Engine |
| IIsCompliant | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Verifies the dimensions to the standard as determined by the ShapeCode namespace. | - | Physical_Engine |
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a ShapeCode is null and outputs relevant error message. | - | Physical_Engine |
| LinksEndProjection | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the minimum end projection for links where the bend is less than 150 degrees.This is based on the diameter of the reinforcement bar and the standard is determined from the ShapeCode namespace. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] | Physical_Engine |
| MaximumRadius | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the maximum radius based on the diameter of the reinforcement bar. The standard is determined from the namespace of the ShapeCode. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] | Physical_Engine |
| ReinforcementStandard | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Gets the standard for reinforcement (e.g. BS 8666) based on the namespace of the ShapeCode. | - | Physical_Engine |
| SchedulingRadius | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the minimum scheduling radius based on the diameter of the reinforcement bar. The standard is determined from the namespace of the ShapeCode. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] | Physical_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IShapeCode : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: Physical_oM.dll

The C# interface definition is available on github:

- [IShapeCode.cs](https://github.com/BHoM/BHoM/blob/develop/Physical_oM/Reinforcement\IShapeCode.cs)

All history and changes of the class can be found by inspection the history.
