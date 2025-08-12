---
title: ILogicalRequest
---

# <small>BH.oM.Data.Requests.</small>**ILogicalRequest**



## Interface structure

### Implemented interfaces and base types

???+ bhom "The ILogicalRequest is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Data.Requests.[IRequest](/api/oM/Framework/Data/Requests/IRequest)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Data.Requests.[LogicalAndRequest](/api/oM/Framework/Data/Requests/LogicalAndRequest)
    - BH.oM.Data.Requests.[LogicalNotRequest](/api/oM/Framework/Data/Requests/LogicalNotRequest)
    - BH.oM.Data.Requests.[LogicalOrRequest](/api/oM/Framework/Data/Requests/LogicalOrRequest)


## Properties

### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IRequests | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IRequest](/api/oM/Framework/Data/Requests/IRequest)&gt; | - | - | Data_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface ILogicalRequest : BH.oM.Data.Requests.IRequest, BH.oM.Base.IObject
```

Assembly: Data_oM.dll

The C# interface definition is available on github:

- [ILogicalRequest.cs](https://github.com/BHoM/BHoM/blob/develop/Data_oM/Requests\ILogicalRequest.cs)

All history and changes of the class can be found by inspection the history.
