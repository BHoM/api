---
title: WasteAndDisposalFactors
---

# <small>BH.oM.LifeCycleAssessment.MaterialFragments.EndOfLife.</small>**WasteAndDisposalFactors**

WasteAndDisposalFactors defines the end of life waste processing and disposal factors to be applied to the material fragment. These factors are applied in addition to any end of life factors provided by an Environmental Product Declaration, and can be used to fill gaps where no EPD data is available. If applied this will help populate all CLimate change metrics available, with LandUseFactor being set to 0.

## Class structure

### Implemented interfaces and base types

???+ bhom "The WasteAndDisposalFactors is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| FossilWasteFactor | [FossilWasteFactor](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EndOfLife/FossilWasteFactor) | Factor used to compute the Fossil climate change impacts. | - |
| OverrideEpdValue | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Controls whether the value should override a potentially pre-existing value on the Environmental Product Declaration. If true, the factor above takes president, if false, the value above is only added if no C3 or C4 factors already have been computed. | - |
| CancelOutBiogenicCarbon | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true, the C3toC4 value for ClimateChangeBiogenic will be set to the negative value of A1 (if present) or A1toA3 to cancel out any benefits given in those phases. If false, this value will be assumed to be 0, and all emissions for the disposal modules related to Fossil. Works under the same premise as the OverrideEpdValue toggle. | - |


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
public class WasteAndDisposalFactors : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: LifeCycleAssessment_oM.dll

The C# class definition is available on github:

- [WasteAndDisposalFactors.cs](https://github.com/BHoM/BHoM/blob/develop/LifeCycleAssessment_oM/MaterialFragments\EndOfLife\WasteAndDisposalFactors.cs)

All history and changes of the class can be found by inspection the history.
