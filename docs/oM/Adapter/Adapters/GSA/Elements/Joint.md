---
title: Joint
---

# <small>BH.oM.Adapters.GSA.Elements.</small>**Joint**

A joint describing linked degrees of freedom between nodes. Relates the displacement or force at the constrained degree of freedom to the primary degree of freedom without considering eccentricities.

## Class structure

### Implemented interfaces and base types

???+ bhom "The Joint is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| PrimaryNode | [Node](/api/oM/Analytical/Structure/Elements/Node) | Defines the primary node of the joint. | - |
| ConstrainedNode | [Node](/api/oM/Analytical/Structure/Elements/Node) | Defines the constrained node of the joint. | - |
| X | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | True defines a rigid connectivity between primary and constrained node for translations along the X-axis, i.e. true prohibits relative translation along the X-axis between primary and constrained node. | - |
| Y | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | True defines a rigid connectivity between primary and constrained node for translations along the Y-axis, i.e. true prohibits relative translation along the Y-axis between primary and constrained node. | - |
| Z | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | True defines a rigid connectivity between primary and constrained node for translations along the Z-axis, i.e. true prohibits relative translation along the Z-axis between primary and constrained node. | - |
| XX | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | True defines a rigid connectivity between primary and constrained node for rotations about the X-axis, i.e. true prohibits relative rotation about the X-axis between primary and constrained node. | - |
| YY | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | True defines a rigid connectivity between primary and constrained node for rotations about the Y-axis, i.e. true prohibits relative rotation about the Y-axis between primary and constrained node. | - |
| ZZ | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | True defines a rigid connectivity between primary and constrained node for rotations about the Z-axis, i.e. true prohibits relative rotation about the Z-axis between primary and constrained node. | - |
| StageList | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0)&gt; | List of analysis stages where the joint should be active as a list of integers. If none specified 'all' will be applied. | - |


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
public class Joint : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: GSA_oM.dll

The C# class definition is available on github:

- [Joint.cs](https://github.com/BHoM/GSA_Toolkit/blob/develop/GSA_oM/Elements\Joint.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/GSA_oM/Elements/Joint.json"
}
```

The JSON Schema is available on github here:

- [Joint.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/GSA_oM/Elements/Joint.json)
