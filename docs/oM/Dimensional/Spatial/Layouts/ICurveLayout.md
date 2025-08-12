---
title: ICurveLayout
---

# <small>BH.oM.Spatial.Layouts.</small>**ICurveLayout**

Base interface for all curve layouts.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The ICurveLayout is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Spatial.Layouts.[ExplicitCurveLayout](/api/oM/Dimensional/Spatial/Layouts/ExplicitCurveLayout)
    - BH.oM.Spatial.Layouts.[OffsetCurveLayout](/api/oM/Dimensional/Spatial/Layouts/OffsetCurveLayout)


## Properties

### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if an CurveLayout is null and outputs relevant error message. | - | Spatial_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface ICurveLayout : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: Spatial_oM.dll

The C# interface definition is available on github:

- [ICurveLayout.cs](https://github.com/BHoM/BHoM/blob/develop/Spatial_oM/Layouts\ICurveLayout.cs)

All history and changes of the class can be found by inspection the history.
