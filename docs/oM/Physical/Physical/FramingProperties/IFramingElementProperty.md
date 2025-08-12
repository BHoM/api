---
title: IFramingElementProperty
---

# <small>BH.oM.Physical.FramingProperties.</small>**IFramingElementProperty**



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IFramingElementProperty is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Physical.FramingProperties.[ConstantFramingProperty](/api/oM/Physical/Physical/FramingProperties/ConstantFramingProperty)


## Properties

### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IAverageProfileArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the average cross-section area of a IFramingElementProperty in such a way that multiplying with the length of the element would give the volume | [Area](/api/oM/Dimensional/Quantities/Attributes/Area) [m²] | Physical_Engine |
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a IFramingElementProperty is null and outputs relevant error message. | - | Physical_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IFramingElementProperty : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: Physical_oM.dll

The C# interface definition is available on github:

- [IFramingElementProperty.cs](https://github.com/BHoM/BHoM/blob/develop/Physical_oM/FramingProperties\IFramingElementProperty.cs)

All history and changes of the class can be found by inspection the history.
