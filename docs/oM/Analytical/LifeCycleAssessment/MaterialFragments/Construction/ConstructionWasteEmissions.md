---
title: ConstructionWasteEmissions
---

# <small>BH.oM.LifeCycleAssessment.MaterialFragments.Construction.</small>**ConstructionWasteEmissions**

Production, transportation, storage and end-of-life treatment and disposal of any material/waste on-site: transport, waste management and disposal of packaging materials.

## Class structure

### Implemented interfaces and base types

???+ bhom "The ConstructionWasteEmissions is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| WasteRate | [WasteRate](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/Construction/WasteRate) | The waste rate associated with the construction process. This factor is used to compute A5.3 emissions based on outputs for A1 to A4 and C2 to C4 available from either EPD and/or transport as well as disposal factors.<br>This value should be the percentage of material brought to site that goes to waste. This is turned into a waste factor to allow for evaluating based on quantities of the built asset. | - |
| ResuedOnSite | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Whether the material is reused on site, which would reduce the emissions associated with transport and processing. Controls whether the C2 factor for the material should be included or not when computing the emissions based on the A5.3 (waste) factor. Defaults to false, meaning the C2 factor is included. | - |


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
public class ConstructionWasteEmissions : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: LifeCycleAssessment_oM.dll

The C# class definition is available on github:

- [ConstructionWasteEmissions.cs](https://github.com/BHoM/BHoM/blob/develop/LifeCycleAssessment_oM/MaterialFragments\Construction\ConstructionWasteEmissions.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/LifeCycleAssessment_oM/MaterialFragments/Construction/ConstructionWasteEmissions.json"
}
```

The JSON Schema is available on github here:

- [ConstructionWasteEmissions.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/LifeCycleAssessment_oM/MaterialFragments/Construction/ConstructionWasteEmissions.json)
