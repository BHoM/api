---
title: PlumbingFixtureFlow
---

# <small>BH.oM.MEP.Fixtures.</small>**PlumbingFixtureFlow**

Flow properties of a plumbing fixture

## Class structure

### Implemented interfaces and base types

???+ bhom "The PlumbingFixtureFlow is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.MEP.Fixtures.[IFixtureFlow](/api/oM/Analytical/MEP/Fixtures/IFixtureFlow)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ClothesWasherVolumePerUse | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Volume of fluid supplied to a clothes washer per use through the plumbing fixture. | [Volume](/api/oM/Dimensional/Quantities/Attributes/Volume) [m³] |
| DishWasherVolumePerUse | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Volume of fluid supplied to a dish washer per use through the plumbing fixture. | [Volume](/api/oM/Dimensional/Quantities/Attributes/Volume) [m³] |
| KitchenFaucetAssumedUse | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Duration of use measured in seconds. | [Time](/api/oM/Dimensional/Quantities/Attributes/Time) [s] |
| KitchenFaucetVolumePerUse | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Volume of fluid supplied to a kitchen faucet per use through the plumbing fixture. | [Volume](/api/oM/Dimensional/Quantities/Attributes/Volume) [m³] |
| LavatoryAssumedUse | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Duration of use measured in seconds. | [Time](/api/oM/Dimensional/Quantities/Attributes/Time) [s] |
| LavatoryVolumePerUse | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Volume of fluid supplied to a lavatory per use through the plumbing fixture. | [Volume](/api/oM/Dimensional/Quantities/Attributes/Volume) [m³] |
| ShowerVolumePerUse | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Volume of fluid supplied to a people washer per use through the plumbing fixture. | [Volume](/api/oM/Dimensional/Quantities/Attributes/Volume) [m³] |
| ShowerAssumedUse | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Duration of use measured in seconds. | [Time](/api/oM/Dimensional/Quantities/Attributes/Time) [s] |
| ToiletVolumePerUse | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Volume of fluid supplied to a toilet per use through the plumbing fixture. | [Volume](/api/oM/Dimensional/Quantities/Attributes/Volume) [m³] |
| UrinalVolumePerUse | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Volume of fluid supplied to a urinal per use through the plumbing fixture. | [Volume](/api/oM/Dimensional/Quantities/Attributes/Volume) [m³] |


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
public class PlumbingFixtureFlow : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.MEP.Fixtures.IFixtureFlow
```

Assembly: MEP_oM.dll

The C# class definition is available on github:

- [PlumbingFixtureFlow.cs](https://github.com/BHoM/BHoM/blob/develop/MEP_oM/Fixtures\PlumbingFixtureFlow.cs)

All history and changes of the class can be found by inspection the history.
