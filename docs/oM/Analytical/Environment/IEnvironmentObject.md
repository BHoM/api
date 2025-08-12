---
title: IEnvironmentObject
---

# <small>BH.oM.Environment.</small>**IEnvironmentObject**



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IEnvironmentObject is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - BH.oM.Environment.[IClimateObject](/api/oM/Analytical/Environment/Climate/IClimateObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Environment.SpaceCriteria.[Profile](/api/oM/Analytical/Environment/SpaceCriteria/Profile)
    - BH.oM.Environment.SpaceCriteria.[Thermostat](/api/oM/Analytical/Environment/SpaceCriteria/Thermostat)
    - BH.oM.Environment.Elements.[BoundaryZone](/api/oM/Analytical/Environment/Elements/BoundaryZone)
    - BH.oM.Environment.Elements.[Building](/api/oM/Analytical/Environment/Elements/Building)
    - BH.oM.Environment.Elements.[Edge](/api/oM/Analytical/Environment/Elements/Edge)
    - BH.oM.Environment.Elements.[Mesh](/api/oM/Analytical/Environment/Elements/Mesh)
    - BH.oM.Environment.Elements.[Opening](/api/oM/Analytical/Environment/Elements/Opening)
    - BH.oM.Environment.Elements.[Panel](/api/oM/Analytical/Environment/Elements/Panel)
    - BH.oM.Environment.Elements.[Space](/api/oM/Analytical/Environment/Elements/Space)
    - BH.oM.Environment.Climate.[Location](/api/oM/Analytical/Environment/Climate/Location)
    - BH.oM.Environment.Climate.[Sun](/api/oM/Analytical/Environment/Climate/Sun)
    - BH.oM.Environment.Climate.[Time](/api/oM/Analytical/Environment/Climate/Time)


## Properties

### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Altitude | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the minimum altitude of an Environment Object as the minimum z value from the bounding box of the geometry | - | Environment_Engine |
| AltitudeRange | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the range of altitude of an Environment Object taken as the maximum z value minus minimum z value from the bounding box of the geometry | - | Environment_Engine |
| Bottom | [ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve) | Returns the bottom of a given environment object. | - | Environment_Engine |
| ExplodeToParts | [Output](/api/oM/Framework/Base/Output)&lt;[List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve)&gt;, [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve)&gt;, [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve)&gt;&gt; | Returns the sides, top and bottom of a given environment object. | - | Environment_Engine |
| Height | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the height of a generic Environment Object | - | Environment_Engine |
| Inclination | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the inclination of a generic Environment Object | - | Environment_Engine |
| Orientation | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0)&gt; | Returns the angle to north of a given environmental object on an xyPlane | - | Environment_Engine |
| Polyline | [Polyline](/api/oM/Dimensional/Geometry/Curve/Polyline) | Returns the external boundary from a generic Environment Object | - | Environment_Engine |
| Sides | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve)&gt; | Returns the sides of a given environment object. | - | Environment_Engine |
| Tilt | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the tilt of an Environment Object | - | Environment_Engine |
| ToLines | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Line](/api/oM/Dimensional/Geometry/Curve/Line)&gt; | Returns the external boundary from a generic Environment Object | - | Environment_Engine |
| Top | [ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve) | Returns the top of a given environment object. | - | Environment_Engine |
| Width | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the width of a generic Environment Object | - | Environment_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IEnvironmentObject : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: Environment_oM.dll

The C# interface definition is available on github:

- [IEnvironmentObject.cs](https://github.com/BHoM/BHoM/blob/develop/Environment_oM/IEnvironmentObject.cs)

All history and changes of the class can be found by inspection the history.
