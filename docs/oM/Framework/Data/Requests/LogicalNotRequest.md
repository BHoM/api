---
title: LogicalNotRequest
---

# <small>BH.oM.Data.Requests.</small>**LogicalNotRequest**

IRequest that inverts the query specified by the input request, i.e. any object that fits this request will be excluded from a pull.

## Class structure

### Implemented interfaces and base types

???+ bhom "The LogicalNotRequest is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Data.Requests.[ILogicalRequest](/api/oM/Framework/Data/Requests/ILogicalRequest)
    -  BH.oM.Data.Requests.[IRequest](/api/oM/Framework/Data/Requests/IRequest)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Request | [IRequest](/api/oM/Framework/Data/Requests/IRequest) | Request to be inverted, i.e. defining what should be excluded. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IRequests | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IRequest](/api/oM/Framework/Data/Requests/IRequest)&gt; | - | - | Data_Engine |
| Requests | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IRequest](/api/oM/Framework/Data/Requests/IRequest)&gt; | - | - | Data_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class LogicalNotRequest : BH.oM.Data.Requests.ILogicalRequest, BH.oM.Data.Requests.IRequest, BH.oM.Base.IObject
```

Assembly: Data_oM.dll

The C# class definition is available on github:

- [LogicalNotRequest.cs](https://github.com/BHoM/BHoM/blob/develop/Data_oM/Requests\LogicalNotRequest.cs)

All history and changes of the class can be found by inspection the history.
