---
title: BarFEAType
---

# Structure.Elements.BarFEAType

Defines the finite element type of the bar and what forces the bar can accommodate, i.e. if the bar should be treated as a bending element or axial only in analysis packages.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| Flexural |  Full axial, flexural and torsional behaviour. 2 x 6 DOFs.  |
| Axial |  Axial only. 2 x 3 DOFs. Can be used to model pin-pin elements.  |
| CompressionOnly |  Axial compression only. No tension stiffness. 2 x 3 DOFs.  |
| TensionOnly |  Axial tension only. No compression stiffness. 2 x 3 DOFs.  |


## Code and Schema

### C# implementation

The enum is defined in C#. The class definition is available on github:

- [BarFEAType.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/Elements/Enums/BarFEAType.cs)

All history and changes of the class can be found by inspection the history.
