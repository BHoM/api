---
title: RevisionFragment
---

# <small>BH.oM.Diffing.</small>**RevisionFragment**

Stores the current and previous Hash of the parent BHoMObject, as assigned after the inclusion in a Revision.

## Class structure

### Implemented interfaces and base types

???+ bhom "The RevisionFragment is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IHashFragment](/api/oM/Framework/Base/Interface/IHashFragment)
    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Base.[IImmutable](/api/oM/Framework/Base/Interface/IImmutable)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Hash | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Current object Hash. | - |
| PreviousHash | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Previous object Hash, typically the one it had in its previous Revision. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class RevisionFragment : BH.oM.Base.IHashFragment, BH.oM.Base.IFragment, BH.oM.Base.IObject, BH.oM.Base.IImmutable
```

Assembly: Diffing_oM.dll

The class is defined in C#. The class definition is available on github:

- [RevisionFragment.cs](https://github.com/BHoM/BHoM/blob/develop/Diffing_oM/RevisionFragment.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Diffing_oM/RevisionFragment.json}
```

The JSON Schema is available on github here:

- [RevisionFragment.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Diffing_oM/RevisionFragment.json)
