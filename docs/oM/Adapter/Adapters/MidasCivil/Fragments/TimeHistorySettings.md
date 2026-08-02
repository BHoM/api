---
title: TimeHistorySettings
---

# <small>BH.oM.Adapters.MidasCivil.</small>**TimeHistorySettings**



## Class structure

### Implemented interfaces and base types

???+ bhom "The TimeHistorySettings is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| LinearType | [LinearType](/api/oM/Adapter/Adapters/MidasCivil/eNum/LinearType) | Indicates whether the time history analysis is performed linear or nonlinear. | - |
| IntegrationMethod | [IntegrationMethod](/api/oM/Adapter/Adapters/MidasCivil/eNum/IntegrationMethod) | Indicates how Midas performs the time history calculation. | - |
| DampingMethod | [DampingMethod](/api/oM/Adapter/Adapters/MidasCivil/eNum/DampingMethod) | Specifies how the damping matrix is calculated in the analysis. | - |
| TimeHistoryType | [TimeHistoryType](/api/oM/Adapter/Adapters/MidasCivil/eNum/TimeHistoryType) | Describes the type of time‑dependent loading used in the analysis. | - |
| DynamicLoadType | [DynamicLoadType](/api/oM/Adapter/Adapters/MidasCivil/eNum/DynamicLoadType) | Defines how the starting state for the time history analysis is determined. <br>It can either begin from the model’s initial, unloaded state (InitialLoad) <br>or continue from the final state of another load case (SequentialOrder). | - |


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
public class TimeHistorySettings : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.Base.IFragment
```

Assembly: MidasCivil_oM.dll

The C# class definition is available on github:

- [TimeHistorySettings.cs](https://github.com/BHoM/MidasCivil_Toolkit/blob/develop/MidasCivil_oM/Fragments\TimeHistorySettings.cs)

All history and changes of the class can be found by inspection the history.
