---
title: IConcreteDropheadSlabConfiguration&lt;T&gt;
---

# <small>BH.oM.Structure.FloorSystem.</small>**IConcreteDropheadSlabConfiguration&lt;T&gt;**

Interface for floor configurations with a concrete slab that can have dropheads over the columns.

## Interface structure

### Generic parameters

The IConcreteDropheadSlabConfiguration contains the following generic paramters:

#### T

Constrained by the following arguments:

- BH.oM.Structure.SurfaceProperties.[ISurfaceProperty](/api/oM/Analytical/Structure/SurfaceProperties/ISurfaceProperty)

### Implemented interfaces and base types

???+ bhom "The IConcreteDropheadSlabConfiguration`1 is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Structure.FloorSystem.[IConcreteSlabConfiguration](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/IConcreteSlabConfiguration)&lt;[T](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/IConcreteSlabConfiguration#t)&gt;
    -  BH.oM.Structure.FloorSystem.[ISlabConfiguration](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/ISlabConfiguration)&lt;[T](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/ISlabConfiguration#t)&gt;
    -  BH.oM.Structure.FloorSystem.[IFloorConfiguration](/api/oM/Analytical/Structure/FloorSystem/IFloorConfiguration)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Structure.FloorSystem.[RCFlatSlab](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/RCFlatSlab)
    - BH.oM.Structure.FloorSystem.[WaffleSlab](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/WaffleSlab)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Drophead | [Drophead](/api/oM/Analytical/Structure/FloorSystem/Detailing/Drophead) | Drophead in the slabs over columns. For a slab without dropheads this will be null. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IConcreteDropheadSlabConfiguration`1 : BH.oM.Structure.FloorSystem.IConcreteSlabConfiguration<>,
BH.oM.Structure.FloorSystem.ISlabConfiguration<>,
BH.oM.Structure.FloorSystem.IFloorConfiguration,
BH.oM.Base.IBHoMObject,
BH.oM.Base.IObject
```

Assembly: Structure_oM.dll

The C# interface definition is available on github:

- [IConcreteDropheadSlabConfiguration.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/FloorSystem\FloorConfigurations\Interfaces\IConcreteDropheadSlabConfiguration.cs)

All history and changes of the class can be found by inspection the history.
