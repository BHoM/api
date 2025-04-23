---
title: BarUniformTemperatureLoad
---

# Structure.Loads.BarUniformTemperatureLoad

Uniform temperature load for Bars.

## Class structure

### Implemented interfaces and base types

???+ bhom "The BarUniformTemperatureLoad in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/api/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api/oM/Framework/Base/IObject)
    -  Structure.Loads.[IElementLoad](/api/oM/Analytical/Structure/Loads/IElementLoad%601)&lt;Structure.Elements.[Bar](/api/oM/Analytical/Structure/Elements/Bar)&gt;
    -  Structure.Loads.[ILoad](/api/oM/Analytical/Structure/Loads/ILoad)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| TemperatureChange | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Uniform temperature change of the Bar. | [Temperature](/api/oM/Dimensional/Quantities/Attributes/Temperature) [K] |
| Loadcase | [Loadcase](/api/oM/Analytical/Structure/Loads/Loadcase) | The Loadcase in which the load is applied. | - |
| Objects | [BHoMGroup](/api/oM/Framework/Base/BHoMGroup%601)&lt;[Bar](/api/oM/Analytical/Structure/Elements/Bar)&gt; | The group of Bars that the load should be applied to. For most analysis packages the objects added here need to be pulled from the analysis package before being assigned to the load. | - |
| Axis | [LoadAxis](/api/oM/Analytical/Structure/Loads/LoadAxis) | Defines whether the load is applied in local or global coordinates. | - |
| Projected | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true the load is projected to the element. This means that the load will be reduced when its direction is at an angle to the element. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a Load is null and outputs relevant error message. | - | Structure_Engine |
| IVisualize | [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netstandard-2.0)&lt;[IGeometry](/api/oM/Dimensional/Geometry/IGeometry)&gt; | Draws arrows representing the load. Visualisation will depend on the load type. | - | Structure_Engine |
| Visualize | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api/oM/Dimensional/Geometry/ICurve)&gt; | Draws lines representing the Bar load over the length of the Bar elements in the load. | - | Structure_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [BarUniformTemperatureLoad.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/Loads\BarUniformTemperatureLoad.cs)

All history and changes of the class can be found by inspection the history.
