---
title: EPDDensity
---

# <small>BH.oM.LifeCycleAssessment.Fragments.</small>**EPDDensity**

A data fragment used to store Density values if provided from the EPD source. 
Density is a required property for all Evaluations of EPDs with Mass-QuantityType.Density can be changed by the user by adding this fragment to an EPD. 
The user accepts responsibility for any changes beyond the given dataset information as not all EPDs will contain Density values.

## Class structure

### Implemented interfaces and base types

???+ bhom "The EPDDensity is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Density | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The material density in kg/m^3. | [Density](/api/oM/Dimensional/Quantities/Attributes/Density) [kg/m³] |


## Code and Schema

### C# implementation

``` C# title="C#"
public class EPDDensity : BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: LifeCycleAssessment_oM.dll

The C# class definition is available on github:

- [EPDDensity.cs](https://github.com/BHoM/BHoM/blob/develop/LifeCycleAssessment_oM/Fragments\EPDDensity.cs)

All history and changes of the class can be found by inspection the history.
