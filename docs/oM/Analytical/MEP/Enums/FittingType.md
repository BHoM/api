---
title: FittingType
---

# <small>BH.oM.MEP.Enums.</small>**FittingType**

A type of fitting used to transition from one segment of linear MEP object to another.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| Undefined |  -  |
| Adapter |  A fitting that allows you to change the size/shape of the linear MEP segment at a given juncture.  |
| Cap |  A fitting that is placed at the end of a linear MEP segment.  |
| Coupling |  A fitting that joins two linear MEP segments of the same size and shape.  |
| Cross |  A fitting that physically connects four different linear MEP segments, each at 90-degree angles.  |
| Elbow |  A fitting that physically connects two different linear MEP segments, and re-directs the segment at a 30,45,60 or 90-degree angle.  |
| Olet |  A fitting that allows you to change the size of the linear MEP segment at a given juncture, and gives additional reinforcement to both segments.  |
| Plug |  A fitting that is placed at the end of a linear MEP segment, allowing future access for maintenance purposes (clean out).  |
| Reducer |  A fitting that allows you to change the size of the linear MEP segment at a given juncture.  |
| Tap |  A fitting that keeps the main linear MEP segment size the same and allows a 45-degree transition to a 90-degree branch.  |
| Transition |  A fitting that allows you to change size and/or shape along the main linear MEP segment .  |
| Tee |  A fitting that keeps the main linear MEP segment size the same and allows a branch at a 90-degree angle.  |
| Union |  A fitting that joins two linear MEP segments of the same size and shape, of which each end can be unscrewed independently.  |
| Wye |  A fitting that joins three linear MEP segments of differing sizes and shapes, also known as pants.  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum FittingType : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: MEP_oM.dll

The C# enum definition is available on github:

- [FittingType.cs](https://github.com/BHoM/BHoM/blob/develop/MEP_oM/Enums\FittingType.cs)

All history and changes of the class can be found by inspection the history.
