---
title: ITertiaryBeamConfiguration&lt;TPrimary,TSecondary,TTertiary&gt;
---

# <small>BH.oM.Structure.FloorSystem.</small>**ITertiaryBeamConfiguration&lt;TPrimary,TSecondary,TTertiary&gt;**

Base interface for framing systems containing primary beams spanning between columns, secondary beams spanning between primary beams and tertiary beams spanning between secondary beams.

## Interface structure

### Generic parameters

The ITertiaryBeamConfiguration contains the following generic paramters:

#### TPrimary

Constrained by the following arguments:

- BH.oM.Structure.SectionProperties.[IGeometricalSection](/api/oM/Analytical/Structure/SectionProperties/IGeometricalSection)

#### TSecondary

Constrained by the following arguments:

- BH.oM.Structure.SectionProperties.[IGeometricalSection](/api/oM/Analytical/Structure/SectionProperties/IGeometricalSection)

#### TTertiary

Constrained by the following arguments:

- BH.oM.Structure.SectionProperties.[IGeometricalSection](/api/oM/Analytical/Structure/SectionProperties/IGeometricalSection)

### Implemented interfaces and base types

???+ bhom "The ITertiaryBeamConfiguration`3 is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Structure.FloorSystem.[ISecondaryBeamConfiguration](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/ISecondaryBeamConfiguration)&lt;[TPrimary](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/ISecondaryBeamConfiguration#tprimary), [TSecondary](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/ISecondaryBeamConfiguration#tsecondary)&gt;
    -  BH.oM.Structure.FloorSystem.[IPrimaryBeamConfiguration](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/IPrimaryBeamConfiguration)&lt;[TPrimary](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/IPrimaryBeamConfiguration#tprimary)&gt;
    -  BH.oM.Structure.FloorSystem.[IFloorConfiguration](/api/oM/Analytical/Structure/FloorSystem/IFloorConfiguration)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - BH.oM.Structure.FloorSystem.[ITimberTertiaryBeamFloorConfiguration](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/Interfaces/ITimberTertiaryBeamFloorConfiguration)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Structure.FloorSystem.[TimberJoistFloor](/api/oM/Analytical/Structure/FloorSystem/FloorConfigurations/TimberJoistFloor)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| TertiaryBeam | [TTertiary](#ttertiary) | Section of the tertiary beams spanning between the secondary beams. | - |
| NumTertiary | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Number of tertiary beams, evenly spaced across the bay in the local Y direction and spanning in the local X direction between the secondary beams. | - |
| TertiaryBeamTopLevel | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Distance from top of slab to top of tertiary beam. Set to slab thickness for slab on top but set to zero for within depth of slab. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface ITertiaryBeamConfiguration`3 : BH.oM.Structure.FloorSystem.ISecondaryBeamConfiguration<, >,
BH.oM.Structure.FloorSystem.IPrimaryBeamConfiguration<>,
BH.oM.Structure.FloorSystem.IFloorConfiguration,
BH.oM.Base.IBHoMObject,
BH.oM.Base.IObject
```

Assembly: Structure_oM.dll

The C# interface definition is available on github:

- [ITertiaryBeamConfiguration.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/FloorSystem\FloorConfigurations\Interfaces\ITertiaryBeamConfiguration.cs)

All history and changes of the class can be found by inspection the history.
