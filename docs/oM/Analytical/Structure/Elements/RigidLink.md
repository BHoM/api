---
title: RigidLink
---

# <small>BH.oM.Structure.Elements.</small>**RigidLink**

A rigid link object defining rigid constraints between two or more nodes.

## Class structure

### Implemented interfaces and base types

???+ bhom "The RigidLink is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| PrimaryNode | [Node](/api/oM/Analytical/Structure/Elements/Node) | A single node to which SecondaryNodes are constrained. | - |
| SecondaryNodes | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Node](/api/oM/Analytical/Structure/Elements/Node)&gt; | List of nodes which are constrained to the PrimaryNode. | - |
| Constraint | [LinkConstraint](/api/oM/Analytical/Structure/Constraints/LinkConstraint) | Defines how SecondaryNodes are constrained to the PrimaryNode. The LinkConstraint describes translation and rotation of SecondaryNodes with respect to the PrimaryNode's coordinate system. | - |


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
| Geometry | [IGeometry](/api/oM/Dimensional/Geometry/Interface/IGeometry) | Gets the geometry of a RigidLink as a list of lines between the primary node and the secondary nodes. Method required for automatic display in UI packages. | - | Structure_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class RigidLink : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: Structure_oM.dll

The C# class definition is available on github:

- [RigidLink.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/Elements\RigidLink.cs)

All history and changes of the class can be found by inspection the history.
