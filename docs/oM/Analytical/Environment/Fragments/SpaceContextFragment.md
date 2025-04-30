---
title: SpaceContextFragment
---

# <small>BH.oM.Environment.Fragments.</small>**SpaceContextFragment**

Fragment containing space context properties (e.g. is external facing, colour, connected elements)

## Class structure

### Implemented interfaces and base types

???+ bhom "The SpaceContextFragment is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| IsExternal | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Defines wheather the space is externally facing | - |
| Colour | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| ConnectedElements | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | A collection of the elements which enclose the space | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class SpaceContextFragment : BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: Environment_oM.dll

The class is defined in C#. The class definition is available on github:

- [SpaceContextFragment.cs](https://github.com/BHoM/BHoM/blob/develop/Environment_oM/Fragments\SpaceContextFragment.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` { .json .copy .select } title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Environment_oM/Fragments/SpaceContextFragment.json}
```

The JSON Schema is available on github here:

- [SpaceContextFragment.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Environment_oM/Fragments/SpaceContextFragment.json)
