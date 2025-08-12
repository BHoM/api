---
title: Exhaust
---

# <small>BH.oM.Environment.SpaceCriteria.</small>**Exhaust**

Exhaust is indicative of the amount of air that should be extracted from a space based on the space type (eg laboratory, woodshop) or fixtures contained within the space (eg toilets, showers)

## Class structure

### Implemented interfaces and base types

???+ bhom "The Exhaust is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| AirChangeRate | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The air change rate per hour (ACH) is a value that denotes the amount of air that must be removed each hour, based on the volume of the space (1 ACH would be 1x the volume of space each hour, if the space is 1m3, it would be 1m3 of extract per hour) | - |
| SpaceTypeContinuous | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The continuous exhaust rate associated with a particular space type (eg pet shop, printing room) measured in m3/s*m2 | - |
| UnitContinuous | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The exhaust rate associated with a particular fixture type (eg toilets, showers) that is run continuously, meaning that it is not triggered by a sensor or switch and is measured in m3/s*unit | - |
| UnitIntermittent | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The exhaust rate associated with a particular fixture type (eg toilets, showers) that is run intermittently, meaning that it is triggered by a sensor or switch and is measured in m3/s*unit | - |


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
public class Exhaust : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: Environment_oM.dll

The C# class definition is available on github:

- [Exhaust.cs](https://github.com/BHoM/BHoM/blob/develop/Environment_oM/SpaceCriteria\Exhaust.cs)

All history and changes of the class can be found by inspection the history.
