---
title: IAnalytical
---

# <small>BH.oM.Analytical.</small>**IAnalytical**



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IAnalytical is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - BH.oM.Analytical.Elements.[IEdge](/api/oM/Analytical/Analytical/Elements/IEdge)
    - BH.oM.Analytical.Elements.[IFace](/api/oM/Analytical/Analytical/Elements/IFace)
    - BH.oM.Analytical.Elements.[ILink](/api/oM/Analytical/Analytical/Elements/ILink)&lt;[TNode](/api/oM/Analytical/Analytical/Elements/ILink#tnode)&gt;
    - BH.oM.Analytical.Elements.[IMesh](/api/oM/Analytical/Analytical/Elements/IMesh)&lt;[TNode](/api/oM/Analytical/Analytical/Elements/IMesh#tnode), [TFace](/api/oM/Analytical/Analytical/Elements/IMesh#tface)&gt;
    - BH.oM.Analytical.Elements.[INode](/api/oM/Analytical/Analytical/Elements/INode)
    - BH.oM.Analytical.Elements.[IOpening](/api/oM/Analytical/Analytical/Elements/IOpening)&lt;[TEdge](/api/oM/Analytical/Analytical/Elements/IOpening#tedge)&gt;
    - BH.oM.Analytical.Elements.[IPanel](/api/oM/Analytical/Analytical/Elements/IPanel)&lt;[TEdge](/api/oM/Analytical/Analytical/Elements/IPanel#tedge), [TOpening](/api/oM/Analytical/Analytical/Elements/IPanel#topening)&gt;
    - BH.oM.Analytical.Elements.[IRegion](/api/oM/Analytical/Analytical/Elements/IRegion)
    - BH.oM.Analytical.Elements.[ISurface](/api/oM/Analytical/Analytical/Elements/ISurface)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Architecture.Elements.[CeilingTile](/api/oM/Analytical/Architecture/Elements/CeilingTile)
    - BH.oM.Architecture.Elements.[Room](/api/oM/Analytical/Architecture/Elements/Room)
    - BH.oM.Environment.Elements.[Edge](/api/oM/Analytical/Environment/Elements/Edge)
    - BH.oM.Environment.Elements.[Opening](/api/oM/Analytical/Environment/Elements/Opening)
    - BH.oM.Environment.Elements.[Panel](/api/oM/Analytical/Environment/Elements/Panel)
    - BH.oM.Environment.Elements.[Space](/api/oM/Analytical/Environment/Elements/Space)
    - BH.oM.Environment.Elements.[Zone](/api/oM/Analytical/Environment/Elements/Zone)
    - BH.oM.Environment.Analysis.[Node](/api/oM/Analytical/Environment/Analysis/Node)
    - BH.oM.Facade.Elements.[CurtainWall](/api/oM/Analytical/Facade/Elements/CurtainWall)
    - BH.oM.Facade.Elements.[FrameEdge](/api/oM/Analytical/Facade/Elements/FrameEdge)
    - BH.oM.Facade.Elements.[Opening](/api/oM/Analytical/Facade/Elements/Opening)
    - BH.oM.Facade.Elements.[Panel](/api/oM/Analytical/Facade/Elements/Panel)
    - BH.oM.Lighting.Analysis.[Node](/api/oM/Analytical/Lighting/Analysis/Node)
    - BH.oM.MEP.System.[Node](/api/oM/Analytical/MEP/System/Node)
    - BH.oM.Structure.Reinforcement.[ReinforcementRegion](/api/oM/Analytical/Structure/Reinforcement/ReinforcementRegion)
    - BH.oM.Structure.Elements.[Bar](/api/oM/Analytical/Structure/Elements/Bar)
    - BH.oM.Structure.Elements.[Edge](/api/oM/Analytical/Structure/Elements/Edge)
    - BH.oM.Structure.Elements.[FEMesh](/api/oM/Analytical/Structure/Elements/FEMesh)
    - BH.oM.Structure.Elements.[FEMeshFace](/api/oM/Analytical/Structure/Elements/FEMeshFace)
    - BH.oM.Structure.Elements.[Node](/api/oM/Analytical/Structure/Elements/Node)
    - BH.oM.Structure.Elements.[Opening](/api/oM/Analytical/Structure/Elements/Opening)
    - BH.oM.Structure.Elements.[PadFoundation](/api/oM/Analytical/Structure/Elements/PadFoundation)
    - BH.oM.Structure.Elements.[Panel](/api/oM/Analytical/Structure/Elements/Panel)
    - BH.oM.Structure.Elements.[Stem](/api/oM/Analytical/Structure/Elements/Stem)
    - BH.oM.Structure.Elements.[Surface](/api/oM/Analytical/Structure/Elements/Surface)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface IAnalytical : BH.oM.Base.IObject
```

Assembly: Analytical_oM.dll

The C# interface definition is available on github:

- [IAnalytical.cs](https://github.com/BHoM/BHoM/blob/develop/Analytical_oM/IAnalytical.cs)

All history and changes of the class can be found by inspection the history.
