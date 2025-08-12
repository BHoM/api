---
title: IContaminantProperty
---

# <small>BH.oM.Ground.</small>**IContaminantProperty**

Base interface for contaminant properties.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IContaminantProperty is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Ground.[AnalysisProperties](/api/oM/Analytical/Ground/ContaminantProperties/AnalysisProperties)
    - BH.oM.Ground.[ContaminantReference](/api/oM/Analytical/Ground/ContaminantProperties/ContaminantReference)
    - BH.oM.Ground.[DetectionProperties](/api/oM/Analytical/Ground/ContaminantProperties/DetectionProperties)
    - BH.oM.Ground.[ResultProperties](/api/oM/Analytical/Ground/ContaminantProperties/ResultProperties)
    - BH.oM.Ground.[TestProperties](/api/oM/Analytical/Ground/ContaminantProperties/TestProperties)


## Properties

### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IsValid | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a IContaminantProperty is valid and outputs relevant error message. | - | Ground_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IContaminantProperty : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: Ground_oM.dll

The C# interface definition is available on github:

- [IContaminantProperty.cs](https://github.com/BHoM/BHoM/blob/develop/Ground_oM/ContaminantProperties\IContaminantProperty.cs)

All history and changes of the class can be found by inspection the history.
