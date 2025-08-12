---
title: LinkConstraint
---

# <small>BH.oM.Structure.Constraints.</small>**LinkConstraint**

Defines the rigid connectivity between a primary and set of secondary nodes.

## Class structure

### Implemented interfaces and base types

???+ bhom "The LinkConstraint is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Structure.[IProperty](/api/oM/Analytical/Structure/IProperty)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | A unique Name is required for some structural packages to create and identify the object. | - |
| XtoX | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | True defines a rigid connectivity between primary and secondary nodes for translations along the X-axis, i.e. true prohibits relative translation along the X-axis between primary and secondary nodes. | - |
| YtoY | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | True defines a rigid connectivity between primary and secondary nodes for translations along the Y-axis, i.e. true prohibits relative translation along the Y-axis between primary and secondary nodes. | - |
| ZtoZ | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | True defines a rigid connectivity between primary and secondary nodes for translations along the Z-axis, i.e. true prohibits relative translation along the Z-axis between primary and secondary nodes. | - |
| XtoYY | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | True means that a X-translation imposes a rigid Y-axis rotation. | - |
| XtoZZ | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | True means that a X-translation imposes a rigid Z-axis rotation. | - |
| YtoXX | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | True means that a Y-translation imposes a rigid X-axis rotation. | - |
| YtoZZ | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | True means that a Y-translation imposes a rigid Z-axis rotation. | - |
| ZtoXX | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | True means that a Z-translation imposes a rigid X-axis rotation. | - |
| ZtoYY | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | True means that a Z-translation imposes a rigid Y-axis rotation. | - |
| XXtoXX | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | True defines a rigid connectivity between primary and secondary nodes for rotations about the X-axis, i.e. true prohibits relative rotation about the X-axis between primary and secondary nodes. | - |
| YYtoYY | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | True defines a rigid connectivity between primary and secondary nodes for rotations about the Y-axis, i.e. true prohibits relative rotation about the Y-axis between primary and secondary nodes. | - |
| ZZtoZZ | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | True defines a rigid connectivity between primary and secondary nodes for rotations about the Z-axis, i.e. true prohibits relative rotation about the Z-axis between primary and secondary nodes. | - |


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
| Description | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Generates a default description for the LinkConstraint based on its fixities where x denoted fixed and f denotes free. | - | Structure_Engine |
| DescriptionOrName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Gets the name from a IProperty. If null or empty, a default description name is provided instead. | - | Structure_Engine |
| IDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Generates a default description for the IProperty, based on its properties. | - | Structure_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class LinkConstraint : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.Structure.IProperty
```

Assembly: Structure_oM.dll

The C# class definition is available on github:

- [LinkConstraint.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/Constraints\LinkConstraint.cs)

All history and changes of the class can be found by inspection the history.
