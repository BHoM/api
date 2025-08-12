---
title: AirHandlingUnitBase
---

# <small>BH.oM.MEP.Equipment.Parts.</small>**AirHandlingUnitBase**

Air Handling Units are devices which house fans, filter, coils, and energy wheels which produce heated and cooled fresh/partially recirculated air to a building

## Class structure

### Implemented interfaces and base types

???+ bhom "The AirHandlingUnitBase is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.MEP.Equipment.Parts.[IPart](/api/oM/Analytical/MEP/Equipment/Parts/IPart)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| TotalSupplyAirFlow | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Total Supply Airflow accounts for the total amount of air supplied to the building by the Air Handling Unit | - |
| TotalSupplyAirExternalStaticPressure | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Total supply external static pressure denotes the resistance within the system that the supply fan has to overcome from filters, grilles, coils, etc | - |
| TotalReturnAirFlow | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Total Return Airflow accounts for the total amount of air returned from the building to the Air Handling Unit | - |
| TotalReturnAirExternalStaticPressure | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Total return external static pressure denotes the resistance within the system that the return fan has to overcome from grilles, ducts, etc | - |
| TotalDesignOutdoorAirFlow | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Total Design Outdoor Airflow accounts for the total amount of outdoor air introduced to the supply air that goes to the building from the Air Handling Unit | - |
| DemandControlledVentilationMinimumOutdoorAirFlow | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Demand Controlled Ventilation Minimum Outdoor Airflow denotes that amount of outdoor air that is required to be supplied to the building, at a minimum | - |
| TotalOutdoorAirFlowExternalStaticPressure | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Total outdoor air external static pressure denotes the resistance within the system that the outdoor air intake fan has to overcome | - |
| TotalReliefAirFlow | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Total Relief Airflow accounts for the total amount of extract/exhaust air that is removed from the system and introduced to the atmosphere | - |
| TotalReliefExternalStaticPressure | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Total Relief Airflow external static pressure denotes the resistance within the system that the relief/extract/exhaust fan has to overcome | - |
| SupplyAirEconomiser | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Supply Air Economisers allow additional outdoor air to be introduced to the system when outdoor conditions are favorable (typically cool and dry) | - |
| WaterEconomiser | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Water Economisers allow returned fluids to be introduced to the system when conditions are favorable | - |


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
public class AirHandlingUnitBase : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.MEP.Equipment.Parts.IPart
```

Assembly: MEP_oM.dll

The C# class definition is available on github:

- [AirHandlingUnitBase.cs](https://github.com/BHoM/BHoM/blob/develop/MEP_oM/Equipment\Parts\AirHandlingUnitBase.cs)

All history and changes of the class can be found by inspection the history.
