---
title: FireProtection
---

# <small>BH.oM.Environment.SpaceCriteria.</small>**FireProtection**

The fire protection attributes of a space are indicative of the hazard level of the space (which influences the sprinkler count), the sprinkler system type required, and the presence of combustible materials or sloped ceilings.

## Class structure

### Implemented interfaces and base types

???+ bhom "The FireProtection is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| HazardType | [HazardType](/api/oM/Analytical/Environment/SpaceCriteria/Enums/HazardType) | Hazard Type indicates the combustibility of the materials within the space (Light, Ordinary or Extra). The indication of hazard type also determines the density of sprinklers required within the space. | - |
| SprinklerSystemType | [SprinklerSystemType](/api/oM/Analytical/Environment/SpaceCriteria/Enums/SprinklerSystemType) | Sprinkler System Type indicates whether the system will need to accommodate spaces that are subject to freezing (dry system type, commonly used in loading docks and parking garages), spaces that contain materials that when on fire would be spread further by water (foam system type, commonly used in a diesel generator room), spaces that contain precious materials that would be ruined by a false trip of the sprinkler system (preaction, commonly used in art galleries.)  | - |
| CombustibleMaterials | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | The presence of combustible materials in the space would indicate the potential need for increasing the hazard type within the space. | - |
| SlopedCeiling | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | The presence of a sloped ceiling within the space would indicate the potential need for the area of the ceiling being calculated as if it were flat (i.e. the space would require more sprinklers than by area alone.) | - |
| MaximumCeilingTemperature | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The maximum ceiling temperature indicates the temperature rating, classification and color of the sprinklers within the space. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class FireProtection : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: Environment_oM.dll

The C# class definition is available on github:

- [FireProtection.cs](https://github.com/BHoM/BHoM/blob/develop/Environment_oM/SpaceCriteria\FireProtection.cs)

All history and changes of the class can be found by inspection the history.
