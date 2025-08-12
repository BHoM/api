---
title: SectionModifier
---

# <small>BH.oM.Structure.Fragments.</small>**SectionModifier**

Sets modifiers to a SectionProperty. The modifiers are used to scale one or more of the property constants for analysis. Constants are multiplied with the modifiers, hence a modifier value of 1 means no change.

## Class structure

### Implemented interfaces and base types

???+ bhom "The SectionModifier is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Area | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Modifies the Area of the SectionProperty. Value of the SectionProperty is multiplied by this value, hence 1 means no scaling applied. | [Ratio](/api/oM/Dimensional/Quantities/Attributes/Ratio) [-] |
| Iy | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Modifies the Moment of Inertia about the local y-Axis of the SectionProperty. Value of the SectionProperty is multiplied by this value, hence 1 means no scaling applied. | [Ratio](/api/oM/Dimensional/Quantities/Attributes/Ratio) [-] |
| Iz | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Modifies the Moment of Inertia about the local z-Axis of the SectionProperty. Value of the SectionProperty is multiplied by this value, hence 1 means no scaling applied. | [Ratio](/api/oM/Dimensional/Quantities/Attributes/Ratio) [-] |
| J | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Modifies the Torsion Constant of the SectionProperty. Value of the SectionProperty is multiplied by this value, hence 1 means no scaling applied. | [Ratio](/api/oM/Dimensional/Quantities/Attributes/Ratio) [-] |
| Asy | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Modifies the Shear Area in the local y direction of the SectionProperty. Value of the SectionProperty is multiplied by this value, hence 1 means no scaling applied. | [Ratio](/api/oM/Dimensional/Quantities/Attributes/Ratio) [-] |
| Asz | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Modifies the Shear Area in the local z direction of the SectionProperty. Value of the SectionProperty is multiplied by this value, hence 1 means no scaling applied. | [Ratio](/api/oM/Dimensional/Quantities/Attributes/Ratio) [-] |


## Code and Schema

### C# implementation

``` C# title="C#"
public class SectionModifier : BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: Structure_oM.dll

The C# class definition is available on github:

- [SectionModifier.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/Fragments\SectionModifier.cs)

All history and changes of the class can be found by inspection the history.
