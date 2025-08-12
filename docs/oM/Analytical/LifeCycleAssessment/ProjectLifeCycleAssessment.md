---
title: ProjectLifeCycleAssessment
---

# <small>BH.oM.LifeCycleAssessment.</small>**ProjectLifeCycleAssessment**

Project LCA can be used to collect all objects used in an evaluation along with the project's specific metatdata for tracking within a user-specified database.

## Class structure

### Implemented interfaces and base types

???+ bhom "The ProjectLifeCycleAssessment is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| LCAScope | [LifeCycleAssessmentScope](/api/oM/Analytical/LifeCycleAssessment/Fragments/LifeCycleAssessmentScope) | LCA Scope metadata designed to help differentiate between project specifications. | - |
| Elements | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IElementM](/api/oM/Dimensional/Dimensional/IElementM)&gt; | A collection of elements you wish to include in the project LCA. | - |


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
public class ProjectLifeCycleAssessment : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: LifeCycleAssessment_oM.dll

The C# class definition is available on github:

- [ProjectLifeCycleAssessment.cs](https://github.com/BHoM/BHoM/blob/develop/LifeCycleAssessment_oM/ProjectLifeCycleAssessment.cs)

All history and changes of the class can be found by inspection the history.
