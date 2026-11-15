---
title: ModalCase
---

# <small>BH.oM.Structure.Loads.</small>**ModalCase**



## Class structure

### Implemented interfaces and base types

???+ bhom "The ModalCase is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Structure.Loads.[ICase](/api/oM/Analytical/Structure/Loads/ICase)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Number | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | - | - |
| NumberOfModes | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | - | - |
| StartMode | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | - | - |
| Mass | [MassSource](/api/oM/Adapter/Structure/Loads/MassSource) | - | - |


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
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a Case is null and outputs relevant error message. | - | Structure_Engine |
| IsValid | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a case, a Loadcase or a LoadCombination, is valid by performing null checks and basic checks on its properties. | - | Structure_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class ModalCase : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.Structure.Loads.ICase
```

Assembly: ETABS_oM.dll

The C# class definition is available on github:

- [ModalCase.cs](https://github.com/BHoM/ETABS_Toolkit/blob/develop/ETABS_oM/Loads\ModalCase.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/ETABS_oM/Loads/ModalCase.json"
}
```

The JSON Schema is available on github here:

- [ModalCase.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/ETABS_oM/Loads/ModalCase.json)
