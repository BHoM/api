---
title: AirHandlingUnit
---

# <small>BH.oM.MEP.Equipment.</small>**AirHandlingUnit**

Air Handling Units are devices which house fans, filter, coils, and energy wheels which produce heated and cooled fresh/partially recirculated air to a building

## Class structure

### Implemented interfaces and base types

???+ bhom "The AirHandlingUnit is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.MEP.Equipment.[IEquipment](/api/oM/Analytical/MEP/Equipment/IEquipment)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Type | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Type denotes the kind of Air Handling Unit (eg heat and ventilation, energy recovery) | - |
| TotalAirFlow | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Total Airflow accounts for the maximum amount of supply/outside air that the Air Handling Unit will be passing. This value is measured in m3/s (e.g. 2.35 m3/s (5000 CFM) of Outside Air) | - |
| AirVelocityAcrossCoil | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Air velocity across coil denotes the maximum velocity of the air that should be passed along the Air Handling Unit's coil. This value is measured in m/s (maximum values around 2.5 m/s (500 ft/min) are considered best practice) | - |
| Parts | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IPart](/api/oM/Analytical/MEP/Equipment/Parts/IPart)&gt; | A collection of the parts (Air Handling Unit, Fans, Coils, Energy Wheel, Filters, Electrical Connectors) that make up the Air Handling Unit | - |


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
| FaceAreaByVelocity | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the height and width of the equipment based on the inputs of AirVelocityAcrossCoil and TotalAirFlow. | - | MEP_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class AirHandlingUnit : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.MEP.Equipment.IEquipment
```

Assembly: MEP_oM.dll

The C# class definition is available on github:

- [AirHandlingUnit.cs](https://github.com/BHoM/BHoM/blob/develop/MEP_oM/Equipment\AirHandlingUnit.cs)

All history and changes of the class can be found by inspection the history.
