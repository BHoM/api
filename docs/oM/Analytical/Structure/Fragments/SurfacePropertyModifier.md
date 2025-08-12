---
title: SurfacePropertyModifier
---

# <small>BH.oM.Structure.Fragments.</small>**SurfacePropertyModifier**

Sets modifiers to a SurfaceProperty. The modifiers are used to scale one or more of the property constants for analysis. Constants are multiplied with the modifiers, hence a modifier value of 1 means no change.

## Class structure

### Implemented interfaces and base types

???+ bhom "The SurfacePropertyModifier is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| FXX | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Modifier of the axial stiffness along the local x-axis. Value of the SurfaceProperty is multiplied by this value, hence 1 means no scaling applied. | [Ratio](/api/oM/Dimensional/Quantities/Attributes/Ratio) [-] |
| FYY | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Modifier of the axial stiffness along the local y-axis. Value of the SurfaceProperty is multiplied by this value, hence 1 means no scaling applied. | [Ratio](/api/oM/Dimensional/Quantities/Attributes/Ratio) [-] |
| FXY | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Modifier of the the in-plane shear. Value of the SurfaceProperty is multiplied by this value, hence 1 means no scaling applied. | [Ratio](/api/oM/Dimensional/Quantities/Attributes/Ratio) [-] |
| MXX | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Modifier of the bending stiffness about the local x-axis. Value of the SurfaceProperty is multiplied by this value, hence 1 means no scaling applied. | [Ratio](/api/oM/Dimensional/Quantities/Attributes/Ratio) [-] |
| MYY | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Modifier of the bending stiffness about the local y-axis. Value of the SurfaceProperty is multiplied by this value, hence 1 means no scaling applied. | [Ratio](/api/oM/Dimensional/Quantities/Attributes/Ratio) [-] |
| MXY | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Modifier of the in-plane twist stiffness. Value of the SurfaceProperty is multiplied by this value, hence 1 means no scaling applied. | [Ratio](/api/oM/Dimensional/Quantities/Attributes/Ratio) [-] |
| VXZ | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Modifier of the xz-out of plane shear stiffness. Value of the SurfaceProperty is multiplied by this value, hence 1 means no scaling applied. | [Ratio](/api/oM/Dimensional/Quantities/Attributes/Ratio) [-] |
| VYZ | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Modifier of the yz-out of plane shear stiffness. Value of the SurfaceProperty is multiplied by this value, hence 1 means no scaling applied. | [Ratio](/api/oM/Dimensional/Quantities/Attributes/Ratio) [-] |
| Mass | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Modifier of the mass. Value of the SurfaceProperty is multiplied by this value, hence 1 means no scaling applied. | [Ratio](/api/oM/Dimensional/Quantities/Attributes/Ratio) [-] |
| Weight | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Modifier of the weight. Value of the SurfaceProperty is multiplied by this value, hence 1 means no scaling applied. | [Ratio](/api/oM/Dimensional/Quantities/Attributes/Ratio) [-] |


## Code and Schema

### C# implementation

``` C# title="C#"
public class SurfacePropertyModifier : BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: Structure_oM.dll

The C# class definition is available on github:

- [SurfacePropertyModifier.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/Fragments\SurfacePropertyModifier.cs)

All history and changes of the class can be found by inspection the history.
