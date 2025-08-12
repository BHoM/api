---
title: ScenarioIdentifierAttribute
---

# <small>BH.oM.Analytical.Results.</small>**ScenarioIdentifierAttribute**

Attribute to be assigned to properties of `IResult`-implementing classes. Tagged properties define the scenario in which the result was generated.

## Class structure

### Implemented interfaces and base types

???+ bhom "The ScenarioIdentifierAttribute is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Analytical.Results.[IdentifierAttribute](/api/oM/Analytical/Analytical/Results/Attributes/IdentifierAttribute)
    -  [Attribute](https://learn.microsoft.com/en-us/dotnet/api/System.Attribute?view=netstandard-2.0)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties

### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| TypeId | [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class ScenarioIdentifierAttribute : BH.oM.Analytical.Results.IdentifierAttribute, System.Attribute, BH.oM.Base.IObject
```

Assembly: Analytical_oM.dll

The C# class definition is available on github:

- [ScenarioIdentifierAttribute.cs](https://github.com/BHoM/BHoM/blob/develop/Analytical_oM/Results\Attributes\ScenarioIdentifierAttribute.cs)

All history and changes of the class can be found by inspection the history.
