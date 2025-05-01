---
title: PrimaryReinforcingBar
---

# <small>BH.oM.Physical.Reinforcement.</small>**PrimaryReinforcingBar**

Defining reinforcement running along the element.

## Class structure

### Implemented interfaces and base types

???+ bhom "The PrimaryReinforcingBar is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Physical.Reinforcement.[IReinforcingBar](/api/oM/Physical/Physical/Reinforcement/IReinforcingBar)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| CentreCurve | [ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve) | Centreline of the Reinforcing bar in three-dimensional space. When the BendRadius is sufficient for any kinks in the rebar, this can be defined as a polyline, ommiting any arcs in corners. | - |
| Diameter | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| Material | [Material](/api/oM/Physical/Physical/Materials/Material) | - | - |
| BendRadius | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Bend radius used for any discontinuities in the CentreCurve. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |


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
public class PrimaryReinforcingBar : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.Physical.Reinforcement.IReinforcingBar
```

Assembly: Physical_oM.dll

The class is defined in C#. The class definition is available on github:

- [PrimaryReinforcingBar.cs](https://github.com/BHoM/BHoM/blob/develop/Physical_oM/Reinforcement\PrimaryReinforcingBar.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Physical_oM/Reinforcement/PrimaryReinforcingBar.json"
}
```

The JSON Schema is available on github here:

- [PrimaryReinforcingBar.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Physical_oM/Reinforcement/PrimaryReinforcingBar.json)
