---
title: IMEPMaterial
---

# <small>BH.oM.MEP.System.MaterialFragments.</small>**IMEPMaterial**

Base interface for MEP materials used by MEP properties or as a fragment of the physical material.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IMEPMaterial is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.MEP.System.MaterialFragments.[CableTrayMaterial](/api/oM/Analytical/MEP/System/MaterialFragments/CableTrayMaterial)
    - BH.oM.MEP.System.MaterialFragments.[DuctMaterial](/api/oM/Analytical/MEP/System/MaterialFragments/DuctMaterial)
    - BH.oM.MEP.System.MaterialFragments.[InsulationMaterial](/api/oM/Analytical/MEP/System/MaterialFragments/InsulationMaterial)
    - BH.oM.MEP.System.MaterialFragments.[LiningMaterial](/api/oM/Analytical/MEP/System/MaterialFragments/LiningMaterial)
    - BH.oM.MEP.System.MaterialFragments.[PipeMaterial](/api/oM/Analytical/MEP/System/MaterialFragments/PipeMaterial)
    - BH.oM.MEP.System.MaterialFragments.[WireMaterial](/api/oM/Analytical/MEP/System/MaterialFragments/WireMaterial)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface IMEPMaterial : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: MEP_oM.dll

The C# interface definition is available on github:

- [IMEPMaterial.cs](https://github.com/BHoM/BHoM/blob/develop/MEP_oM/System\MaterialFragments\IMEPMaterial.cs)

All history and changes of the class can be found by inspection the history.
