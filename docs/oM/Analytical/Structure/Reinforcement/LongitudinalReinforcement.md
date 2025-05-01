---
title: LongitudinalReinforcement
---

# <small>BH.oM.Structure.Reinforcement.</small>**LongitudinalReinforcement**

Defines any longitudinal reinforcement along a Bar.

## Class structure

### Implemented interfaces and base types

???+ bhom "The LongitudinalReinforcement is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Structure.Reinforcement.[IBarReinforcement](/api/oM/Analytical/Structure/Reinforcement/IBarReinforcement)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| RebarLayout | [ILayout2D](/api/oM/Dimensional/Spatial/Layouts/ILayout2D) | Layout controlling the distribution of the rebars across the SectionProperty. | - |
| Diameter | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Diameter of a single rebar. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| Material | [IMaterialFragment](/api/oM/Analytical/Structure/MaterialFragments/IMaterialFragment) | - | - |
| StartLocation | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Normalised length (0 means start, 1 means end) along the element where the rebars start. | - |
| EndLocation | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Normalised length (0 means start, 1 means end) along the element where the rebars ends. | - |


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
| Area | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Calculates the total section area of all rebars in the reinforcement object. | [Area](/api/oM/Dimensional/Quantities/Attributes/Area) [m²] | Structure_Engine |
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a BarReinforcement is null and outputs relevant error message. | - | Structure_Engine |
| ReinforcingBarCount | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Return the number of reinforcing bars in one a LongtudinalReinforcement object. | - | Structure_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class LongitudinalReinforcement : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.Structure.Reinforcement.IBarReinforcement
```

Assembly: Structure_oM.dll

The C# class definition is available on github:

- [LongitudinalReinforcement.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/Reinforcement\LongitudinalReinforcement.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by refernce. To do this, use the schema reference below in in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Structure_oM/Reinforcement/LongitudinalReinforcement.json"
}
```

The JSON Schema is available on github here:

- [LongitudinalReinforcement.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Structure_oM/Reinforcement/LongitudinalReinforcement.json)
