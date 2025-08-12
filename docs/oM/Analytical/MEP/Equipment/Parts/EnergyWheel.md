---
title: EnergyWheel
---

# <small>BH.oM.MEP.Equipment.Parts.</small>**EnergyWheel**

Energy wheels are devices that capture sensible and/or latent heat from air which would otherwise be lost to the atmosphere

## Class structure

### Implemented interfaces and base types

???+ bhom "The EnergyWheel is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.MEP.Equipment.Parts.[IPart](/api/oM/Analytical/MEP/Equipment/Parts/IPart)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| OutdoorSummerEnteringDryBulbTemperature | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Outdoor Summer Entering Dry Bulb Temperature indicates the temperature of the air entering the system in degrees Celsius, without taking humidity into consideration | - |
| OutdoorSummerEnteringWetBulbTemperature | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Outdoor Summer Entering Wet Bulb Temperature indicates the temperature of the air entering the system in degrees Celsius, while taking humidity into consideration | - |
| OutdoorSummerLeavingDryBulbTemperature | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Outdoor Summer Leaving Dry Bulb Temperature indicates the temperature of the air leaving the system in degrees Celsius, without taking humidity into consideration | - |
| OutdoorSummerLeavingWetBulbTemperature | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Outdoor Summer Leaving Wet Bulb Temperature indicates the temperature of the air leaving the system in degrees Celsius, while taking humidity into consideration | - |
| ReliefSummerEnteringDryBulbTemperature | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Relief Summer Entering Dry Bulb Temperature indicates the temperature of the air entering the system in degrees Celsius, without taking humidity into consideration | - |
| ReliefSummerEnteringWetBulbTemperature | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Relief Summer Entering Wet Bulb Temperature indicates the temperature of the air entering the system in degrees Celsius, while taking humidity into consideration | - |
| ReliefSummerLeavingDryBulbTemperature | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Relief Summer Leaving Dry Bulb Temperature indicates the temperature of the air leaving the system in degrees Celsius, without taking humidity into consideration | - |
| ReliefSummerLeavingWetBulbTemperature | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Relief Summer Leaving Wet Bulb Temperature indicates the temperature of the air leaving the system in degrees Celsius, while taking humidity into consideration | - |
| SummerSensibleEffectiveness | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Summer Sensible Effectiveness denotes the wheel's ability to extract sensible heat as a percentage | - |
| SummerTotalEffectiveness | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Summer Sensible Effectiveness denotes the wheel's ability to extract sensible and latent heat (also known as the total) as a percentage | - |
| OutdoorWinterEnteringDryBulbTemperature | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Outdoor Winter Entering Dry Bulb Temperature indicates the temperature of the air entering the system in degrees Celsius, without taking humidity into consideration | - |
| OutdoorWinterEnteringWetBulbTemperature | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Outdoor Winter Entering Wet Bulb Temperature indicates the temperature of the air entering the system in degrees Celsius, while taking humidity into consideration | - |
| OutdoorWinterLeavingDryBulbTemperature | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Outdoor Winter Leaving Dry Bulb Temperature indicates the temperature of the air leaving the system in degrees Celsius, without taking humidity into consideration | - |
| OutdoorWinterLeavingWetBulbTemperature | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Outdoor Winter Leaving Wet Bulb Temperature indicates the temperature of the air leaving the system in degrees Celsius, while taking humidity into consideration | - |
| ReliefWinterEnteringDryBulbTemperature | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Relief Winter Entering Dry Bulb Temperature indicates the temperature of the air entering the system in degrees Celsius, without taking humidity into consideration | - |
| ReliefWinterEnteringWetBulbTemperature | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Relief Winter Entering Wet Bulb Temperature indicates the temperature of the air entering the system in degrees Celsius, while taking humidity into consideration | - |
| ReliefWinterLeavingDryBulbTemperature | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Relief Winter Leaving Dry Bulb Temperature indicates the temperature of the air leaving the system in degrees Celsius, without taking humidity into consideration | - |
| ReliefWinterLeavingWetBulbTemperature | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Relief Winter Leaving Wet Bulb Temperature indicates the temperature of the air leaving the system in degrees Celsius, while taking humidity into consideration | - |
| WinterSensibleEffectiveness | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Winter Sensible Effectiveness denotes the wheel's ability to extract sensible heat as a percentage | - |
| WinterTotalEffectiveness | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Winter Sensible Effectiveness denotes the wheel's ability to extract sensible and latent heat (also known as the total) as a percentage | - |
| Type | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Type indicates the type of wheel (eg air-to-air enthalpy or heat recovery | - |
| Control | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Control indicates the means of controlling the unit (eg variable frequency controller) | - |


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
public class EnergyWheel : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.MEP.Equipment.Parts.IPart
```

Assembly: MEP_oM.dll

The C# class definition is available on github:

- [EnergyWheel.cs](https://github.com/BHoM/BHoM/blob/develop/MEP_oM/Equipment\Parts\EnergyWheel.cs)

All history and changes of the class can be found by inspection the history.
