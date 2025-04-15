---
title: LoadCombination
---

# Structure.Loads.LoadCombination

Load combination class to set up combination of factored Loadcases.

## Class structure

### Implemented interfaces and base types

???+ bhom "The LoadCombination in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/documentation/oM/Framework/Base/IObject)
    -  Structure.Loads.[ICase](/documentation/oM/Analytical/Structure/Loads/ICase)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | A unique Name is required for some structural packages to create and identify the object. | - |
| LoadCases | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Tuple](https://learn.microsoft.com/en-us/dotnet/api/System.Tuple-2?view=netstandard-2.0)&lt;[double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0), [ICase](/documentation/oM/Analytical/Structure/Loads/ICase)&gt;&gt; | The factored Loadcases that make up the combination. Stored as a collection of Tuple&lt;double,ICase&gt; where the double is the factor the case should be scaled by in this combination. | - |
| Number | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Unique numeric identifier of the LoadCombination. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/documentation/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a Case is null and outputs relevant error message. | - | Structure_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [LoadCombination.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/Loads\LoadCombination.cs)

All history and changes of the class can be found by inspection the history.
