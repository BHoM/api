---
title: IProperty
---

# <small>BH.oM.Structure.</small>**IProperty**

Base interface for all structural properties.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IProperty is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - BH.oM.Structure.SurfaceProperties.[ISurfaceProperty](/api/oM/Analytical/Structure/SurfaceProperties/ISurfaceProperty)
    - BH.oM.Structure.SectionProperties.[IGeometricalSection](/api/oM/Analytical/Structure/SectionProperties/IGeometricalSection)
    - BH.oM.Structure.SectionProperties.[ISectionProperty](/api/oM/Analytical/Structure/SectionProperties/ISectionProperty)
    - BH.oM.Structure.SectionProperties.[ISteelSection](/api/oM/Analytical/Structure/SectionProperties/ISteelSection)
    - BH.oM.Structure.MaterialFragments.[IIsotropic](/api/oM/Analytical/Structure/MaterialFragments/IIsotropic)
    - BH.oM.Structure.MaterialFragments.[IMaterialFragment](/api/oM/Analytical/Structure/MaterialFragments/IMaterialFragment)
    - BH.oM.Structure.MaterialFragments.[IOrthotropic](/api/oM/Analytical/Structure/MaterialFragments/IOrthotropic)
    - BH.oM.Structure.MaterialFragments.[ITimber](/api/oM/Analytical/Structure/MaterialFragments/ITimber)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Structure.SurfaceProperties.[BiDirectionalVoided](/api/oM/Analytical/Structure/SurfaceProperties/BiDirectionalVoided)
    - BH.oM.Structure.SurfaceProperties.[BuiltUpDoubleRibbed](/api/oM/Analytical/Structure/SurfaceProperties/BuiltUpDoubleRibbed)
    - BH.oM.Structure.SurfaceProperties.[BuiltUpRibbed](/api/oM/Analytical/Structure/SurfaceProperties/BuiltUpRibbed)
    - BH.oM.Structure.SurfaceProperties.[Cassette](/api/oM/Analytical/Structure/SurfaceProperties/Cassette)
    - BH.oM.Structure.SurfaceProperties.[ConstantThickness](/api/oM/Analytical/Structure/SurfaceProperties/ConstantThickness)
    - BH.oM.Structure.SurfaceProperties.[CorrugatedDeck](/api/oM/Analytical/Structure/SurfaceProperties/CorrugatedDeck)
    - BH.oM.Structure.SurfaceProperties.[HollowCore](/api/oM/Analytical/Structure/SurfaceProperties/HollowCore)
    - BH.oM.Structure.SurfaceProperties.[Layered](/api/oM/Analytical/Structure/SurfaceProperties/Layered)
    - BH.oM.Structure.SurfaceProperties.[LoadingPanelProperty](/api/oM/Analytical/Structure/SurfaceProperties/LoadingPanelProperty)
    - BH.oM.Structure.SurfaceProperties.[OneDirectionalVoided](/api/oM/Analytical/Structure/SurfaceProperties/OneDirectionalVoided)
    - BH.oM.Structure.SurfaceProperties.[Ribbed](/api/oM/Analytical/Structure/SurfaceProperties/Ribbed)
    - BH.oM.Structure.SurfaceProperties.[SlabOnDeck](/api/oM/Analytical/Structure/SurfaceProperties/SlabOnDeck)
    - BH.oM.Structure.SurfaceProperties.[ToppedSlab](/api/oM/Analytical/Structure/SurfaceProperties/ToppedSlab)
    - BH.oM.Structure.SurfaceProperties.[Waffle](/api/oM/Analytical/Structure/SurfaceProperties/Waffle)
    - BH.oM.Structure.SectionProperties.[AluminiumSection](/api/oM/Analytical/Structure/SectionProperties/AluminiumSection)
    - BH.oM.Structure.SectionProperties.[CableSection](/api/oM/Analytical/Structure/SectionProperties/CableSection)
    - BH.oM.Structure.SectionProperties.[CellularSection](/api/oM/Analytical/Structure/SectionProperties/CellularSection)
    - BH.oM.Structure.SectionProperties.[CompositeSection](/api/oM/Analytical/Structure/SectionProperties/CompositeSection)
    - BH.oM.Structure.SectionProperties.[ConcreteSection](/api/oM/Analytical/Structure/SectionProperties/ConcreteSection)
    - BH.oM.Structure.SectionProperties.[ExplicitSection](/api/oM/Analytical/Structure/SectionProperties/ExplicitSection)
    - BH.oM.Structure.SectionProperties.[GenericSection](/api/oM/Analytical/Structure/SectionProperties/GenericSection)
    - BH.oM.Structure.SectionProperties.[SteelSection](/api/oM/Analytical/Structure/SectionProperties/SteelSection)
    - BH.oM.Structure.SectionProperties.[TimberSection](/api/oM/Analytical/Structure/SectionProperties/TimberSection)
    - BH.oM.Structure.Offsets.[Offset](/api/oM/Analytical/Structure/Offsets/Offset)
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
    - BH.oM.Structure.Constraints.[BarRelease](/api/oM/Analytical/Structure/Constraints/BarRelease)
    - BH.oM.Structure.Constraints.[Constraint3DOF](/api/oM/Analytical/Structure/Constraints/Constraint3DOF)
    - BH.oM.Structure.Constraints.[Constraint4DOF](/api/oM/Analytical/Structure/Constraints/Constraint4DOF)
    - BH.oM.Structure.Constraints.[Constraint6DOF](/api/oM/Analytical/Structure/Constraints/Constraint6DOF)
    - BH.oM.Structure.Constraints.[LinkConstraint](/api/oM/Analytical/Structure/Constraints/LinkConstraint)


## Properties

### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| DescriptionOrName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Gets the name from a IProperty. If null or empty, a default description name is provided instead. | - | Structure_Engine |
| IDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Generates a default description for the IProperty, based on its properties. | - | Structure_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IProperty : BH.oM.Base.IObject
```

Assembly: Structure_oM.dll

The C# interface definition is available on github:

- [IProperty.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/IProperty.cs)

All history and changes of the class can be found by inspection the history.
