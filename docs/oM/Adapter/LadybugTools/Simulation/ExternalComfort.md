---
title: ExternalComfort
---

# <small>BH.oM.LadybugTools.</small>**ExternalComfort**



## Class structure

### Implemented interfaces and base types

???+ bhom "The ExternalComfort is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.LadybugTools.[ILadybugTools](/api/oM/Adapter/LadybugTools/ILadybugTools)
    -  BH.oM.Base.[IImmutable](/api/oM/Framework/Base/Interface/IImmutable)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| SimulationResult | [SimulationResult](/api/oM/Adapter/LadybugTools/Simulation/SimulationResult) | The SimulationResult associated with this object. | - |
| Typology | [Typology](/api/oM/Adapter/LadybugTools/Simulation/Typology) | The typology in the processing of this object. | - |
| DryBulbTemperature | [HourlyContinuousCollection](/api/oM/Adapter/LadybugTools/Collections/HourlyContinuousCollection) | The calculated dry bulb temperature. | - |
| RelativeHumidity | [HourlyContinuousCollection](/api/oM/Adapter/LadybugTools/Collections/HourlyContinuousCollection) | The calculated relative humidity. | - |
| WindSpeed | [HourlyContinuousCollection](/api/oM/Adapter/LadybugTools/Collections/HourlyContinuousCollection) | The calculated wind speed. | - |
| MeanRadiantTemperature | [HourlyContinuousCollection](/api/oM/Adapter/LadybugTools/Collections/HourlyContinuousCollection) | The calculated mean radiant temperature. | - |
| UniversalThermalClimateIndex | [HourlyContinuousCollection](/api/oM/Adapter/LadybugTools/Collections/HourlyContinuousCollection) | The calculated universal thermal climate index. | - |


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
public class ExternalComfort : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.LadybugTools.ILadybugTools, BH.oM.Base.IImmutable
```

Assembly: LadybugTools_oM.dll

The C# class definition is available on github:

- [ExternalComfort.cs](https://github.com/BHoM/LadybugTools_Toolkit/blob/develop/LadybugTools_oM/Simulation\ExternalComfort.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/LadybugTools_oM/ExternalComfort.json"
}
```

The JSON Schema is available on github here:

- [ExternalComfort.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/LadybugTools_oM/ExternalComfort.json)
