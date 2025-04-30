---
title: IsNotNull
---

# <small>BH.oM.Verification.Conditions.</small>**IsNotNull**

Condition that verifies whether an object is null.

## Class structure

### Implemented interfaces and base types

???+ bhom "The IsNotNull is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Verification.Conditions.[ICondition](/api/oM/Framework/Verification/Conditions/Interfaces/ICondition)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties

### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| INestedConditions | [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netstandard-2.0)&lt;[ICondition](/api/oM/Framework/Verification/Conditions/Interfaces/ICondition)&gt; | Extracts the conditions nested inside a given condition, e.g. conditions nested inside logical conditions. | - | Verification_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class IsNotNull : BH.oM.Verification.Conditions.ICondition, BH.oM.Base.IObject
```

Assembly: Verification_oM.dll

The class is defined in C#. The class definition is available on github:

- [IsNotNull.cs](https://github.com/BHoM/BHoM/blob/develop/Verification_oM/Conditions\IsNotNull.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Verification_oM/Conditions/IsNotNull.json}
```

The JSON Schema is available on github here:

- [IsNotNull.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Verification_oM/Conditions/IsNotNull.json)
