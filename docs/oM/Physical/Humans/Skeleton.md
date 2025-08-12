---
title: Skeleton
---

# <small>BH.oM.Humans.</small>**Skeleton**



## Class structure

### Implemented interfaces and base types

???+ bhom "The Skeleton is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Humans.[IHumanRole](/api/oM/Physical/Humans/Interfaces/IHumanRole)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Head | [Head](/api/oM/Physical/Humans/BodyParts/Head) | - | - |
| RightHand | [RightHand](/api/oM/Physical/Humans/BodyParts/RightHand) | - | - |
| LeftHand | [LeftHand](/api/oM/Physical/Humans/BodyParts/LeftHand) | - | - |
| RightThumb | [RightThumb](/api/oM/Physical/Humans/BodyParts/RightThumb) | - | - |
| LeftThumb | [LeftThumb](/api/oM/Physical/Humans/BodyParts/LeftThumb) | - | - |
| Neck | [Neck](/api/oM/Physical/Humans/BodyParts/Neck) | - | - |
| RightShoulder | [RightShoulder](/api/oM/Physical/Humans/BodyParts/RightShoulder) | - | - |
| LeftShoulder | [LeftShoulder](/api/oM/Physical/Humans/BodyParts/LeftShoulder) | - | - |
| Spine | [Spine](/api/oM/Physical/Humans/BodyParts/Spine) | - | - |
| RightHip | [RightHip](/api/oM/Physical/Humans/BodyParts/RightHip) | - | - |
| LeftHip | [LeftHip](/api/oM/Physical/Humans/BodyParts/LeftHip) | - | - |
| RightUpperArm | [RightUpperArm](/api/oM/Physical/Humans/BodyParts/RightUpperArm) | - | - |
| LeftUpperArm | [LeftUpperArm](/api/oM/Physical/Humans/BodyParts/LeftUpperArm) | - | - |
| RightLowerArm | [RightLowerArm](/api/oM/Physical/Humans/BodyParts/RightLowerArm) | - | - |
| LeftLowerArm | [LeftLowerArm](/api/oM/Physical/Humans/BodyParts/LeftLowerArm) | - | - |
| RightUpperLeg | [RightUpperLeg](/api/oM/Physical/Humans/BodyParts/RightUpperLeg) | - | - |
| LeftUpperLeg | [LeftUpperLeg](/api/oM/Physical/Humans/BodyParts/LeftUpperLeg) | - | - |
| RightLowerLeg | [RightLowerLeg](/api/oM/Physical/Humans/BodyParts/RightLowerLeg) | - | - |
| LeftLowerLeg | [LeftLowerLeg](/api/oM/Physical/Humans/BodyParts/LeftLowerLeg) | - | - |
| RightFoot | [RightFoot](/api/oM/Physical/Humans/BodyParts/RightFoot) | - | - |
| LeftFoot | [LeftFoot](/api/oM/Physical/Humans/BodyParts/LeftFoot) | - | - |


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
| TrackingLines | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [Line](/api/oM/Dimensional/Geometry/Curve/Line)&gt; | - | - | Humans_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class Skeleton : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.Humans.IHumanRole
```

Assembly: Humans_oM.dll

The C# class definition is available on github:

- [Skeleton.cs](https://github.com/BHoM/BHoM/blob/develop/Humans_oM/Skeleton.cs)

All history and changes of the class can be found by inspection the history.
