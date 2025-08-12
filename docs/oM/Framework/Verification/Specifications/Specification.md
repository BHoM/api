---
title: Specification
---

# <small>BH.oM.Verification.Specifications.</small>**Specification**

A top level object in verification workflow. Contains the information about the whole workflow, from extraction, to checking, to reporting.

## Class structure

### Implemented interfaces and base types

???+ bhom "The Specification is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Base.[ISpecification](/api/oM/Framework/Base/Interface/ISpecification)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Clause | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Human readable identifier to reference the Specification. | - |
| Description | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Description of the Specification. | - |
| Extraction | [IExtraction](/api/oM/Framework/Verification/Extraction/Interfaces/IExtraction) | Object describing how to extract the objects to be verify against Requirements. | - |
| Requirements | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IRequirement](/api/oM/Framework/Verification/Requirements/Interfaces/IRequirement)&gt; | A collection of objects, each containing an atomic check together with reporting config and metadata. | - |


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
public class Specification : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.Base.ISpecification
```

Assembly: Verification_oM.dll

The C# class definition is available on github:

- [Specification.cs](https://github.com/BHoM/BHoM/blob/develop/Verification_oM/Specifications\Specification.cs)

All history and changes of the class can be found by inspection the history.
