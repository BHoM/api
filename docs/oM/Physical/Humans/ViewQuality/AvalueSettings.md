---
title: AvalueSettings
---

# <small>BH.oM.Humans.ViewQuality.</small>**AvalueSettings**



## Class structure

### Implemented interfaces and base types

???+ bhom "The AvalueSettings is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| EffectiveConeOfVision | [Polyline](/api/oM/Dimensional/Geometry/Curve/Polyline) | Reference Cone of Vision used for all Spectators. This is equivalent to the curve generated from the intersection of the near clipping plane and the viewing frustum.It should be planar and closed and in a plane parallel to the global XY Plane.Default value is a square based frustum with 30 degree field of view and near clipping plane 0.1 from the eye reference location. Giving a a 0.115 * 0.115 square EffectiveConeOfVision. | - |
| FarClippingPlaneDistance | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The distance from a spectator to the far clipping plane of their view frustum. Spectators in front of this plane will not be used in the occlusion part of the Avalue calculation. Default value is 1. | - |
| CalculateOcclusion | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Calculate proportion of playing area obstructed by heads of Spectators in front. Default value is false | - |
| EffectiveConeOfVisionWidth | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Width of default EffectiveConeOfVision. Default value is 0.115. Used only when no EffectiveConeOfVision is provided. | - |
| EffectiveConeOfVisionHeight | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Height of default EffectiveConeOfVision. Default value is 0.115. Used only when no EffectiveConeOfVision is provided. | - |
| NearClippingPlaneDistance | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The distance from a spectator to the near clipping plane of their view frustum. Default value is 0.1. Used only when no EffectiveConeOfVision is provided. | - |
| FocalPoint | [Point](/api/oM/Dimensional/Geometry/Vector/Point) | Optional focal point to set the view direction of the spectators. If none provided the Avalue is calculated using the neutral viewing direction of each spectator. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class AvalueSettings : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: Humans_oM.dll

The C# class definition is available on github:

- [AvalueSettings.cs](https://github.com/BHoM/BHoM/blob/develop/Humans_oM/ViewQuality\AvalueSettings.cs)

All history and changes of the class can be found by inspection the history.
