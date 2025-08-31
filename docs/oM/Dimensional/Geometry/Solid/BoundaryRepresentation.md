---
title: BoundaryRepresentation
---

# <small>BH.oM.Geometry.</small>**BoundaryRepresentation**

Solid representation defined by a collection of connected surfaces forming a closed volume

## Class structure

### Implemented interfaces and base types

???+ bhom "The BoundaryRepresentation is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Geometry.[ISolid](/api/oM/Dimensional/Geometry/Solid/ISolid)
    -  BH.oM.Geometry.[IGeometry](/api/oM/Dimensional/Geometry/Interface/IGeometry)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Base.[IImmutable](/api/oM/Framework/Base/Interface/IImmutable)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Surfaces | [ReadOnlyCollection](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1?view=netstandard-2.0)&lt;[ISurface](/api/oM/Dimensional/Geometry/Surface/ISurface)&gt; | List of ISurfaces must form a closed volume - checks and guarantees to be performed at conversion | - |
| Volume | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The enclosed volume created by the boundary surfaces. Property is set where available at conversion. If unavailable, or invalidated, will read NaN (not a number) | [Volume](/api/oM/Dimensional/Quantities/Attributes/Volume) [m³] |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| GeometryHash | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Returns a signature of the input geometry, useful for diffing.<br>The hash is computed as a serialised array representing the coordinate of significant points taken on the geometry.<br>The number of points is reduced to the minimum essential to determine uniquely any geometry.<br>Additionally, the resulting points are transformed based on the source geometry type, to remove or minimise collisions.<br>(Any transformation so performed is translational only, in order to support geometrical tolerance, i.e. numerical distance, when comparing GeometryHashes downstream). | - | Geometry_Engine |
| IArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Calculates the area of the provided geometry. | [Area](/api/oM/Dimensional/Quantities/Attributes/Area) [m²] | Geometry_Engine |
| IBounds | [BoundingBox](/api/oM/Dimensional/Geometry/Misc/BoundingBox) | Returns the global world axis oriented enclosing BoundingBox for all points of the geometry, i.e. the box with the smallest volume within which all the points on the geometry lie. | - | Geometry_Engine |
| IHashArray | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0)[] | Returns a signature of the input geometry, useful for distance-based comparisons and diffing.<br>The hash is computed as an array representing the coordinate of significant points taken on the geometry.<br>The number of points is reduced to the minimum essential to determine uniquely any geometry.<br>Additionally, the resulting points are transformed based on the source geometry type, to remove or minimise collisions.<br>(Any transformation so performed is translational only, in order to support geometrical tolerance, i.e. numerical distance, when comparing GeometryHashes downstream). | - | Geometry_Engine |
| IIsPlanar | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if the IGeometry is planar, i.e. all of its parts fit in a single plane. | - | Geometry_Engine |
| IIsValid | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if any IGeometry is valid using dynamic dispatch. | - | Geometry_Engine |
| INormals | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Vector](/api/oM/Dimensional/Geometry/Vector/Vector)&gt; | Interface method that returns the list of vectors normal to any IGeometry. | - | Geometry_Engine |
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a Geometry is null and outputs relevant error message. | - | Geometry_Engine |
| ISubParts | [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netstandard-2.0)&lt;[IGeometry](/api/oM/Dimensional/Geometry/Interface/IGeometry)&gt; | Gets the individual parts that make up any IGeometry. | - | Geometry_Engine |
| IsValid | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if any IGeometry is valid. Currently returns true for all geometries. | - | Geometry_Engine |
| IVolume | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the enclosed volume of a solid. | [Volume](/api/oM/Dimensional/Quantities/Attributes/Volume) [m³] | Geometry_Engine |
| Volume | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the enclosed volume created by the BoundaryRepresentation Surfaces. This value is retrieved from the immutable property stored on the object itself. | [Volume](/api/oM/Dimensional/Quantities/Attributes/Volume) [m³] | Geometry_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class BoundaryRepresentation : BH.oM.Geometry.ISolid, BH.oM.Geometry.IGeometry, BH.oM.Base.IObject, BH.oM.Base.IImmutable
```

Assembly: Geometry_oM.dll

The C# class definition is available on github:

- [BoundaryRepresentation.cs](https://github.com/BHoM/BHoM/blob/develop/Geometry_oM/Solid\BoundaryRepresentation.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Geometry_oM/BoundaryRepresentation.json"
}
```

The JSON Schema is available on github here:

- [BoundaryRepresentation.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Geometry_oM/BoundaryRepresentation.json)
### Example JSON instance

Example JSON instance of type BoundaryRepresentation.

``` json title="Example JSON"
{
  "_t": "BH.oM.Geometry.BoundaryRepresentation",
  "Surfaces": [
    {
      "_t": "BH.oM.Geometry.PlanarSurface",
      "ExternalBoundary": {
        "_t": "BH.oM.Geometry.BoundaryCurve",
        "Curves": {
          "_t": "System.Collections.ObjectModel.ReadOnlyCollection\u00601[[BH.oM.Geometry.ICurve, Geometry_oM, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null]]",
          "_v": [
            {
              "_t": "BH.oM.Geometry.Line",
              "Start": {
                "_t": "BH.oM.Geometry.Point",
                "X": -25.0,
                "Y": 5.0,
                "Z": 0.0
              },
              "End": {
                "_t": "BH.oM.Geometry.Point",
                "X": -25.0,
                "Y": -11.0,
                "Z": 0.0
              },
              "Infinite": false
            },
            {
              "_t": "BH.oM.Geometry.Line",
              "Start": {
                "_t": "BH.oM.Geometry.Point",
                "X": -25.0,
                "Y": -11.0,
                "Z": 0.0
              },
              "End": {
                "_t": "BH.oM.Geometry.Point",
                "X": -25.0,
                "Y": -11.0,
                "Z": 11.0
              },
              "Infinite": false
            },
            {
              "_t": "BH.oM.Geometry.Line",
              "Start": {
                "_t": "BH.oM.Geometry.Point",
                "X": -25.0,
                "Y": -11.0,
                "Z": 11.0
              },
              "End": {
                "_t": "BH.oM.Geometry.Point",
                "X": -25.0,
                "Y": 5.0,
                "Z": 11.0
              },
              "Infinite": false
            },
            {
              "_t": "BH.oM.Geometry.Line",
              "Start": {
                "_t": "BH.oM.Geometry.Point",
                "X": -25.0,
                "Y": 5.0,
                "Z": 11.0
              },
              "End": {
                "_t": "BH.oM.Geometry.Point",
                "X": -25.0,
                "Y": 5.0,
                "Z": 0.0
              },
              "Infinite": false
            }
          ]
        }
      },
      "InternalBoundaries": []
    },
    {
      "_t": "BH.oM.Geometry.PlanarSurface",
      "ExternalBoundary": {
        "_t": "BH.oM.Geometry.BoundaryCurve",
        "Curves": {
          "_t": "System.Collections.ObjectModel.ReadOnlyCollection\u00601[[BH.oM.Geometry.ICurve, Geometry_oM, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null]]",
          "_v": [
            {
              "_t": "BH.oM.Geometry.Line",
              "Start": {
                "_t": "BH.oM.Geometry.Point",
                "X": -25.0,
                "Y": -11.0,
                "Z": 0.0
              },
              "End": {
                "_t": "BH.oM.Geometry.Point",
                "X": -13.0,
                "Y": -11.0,
                "Z": 0.0
              },
              "Infinite": false
            },
            {
              "_t": "BH.oM.Geometry.Line",
              "Start": {
                "_t": "BH.oM.Geometry.Point",
                "X": -13.0,
                "Y": -11.0,
                "Z": 0.0
              },
              "End": {
                "_t": "BH.oM.Geometry.Point",
                "X": -13.0,
                "Y": -11.0,
                "Z": 11.0
              },
              "Infinite": false
            },
            {
              "_t": "BH.oM.Geometry.Line",
              "Start": {
                "_t": "BH.oM.Geometry.Point",
                "X": -13.0,
                "Y": -11.0,
                "Z": 11.0
              },
              "End": {
                "_t": "BH.oM.Geometry.Point",
                "X": -25.0,
                "Y": -11.0,
                "Z": 11.0
              },
              "Infinite": false
            },
            {
              "_t": "BH.oM.Geometry.Line",
              "Start": {
                "_t": "BH.oM.Geometry.Point",
                "X": -25.0,
                "Y": -11.0,
                "Z": 11.0
              },
              "End": {
                "_t": "BH.oM.Geometry.Point",
                "X": -25.0,
                "Y": -11.0,
                "Z": 0.0
              },
              "Infinite": false
            }
          ]
        }
      },
      "InternalBoundaries": []
    },
    {
      "_t": "BH.oM.Geometry.PlanarSurface",
      "ExternalBoundary": {
        "_t": "BH.oM.Geometry.BoundaryCurve",
        "Curves": {
          "_t": "System.Collections.ObjectModel.ReadOnlyCollection\u00601[[BH.oM.Geometry.ICurve, Geometry_oM, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null]]",
          "_v": [
            {
              "_t": "BH.oM.Geometry.Line",
              "Start": {
                "_t": "BH.oM.Geometry.Point",
                "X": -13.0,
                "Y": -11.0,
                "Z": 0.0
              },
              "End": {
                "_t": "BH.oM.Geometry.Point",
                "X": -13.0,
                "Y": 5.0,
                "Z": 0.0
              },
              "Infinite": false
            },
            {
              "_t": "BH.oM.Geometry.Line",
              "Start": {
                "_t": "BH.oM.Geometry.Point",
                "X": -13.0,
                "Y": 5.0,
                "Z": 0.0
              },
              "End": {
                "_t": "BH.oM.Geometry.Point",
                "X": -13.0,
                "Y": 5.0,
                "Z": 11.0
              },
              "Infinite": false
            },
            {
              "_t": "BH.oM.Geometry.Line",
              "Start": {
                "_t": "BH.oM.Geometry.Point",
                "X": -13.0,
                "Y": 5.0,
                "Z": 11.0
              },
              "End": {
                "_t": "BH.oM.Geometry.Point",
                "X": -13.0,
                "Y": -11.0,
                "Z": 11.0
              },
              "Infinite": false
            },
            {
              "_t": "BH.oM.Geometry.Line",
              "Start": {
                "_t": "BH.oM.Geometry.Point",
                "X": -13.0,
                "Y": -11.0,
                "Z": 11.0
              },
              "End": {
                "_t": "BH.oM.Geometry.Point",
                "X": -13.0,
                "Y": -11.0,
                "Z": 0.0
              },
              "Infinite": false
            }
          ]
        }
      },
      "InternalBoundaries": []
    },
    {
      "_t": "BH.oM.Geometry.PlanarSurface",
      "ExternalBoundary": {
        "_t": "BH.oM.Geometry.BoundaryCurve",
        "Curves": {
          "_t": "System.Collections.ObjectModel.ReadOnlyCollection\u00601[[BH.oM.Geometry.ICurve, Geometry_oM, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null]]",
          "_v": [
            {
              "_t": "BH.oM.Geometry.Line",
              "Start": {
                "_t": "BH.oM.Geometry.Point",
                "X": -13.0,
                "Y": 5.0,
                "Z": 0.0
              },
              "End": {
                "_t": "BH.oM.Geometry.Point",
                "X": -25.0,
                "Y": 5.0,
                "Z": 0.0
              },
              "Infinite": false
            },
            {
              "_t": "BH.oM.Geometry.Line",
              "Start": {
                "_t": "BH.oM.Geometry.Point",
                "X": -25.0,
                "Y": 5.0,
                "Z": 0.0
              },
              "End": {
                "_t": "BH.oM.Geometry.Point",
                "X": -25.0,
                "Y": 5.0,
                "Z": 11.0
              },
              "Infinite": false
            },
            {
              "_t": "BH.oM.Geometry.Line",
              "Start": {
                "_t": "BH.oM.Geometry.Point",
                "X": -25.0,
                "Y": 5.0,
                "Z": 11.0
              },
              "End": {
                "_t": "BH.oM.Geometry.Point",
                "X": -13.0,
                "Y": 5.0,
                "Z": 11.0
              },
              "Infinite": false
            },
            {
              "_t": "BH.oM.Geometry.Line",
              "Start": {
                "_t": "BH.oM.Geometry.Point",
                "X": -13.0,
                "Y": 5.0,
                "Z": 11.0
              },
              "End": {
                "_t": "BH.oM.Geometry.Point",
                "X": -13.0,
                "Y": 5.0,
                "Z": 0.0
              },
              "Infinite": false
            }
          ]
        }
      },
      "InternalBoundaries": []
    },
    {
      "_t": "BH.oM.Geometry.PlanarSurface",
      "ExternalBoundary": {
        "_t": "BH.oM.Geometry.BoundaryCurve",
        "Curves": {
          "_t": "System.Collections.ObjectModel.ReadOnlyCollection\u00601[[BH.oM.Geometry.ICurve, Geometry_oM, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null]]",
          "_v": [
            {
              "_t": "BH.oM.Geometry.Line",
              "Start": {
                "_t": "BH.oM.Geometry.Point",
                "X": -25.0,
                "Y": 5.0,
                "Z": 0.0
              },
              "End": {
                "_t": "BH.oM.Geometry.Point",
                "X": -25.0,
                "Y": -11.0,
                "Z": 0.0
              },
              "Infinite": false
            },
            {
              "_t": "BH.oM.Geometry.Line",
              "Start": {
                "_t": "BH.oM.Geometry.Point",
                "X": -25.0,
                "Y": -11.0,
                "Z": 0.0
              },
              "End": {
                "_t": "BH.oM.Geometry.Point",
                "X": -13.0,
                "Y": -11.0,
                "Z": 0.0
              },
              "Infinite": false
            },
            {
              "_t": "BH.oM.Geometry.Line",
              "Start": {
                "_t": "BH.oM.Geometry.Point",
                "X": -13.0,
                "Y": -11.0,
                "Z": 0.0
              },
              "End": {
                "_t": "BH.oM.Geometry.Point",
                "X": -13.0,
                "Y": 5.0,
                "Z": 0.0
              },
              "Infinite": false
            },
            {
              "_t": "BH.oM.Geometry.Line",
              "Start": {
                "_t": "BH.oM.Geometry.Point",
                "X": -13.0,
                "Y": 5.0,
                "Z": 0.0
              },
              "End": {
                "_t": "BH.oM.Geometry.Point",
                "X": -25.0,
                "Y": 5.0,
                "Z": 0.0
              },
              "Infinite": false
            }
          ]
        }
      },
      "InternalBoundaries": []
    },
    {
      "_t": "BH.oM.Geometry.PlanarSurface",
      "ExternalBoundary": {
        "_t": "BH.oM.Geometry.BoundaryCurve",
        "Curves": {
          "_t": "System.Collections.ObjectModel.ReadOnlyCollection\u00601[[BH.oM.Geometry.ICurve, Geometry_oM, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null]]",
          "_v": [
            {
              "_t": "BH.oM.Geometry.Line",
              "Start": {
                "_t": "BH.oM.Geometry.Point",
                "X": -25.0,
                "Y": 5.0,
                "Z": 11.0
              },
              "End": {
                "_t": "BH.oM.Geometry.Point",
                "X": -25.0,
                "Y": -11.0,
                "Z": 11.0
              },
              "Infinite": false
            },
            {
              "_t": "BH.oM.Geometry.Line",
              "Start": {
                "_t": "BH.oM.Geometry.Point",
                "X": -25.0,
                "Y": -11.0,
                "Z": 11.0
              },
              "End": {
                "_t": "BH.oM.Geometry.Point",
                "X": -13.0,
                "Y": -11.0,
                "Z": 11.0
              },
              "Infinite": false
            },
            {
              "_t": "BH.oM.Geometry.Line",
              "Start": {
                "_t": "BH.oM.Geometry.Point",
                "X": -13.0,
                "Y": -11.0,
                "Z": 11.0
              },
              "End": {
                "_t": "BH.oM.Geometry.Point",
                "X": -13.0,
                "Y": 5.0,
                "Z": 11.0
              },
              "Infinite": false
            },
            {
              "_t": "BH.oM.Geometry.Line",
              "Start": {
                "_t": "BH.oM.Geometry.Point",
                "X": -13.0,
                "Y": 5.0,
                "Z": 11.0
              },
              "End": {
                "_t": "BH.oM.Geometry.Point",
                "X": -25.0,
                "Y": 5.0,
                "Z": 11.0
              },
              "Infinite": false
            }
          ]
        }
      },
      "InternalBoundaries": []
    }
  ],
  "Volume": 2112.0,
  "_bhomVersion": "8.2"
}
```

