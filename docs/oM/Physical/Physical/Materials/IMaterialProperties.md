---
title: IMaterialProperties
---

# <small>BH.oM.Physical.Materials.</small>**IMaterialProperties**



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IMaterialProperties is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - BH.oM.Environment.MaterialFragments.[IEnvironmentMaterial](/api/oM/Analytical/Environment/MaterialFragments/IEnvironmentMaterial)
    - BH.oM.MEP.System.MaterialFragments.[IInsulationMaterial](/api/oM/Analytical/MEP/System/MaterialFragments/IInsulationMaterial)
    - BH.oM.Physical.Materials.[IDensityProvider](/api/oM/Physical/Physical/Materials/IDensityProvider)
    - BH.oM.Structure.MaterialFragments.[IIsotropic](/api/oM/Analytical/Structure/MaterialFragments/IIsotropic)
    - BH.oM.Structure.MaterialFragments.[IMaterialFragment](/api/oM/Analytical/Structure/MaterialFragments/IMaterialFragment)
    - BH.oM.Structure.MaterialFragments.[IOrthotropic](/api/oM/Analytical/Structure/MaterialFragments/IOrthotropic)
    - BH.oM.Structure.MaterialFragments.[ITimber](/api/oM/Analytical/Structure/MaterialFragments/ITimber)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Environment.MaterialFragments.[GasMaterial](/api/oM/Analytical/Environment/MaterialFragments/GasMaterial)
    - BH.oM.Environment.MaterialFragments.[SolidMaterial](/api/oM/Analytical/Environment/MaterialFragments/SolidMaterial)
    - BH.oM.LifeCycleAssessment.MaterialFragments.[CombinedLifeCycleAssessmentFactors](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/CombinedLifeCycleAssessmentFactors)
    - BH.oM.LifeCycleAssessment.MaterialFragments.[EnvironmentalProductDeclaration](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalProductDeclaration)
    - BH.oM.MEP.System.MaterialFragments.[DuctMaterial](/api/oM/Analytical/MEP/System/MaterialFragments/DuctMaterial)
    - BH.oM.MEP.System.MaterialFragments.[InsulationMaterial](/api/oM/Analytical/MEP/System/MaterialFragments/InsulationMaterial)
    - BH.oM.MEP.System.MaterialFragments.[LiningMaterial](/api/oM/Analytical/MEP/System/MaterialFragments/LiningMaterial)
    - BH.oM.MEP.System.MaterialFragments.[PipeMaterial](/api/oM/Analytical/MEP/System/MaterialFragments/PipeMaterial)
    - BH.oM.MEP.System.MaterialFragments.[WireMaterial](/api/oM/Analytical/MEP/System/MaterialFragments/WireMaterial)
    - BH.oM.Structure.MaterialFragments.[Aluminium](/api/oM/Analytical/Structure/MaterialFragments/Aluminium)
    - BH.oM.Structure.MaterialFragments.[Concrete](/api/oM/Analytical/Structure/MaterialFragments/Concrete)
    - BH.oM.Structure.MaterialFragments.[GenericIsotropicMaterial](/api/oM/Analytical/Structure/MaterialFragments/GenericIsotropicMaterial)
    - BH.oM.Structure.MaterialFragments.[GenericOrthotropicMaterial](/api/oM/Analytical/Structure/MaterialFragments/GenericOrthotropicMaterial)
    - BH.oM.Structure.MaterialFragments.[Glulam](/api/oM/Analytical/Structure/MaterialFragments/Glulam)
    - BH.oM.Structure.MaterialFragments.[LaminatedVeneerLumberCrossbands](/api/oM/Analytical/Structure/MaterialFragments/LaminatedVeneerLumberCrossbands)
    - BH.oM.Structure.MaterialFragments.[LaminatedVeneerLumberParallel](/api/oM/Analytical/Structure/MaterialFragments/LaminatedVeneerLumberParallel)
    - BH.oM.Structure.MaterialFragments.[SawnTimber](/api/oM/Analytical/Structure/MaterialFragments/SawnTimber)
    - BH.oM.Structure.MaterialFragments.[Steel](/api/oM/Analytical/Structure/MaterialFragments/Steel)
    - BH.oM.Structure.MaterialFragments.[Timber](/api/oM/Analytical/Structure/MaterialFragments/Timber)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface IMaterialProperties : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: Physical_oM.dll

The C# interface definition is available on github:

- [IMaterialProperties.cs](https://github.com/BHoM/BHoM/blob/develop/Physical_oM/Materials\IMaterialProperties.cs)

All history and changes of the class can be found by inspection the history.
