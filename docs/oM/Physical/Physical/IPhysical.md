---
title: IPhysical
---

# <small>BH.oM.Physical.</small>**IPhysical**



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IPhysical is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - BH.oM.Physical.Elements.[IFramingElement](/api/oM/Physical/Physical/Elements/IFramingElement)
    - BH.oM.Physical.Elements.[IOpening](/api/oM/Physical/Physical/Elements/IOpening)
    - BH.oM.Physical.Elements.[ISolid](/api/oM/Physical/Physical/Elements/ISolid)
    - BH.oM.Physical.Elements.[ISurface](/api/oM/Physical/Physical/Elements/ISurface)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Physical.Materials.[Material](/api/oM/Physical/Physical/Materials/Material)
    - BH.oM.Physical.Materials.[MaterialComposition](/api/oM/Physical/Physical/Materials/MaterialComposition)
    - BH.oM.Physical.Materials.[VolumetricMaterialTakeoff](/api/oM/Physical/Physical/Materials/VolumetricMaterialTakeoff)
    - BH.oM.Physical.Elements.[Beam](/api/oM/Physical/Physical/Elements/Beam)
    - BH.oM.Physical.Elements.[Bracing](/api/oM/Physical/Physical/Elements/Bracing)
    - BH.oM.Physical.Elements.[Cable](/api/oM/Physical/Physical/Elements/Cable)
    - BH.oM.Physical.Elements.[Column](/api/oM/Physical/Physical/Elements/Column)
    - BH.oM.Physical.Elements.[Door](/api/oM/Physical/Physical/Elements/Door)
    - BH.oM.Physical.Elements.[Floor](/api/oM/Physical/Physical/Elements/Floor)
    - BH.oM.Physical.Elements.[MeshElement](/api/oM/Physical/Physical/Elements/MeshElement)
    - BH.oM.Physical.Elements.[PadFoundation](/api/oM/Physical/Physical/Elements/PadFoundation)
    - BH.oM.Physical.Elements.[Pile](/api/oM/Physical/Physical/Elements/Pile)
    - BH.oM.Physical.Elements.[Roof](/api/oM/Physical/Physical/Elements/Roof)
    - BH.oM.Physical.Elements.[SolidBulk](/api/oM/Physical/Physical/Elements/SolidBulk)
    - BH.oM.Physical.Elements.[Void](/api/oM/Physical/Physical/Elements/Void)
    - BH.oM.Physical.Elements.[Wall](/api/oM/Physical/Physical/Elements/Wall)
    - BH.oM.Physical.Elements.[Window](/api/oM/Physical/Physical/Elements/Window)
    - BH.oM.Physical.Constructions.[Construction](/api/oM/Physical/Physical/Constructions/Construction)
    - BH.oM.Physical.Constructions.[Layer](/api/oM/Physical/Physical/Constructions/Layer)


## Properties

### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| ExternalPolyline | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Polyline](/api/oM/Dimensional/Geometry/Curve/Polyline)&gt; | Returns the External Polyline representation of a physical object (e.g. wall or window). | - | Physical_Engine |
| InternalPolyline | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Polyline](/api/oM/Dimensional/Geometry/Curve/Polyline)&gt; | Returns the Internal Polyline representation of a physical object (e.g. wall or window). | - | Physical_Engine |
| Polyline | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Polyline](/api/oM/Dimensional/Geometry/Curve/Polyline)&gt; | Returns a Polyline representation of a physical object (e.g. wall or window). | - | Physical_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IPhysical : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: Physical_oM.dll

The C# interface definition is available on github:

- [IPhysical.cs](https://github.com/BHoM/BHoM/blob/develop/Physical_oM/IPhysical.cs)

All history and changes of the class can be found by inspection the history.
