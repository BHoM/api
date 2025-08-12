---
title: MeshResultLayer
---

# <small>BH.oM.Structure.Results.</small>**MeshResultLayer**

Specifies which layer the results are extracted from or if it is a maxima/minima of the layers.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| Lower |  Lower surface/extreme fibre of the panel/mesh element.  |
| Middle |  Middle layer of the panel/mesh element.  |
| Upper |  Upper surface/extreme fibre of the panel/mesh element.  |
| Minimum |  The minimum value of all layers in the panel/mesh element.  |
| Maximum |  The maximum value of all layers in the panel/mesh element.  |
| AbsoluteMaximum |  The absolute maximum value of all layers in the panel/mesh element.  |
| Arbitrary |  An arbitrary position within the thickness of the element.  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum MeshResultLayer : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: Structure_oM.dll

The C# enum definition is available on github:

- [MeshResultLayer.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/Results\Mesh\Enums\MeshResultLayer.cs)

All history and changes of the class can be found by inspection the history.
