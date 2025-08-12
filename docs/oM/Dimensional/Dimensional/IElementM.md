---
title: IElementM
---

# <small>BH.oM.Dimensional.</small>**IElementM**

Enables Mass based operations to be performed on elements with materiality
Ensures the material composition of a physical object is represented, defined as proportions of discrete types of material forming the object's total solid volume.
Objects implementing this Interface will be required to implement some base methods for getting and setting data in a way that maintains the object's other properties.


[Documentation link](https://bhom.xyz/documentation/BHoM_oM/Dimensional_oM/IElement-required-extension-methods/)

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IElementM is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - BH.oM.MEP.System.[IFlow](/api/oM/Analytical/MEP/System/IFlow)
    - BH.oM.Physical.Elements.[IFramingElement](/api/oM/Physical/Physical/Elements/IFramingElement)
    - BH.oM.Physical.Elements.[ISolid](/api/oM/Physical/Physical/Elements/ISolid)
    - BH.oM.Physical.Elements.[ISurface](/api/oM/Physical/Physical/Elements/ISurface)
    - BH.oM.Structure.Elements.[IAreaElement](/api/oM/Analytical/Structure/Elements/IAreaElement)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Environment.Elements.[Opening](/api/oM/Analytical/Environment/Elements/Opening)
    - BH.oM.Environment.Elements.[Panel](/api/oM/Analytical/Environment/Elements/Panel)
    - BH.oM.Facade.Elements.[CurtainWall](/api/oM/Analytical/Facade/Elements/CurtainWall)
    - BH.oM.Facade.Elements.[FrameEdge](/api/oM/Analytical/Facade/Elements/FrameEdge)
    - BH.oM.Facade.Elements.[Opening](/api/oM/Analytical/Facade/Elements/Opening)
    - BH.oM.Facade.Elements.[Panel](/api/oM/Analytical/Facade/Elements/Panel)
    - BH.oM.MEP.System.[CableTray](/api/oM/Analytical/MEP/System/CableTray)
    - BH.oM.MEP.System.[Duct](/api/oM/Analytical/MEP/System/Duct)
    - BH.oM.MEP.System.[FlowSystem](/api/oM/Analytical/MEP/System/FlowSystem)
    - BH.oM.MEP.System.[Pipe](/api/oM/Analytical/MEP/System/Pipe)
    - BH.oM.MEP.System.[Wire](/api/oM/Analytical/MEP/System/Wire)
    - BH.oM.MEP.System.[WireSegment](/api/oM/Analytical/MEP/System/WireSegment)
    - BH.oM.Physical.Elements.[Beam](/api/oM/Physical/Physical/Elements/Beam)
    - BH.oM.Physical.Elements.[Bracing](/api/oM/Physical/Physical/Elements/Bracing)
    - BH.oM.Physical.Elements.[Cable](/api/oM/Physical/Physical/Elements/Cable)
    - BH.oM.Physical.Elements.[Column](/api/oM/Physical/Physical/Elements/Column)
    - BH.oM.Physical.Elements.[Door](/api/oM/Physical/Physical/Elements/Door)
    - BH.oM.Physical.Elements.[ExplicitBulk](/api/oM/Physical/Physical/Elements/ExplicitBulk)
    - BH.oM.Physical.Elements.[Floor](/api/oM/Physical/Physical/Elements/Floor)
    - BH.oM.Physical.Elements.[PadFoundation](/api/oM/Physical/Physical/Elements/PadFoundation)
    - BH.oM.Physical.Elements.[Pile](/api/oM/Physical/Physical/Elements/Pile)
    - BH.oM.Physical.Elements.[PileFoundation](/api/oM/Physical/Physical/Elements/PileFoundation)
    - BH.oM.Physical.Elements.[Roof](/api/oM/Physical/Physical/Elements/Roof)
    - BH.oM.Physical.Elements.[SolidBulk](/api/oM/Physical/Physical/Elements/SolidBulk)
    - BH.oM.Physical.Elements.[Wall](/api/oM/Physical/Physical/Elements/Wall)
    - BH.oM.Physical.Elements.[Window](/api/oM/Physical/Physical/Elements/Window)
    - BH.oM.Security.Elements.[CameraDevice](/api/oM/Analytical/Security/Elements/CameraDevice)
    - BH.oM.Structure.Elements.[Bar](/api/oM/Analytical/Structure/Elements/Bar)
    - BH.oM.Structure.Elements.[FEMesh](/api/oM/Analytical/Structure/Elements/FEMesh)
    - BH.oM.Structure.Elements.[PadFoundation](/api/oM/Analytical/Structure/Elements/PadFoundation)
    - BH.oM.Structure.Elements.[Panel](/api/oM/Analytical/Structure/Elements/Panel)
    - BH.oM.Structure.Elements.[Pile](/api/oM/Analytical/Structure/Elements/Pile)
    - BH.oM.Structure.Elements.[PileFoundation](/api/oM/Analytical/Structure/Elements/PileFoundation)
    - BH.oM.Structure.Elements.[RetainingWall](/api/oM/Analytical/Structure/Elements/RetainingWall)
    - BH.oM.Structure.Elements.[Stem](/api/oM/Analytical/Structure/Elements/Stem)
    - BH.oM.Structure.Elements.[Surface](/api/oM/Analytical/Structure/Elements/Surface)


## Properties

### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IGeneralMaterialTakeoff | [GeneralMaterialTakeoff](/api/oM/Physical/Physical/Materials/GeneralMaterialTakeoff) | Gets the unique Materials along with their volumes defining an object's make-up. | - | Matter_Engine |
| IMaterialComposition | [MaterialComposition](/api/oM/Physical/Physical/Materials/MaterialComposition) | Gets the unique Materials along with their relative proportions defining an object's make-up. | - | Matter_Engine |
| ISolidVolume | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns an element's solid volume, i.e. the the volume of the element that had any materiality, excluding cavities, openings and voids. | [Volume](/api/oM/Dimensional/Quantities/Attributes/Volume) [m³] | Matter_Engine |
| IVolumetricMaterialTakeoff | [VolumetricMaterialTakeoff](/api/oM/Physical/Physical/Materials/VolumetricMaterialTakeoff) | Gets the unique Materials along with their volumes defining an object's make-up. | - | Matter_Engine |
| Mass | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Evaluates the mass of an object based its VolumetricMaterialTakeoff and Density. | [Mass](/api/oM/Dimensional/Quantities/Attributes/Mass) [kg] | Matter_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IElementM : BH.oM.Base.IObject
```

Assembly: Dimensional_oM.dll

The C# interface definition is available on github:

- [IElementM.cs](https://github.com/BHoM/BHoM/blob/develop/Dimensional_oM/IElementM.cs)

All history and changes of the class can be found by inspection the history.
