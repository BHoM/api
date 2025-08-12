---
title: IRequest
---

# <small>BH.oM.Data.Requests.</small>**IRequest**



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IRequest is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - BH.oM.Data.Requests.[ILogicalRequest](/api/oM/Framework/Data/Requests/ILogicalRequest)
    - BH.oM.Data.Requests.[IResultRequest](/api/oM/Framework/Data/Requests/IResultRequest)
    - BH.oM.Structure.Requests.[IStructuralResultRequest](/api/oM/Analytical/Structure/Requests/IStructuralResultRequest)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Data.Requests.[BatchRequest](/api/oM/Framework/Data/Requests/BatchRequest)
    - BH.oM.Data.Requests.[CustomRequest](/api/oM/Framework/Data/Requests/CustomRequest)
    - BH.oM.Data.Requests.[FilterRequest](/api/oM/Framework/Data/Requests/FilterRequest)
    - BH.oM.Data.Requests.[LogicalAndRequest](/api/oM/Framework/Data/Requests/LogicalAndRequest)
    - BH.oM.Data.Requests.[LogicalNotRequest](/api/oM/Framework/Data/Requests/LogicalNotRequest)
    - BH.oM.Data.Requests.[LogicalOrRequest](/api/oM/Framework/Data/Requests/LogicalOrRequest)
    - BH.oM.Data.Requests.[SelectionRequest](/api/oM/Framework/Data/Requests/SelectionRequest)
    - BH.oM.Structure.Requests.[BarResultRequest](/api/oM/Analytical/Structure/Requests/BarResultRequest)
    - BH.oM.Structure.Requests.[GlobalResultRequest](/api/oM/Analytical/Structure/Requests/GlobalResultRequest)
    - BH.oM.Structure.Requests.[MeshResultRequest](/api/oM/Analytical/Structure/Requests/MeshResultRequest)
    - BH.oM.Structure.Requests.[NodeResultRequest](/api/oM/Analytical/Structure/Requests/NodeResultRequest)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface IRequest : BH.oM.Base.IObject
```

Assembly: Data_oM.dll

The C# interface definition is available on github:

- [IRequest.cs](https://github.com/BHoM/BHoM/blob/develop/Data_oM/Requests\IRequest.cs)

All history and changes of the class can be found by inspection the history.
