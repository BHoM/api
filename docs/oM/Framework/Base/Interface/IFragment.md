---
title: IFragment
---

# <small>BH.oM.Base.</small>**IFragment**

Describes objects that can exist independently or can be attached to other BHoM objects as part of their `FragmentSet` property.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IFragment is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - BH.oM.Analytical.Fragments.[IDependencyFragment](/api/oM/Analytical/Analytical/Fragments/IDependencyFragment)
    - BH.oM.Analytical.Fragments.[IProjectionFragment](/api/oM/Analytical/Analytical/Fragments/IProjectionFragment)
    - BH.oM.Base.[IAdapterId](/api/oM/Framework/Base/Interface/IAdapterId)
    - BH.oM.Base.[IHashFragment](/api/oM/Framework/Base/Interface/IHashFragment)
    - BH.oM.Base.[IPersistentAdapterId](/api/oM/Framework/Base/Interface/IPersistentAdapterId)
    - BH.oM.Environment.MaterialFragments.[IEnvironmentMaterial](/api/oM/Analytical/Environment/MaterialFragments/IEnvironmentMaterial)
    - BH.oM.Graphics.Fragments.[IRepresentationFragment](/api/oM/Graphics/Graphics/Fragments/IRepresentationFragment)
    - BH.oM.MEP.System.MaterialFragments.[IInsulationMaterial](/api/oM/Analytical/MEP/System/MaterialFragments/IInsulationMaterial)
    - BH.oM.Structure.MaterialFragments.[IIsotropic](/api/oM/Analytical/Structure/MaterialFragments/IIsotropic)
    - BH.oM.Structure.MaterialFragments.[IMaterialFragment](/api/oM/Analytical/Structure/MaterialFragments/IMaterialFragment)
    - BH.oM.Structure.MaterialFragments.[IOrthotropic](/api/oM/Analytical/Structure/MaterialFragments/IOrthotropic)
    - BH.oM.Structure.MaterialFragments.[ITimber](/api/oM/Analytical/Structure/MaterialFragments/ITimber)


### Classes implementing this interface

??? bhom "The following classes are implementing this interface:"

    - BH.oM.Analytical.Fragments.[ProjectionFragment](/api/oM/Analytical/Analytical/Fragments/ProjectionFragment)
    - BH.oM.Analytical.Fragments.[RoutingFragment](/api/oM/Analytical/Analytical/Fragments/RoutingFragment)
    - BH.oM.Analytical.Fragments.[SourcesDependencyFragment](/api/oM/Analytical/Analytical/Fragments/SourcesDependencyFragment)
    - BH.oM.Analytical.Fragments.[TargetsDependencyFragment](/api/oM/Analytical/Analytical/Fragments/TargetsDependencyFragment)
    - BH.oM.Base.[HashFragment](/api/oM/Framework/Base/HashFragment)
    - BH.oM.Diffing.[RevisionFragment](/api/oM/Framework/Diffing/RevisionFragment)
    - BH.oM.Environment.MaterialFragments.[GasMaterial](/api/oM/Analytical/Environment/MaterialFragments/GasMaterial)
    - BH.oM.Environment.MaterialFragments.[SolidMaterial](/api/oM/Analytical/Environment/MaterialFragments/SolidMaterial)
    - BH.oM.Environment.Fragments.[AnalyticalConstruction](/api/oM/Analytical/Environment/Fragments/AnalyticalConstruction)
    - BH.oM.Environment.Fragments.[BuildingAnalyticalFragment](/api/oM/Analytical/Environment/Fragments/BuildingAnalyticalFragment)
    - BH.oM.Environment.Fragments.[BuildingContextFragment](/api/oM/Analytical/Environment/Fragments/BuildingContextFragment)
    - BH.oM.Environment.Fragments.[BuildingResultFragment](/api/oM/Analytical/Environment/Fragments/BuildingResultFragment)
    - BH.oM.Environment.Fragments.[CoefficientFragment](/api/oM/Analytical/Environment/Fragments/CoefficientFragment)
    - BH.oM.Environment.Fragments.[EnvironmentConstructionFragment](/api/oM/Analytical/Environment/Fragments/EnvironmentConstructionFragment)
    - BH.oM.Environment.Fragments.[LightReflectanceFragment](/api/oM/Analytical/Environment/Fragments/LightReflectanceFragment)
    - BH.oM.Environment.Fragments.[LightTransmittanceFragment](/api/oM/Analytical/Environment/Fragments/LightTransmittanceFragment)
    - BH.oM.Environment.Fragments.[LoadFragment](/api/oM/Analytical/Environment/Fragments/LoadFragment)
    - BH.oM.Environment.Fragments.[OriginContextFragment](/api/oM/Analytical/Environment/Fragments/OriginContextFragment)
    - BH.oM.Environment.Fragments.[PanelAnalyticalFragment](/api/oM/Analytical/Environment/Fragments/PanelAnalyticalFragment)
    - BH.oM.Environment.Fragments.[PanelContextFragment](/api/oM/Analytical/Environment/Fragments/PanelContextFragment)
    - BH.oM.Environment.Fragments.[RadiationFragment](/api/oM/Analytical/Environment/Fragments/RadiationFragment)
    - BH.oM.Environment.Fragments.[SpaceAnalyticalFragment](/api/oM/Analytical/Environment/Fragments/SpaceAnalyticalFragment)
    - BH.oM.Environment.Fragments.[SpaceContextFragment](/api/oM/Analytical/Environment/Fragments/SpaceContextFragment)
    - BH.oM.Facade.Fragments.[ConstructionOffset](/api/oM/Analytical/Facade/Fragments/ConstructionOffset)
    - BH.oM.Facade.Fragments.[FrameExtensionBox](/api/oM/Analytical/Facade/Fragments/FrameExtensionBox)
    - BH.oM.Facade.Fragments.[GlazingLocation](/api/oM/Analytical/Facade/Fragments/GlazingLocation)
    - BH.oM.Facade.Fragments.[PsiGlassEdge](/api/oM/Analytical/Facade/Fragments/PsiGlassEdge)
    - BH.oM.Facade.Fragments.[PsiJoint](/api/oM/Analytical/Facade/Fragments/PsiJoint)
    - BH.oM.Facade.Fragments.[UValueCavity](/api/oM/Analytical/Facade/Fragments/UValueCavity)
    - BH.oM.Facade.Fragments.[UValueContinuous](/api/oM/Analytical/Facade/Fragments/UValueContinuous)
    - BH.oM.Facade.Fragments.[UValueFrame](/api/oM/Analytical/Facade/Fragments/UValueFrame)
    - BH.oM.Facade.Fragments.[UValueGlassCentre](/api/oM/Analytical/Facade/Fragments/UValueGlassCentre)
    - BH.oM.Facade.Fragments.[UValueGlassEdge](/api/oM/Analytical/Facade/Fragments/UValueGlassEdge)
    - BH.oM.Graphics.[ColourFragment](/api/oM/Graphics/Graphics/Colours/ColourFragment)
    - BH.oM.Graphics.[RenderMesh](/api/oM/Graphics/Graphics/Render/RenderMesh)
    - BH.oM.Graphics.Fragments.[EntityRepresentation](/api/oM/Graphics/Graphics/Fragments/EntityRepresentation)
    - BH.oM.Graphics.Fragments.[GraphRepresentation](/api/oM/Graphics/Graphics/Fragments/GraphRepresentation)
    - BH.oM.Graphics.Fragments.[GroupRepresentation](/api/oM/Graphics/Graphics/Fragments/GroupRepresentation)
    - BH.oM.Graphics.Fragments.[RelationRepresentation](/api/oM/Graphics/Graphics/Fragments/RelationRepresentation)
    - BH.oM.LifeCycleAssessment.[LifeCycleAssessmentScope](/api/oM/Analytical/LifeCycleAssessment/Fragments/LifeCycleAssessmentScope)
    - BH.oM.LifeCycleAssessment.[Scope](/api/oM/Analytical/LifeCycleAssessment/Fragments/Scope)
    - BH.oM.LifeCycleAssessment.Fragments.[AdditionalEPDData](/api/oM/Analytical/LifeCycleAssessment/Fragments/AdditionalEPDData)
    - BH.oM.LifeCycleAssessment.Fragments.[EPDDensity](/api/oM/Analytical/LifeCycleAssessment/Fragments/EPDDensity)
    - BH.oM.MEP.System.MaterialFragments.[InsulationMaterial](/api/oM/Analytical/MEP/System/MaterialFragments/InsulationMaterial)
    - BH.oM.MEP.System.MaterialFragments.[LiningMaterial](/api/oM/Analytical/MEP/System/MaterialFragments/LiningMaterial)
    - BH.oM.MEP.Fragments.[GeometryFragment](/api/oM/Analytical/MEP/Fragments/GeometryFragment)
    - BH.oM.MEP.Fragments.[IdentityFragment](/api/oM/Analytical/MEP/Fragments/IdentityFragment)
    - BH.oM.MEP.Fragments.[PlumbingFlowFragment](/api/oM/Analytical/MEP/Fragments/PlumbingFlowFragment)
    - BH.oM.MEP.Fragments.[PlumbingLoadingFixtureUnitFragment](/api/oM/Analytical/MEP/Fragments/PlumbingLoadingFixtureUnitFragment)
    - BH.oM.Physical.Reinforcement.[ReinforcementFragment](/api/oM/Physical/Physical/Reinforcement/ReinforcementFragment)
    - BH.oM.Physical.Materials.[VolumetricMaterialTakeoff](/api/oM/Physical/Physical/Materials/VolumetricMaterialTakeoff)
    - BH.oM.Structure.Reinforcement.[PanelRebarIntent](/api/oM/Analytical/Structure/Reinforcement/PanelRebarIntent)
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
    - BH.oM.Structure.Fragments.[ReinforcementDensity](/api/oM/Analytical/Structure/Fragments/ReinforcementDensity)
    - BH.oM.Structure.Fragments.[SectionModifier](/api/oM/Analytical/Structure/Fragments/SectionModifier)
    - BH.oM.Structure.Fragments.[SurfacePropertyModifier](/api/oM/Analytical/Structure/Fragments/SurfacePropertyModifier)
    - BH.oM.Test.Adapter.[TestAdapterId](/api/oM/Framework/Test/Adapter/TestAdapterId)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface IFragment : BH.oM.Base.IObject
```

Assembly: BHoM.dll

The C# interface definition is available on github:

- [IFragment.cs](https://github.com/BHoM/BHoM/blob/develop/BHoM/Interface\IFragment.cs)

All history and changes of the class can be found by inspection the history.
