---
title: Source
---

# <small>BH.oM.Data.Library.</small>**Source**



## Class structure

### Implemented interfaces and base types

???+ bhom "The Source is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| SourceLink | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Hyperlink or file path to where the source information used can be found. | - |
| Title | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Title of the source. For example Book title, Paper title, Code title etc. | - |
| Author | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Author of the source. | - |
| ItemReference | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Table, figure or code reference etc. | - |
| Version | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Version or edition of the source. | - |
| Publisher | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Publisher of the source. | - |
| Schema | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Schema of the source. | - |
| Language | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Language of the source. | - |
| Location | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Country/Region of the source. | - |
| Copyright | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Any applicable copyright information associated with the source. | - |
| Contributors | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Contributors to the source. | - |
| Confidence | [Confidence](/api/oM/Framework/Data/Library/Confidence) | Level of confidence of the data related to the source. | - |


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
public class Source : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: Data_oM.dll

The C# class definition is available on github:

- [Source.cs](https://github.com/BHoM/BHoM/blob/develop/Data_oM/Library\Source.cs)

All history and changes of the class can be found by inspection the history.
