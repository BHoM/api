---
title: Fan
---

# <small>BH.oM.MEP.Equipment.Parts.</small>**Fan**

Fans are devices that create a current of air (used for ventilation and cooling) by rotating blades

## Class structure

### Implemented interfaces and base types

???+ bhom "The Fan is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.MEP.Equipment.Parts.[IPart](/api/oM/Analytical/MEP/Equipment/Parts/IPart)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| FlowRate | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Flow Rate denotes the amount of air that is drawn across the fan, measured in m3/s | - |
| ExternalStaticPressure | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | External static pressure denotes the resistance within the system that the fan has to overcome from filters, grilles, coils, etc | - |
| Speed | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Speed denotes the rotational speed of the fan blades | - |
| DriveType | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Drive type denotes the drive type as either direct or belt | - |
| SpeedControl | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | A device for controlling the fan speed. | - |
| BrakeHorsePower | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| HorsePower | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| Efficiency | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Efficiency denotes the ratio between the power transferred to airflow produced by the fan and the power used by the fan | - |


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
public class Fan : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.MEP.Equipment.Parts.IPart
```

Assembly: MEP_oM.dll

The C# class definition is available on github:

- [Fan.cs](https://github.com/BHoM/BHoM/blob/develop/MEP_oM/Equipment\Parts\Fan.cs)

All history and changes of the class can be found by inspection the history.
