---
title: CollectionNames
---

# <small>BH.oM.Adapters.Mongo.Requests.</small>**CollectionNames**

Request that gets the name of all collections in a Mongo database.

## Class structure

### Implemented interfaces and base types

???+ bhom "The CollectionNames is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Data.Requests.[IRequest](/api/oM/Framework/Data/Requests/IRequest)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties

### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Discipline | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[Discipline](/api/oM/Adapter/Adapters/Revit/Enums/Discipline)&gt; | Gets discipline enforced by the Request. If the result is different than defaultDiscipline and neither of two is Undefined, null is returned (the result discipline is conflicting with defaultDiscipline). | - | Revit_Engine |
| IFilterDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Returns a description of the filter represented by the given IRequest. | - | Revit_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class CollectionNames : BH.oM.Data.Requests.IRequest, BH.oM.Base.IObject
```

Assembly: Mongo_oM.dll

The C# class definition is available on github:

- [CollectionNames.cs](https://github.com/BHoM/Mongo_Toolkit/blob/develop/Mongo_oM/Requests\CollectionNames.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Mongo_oM/Requests/CollectionNames.json"
}
```

The JSON Schema is available on github here:

- [CollectionNames.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Mongo_oM/Requests/CollectionNames.json)
