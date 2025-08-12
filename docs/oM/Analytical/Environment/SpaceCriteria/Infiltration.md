---
title: Infiltration
---

# <small>BH.oM.Environment.SpaceCriteria.</small>**Infiltration**

Infiltration gains are defined as the amount of heat or heat loss contributed by cracks in the exterior envelope of the building which allow unconditioned outside air to be introduced to the space

## Class structure

### Implemented interfaces and base types

???+ bhom "The Infiltration is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Environment.SpaceCriteria.[IGain](/api/oM/Analytical/Environment/SpaceCriteria/IGain)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| AirChangeRate | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The AirChangeRate indicates the amount of conditioned air lost by infiltration that should be replaced each hour, based on the volume of the space (1 ACH would be 1x the volume of space each hour, if the space is 1m3, it would be 1m3 of outside air per hour) | - |
| AirflowByWallExternalArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The AirflowByWallExternalArea indicates the amount of air (m3/s) lost by infiltration based on the exterior wall area, that should be replaced within the space. | - |
| AirflowByWallExternalCrackLength | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The AirflowByWallExternalCrackLength indicates the amount of air (m3/s) lost by infiltration based on the exterior wall crack length (the sum of the edge lengths), that should be replaced within the space. | - |
| Profile | [Profile](/api/oM/Analytical/Environment/SpaceCriteria/Profile) | Profiles depict the time period (hours per day, days per week) during which infiltration is contributing to or causing a loss of heat to the space. | - |


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
public class Infiltration : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.Environment.SpaceCriteria.IGain
```

Assembly: Environment_oM.dll

The C# class definition is available on github:

- [Infiltration.cs](https://github.com/BHoM/BHoM/blob/develop/Environment_oM/SpaceCriteria\Infiltration.cs)

All history and changes of the class can be found by inspection the history.
