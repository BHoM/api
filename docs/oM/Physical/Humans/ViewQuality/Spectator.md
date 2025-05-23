---
title: Spectator
---

# <small>BH.oM.Humans.ViewQuality.</small>**Spectator**



## Class structure

### Implemented interfaces and base types

???+ bhom "The Spectator is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Humans.[IHumanRole](/api/oM/Physical/Humans/Interfaces/IHumanRole)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Head | [Head](/api/oM/Physical/Humans/BodyParts/Head) | - | - |
| HeadOutline | [Polyline](/api/oM/Dimensional/Geometry/Curve/Polyline) | - | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Cartesian | [Cartesian](/api/oM/Dimensional/Geometry/CoordinateSystem/Cartesian) | Find the orientation of a spectator. | - | Humans_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class Spectator : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.Humans.IHumanRole
```

Assembly: Humans_oM.dll

The C# class definition is available on github:

- [Spectator.cs](https://github.com/BHoM/BHoM/blob/develop/Humans_oM/ViewQuality\Spectator.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Humans_oM/ViewQuality/Spectator.json"
}
```

The JSON Schema is available on github here:

- [Spectator.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Humans_oM/ViewQuality/Spectator.json)
