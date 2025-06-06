---
title: Node
---

# <small>BH.oM.Structure.Elements.</small>**Node**

0D finite element for structural analysis. Node class contains positional information as well as orientation and support.

## Class structure

### Implemented interfaces and base types

???+ bhom "The Node is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Dimensional.[IElement0D](/api/oM/Dimensional/Dimensional/IElement0D)
    -  BH.oM.Dimensional.[IElement](/api/oM/Dimensional/Dimensional/IElement)
    -  BH.oM.Analytical.Elements.[INode](/api/oM/Analytical/Analytical/Elements/INode)
    -  BH.oM.Analytical.[IAnalytical](/api/oM/Analytical/Analytical/IAnalytical)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Position | [Point](/api/oM/Dimensional/Geometry/Vector/Point) | Position of the node in global Cartesian 3D space. | - |
| Orientation | [Basis](/api/oM/Dimensional/Geometry/Vector/Basis) | Local x, y, and z axes of the node as a vector Basis. Defaults to null which is interpretated to defaults when pushed to software and world axes in BHoM. | - |
| Support | [Constraint6DOF](/api/oM/Analytical/Structure/Constraints/Constraint6DOF) | Defines the Support property of the Node. If not set, the Node will be assumed to be free to translate and rotate. | - |


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
| Bounds | [BoundingBox](/api/oM/Dimensional/Geometry/Misc/BoundingBox) | Queries the IElement0Ds BoundingBox. Acts on the Point definition of the IElement0D through the Geometry_Engine. | - | Spatial_Engine |
| Centroid | [Point](/api/oM/Dimensional/Geometry/Vector/Point) | Queries the centre of weight for the homogeneous geometrical representation of an IElement0D. Always returns the point location due to zero-dimensionality of an IElement0D. | - | Spatial_Engine |
| ControlPoints | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api/oM/Dimensional/Geometry/Vector/Point)&gt; | Queries the control points of the geometrical representation of an IElement0D. Always returns the point location due to zero-dimensionality of an IElement0D. | - | Spatial_Engine |
| CoordinateSystem | [Cartesian](/api/oM/Dimensional/Geometry/CoordinateSystem/Cartesian) | Get the carteseian coordinate system descibring the position and local orientation of the node in the global coordinate system. | - | Structure_Engine |
| ElementCurves | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve)&gt; | Queries the defining curves of an IElement0D. Always returns empty collection due to zero-dimensionality of an IElement0D. | - | Spatial_Engine |
| ElementVertices | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api/oM/Dimensional/Geometry/Vector/Point)&gt; | Returns the point from the IElement0D. Mainly to accomodate the interface method. | - | Spatial_Engine |
| Geometry | [Point](/api/oM/Dimensional/Geometry/Vector/Point) | Gets the geometry of a INode as a Point. Method required for automatic display in UI packages. | - | Analytical_Engine |
| IArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Queries the area of the geometrical representation of an IElement. | [Area](/api/oM/Dimensional/Quantities/Attributes/Area) [m²] | Spatial_Engine |
| IBounds | [BoundingBox](/api/oM/Dimensional/Geometry/Misc/BoundingBox) | Queries the IElements BoundingBox. Acts on the elements geometrical definition of the IElement through the Geometry_Engine. | - | Spatial_Engine |
| ICentroid | [Point](/api/oM/Dimensional/Geometry/Vector/Point) | Queries the centre of weight for the homogeneous geometrical representation of an IElement. | - | Spatial_Engine |
| IControlPoints | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api/oM/Dimensional/Geometry/Vector/Point)&gt; | Queries the control points of the geometrical representation of an IElement. | - | Spatial_Engine |
| IElementCurves | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve)&gt; | Queries the geometricly defining curves of the IElements geometry. | - | Spatial_Engine |
| IElementVertices | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api/oM/Dimensional/Geometry/Vector/Point)&gt; | Returns the discontinuity points from the defining ICurves of the IElement. | - | Spatial_Engine |
| IGeometry | [Point](/api/oM/Dimensional/Geometry/Vector/Point) | Queries the defining geometrical object which all spatial operations will act on. | - | Spatial_Engine |
| IIsPlanar | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks whether all control points of an element lie in a single plane. | - | Spatial_Engine |
| IIsSelfIntersecting | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if any of the curves defining an IElement is closer to itself than the tolerance at any two points (is self intersecting). In case of IElement2D, does not check for intersections between external and internal curves, or between different internal curves. | - | Spatial_Engine |
| IsConstrained | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Method checks if a Node has a Support assigned. | - | Structure_Engine |
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a Node or its defining properties are null and outputs relevant error message. | - | Structure_Engine |
| IsPlanar | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks whether all control points of an element lie in a single plane. | - | Spatial_Engine |
| IsSelfIntersecting | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if the one dimensional representation of the IElement0D is closer to itself than the tolerance at any two points. Always false because a zero-dimensional IElement0D does not consist of curves. | - | Spatial_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class Node : BH.oM.Base.BHoMObject,
BH.oM.Base.IBHoMObject,
BH.oM.Base.IObject,
BH.oM.Dimensional.IElement0D,
BH.oM.Dimensional.IElement,
BH.oM.Analytical.Elements.INode,
BH.oM.Analytical.IAnalytical
```

Assembly: Structure_oM.dll

The C# class definition is available on github:

- [Node.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/Elements\Node.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Structure_oM/Elements/Node.json"
}
```

The JSON Schema is available on github here:

- [Node.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Structure_oM/Elements/Node.json)
### Example JSON instance

Example JSON instance of type Node.

``` json title="Example JSON"
{
  "_t": "BH.oM.Structure.Elements.Node",
  "Position": {
    "_t": "BH.oM.Geometry.Point",
    "X": 0.0,
    "Y": 0.0,
    "Z": 0.0
  },
  "Orientation": {
    "_t": "BH.oM.Geometry.Basis",
    "X": {
      "_t": "BH.oM.Geometry.Vector",
      "X": 1.0,
      "Y": 0.0,
      "Z": 0.0
    },
    "Y": {
      "_t": "BH.oM.Geometry.Vector",
      "X": 0.0,
      "Y": 1.0,
      "Z": 0.0
    },
    "Z": {
      "_t": "BH.oM.Geometry.Vector",
      "X": 0.0,
      "Y": 0.0,
      "Z": 1.0
    }
  },
  "Support": {
    "_t": "BH.oM.Structure.Constraints.Constraint6DOF",
    "Name": null,
    "TranslationalStiffnessX": 0.0,
    "TranslationalStiffnessY": 0.0,
    "TranslationalStiffnessZ": 0.0,
    "RotationalStiffnessX": 0.0,
    "RotationalStiffnessY": 0.0,
    "RotationalStiffnessZ": 0.0,
    "TranslationX": "Free",
    "TranslationY": "Free",
    "TranslationZ": "Free",
    "RotationX": "Free",
    "RotationY": "Free",
    "RotationZ": "Free",
    "BHoM_Guid": "454affc3-0278-43d4-aebc-cac58138507e"
  },
  "BHoM_Guid": "b621fff3-59f5-4bde-8823-cd6f364abd25",
  "Name": "Node Name",
  "_bhomVersion": "8.2"
}
```

