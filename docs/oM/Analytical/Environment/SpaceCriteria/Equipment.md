---
title: Equipment
---

# <small>BH.oM.Environment.SpaceCriteria.</small>**Equipment**

Equipment gains are defined as the amount of both latent and sensible heat contributed by specified equipment within the space (dishwasher, oven, etc)

## Class structure

### Implemented interfaces and base types

???+ bhom "The Equipment is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Environment.SpaceCriteria.[IGain](/api/oM/Analytical/Environment/SpaceCriteria/IGain)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Sensible | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The sensible heat contributed by equipment, which contributes to a rise in temperature with no change in phase. | - |
| Latent | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The latent heat contributed by equipment, which contributes to a change in phase from solid to liquid. | - |
| Profile | [Profile](/api/oM/Analytical/Environment/SpaceCriteria/Profile) | Profiles depict the time period (hours per day, days per week) during which equipment is contributing heat to the space. | - |
| RadiantFraction | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The radiant fraction depicts the percentage of long wave radiant heat given off by equipment. | - |


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
public class Equipment : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.Environment.SpaceCriteria.IGain
```

Assembly: Environment_oM.dll

The class is defined in C#. The class definition is available on github:

- [Equipment.cs](https://github.com/BHoM/BHoM/blob/develop/Environment_oM/SpaceCriteria\Equipment.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` { .json .copy .select } title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Environment_oM/SpaceCriteria/Equipment.json}
```

The JSON Schema is available on github here:

- [Equipment.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Environment_oM/SpaceCriteria/Equipment.json)
