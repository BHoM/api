---
title: IntegrationSlice
---

# <small>BH.oM.Geometry.</small>**IntegrationSlice**

Describes a discrete finite slice of an area. Used for numerical approximation of an integration.

## Class structure

### Implemented interfaces and base types

???+ bhom "The IntegrationSlice is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Width | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| Length | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| Centre | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| Placement | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0)[] | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class IntegrationSlice : BH.oM.Base.IObject
```

Assembly: Geometry_oM.dll

The C# class definition is available on github:

- [IntegrationSlice.cs](https://github.com/BHoM/BHoM/blob/develop/Geometry_oM/Math\IntegrationSlice.cs)

All history and changes of the class can be found by inspection the history.
