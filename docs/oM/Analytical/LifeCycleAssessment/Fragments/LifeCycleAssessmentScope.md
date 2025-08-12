---
title: LifeCycleAssessmentScope
---

# <small>BH.oM.LifeCycleAssessment.</small>**LifeCycleAssessmentScope**

The Life Cycle Assessment Scope fragment intends to provide a method of reporting project criteria (name, area, type, location). This object may be used for studies at any stage of development and can serve as a true means of 'apples to apples' comparison when catalogued. The information provided within this object is utilised for database construction and organisation only, therefore all values will not effect the overall life cycle assessment results.

## Class structure

### Implemented interfaces and base types

???+ bhom "The LifeCycleAssessmentScope is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| AdditionalNotes | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Additional notes should convey project design constraints (eg design for seismic activity) that could affect the overall embodied carbon. | - |
| BiogenicCarbon | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Biogenic Carbon is a true/false that indicates that the project contains materials that originated from a biological source (trees, soil), these materials have the ability sequester/store carbon. | - |
| BuildingLifespan | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | The assumed lifespan of the building being evaluated.  These values are for categorisation purposes only and will not effect the overall results. | - |
| ConstructionScopeNew | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Identifies the overall construction scope for the project. Set True if New Construction exists within your project. | - |
| ConstructionScopeRenovation | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Identifies the overall construction scope for the project. Set True if Renovation exists within your project. | - |
| ContactName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The Contact Name denotes the person/people who performed the LCA study. | - |
| GravityStructuralMaterial | [GravityStructuralMaterial](/api/oM/Analytical/LifeCycleAssessment/Enums/GravityStructuralMaterial) | The primary structural system providing gravity support for the building. | - |
| LateralStructuralMaterial | [LateralStructuralMaterial](/api/oM/Analytical/LifeCycleAssessment/Enums/LateralStructuralMaterial) | The primary structural system providing lateral support for the building. | - |
| LevelOfDevelopment | [LevelOfDevelopment](/api/oM/Analytical/LifeCycleAssessment/Enums/LevelOfDevelopment) | Typically a term utilised in BIM practices to clearly identify the scope of work being account for. Equivalents for LOD classifications can offen times be linked to design and construction phases common to the projects locale. | - |
| LifeCycleAssessmentPhases | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Module](/api/oM/Analytical/LifeCycleAssessment/Enums/Module)&gt; | This is a list of life cycle assessment phases to be accounted for within this assessment. These values are for categorisation purposes only and will not effect the overall results. | - |
| ProjectType | [ProjectType](/api/oM/Analytical/LifeCycleAssessment/Enums/ProjectType) | A general classification of the buildings primary function. This value is for categorisation purposes only and will not effect the overall results. | - |
| ProjectName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The Project Name denotes the name of the project for reporting purposes. | - |
| ProjectArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The Project Area (m2) denotes the more precise project area which will allow assessment of kgCO2eq/m2 metrics. | [Area](/api/oM/Dimensional/Quantities/Attributes/Area) [m²] |
| SeismicDesignCategory | [SeismicDesignCategory](/api/oM/Analytical/LifeCycleAssessment/Enums/SeismicDesignCategory) | Seismic Design Category is a classification assigned to a structure based on it's occupancy category, and the severity of the design earthquake ground motion. These categories are currently in reference to ASCE 7-05. | - |
| WindSpeedCategory | [WindSpeedCategory](/api/oM/Analytical/LifeCycleAssessment/Enums/WindSpeedCategory) | Wind speed category is in reference to the Beaufort Scale of wind speeds. Values are arranged from 0-12 equivalent, 0 being Calm and 12 being Hurricane, and are used only to represent an average site-based, wind condition. Specific informaion on categorisation can be found at https://www.spc.noaa.gov/faq/tornado/beaufort.html | - |
| Location | [Location](/api/oM/Analytical/Environment/Climate/Location) | Provide the projects geographic location for database organisation purposes. This value is for categorisation purposes only and will not effect the overall results. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class LifeCycleAssessmentScope : BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: LifeCycleAssessment_oM.dll

The C# class definition is available on github:

- [LifeCycleAssessmentScope.cs](https://github.com/BHoM/BHoM/blob/develop/LifeCycleAssessment_oM/Fragments\LifeCycleAssessmentScope.cs)

All history and changes of the class can be found by inspection the history.
