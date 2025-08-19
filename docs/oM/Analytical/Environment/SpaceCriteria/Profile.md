---
title: Profile
---

# <small>BH.oM.Environment.SpaceCriteria.</small>**Profile**

A profile object represents a gain, thermostat or humdistat as conditions vary over a 24-hour period

## Class structure

### Implemented interfaces and base types

???+ bhom "The Profile is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Environment.[IEnvironmentObject](/api/oM/Analytical/Environment/IEnvironmentObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ProfileType | [ProfileType](/api/oM/Analytical/Environment/SpaceCriteria/Enums/ProfileType) | Profile Type depicts the type of profile (OnOff (0 or 1), ModulatingPercentage (0.0-1.0), or Absolute (-10000 to +10000)) | - |
| ProfileDay | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ProfileDay](/api/oM/Analytical/Environment/SpaceCriteria/Enums/ProfileDay)&gt; | Profile Day depicts the day described in the profile, whether it's a day of the week or a holiday | - |
| HourlyValues | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0)&gt; | Hourly Values denotes the hour-by-hour values for a 24-hour period. These values may be represented in temperature (degrees C) (thermostat), fraction (0.9) (lighting gain), or flow (m3/s) (ventilation) | - |


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
| Altitude | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the minimum altitude of an Environment Object as the minimum z value from the bounding box of the geometry. | - | Environment_Engine |
| AltitudeRange | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the range of altitude of an Environment Object taken as the maximum z value minus minimum z value from the bounding box of the geometry | - | Environment_Engine |
| Bottom | [ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve) | Returns the bottom of a given environment object. | - | Environment_Engine |
| ExplodeToParts | [Output](/api/oM/Framework/Base/Output)&lt;[List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve)&gt;, [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve)&gt;, [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve)&gt;&gt; | Returns the sides, top and bottom of a given environment object. | - | Environment_Engine |
| Height | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the height of a generic Environment Object. | - | Environment_Engine |
| Inclination | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the inclination of a generic Environment Object. | - | Environment_Engine |
| Orientation | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0)&gt; | Returns the angle to north of a given environmental object on an xyPlane. | - | Environment_Engine |
| Polyline | [Polyline](/api/oM/Dimensional/Geometry/Curve/Polyline) | Returns the external boundary from a generic Environment Object. | - | Environment_Engine |
| Sides | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve)&gt; | Returns the sides of a given environment object. | - | Environment_Engine |
| Tilt | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the tilt of an Environment Object. | - | Environment_Engine |
| ToLines | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Line](/api/oM/Dimensional/Geometry/Curve/Line)&gt; | Returns the external boundary from a generic Environment Object | - | Environment_Engine |
| Top | [ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve) | Returns the top of a given environment object. | - | Environment_Engine |
| Width | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the width of a generic Environment Object. | - | Environment_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class Profile : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.Environment.IEnvironmentObject
```

Assembly: Environment_oM.dll

The C# class definition is available on github:

- [Profile.cs](https://github.com/BHoM/BHoM/blob/develop/Environment_oM/SpaceCriteria\Profile.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Environment_oM/SpaceCriteria/Profile.json"
}
```

The JSON Schema is available on github here:

- [Profile.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Environment_oM/SpaceCriteria/Profile.json)
