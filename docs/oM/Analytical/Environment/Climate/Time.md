---
title: Time
---

# Environment.Climate.Time

An environment object used to describe time for climate analysis

## Class structure

### Implemented interfaces and base types

???+ bhom "The Time in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/api_documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/api_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)
    -  Environment.[IClimateObject](/api_documentation/oM/Analytical/Environment/IClimateObject)
    -  Environment.[IEnvironmentObject](/api_documentation/oM/Analytical/Environment/IEnvironmentObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Year | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | A number that represents the year (e.g. 1970) | - |
| Month | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | A number between 1 to 12, where 1 is January | - |
| Day | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | A number between 1 to 31 | - |
| Hour | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | A number between 0 to 23 | - |
| Minute | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | A number between 0 to 59 | - |
| Second | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | A number between 0 to 59 | - |
| Millisecond | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | A number between 0 to 999 | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api_documentation/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Altitude | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the minimum altitude of an Environment Object as the minimum z value from the bounding box of the geometry | - | Environment_Engine |
| AltitudeRange | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the range of altitude of an Environment Object taken as the maximum z value minus minimum z value from the bounding box of the geometry | - | Environment_Engine |
| Bottom | [ICurve](/api_documentation/oM/Dimensional/Geometry/ICurve) | Returns the bottom of a given environment object. | - | Environment_Engine |
| DateTime | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/System.DateTime?view=netstandard-2.0) | Returns the date time object from a Time object | - | Environment_Engine |
| ExplodeToParts | [Output](/api_documentation/oM/Framework/Base/Output%603)&lt;[List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api_documentation/oM/Dimensional/Geometry/ICurve)&gt;, [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api_documentation/oM/Dimensional/Geometry/ICurve)&gt;, [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api_documentation/oM/Dimensional/Geometry/ICurve)&gt;&gt; | Returns the sides, top and bottom of a given environment object. | - | Environment_Engine |
| Height | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the height of a generic Environment Object | - | Environment_Engine |
| Inclination | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the inclination of a generic Environment Object | - | Environment_Engine |
| Orientation | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0)&gt; | Returns the angle to north of a given environmental object on an xyPlane | - | Environment_Engine |
| Polyline | [Polyline](/api_documentation/oM/Dimensional/Geometry/Polyline) | Returns the external boundary from a generic Environment Object | - | Environment_Engine |
| Sides | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api_documentation/oM/Dimensional/Geometry/ICurve)&gt; | Returns the sides of a given environment object. | - | Environment_Engine |
| Tilt | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the tilt of an Environment Object | - | Environment_Engine |
| ToLines | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Line](/api_documentation/oM/Dimensional/Geometry/Line)&gt; | Returns the external boundary from a generic Environment Object | - | Environment_Engine |
| Top | [ICurve](/api_documentation/oM/Dimensional/Geometry/ICurve) | Returns the top of a given environment object. | - | Environment_Engine |
| Width | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the width of a generic Environment Object | - | Environment_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [Time.cs](https://github.com/BHoM/BHoM/blob/develop/Environment_oM/Climate\Time.cs)

All history and changes of the class can be found by inspection the history.
