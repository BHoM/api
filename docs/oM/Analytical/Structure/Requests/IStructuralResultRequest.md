---
title: IStructuralResultRequest
---

# <small>BH.oM.Structure.Requests.</small>**IStructuralResultRequest**



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IStructuralResultRequest is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Data.Requests.[IResultRequest](/api/oM/Framework/Data/Requests/IResultRequest)
    -  BH.oM.Data.Requests.[IRequest](/api/oM/Framework/Data/Requests/IRequest)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Adapters.ETABS.Requests.[PierAndSpandrelForceRequest](/api/oM/Adapter/Adapters/ETABS/Requests/PierAndSpandrelForceRequest)
    - BH.oM.Adapters.SAP2000.Requests.[SteelUtilisationRequest](/api/oM/Adapter/Adapters/SAP2000/Requests/SteelUtilisationRequest)
    - BH.oM.Structure.Requests.[BarResultRequest](/api/oM/Analytical/Structure/Requests/BarResultRequest)
    - BH.oM.Structure.Requests.[GlobalResultRequest](/api/oM/Analytical/Structure/Requests/GlobalResultRequest)
    - BH.oM.Structure.Requests.[LinkResultRequest](/api/oM/Analytical/Structure/Requests/LinkResultRequest)
    - BH.oM.Structure.Requests.[MeshResultRequest](/api/oM/Analytical/Structure/Requests/MeshResultRequest)
    - BH.oM.Structure.Requests.[NodeResultRequest](/api/oM/Analytical/Structure/Requests/NodeResultRequest)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Modes | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Discipline | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[Discipline](/api/oM/Adapter/Adapters/Revit/Enums/Discipline)&gt; | Gets discipline enforced by the Request. If the result is different than defaultDiscipline and neither of two is Undefined, null is returned (the result discipline is conflicting with defaultDiscipline). | - | Revit_Engine |
| IFilterDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Returns a description of the filter represented by the given IRequest. | - | Revit_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IStructuralResultRequest : BH.oM.Data.Requests.IResultRequest, BH.oM.Data.Requests.IRequest, BH.oM.Base.IObject
```

Assembly: Structure_oM.dll

The C# interface definition is available on github:

- [IStructuralResultRequest.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/Requests\IStructuralResultRequest.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Structure_oM/Requests/IStructuralResultRequest.json"
}
```

The JSON Schema is available on github here:

- [IStructuralResultRequest.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Structure_oM/Requests/IStructuralResultRequest.json)
