---
title: SingleTransportModeImpact
---

# <small>BH.oM.LifeCycleAssessment.MaterialFragments.Transport.</small>**SingleTransportModeImpact**

Class for computing Transport emissions for a particular part of journey to site.

## Class structure

### Implemented interfaces and base types

???+ bhom "The SingleTransportModeImpact is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.LifeCycleAssessment.MaterialFragments.Transport.[ITransportFactors](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/Transport/ITransportFactors)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| VehicleEmissions | [VehicleEmissions](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/Transport/VehicleEmissions) | Emissions for the vechicle for the particular part of the journey. | - |
| DistanceTraveled | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Total distance transported with the particular vehicle. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| Factor | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Factor applied to the resulting emission for this single mode transport. Resulting value will be multiplied by this factor. Mainly used for creating end of life routes where parts of the material will be going to different facilities. | - |


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
public class SingleTransportModeImpact : BH.oM.Base.BHoMObject,
BH.oM.Base.IBHoMObject,
BH.oM.Base.IObject,
BH.oM.LifeCycleAssessment.MaterialFragments.Transport.ITransportFactors
```

Assembly: LifeCycleAssessment_oM.dll

The C# class definition is available on github:

- [SingleTransportModeImpact.cs](https://github.com/BHoM/BHoM/blob/develop/LifeCycleAssessment_oM/MaterialFragments\Transport\SingleTransportModeImpact.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/LifeCycleAssessment_oM/MaterialFragments/Transport/SingleTransportModeImpact.json"
}
```

The JSON Schema is available on github here:

- [SingleTransportModeImpact.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/LifeCycleAssessment_oM/MaterialFragments/Transport/SingleTransportModeImpact.json)
