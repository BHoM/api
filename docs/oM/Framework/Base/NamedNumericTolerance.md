---
title: NamedNumericTolerance
---

# <small>BH.oM.Base.</small>**NamedNumericTolerance**

Tolerance used for specific numerical objects or properties with a specific name.When computing Hash or the property Diffing, if the analysed object or property name is found in this collection, the corresponding tolerance is considered.

## Class structure

### Implemented interfaces and base types

???+ bhom "The NamedNumericTolerance is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | When computing Hash or the property Diffing, if the analysed object name or property name is found in this collection, the corresponding tolerance is applied.<br>Supports * wildcard in the property name matching. Examples: <br>	 - `BH.oM.Geometry.Vector`: applies the corresponding tolerance to all numerical properties of Vectors, i.e. X, Y, Z;<br>	 - `BH.oM.Structure.Elements.*.Position`: applies the corresponding tolerance to all numerical properties of properties named `Position` under any Structural Element,<br>	    e.g. Bar.Position.X, Bar.Position.Y, Bar.Position.Z. and at the same time also Node.Position.X, Node.Position.Y, Node.Position.Z. | - |
| Tolerance | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Numeric tolerance. Applies rounding for numbers smaller than this. Defaults to 1E-12. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class NamedNumericTolerance : BH.oM.Base.IObject
```

Assembly: BHoM.dll

The C# class definition is available on github:

- [NamedNumericTolerance.cs](https://github.com/BHoM/BHoM/blob/develop/BHoM/NamedNumericTolerance.cs)

All history and changes of the class can be found by inspection the history.
