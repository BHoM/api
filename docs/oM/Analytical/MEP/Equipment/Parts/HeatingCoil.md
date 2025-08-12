---
title: HeatingCoil
---

# <small>BH.oM.MEP.Equipment.Parts.</small>**HeatingCoil**

Heating coils allow fluids (air) to raise their temperature as they pass through the coil

## Class structure

### Implemented interfaces and base types

???+ bhom "The HeatingCoil is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.MEP.Equipment.Parts.[IPart](/api/oM/Analytical/MEP/Equipment/Parts/IPart)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| SensibleCapacity | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Sensible capacity indicates the ability for the heating coil to change the temperature of the fluid (air). | - |
| EnteringDryBulbAirTemperature | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Entering Dry Bulb Air Temperature indicates the heat intensity of the air entering the system in degrees Celsius | - |
| LeavingDryBulbAirTemperature | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Leaving Dry Bulb Air Temperature indicates the heat intensity of the air leaving the system in degrees Celsius | - |
| EnteringWaterTemperature | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Entering Water Temperature indicates the heat intensity of the water entering the system in degrees Celsius | - |
| LeavingWaterTemperature | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Leaving Water Temperature indicates the heat intensity of the water leaving the system in degrees Celsius | - |
| PressureDrop | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Pressure Drop indicates the amount of resistance created by the coil which creates a loss in pressure of the fluid (air) | - |
| NumberOfRows | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Number of Rows indicates the number of rows of coils that the fluid (air) passes through | - |


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
public class HeatingCoil : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.MEP.Equipment.Parts.IPart
```

Assembly: MEP_oM.dll

The C# class definition is available on github:

- [HeatingCoil.cs](https://github.com/BHoM/BHoM/blob/develop/MEP_oM/Equipment\Parts\HeatingCoil.cs)

All history and changes of the class can be found by inspection the history.
