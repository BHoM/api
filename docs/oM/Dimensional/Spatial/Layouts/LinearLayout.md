---
title: LinearLayout
---

# <small>BH.oM.Spatial.Layouts.</small>**LinearLayout**

Linear distribution of points along a vector from one side of the perimeter of the host object to the other.

## Class structure

### Implemented interfaces and base types

???+ bhom "The LinearLayout is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Spatial.Layouts.[ILayout2D](/api/oM/Dimensional/Spatial/Layouts/ILayout2D)
    -  BH.oM.Base.[IImmutable](/api/oM/Framework/Base/Interface/IImmutable)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| NumberOfPoints | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Number of points along the axis. | - |
| Direction | [Vector](/api/oM/Dimensional/Geometry/Vector/Vector) | Direction of the axis. Vector should lie in the XY-plane, i.e. have a Z-coordinate equal to 0. | - |
| Offset | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Offset of the linear layout in relation to the reference point, perpendicular to the Direction vector in the XY plane.<br>A positive value will mean an offset towards the centre of the boundingbox of the host objects. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| ReferencePoint | [ReferencePoint](/api/oM/Dimensional/Spatial/Layouts/Enums/ReferencePoint) | Controls which point on the host element that should be used for the layout. | - |


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
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if an Layout2D is null and outputs relevant error message. | - | Spatial_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class LinearLayout : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.Spatial.Layouts.ILayout2D, BH.oM.Base.IImmutable
```

Assembly: Spatial_oM.dll

The C# class definition is available on github:

- [LinearLayout.cs](https://github.com/BHoM/BHoM/blob/develop/Spatial_oM/Layouts\LinearLayout.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Spatial_oM/Layouts/LinearLayout.json"
}
```

The JSON Schema is available on github here:

- [LinearLayout.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Spatial_oM/Layouts/LinearLayout.json)
