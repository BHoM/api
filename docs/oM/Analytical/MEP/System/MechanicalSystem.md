---
title: MechanicalSystem
---

# <small>BH.oM.MEP.System.</small>**MechanicalSystem**

Mechanical systems are qualified by their ability to convey air, water, etc to a building/room/area

## Class structure

### Implemented interfaces and base types

???+ bhom "The MechanicalSystem is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.MEP.System.[ISystemType](/api/oM/Analytical/MEP/System/ISystemType)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| FluidType | [FluidType](/api/oM/Analytical/MEP/Enums/FluidType) | Fluid type that flows throughout the specified flow objects. | - |
| FluidTemperature | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The mean temperature of the fluid within the mechanical system (degrees Celsius). | - |
| FluidViscosity | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The viscosity of the fluid is the measure of its resistance to flow. | - |
| FluidDensity | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The mass per unit volume of the fluid within the mechanical system. | - |


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
public class MechanicalSystem : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.MEP.System.ISystemType
```

Assembly: MEP_oM.dll

The C# class definition is available on github:

- [MechanicalSystem.cs](https://github.com/BHoM/BHoM/blob/develop/MEP_oM/System\MechanicalSystem.cs)

All history and changes of the class can be found by inspection the history.
