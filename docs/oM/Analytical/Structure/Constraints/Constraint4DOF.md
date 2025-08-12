---
title: Constraint4DOF
---

# <small>BH.oM.Structure.Constraints.</small>**Constraint4DOF**

Constraint objects with four degrees of freedom, three translational and one rotational. Used for support or release of 1D analytical elements of 2D analytical objects. The Rotational DOF will correspond to rotation about the axis of the object.

## Class structure

### Implemented interfaces and base types

???+ bhom "The Constraint4DOF is inheriting from the following base type(s) and implements the following interfaces:"

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
| TranslationX | [DOFType](/api/oM/Analytical/Structure/Constraints/Enums/DOFType) | Defines the translational fixity in the X-direction. | - |
| TranslationY | [DOFType](/api/oM/Analytical/Structure/Constraints/Enums/DOFType) | Defines the translational fixity in the Y-direction. | - |
| TranslationZ | [DOFType](/api/oM/Analytical/Structure/Constraints/Enums/DOFType) | Defines the translational fixity in the Z-direction. | - |
| RotationX | [DOFType](/api/oM/Analytical/Structure/Constraints/Enums/DOFType) | Defines the rotational fixity about the axis of the element. | - |
| TranslationalStiffnessX | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Defines the stiffness in X-direction. This will only be active when corresponding degree of freedom has a DOFType with a stiffness dependency, such as Spring. | [ForcePerUnitLength](/api/oM/Dimensional/Quantities/Attributes/ForcePerUnitLength) [N/m] |
| TranslationalStiffnessY | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Defines the stiffness in Y-direction. This will only be active when corresponding degree of freedom has a DOFType with a stiffness dependency, such as Spring. | [ForcePerUnitLength](/api/oM/Dimensional/Quantities/Attributes/ForcePerUnitLength) [N/m] |
| TranslationalStiffnessZ | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Defines the stiffness in Z-direction. This will only be active when corresponding degree of freedom has a DOFType with a stiffness dependency, such as Spring. | [ForcePerUnitLength](/api/oM/Dimensional/Quantities/Attributes/ForcePerUnitLength) [N/m] |
| RotationalStiffnessX | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Defines the stiffness for rotation about the axis of the element. This will only be active when corresponding degree of freedom has a DOFType with a stiffness dependency, such as Spring. | [MomentPerUnitAngle](/api/oM/Dimensional/Quantities/Attributes/MomentPerUnitAngle) [N.m/rad] |


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
| Description | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Generates a default description for the Constraint4DOF based on the constraints at each degree of freedom. | - | Structure_Engine |
| DescriptionOrName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Gets the name from a IProperty. If null or empty, a default description name is provided instead. | - | Structure_Engine |
| IDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Generates a default description for the IProperty, based on its properties. | - | Structure_Engine |
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a Constraint4DOF is null and outputs relevant error message. | - | Structure_Engine |
| IsNumericallyDependent | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Returns true if any of the degrees of freedom is of a value based type or the values are non-zero. | - | Structure_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class Constraint4DOF : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.Structure.IProperty
```

Assembly: Structure_oM.dll

The C# class definition is available on github:

- [Constraint4DOF.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/Constraints\Constraint4DOF.cs)

All history and changes of the class can be found by inspection the history.
