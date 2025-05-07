---
title: WireSectionProperty
---

# <small>BH.oM.MEP.System.SectionProperties.</small>**WireSectionProperty**



## Class structure

### Implemented interfaces and base types

???+ bhom "The WireSectionProperty is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.MEP.System.SectionProperties.[IFlowSectionProperty](/api/oM/Analytical/MEP/System/SectionProperties/IFlowSectionProperty)
    -  BH.oM.Base.[IImmutable](/api/oM/Framework/Base/Interface/IImmutable)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ConductiveMaterial | [Material](/api/oM/Physical/Physical/Materials/Material) | The wire material is the primary material that the wire is composed of (copper, aluminium). | - |
| InsulationMaterial | [Material](/api/oM/Physical/Physical/Materials/Material) | The insulation is the layer of material outside of the conductive material, meant to insulate the internal conditions of the conductive material. | - |
| SectionProfile | [SectionProfile](/api/oM/Analytical/MEP/System/SectionProperties/SectionProfile) | The section profile of the object that will determine its use within a System. | - |
| ElementSolidArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | This area takes the element's thickness into account to determine the actual area of the 'solid' portion of the ShapeProfile. | - |
| ElementVoidArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The interior area within the element's shapeProfile. This corresponds to the actual open area less any material thickness. | - |
| LiningSolidArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The solid area of the lining within the element. This area takes into account the ElementSolidArea. | - |
| LiningVoidArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The innermost, open area within the Element and its interior lining. This corresponds to the actual open area of the element. | - |
| InsulationSolidArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The actual area of the exterior insulation material. | - |
| InsulationVoidArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The interior area within the Insulation. This should correspond to the element's height and width properties. | - |


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
public class WireSectionProperty : BH.oM.Base.BHoMObject,
BH.oM.Base.IBHoMObject,
BH.oM.Base.IObject,
BH.oM.MEP.System.SectionProperties.IFlowSectionProperty,
BH.oM.Base.IImmutable
```

Assembly: MEP_oM.dll

The C# class definition is available on github:

- [WireSectionProperty.cs](https://github.com/BHoM/BHoM/blob/develop/MEP_oM/System\SectionProperties\WireSectionProperty.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/MEP_oM/System/SectionProperties/WireSectionProperty.json"
}
```

The JSON Schema is available on github here:

- [WireSectionProperty.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/MEP_oM/System/SectionProperties/WireSectionProperty.json)
