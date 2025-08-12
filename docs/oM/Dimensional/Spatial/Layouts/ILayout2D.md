---
title: ILayout2D
---

# <small>BH.oM.Spatial.Layouts.</small>**ILayout2D**

Base interface for all 2D layouts

## Interface structure

### Implemented interfaces and base types

???+ bhom "The ILayout2D is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Spatial.Layouts.[ExplicitLayout](/api/oM/Dimensional/Spatial/Layouts/ExplicitLayout)
    - BH.oM.Spatial.Layouts.[LinearLayout](/api/oM/Dimensional/Spatial/Layouts/LinearLayout)
    - BH.oM.Spatial.Layouts.[MultiLinearLayout](/api/oM/Dimensional/Spatial/Layouts/MultiLinearLayout)
    - BH.oM.Spatial.Layouts.[PerimeterLayout](/api/oM/Dimensional/Spatial/Layouts/PerimeterLayout)


## Properties

### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if an Layout2D is null and outputs relevant error message. | - | Spatial_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface ILayout2D : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: Spatial_oM.dll

The C# interface definition is available on github:

- [ILayout2D.cs](https://github.com/BHoM/BHoM/blob/develop/Spatial_oM/Layouts\ILayout2D.cs)

All history and changes of the class can be found by inspection the history.
