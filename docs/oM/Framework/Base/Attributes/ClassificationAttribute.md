---
title: ClassificationAttribute
---

# <small>BH.oM.Base.Attributes.</small>**ClassificationAttribute**

Attribute representing classification of method parameters and object properties, i.e. it tells that a given member is a folder path, quantity etc.

## Class structure

### Implemented interfaces and base types

???+ bhom "The ClassificationAttribute is inheriting from the following base type(s) and implements the following interfaces:"

    -  [Attribute](https://learn.microsoft.com/en-us/dotnet/api/System.Attribute?view=netstandard-2.0)
    -  BH.oM.Base.[IImmutable](/api/oM/Framework/Base/Interface/IImmutable)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes inheriting from this class

??? bhom "The following classes are inheriting from this class:"

    - BH.oM.Base.Attributes.[FilePathAttribute](/api/oM/Framework/Base/Attributes/FilePathAttribute)
    - BH.oM.Base.Attributes.[FolderPathAttribute](/api/oM/Framework/Base/Attributes/FolderPathAttribute)
    - BH.oM.Quantities.Attributes.[AbioticDepletionMineralsAndMetals](/api/oM/Dimensional/Quantities/Attributes/AbioticDepletionMineralsAndMetals)
    - BH.oM.Quantities.Attributes.[AbioticDepletionMineralsAndMetalsPerQuantity](/api/oM/Dimensional/Quantities/Attributes/AbioticDepletionMineralsAndMetalsPerQuantity)
    - BH.oM.Quantities.Attributes.[QuantityAttribute](/api/oM/Dimensional/Quantities/Attributes/Abstract/QuantityAttribute)
    - BH.oM.Quantities.Attributes.[Acceleration](/api/oM/Dimensional/Quantities/Attributes/Acceleration)
    - BH.oM.Quantities.Attributes.[Acidification](/api/oM/Dimensional/Quantities/Attributes/Acidification)
    - BH.oM.Quantities.Attributes.[AcidificationPerQuantity](/api/oM/Dimensional/Quantities/Attributes/AcidificationPerQuantity)
    - BH.oM.Quantities.Attributes.[AirPermeability](/api/oM/Dimensional/Quantities/Attributes/AirPermeability)
    - BH.oM.Quantities.Attributes.[AmountOfSubstance](/api/oM/Dimensional/Quantities/Attributes/AmountOfSubstance)
    - BH.oM.Quantities.Attributes.[Angle](/api/oM/Dimensional/Quantities/Attributes/Angle)
    - BH.oM.Quantities.Attributes.[AngularAcceleration](/api/oM/Dimensional/Quantities/Attributes/AngularAcceleration)
    - BH.oM.Quantities.Attributes.[AngularVelocity](/api/oM/Dimensional/Quantities/Attributes/AngularVelocity)
    - BH.oM.Quantities.Attributes.[Area](/api/oM/Dimensional/Quantities/Attributes/Area)
    - BH.oM.Quantities.Attributes.[AreaPerUnitLength](/api/oM/Dimensional/Quantities/Attributes/AreaPerUnitLength)
    - BH.oM.Quantities.Attributes.[ClimateChange](/api/oM/Dimensional/Quantities/Attributes/ClimateChange)
    - BH.oM.Quantities.Attributes.[ClimateChangePerQuantity](/api/oM/Dimensional/Quantities/Attributes/ClimateChangePerQuantity)
    - BH.oM.Quantities.Attributes.[Density](/api/oM/Dimensional/Quantities/Attributes/Density)
    - BH.oM.Quantities.Attributes.[ElectricConductance](/api/oM/Dimensional/Quantities/Attributes/ElectricConductance)
    - BH.oM.Quantities.Attributes.[ElectricConductivity](/api/oM/Dimensional/Quantities/Attributes/ElectricConductivity)
    - BH.oM.Quantities.Attributes.[ElectricCurrent](/api/oM/Dimensional/Quantities/Attributes/ElectricCurrent)
    - BH.oM.Quantities.Attributes.[Energy](/api/oM/Dimensional/Quantities/Attributes/Energy)
    - BH.oM.Quantities.Attributes.[EnergyPerQuantity](/api/oM/Dimensional/Quantities/Attributes/EnergyPerQuantity)
    - BH.oM.Quantities.Attributes.[EnergyPerUnitArea](/api/oM/Dimensional/Quantities/Attributes/EnergyPerUnitArea)
    - BH.oM.Quantities.Attributes.[EnergyPerUnitTime](/api/oM/Dimensional/Quantities/Attributes/EnergyPerUnitTime)
    - BH.oM.Quantities.Attributes.[EutrophicationAquaticFreshwater](/api/oM/Dimensional/Quantities/Attributes/EutrophicationAquaticFreshwater)
    - BH.oM.Quantities.Attributes.[EutrophicationAquaticFreshwaterPerQuantity](/api/oM/Dimensional/Quantities/Attributes/EutrophicationAquaticFreshwaterPerQuantity)
    - BH.oM.Quantities.Attributes.[EutrophicationAquaticMarine](/api/oM/Dimensional/Quantities/Attributes/EutrophicationAquaticMarine)
    - BH.oM.Quantities.Attributes.[EutrophicationAquaticMarinePerQuantity](/api/oM/Dimensional/Quantities/Attributes/EutrophicationAquaticMarinePerQuantity)
    - BH.oM.Quantities.Attributes.[EutrophicationCML](/api/oM/Dimensional/Quantities/Attributes/EutrophicationCML)
    - BH.oM.Quantities.Attributes.[EutrophicationCMLPerQuantity](/api/oM/Dimensional/Quantities/Attributes/EutrophicationCMLPerQuantity)
    - BH.oM.Quantities.Attributes.[EutrophicationTerrestrial](/api/oM/Dimensional/Quantities/Attributes/EutrophicationTerrestrial)
    - BH.oM.Quantities.Attributes.[EutrophicationTerrestrialPerQuantity](/api/oM/Dimensional/Quantities/Attributes/EutrophicationTerrestrialPerQuantity)
    - BH.oM.Quantities.Attributes.[EutrophicationTRACI](/api/oM/Dimensional/Quantities/Attributes/EutrophicationTRACI)
    - BH.oM.Quantities.Attributes.[EutrophicationTRACIPerQuantity](/api/oM/Dimensional/Quantities/Attributes/EutrophicationTRACIPerQuantity)
    - BH.oM.Quantities.Attributes.[Force](/api/oM/Dimensional/Quantities/Attributes/Force)
    - BH.oM.Quantities.Attributes.[ForcePerUnitLength](/api/oM/Dimensional/Quantities/Attributes/ForcePerUnitLength)
    - BH.oM.Quantities.Attributes.[Frequency](/api/oM/Dimensional/Quantities/Attributes/Frequency)
    - BH.oM.Quantities.Attributes.[Illuminance](/api/oM/Dimensional/Quantities/Attributes/Illuminance)
    - BH.oM.Quantities.Attributes.[Length](/api/oM/Dimensional/Quantities/Attributes/Length)
    - BH.oM.Quantities.Attributes.[LuminousIntensity](/api/oM/Dimensional/Quantities/Attributes/LuminousIntensity)
    - BH.oM.Quantities.Attributes.[Mass](/api/oM/Dimensional/Quantities/Attributes/Mass)
    - BH.oM.Quantities.Attributes.[MassFraction](/api/oM/Dimensional/Quantities/Attributes/MassFraction)
    - BH.oM.Quantities.Attributes.[MassPerUnitArea](/api/oM/Dimensional/Quantities/Attributes/MassPerUnitArea)
    - BH.oM.Quantities.Attributes.[MassPerUnitLength](/api/oM/Dimensional/Quantities/Attributes/MassPerUnitLength)
    - BH.oM.Quantities.Attributes.[Molality](/api/oM/Dimensional/Quantities/Attributes/Molality)
    - BH.oM.Quantities.Attributes.[Molarity](/api/oM/Dimensional/Quantities/Attributes/Molarity)
    - BH.oM.Quantities.Attributes.[Moment](/api/oM/Dimensional/Quantities/Attributes/Moment)
    - BH.oM.Quantities.Attributes.[MomentPerUnitAngle](/api/oM/Dimensional/Quantities/Attributes/MomentPerUnitAngle)
    - BH.oM.Quantities.Attributes.[MomentPerUnitLength](/api/oM/Dimensional/Quantities/Attributes/MomentPerUnitLength)
    - BH.oM.Quantities.Attributes.[OzoneDepletion](/api/oM/Dimensional/Quantities/Attributes/OzoneDepletion)
    - BH.oM.Quantities.Attributes.[OzoneDepletionPerQuantity](/api/oM/Dimensional/Quantities/Attributes/OzoneDepletionPerQuantity)
    - BH.oM.Quantities.Attributes.[PhotochemicalOzoneCreation](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreation)
    - BH.oM.Quantities.Attributes.[PhotochemicalOzoneCreationCML](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationCML)
    - BH.oM.Quantities.Attributes.[PhotochemicalOzoneCreationCMLPerQuantity](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationCMLPerQuantity)
    - BH.oM.Quantities.Attributes.[PhotochemicalOzoneCreationPerQuantity](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationPerQuantity)
    - BH.oM.Quantities.Attributes.[PhotochemicalOzoneCreationTRACI](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACI)
    - BH.oM.Quantities.Attributes.[PhotochemicalOzoneCreationTRACIPerQuantity](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACIPerQuantity)
    - BH.oM.Quantities.Attributes.[Pressure](/api/oM/Dimensional/Quantities/Attributes/Pressure)
    - BH.oM.Quantities.Attributes.[Ratio](/api/oM/Dimensional/Quantities/Attributes/Ratio)
    - BH.oM.Quantities.Attributes.[SecondMomentOfArea](/api/oM/Dimensional/Quantities/Attributes/SecondMomentOfArea)
    - BH.oM.Quantities.Attributes.[SectionModulus](/api/oM/Dimensional/Quantities/Attributes/SectionModulus)
    - BH.oM.Quantities.Attributes.[ShearModulus](/api/oM/Dimensional/Quantities/Attributes/ShearModulus)
    - BH.oM.Quantities.Attributes.[SoundPressureLevel](/api/oM/Dimensional/Quantities/Attributes/SoundPressureLevel)
    - BH.oM.Quantities.Attributes.[SpecificEnergy](/api/oM/Dimensional/Quantities/Attributes/SpecificEnergy)
    - BH.oM.Quantities.Attributes.[Strain](/api/oM/Dimensional/Quantities/Attributes/Strain)
    - BH.oM.Quantities.Attributes.[Stress](/api/oM/Dimensional/Quantities/Attributes/Stress)
    - BH.oM.Quantities.Attributes.[Temperature](/api/oM/Dimensional/Quantities/Attributes/Temperature)
    - BH.oM.Quantities.Attributes.[ThermalExpansionCoefficient](/api/oM/Dimensional/Quantities/Attributes/ThermalExpansionCoefficient)
    - BH.oM.Quantities.Attributes.[ThermalTransmittance](/api/oM/Dimensional/Quantities/Attributes/ThermalTransmittance)
    - BH.oM.Quantities.Attributes.[Time](/api/oM/Dimensional/Quantities/Attributes/Time)
    - BH.oM.Quantities.Attributes.[TorsionConstant](/api/oM/Dimensional/Quantities/Attributes/TorsionConstant)
    - BH.oM.Quantities.Attributes.[Velocity](/api/oM/Dimensional/Quantities/Attributes/Velocity)
    - BH.oM.Quantities.Attributes.[Volume](/api/oM/Dimensional/Quantities/Attributes/Volume)
    - BH.oM.Quantities.Attributes.[VolumePerQuantity](/api/oM/Dimensional/Quantities/Attributes/VolumePerQuantity)
    - BH.oM.Quantities.Attributes.[VolumetricFlowRate](/api/oM/Dimensional/Quantities/Attributes/VolumetricFlowRate)
    - BH.oM.Quantities.Attributes.[WarpingConstant](/api/oM/Dimensional/Quantities/Attributes/WarpingConstant)
    - BH.oM.Quantities.Attributes.[WeightedSoundReductionIndex](/api/oM/Dimensional/Quantities/Attributes/WeightedSoundReductionIndex)
    - BH.oM.Quantities.Attributes.[YoungsModulus](/api/oM/Dimensional/Quantities/Attributes/YoungsModulus)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Name of the method parameter this attribute corresponds to (not relevant in case of object properties). | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| TypeId | [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0) | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Return the custom description of a classification attribute. | - | Reflection_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public abstract class ClassificationAttribute : System.Attribute, BH.oM.Base.IImmutable, BH.oM.Base.IObject
```

Assembly: BHoM.dll

The C# abstract class definition is available on github:

- [ClassificationAttribute.cs](https://github.com/BHoM/BHoM/blob/develop/BHoM/Attributes\ClassificationAttribute.cs)

All history and changes of the class can be found by inspection the history.
