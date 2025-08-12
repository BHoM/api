---
title: DensityExtractionOptions
---

# <small>BH.oM.Matter.Options.</small>**DensityExtractionOptions**

Settings for extraction of Density from a List of IDensityProviders.

## Class structure

### Implemented interfaces and base types

???+ bhom "The DensityExtractionOptions is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Type | [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=netstandard-2.0) | A specific type of IDensityProvider to limit the search to. If null all IDensityProviders on the material are considered.<br>Errors will be raised if the type provided is not a IDensityProvider type. | - |
| AllowFallbackIfNoType | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true, and material does not contain a IDensityProvider of the specified type, DensityExtraction falls back to look for other densities. If false and material does not contain the type DensityExtraction exits. | - |
| ExtractionType | [DensityExtractionType](/api/oM/Dimensional/Matter/Options/Enums/DensityExtractionType) | - | - |
| EqualTolerance | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The ratio tolerance for considering the value of the densities as equal. Density values are deemed equal if (max - min / mean) is smaller than this value, where mean = (max + min)/2, i.e. a tolerance of 0.01 means an allowable difference of 1% normalised to the mean value of found densities. | [Ratio](/api/oM/Dimensional/Quantities/Attributes/Ratio) [-] |
| IgnoreZeroValues | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Ignores densities of 0 if true when computing average or checking for equality. | - |
| ZeroTolerance | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Threshold for density values to be seen as 0. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class DensityExtractionOptions : BH.oM.Base.IObject
```

Assembly: Matter_oM.dll

The C# class definition is available on github:

- [DensityExtractionOptions.cs](https://github.com/BHoM/BHoM/blob/develop/Matter_oM/Options\DensityExtractionOptions.cs)

All history and changes of the class can be found by inspection the history.
