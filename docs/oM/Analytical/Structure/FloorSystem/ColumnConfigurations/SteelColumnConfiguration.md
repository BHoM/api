---
title: SteelColumnConfiguration
---

# <small>BH.oM.Structure.FloorSystem.</small>**SteelColumnConfiguration**

Steel column required to support a given number of stories at a given floor height, including the intumescent paint applied for fire protection.

## Class structure

### Implemented interfaces and base types

???+ bhom "The SteelColumnConfiguration is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Structure.FloorSystem.[IColumnConfiguration](/api/oM/Analytical/Structure/FloorSystem/IColumnConfiguration)&lt;BH.oM.Structure.SectionProperties.[SteelSection](/api/oM/Analytical/Structure/SectionProperties/SteelSection)&gt;


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ColumnSection | [SteelSection](/api/oM/Analytical/Structure/SectionProperties/SteelSection) | Section of the column required for this configuration. | - |
| FloorHeight | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Floor-to-floor height that the column configuration is designed for. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| NumberOfStories | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Number of stories supported by the column in this configuration. | - |
| IntumescentPaintThickness | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Thickness of intumescent paint covering exposed steelwork. Allowance used for when computing takeoffs of the configuration. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| IntumescentPaintMaterial | [Material](/api/oM/Physical/Physical/Materials/Material) | Material of the intumescent paint. Used when computing material takeoffs of the configuration. | - |


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
public class SteelColumnConfiguration : BH.oM.Base.BHoMObject,
BH.oM.Base.IBHoMObject,
BH.oM.Base.IObject,
BH.oM.Structure.FloorSystem.IColumnConfiguration<BH.oM.Structure.SectionProperties.SteelSection>
```

Assembly: Structure_oM.dll

The C# class definition is available on github:

- [SteelColumnConfiguration.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/FloorSystem\ColumnConfigurations\SteelColumnConfiguration.cs)

All history and changes of the class can be found by inspection the history.
