---
title: Employee
---

# <small>BH.oM.Humans.</small>**Employee**



## Class structure

### Implemented interfaces and base types

???+ bhom "The Employee is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Humans.[IHumanRole](/api/oM/Physical/Humans/Interfaces/IHumanRole)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Company | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Company the Employee works for. | - |
| Office | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Office assigned to the Employee. | - |
| Discipline | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Discipline the Employee works in. | - |
| Team | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Team the Employee belongs to. | - |
| Manager | [Employee](/api/oM/Physical/Humans/Employee) | Manager of the Employee. | - |
| Grade | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Seniority of the Employee. | - |
| Email | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Company email of the Employee. | - |
| Phone | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Company phone number of the Employee. | - |
| CodeDevelopmentRole | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| BusinessUnit | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Business Unit the Employee is assigned to. | - |


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
public class Employee : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.Humans.IHumanRole
```

Assembly: Humans_oM.dll

The C# class definition is available on github:

- [Employee.cs](https://github.com/BHoM/BHoM/blob/develop/Humans_oM/Employee.cs)

All history and changes of the class can be found by inspection the history.
