---
title: ILoad
---

# <small>BH.oM.Structure.Loads.</small>**ILoad**

Base interface implemented by all load classes.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The ILoad is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - BH.oM.Structure.Loads.[IElementLoad](/api/oM/Analytical/Structure/Loads/IElementLoad)&lt;[T](/api/oM/Analytical/Structure/Loads/IElementLoad#t)&gt;


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Structure.Loads.[AreaDifferentialTemperatureLoad](/api/oM/Analytical/Structure/Loads/AreaDifferentialTemperatureLoad)
    - BH.oM.Structure.Loads.[AreaUniformlyDistributedLoad](/api/oM/Analytical/Structure/Loads/AreaUniformlyDistributedLoad)
    - BH.oM.Structure.Loads.[AreaUniformTemperatureLoad](/api/oM/Analytical/Structure/Loads/AreaUniformTemperatureLoad)
    - BH.oM.Structure.Loads.[BarDifferentialTemperatureLoad](/api/oM/Analytical/Structure/Loads/BarDifferentialTemperatureLoad)
    - BH.oM.Structure.Loads.[BarPointLoad](/api/oM/Analytical/Structure/Loads/BarPointLoad)
    - BH.oM.Structure.Loads.[BarPrestressLoad](/api/oM/Analytical/Structure/Loads/BarPrestressLoad)
    - BH.oM.Structure.Loads.[BarUniformlyDistributedLoad](/api/oM/Analytical/Structure/Loads/BarUniformlyDistributedLoad)
    - BH.oM.Structure.Loads.[BarUniformTemperatureLoad](/api/oM/Analytical/Structure/Loads/BarUniformTemperatureLoad)
    - BH.oM.Structure.Loads.[BarVaryingDistributedLoad](/api/oM/Analytical/Structure/Loads/BarVaryingDistributedLoad)
    - BH.oM.Structure.Loads.[ContourLoad](/api/oM/Analytical/Structure/Loads/ContourLoad)
    - BH.oM.Structure.Loads.[GeometricalLineLoad](/api/oM/Analytical/Structure/Loads/GeometricalLineLoad)
    - BH.oM.Structure.Loads.[GravityLoad](/api/oM/Analytical/Structure/Loads/GravityLoad)
    - BH.oM.Structure.Loads.[PointAcceleration](/api/oM/Analytical/Structure/Loads/PointAcceleration)
    - BH.oM.Structure.Loads.[PointDisplacement](/api/oM/Analytical/Structure/Loads/PointDisplacement)
    - BH.oM.Structure.Loads.[PointLoad](/api/oM/Analytical/Structure/Loads/PointLoad)
    - BH.oM.Structure.Loads.[PointVelocity](/api/oM/Analytical/Structure/Loads/PointVelocity)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Loadcase | [Loadcase](/api/oM/Analytical/Structure/Loads/Loadcase) | The Loadcase in which the load is applied. | - |
| Axis | [LoadAxis](/api/oM/Analytical/Structure/Loads/Enums/LoadAxis) | Defines whether the load is applied in local or global coordinates. | - |
| Projected | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true the load is projected along to the element. This means that the load will be reduced when its direction is at an angle to the element. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a Load is null and outputs relevant error message. | - | Structure_Engine |
| IVisualize | [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netstandard-2.0)&lt;[IGeometry](/api/oM/Dimensional/Geometry/Interface/IGeometry)&gt; | Draws arrows representing the load. Visualisation will depend on the load type. | - | Structure_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface ILoad : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: Structure_oM.dll

The C# interface definition is available on github:

- [ILoad.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/Loads\ILoad.cs)

All history and changes of the class can be found by inspection the history.
