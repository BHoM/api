---
title: FloorDesign
---

# <small>BH.oM.Structure.FloorSystem.</small>**FloorDesign**

Design of a floor bay, combining a floor configuration and its column configurations with the spans, loading and performance data (depth, mass, fire rating, edge condition and design code) the design was developed for.

## Class structure

### Implemented interfaces and base types

???+ bhom "The FloorDesign is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Base.[IImmutable](/api/oM/Framework/Base/Interface/IImmutable)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Name of the floor design. | - |
| FloorConfiguration | [IFloorConfiguration](/api/oM/Analytical/Structure/FloorSystem/IFloorConfiguration) | Configuration of the floor structure, i.e. the slab and framing, that the design is based on. | - |
| ColumnConfiguration | [ColumnData](/api/oM/Analytical/Structure/FloorSystem/ColumnData) | Column data for the columns supporting the floor, giving the column required for different numbers of supported stories. | - |
| SpanX | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Length of the primary beam or local X dimension. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| SpanY | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Length of the secondary beam or local Y dimension. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| LoadSDL | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Uniformly applied super-imposed dead load on the floor area. | [Pressure](/api/oM/Dimensional/Quantities/Attributes/Pressure) [Pa] |
| LoadLL | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Uniformly applied live load on the floor area. | [Pressure](/api/oM/Dimensional/Quantities/Attributes/Pressure) [Pa] |
| Depth | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Total floor depth from top of slab to bottom of deepest beam. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| Mass | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Mass of the floor bay per area. | [MassPerUnitArea](/api/oM/Dimensional/Quantities/Attributes/MassPerUnitArea) [kg/m²] |
| FireRating | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Structural fire rating requirement. | [Time](/api/oM/Dimensional/Quantities/Attributes/Time) [s] |
| EdgeCondition | [EdgeCondition](/api/oM/Analytical/Structure/FloorSystem/Enums/EdgeCondition) | Position of the floor bay within the floor plate that the design applies to. Defaults to Interior. | - |
| DesignCode | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Structural engineering code to which the floor bay has been designed. | - |
| DesignNotes | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Design assumptions and additional information about the design. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class FloorDesign : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.Base.IImmutable
```

Assembly: Structure_oM.dll

The C# class definition is available on github:

- [FloorDesign.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/FloorSystem\FloorDesign.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Structure_oM/FloorSystem/FloorDesign.json"
}
```

The JSON Schema is available on github here:

- [FloorDesign.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Structure_oM/FloorSystem/FloorDesign.json)
