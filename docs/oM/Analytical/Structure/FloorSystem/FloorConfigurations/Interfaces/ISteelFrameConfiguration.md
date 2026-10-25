---
title: ISteelFrameConfiguration
---

# <small>BH.oM.Structure.FloorSystem.</small>**ISteelFrameConfiguration**

Interface for floor configurations with a frame of steel primary beams and steel secondary beams, including the intumescent paint applied to the beams for fire protection.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The ISteelFrameConfiguration is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Structure.FloorSystem.[ISecondaryBeamConfiguration](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/ISecondaryBeamConfiguration)&lt;BH.oM.Structure.SectionProperties.[ISteelSection](/api/oM/Analytical/Structure/SectionProperties/ISteelSection), BH.oM.Structure.SectionProperties.[ISteelSection](/api/oM/Analytical/Structure/SectionProperties/ISteelSection)&gt;
    -  BH.oM.Structure.FloorSystem.[IPrimaryBeamConfiguration](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/IPrimaryBeamConfiguration)&lt;BH.oM.Structure.SectionProperties.[ISteelSection](/api/oM/Analytical/Structure/SectionProperties/ISteelSection)&gt;
    -  BH.oM.Structure.FloorSystem.[IFloorConfiguration](/api/oM/Analytical/Structure/FloorSystem/IFloorConfiguration)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Structure.FloorSystem.[CompositeSteelInfillBeams](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/CompositeSteelInfillBeams)
    - BH.oM.Structure.FloorSystem.[SteelInfillBeams](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/SteelInfillBeams)
    - BH.oM.Structure.FloorSystem.FloorConfigurations.[HybridTimberOnSteel](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/HybridTimberOnSteel)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| IntumescentPaintThicknessPrimary | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Thickness of intumescent paint covering exposed primary beam steelwork. Allowance used for when computing takeoffs of the configuration. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| IntumescentPaintThicknessSecondary | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Thickness of intumescent paint covering exposed secondary beam steelwork. Allowance used for when computing takeoffs of the configuration. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| IntumescentPaintMaterial | [Material](/api/oM/Physical/Physical/Materials/Material) | Material of the intumescent paint. Used when computing material takeoffs of the configuration. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface ISteelFrameConfiguration : BH.oM.Structure.FloorSystem.ISecondaryBeamConfiguration<BH.oM.Structure.SectionProperties.ISteelSection, BH.oM.Structure.SectionProperties.ISteelSection>,
BH.oM.Structure.FloorSystem.IPrimaryBeamConfiguration<BH.oM.Structure.SectionProperties.ISteelSection>,
BH.oM.Structure.FloorSystem.IFloorConfiguration,
BH.oM.Base.IBHoMObject,
BH.oM.Base.IObject
```

Assembly: Structure_oM.dll

The C# interface definition is available on github:

- [ISteelFrameConfiguration.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/FloorSystem\FloorConfigurations\Interfaces\ISteelFrameConfiguration.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Structure_oM/FloorSystem/ISteelFrameConfiguration.json"
}
```

The JSON Schema is available on github here:

- [ISteelFrameConfiguration.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Structure_oM/FloorSystem/ISteelFrameConfiguration.json)
