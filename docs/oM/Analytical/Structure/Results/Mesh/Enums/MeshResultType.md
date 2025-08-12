---
title: MeshResultType
---

# <small>BH.oM.Structure.Results.</small>**MeshResultType**

Specifies which layer the results are extracted from or if it is a maxima/minima of the layers.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| Forces |  Bending moments and shear forces out-of-plane, membrane forces in the plane of the mesh/element.  |
| Stresses |  Stresses in the plane of the mesh/element.  |
| Displacements |  Displacements of the mesh/element nodes.  |
| VonMises |  Von Mises stresses and forces.  |
| MeshModeShape |  Mode shape of the mesh/element nodes.  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum MeshResultType : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: Structure_oM.dll

The C# enum definition is available on github:

- [MeshResultType.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/Results\Mesh\Enums\MeshResultType.cs)

All history and changes of the class can be found by inspection the history.
