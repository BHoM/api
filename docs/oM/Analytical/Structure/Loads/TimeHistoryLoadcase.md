---
title: TimeHistoryLoadcase
---

# <small>BH.oM.Structure.Loads.</small>**TimeHistoryLoadcase**

Defines a time history analysis case with time integration parameters.

## Class structure

### Implemented interfaces and base types

???+ bhom "The TimeHistoryLoadcase is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Structure.Loads.[ICase](/api/oM/Analytical/Structure/Loads/ICase)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Unique name identifying the time history load case. | - |
| Number | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Numerical identifier for the load case. | - |
| StartTime | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Start time of the time history loadcase. | [Time](/api/oM/Dimensional/Quantities/Attributes/Time) [s] |
| EndTime | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | End time of the time history loadcase. | [Time](/api/oM/Dimensional/Quantities/Attributes/Time) [s] |
| TimeStep | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Time step used for the loadcase. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a Case is null and outputs relevant error message. | - | Structure_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class TimeHistoryLoadcase : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.Structure.Loads.ICase
```

Assembly: Structure_oM.dll

The C# class definition is available on github:

- [TimeHistoryLoadcase.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/Loads\TimeHistoryLoadcase.cs)

All history and changes of the class can be found by inspection the history.
