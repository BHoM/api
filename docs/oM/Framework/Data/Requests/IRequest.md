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
    - BH.oM.Adapters.File.[IDirectoryRequest](/api/oM/Adapter/Adapters/File/Requests/Interfaces/IDirectoryRequest)
    - BH.oM.Adapters.File.[IFileRequest](/api/oM/Adapter/Adapters/File/Requests/Interfaces/IFileRequest)
    - BH.oM.Adapters.File.[IFilingRequest](/api/oM/Adapter/Adapters/File/Requests/Interfaces/IFilingRequest)
    - BH.oM.Adapters.File.[IResourceRequest](/api/oM/Adapter/Adapters/File/Requests/Interfaces/IResourceRequest)
    - BH.oM.Adapters.File.[ISortableRequest](/api/oM/Adapter/Adapters/File/Requests/Interfaces/ISortableRequest)
    - BH.oM.Structure.Requests.[IStructuralResultRequest](/api/oM/Analytical/Structure/Requests/IStructuralResultRequest)


### Classes implementing this interface

??? bhom "The following classes are implementing this interface:"

    - BH.oM.Data.Requests.[BatchRequest](/api/oM/Framework/Data/Requests/BatchRequest)
    - BH.oM.Data.Requests.[CustomRequest](/api/oM/Framework/Data/Requests/CustomRequest)
    - BH.oM.Data.Requests.[FilterRequest](/api/oM/Framework/Data/Requests/FilterRequest)
    - BH.oM.Data.Requests.[LogicalAndRequest](/api/oM/Framework/Data/Requests/LogicalAndRequest)
    - BH.oM.Data.Requests.[LogicalNotRequest](/api/oM/Framework/Data/Requests/LogicalNotRequest)
    - BH.oM.Data.Requests.[LogicalOrRequest](/api/oM/Framework/Data/Requests/LogicalOrRequest)
    - BH.oM.Data.Requests.[SelectionRequest](/api/oM/Framework/Data/Requests/SelectionRequest)
    - BH.oM.Adapters.ETABS.Requests.[PierAndSpandrelForceRequest](/api/oM/Adapter/Adapters/ETABS/Requests/PierAndSpandrelForceRequest)
    - BH.oM.Adapters.Excel.[CellContentsRequest](/api/oM/Adapter/Adapters/Excel/Requests/CellContentsRequest)
    - BH.oM.Adapters.Excel.[CellValuesRequest](/api/oM/Adapter/Adapters/Excel/Requests/CellValuesRequest)
    - BH.oM.Adapters.Excel.[ObjectRequest](/api/oM/Adapter/Adapters/Excel/Requests/ObjectRequest)
    - BH.oM.Adapters.Excel.[WorksheetsRequest](/api/oM/Adapter/Adapters/Excel/Requests/WorksheetsRequest)
    - BH.oM.Adapters.File.[DirectoryRequest](/api/oM/Adapter/Adapters/File/Requests/DirectoryRequest)
    - BH.oM.Adapters.File.[FileContentRequest](/api/oM/Adapter/Adapters/File/Requests/FileContentRequest)
    - BH.oM.Adapters.File.[FileDirRequest](/api/oM/Adapter/Adapters/File/Requests/FileDirRequest)
    - BH.oM.Adapters.File.[FileRequest](/api/oM/Adapter/Adapters/File/Requests/FileRequest)
    - BH.oM.Adapters.File.[RemoveRequest](/api/oM/Adapter/Adapters/File/Requests/RemoveRequest)
    - BH.oM.Adapters.HTTP.[GetRequest](/api/oM/Adapter/Adapters/HTTP/GetRequest)
    - BH.oM.Adapters.Mongo.Requests.[CollectionNames](/api/oM/Adapter/Adapters/Mongo/Requests/CollectionNames)
    - BH.oM.Adapters.Revit.Requests.[ConditionRequest](/api/oM/Adapter/Adapters/Revit/Requests/ConditionRequest)
    - BH.oM.Adapters.Revit.Requests.[EnergyAnalysisModelRequest](/api/oM/Adapter/Adapters/Revit/Requests/EnergyAnalysisModelRequest)
    - BH.oM.Adapters.Revit.Requests.[FilterActiveView](/api/oM/Adapter/Adapters/Revit/Requests/FilterActiveView)
    - BH.oM.Adapters.Revit.Requests.[FilterByActiveWorkset](/api/oM/Adapter/Adapters/Revit/Requests/FilterByActiveWorkset)
    - BH.oM.Adapters.Revit.Requests.[FilterByCategory](/api/oM/Adapter/Adapters/Revit/Requests/FilterByCategory)
    - BH.oM.Adapters.Revit.Requests.[FilterByDBTypeName](/api/oM/Adapter/Adapters/Revit/Requests/FilterByDBTypeName)
    - BH.oM.Adapters.Revit.Requests.[FilterByElementIds](/api/oM/Adapter/Adapters/Revit/Requests/FilterByElementIds)
    - BH.oM.Adapters.Revit.Requests.[FilterByFamilyAndTypeName](/api/oM/Adapter/Adapters/Revit/Requests/FilterByFamilyAndTypeName)
    - BH.oM.Adapters.Revit.Requests.[FilterByFamilyType](/api/oM/Adapter/Adapters/Revit/Requests/FilterByFamilyType)
    - BH.oM.Adapters.Revit.Requests.[FilterByLink](/api/oM/Adapter/Adapters/Revit/Requests/FilterByLink)
    - BH.oM.Adapters.Revit.Requests.[FilterByParameterExistence](/api/oM/Adapter/Adapters/Revit/Requests/FilterByParameterExistence)
    - BH.oM.Adapters.Revit.Requests.[FilterByScopeBox](/api/oM/Adapter/Adapters/Revit/Requests/FilterByScopeBox)
    - BH.oM.Adapters.Revit.Requests.[FilterBySelectionSet](/api/oM/Adapter/Adapters/Revit/Requests/FilterBySelectionSet)
    - BH.oM.Adapters.Revit.Requests.[FilterByUniqueIds](/api/oM/Adapter/Adapters/Revit/Requests/FilterByUniqueIds)
    - BH.oM.Adapters.Revit.Requests.[FilterByUsage](/api/oM/Adapter/Adapters/Revit/Requests/FilterByUsage)
    - BH.oM.Adapters.Revit.Requests.[FilterByViewSpecific](/api/oM/Adapter/Adapters/Revit/Requests/FilterByViewSpecific)
    - BH.oM.Adapters.Revit.Requests.[FilterByVisibleInActiveView](/api/oM/Adapter/Adapters/Revit/Requests/FilterByVisibleInActiveView)
    - BH.oM.Adapters.Revit.Requests.[FilterByVisibleInView](/api/oM/Adapter/Adapters/Revit/Requests/FilterByVisibleInView)
    - BH.oM.Adapters.Revit.Requests.[FilterByWorkset](/api/oM/Adapter/Adapters/Revit/Requests/FilterByWorkset)
    - BH.oM.Adapters.Revit.Requests.[FilterEverything](/api/oM/Adapter/Adapters/Revit/Requests/FilterEverything)
    - BH.oM.Adapters.Revit.Requests.[FilterFamilyByName](/api/oM/Adapter/Adapters/Revit/Requests/FilterFamilyByName)
    - BH.oM.Adapters.Revit.Requests.[FilterFamilyTypeByName](/api/oM/Adapter/Adapters/Revit/Requests/FilterFamilyTypeByName)
    - BH.oM.Adapters.Revit.Requests.[FilterLinkInstance](/api/oM/Adapter/Adapters/Revit/Requests/FilterLinkInstance)
    - BH.oM.Adapters.Revit.Requests.[FilterMemberElements](/api/oM/Adapter/Adapters/Revit/Requests/FilterMemberElements)
    - BH.oM.Adapters.Revit.Requests.[FilterModelElements](/api/oM/Adapter/Adapters/Revit/Requests/FilterModelElements)
    - BH.oM.Adapters.Revit.Requests.[FilterTypesOfFamily](/api/oM/Adapter/Adapters/Revit/Requests/FilterTypesOfFamily)
    - BH.oM.Adapters.Revit.Requests.[FilterViewByName](/api/oM/Adapter/Adapters/Revit/Requests/FilterViewByName)
    - BH.oM.Adapters.Revit.Requests.[FilterViewsByTemplate](/api/oM/Adapter/Adapters/Revit/Requests/FilterViewsByTemplate)
    - BH.oM.Adapters.Revit.Requests.[FilterViewsByType](/api/oM/Adapter/Adapters/Revit/Requests/FilterViewsByType)
    - BH.oM.Adapters.Revit.Requests.[FilterViewTemplateByName](/api/oM/Adapter/Adapters/Revit/Requests/FilterViewTemplateByName)
    - BH.oM.Adapters.SAP2000.Requests.[SteelUtilisationRequest](/api/oM/Adapter/Adapters/SAP2000/Requests/SteelUtilisationRequest)
    - BH.oM.Adapters.SQL.[CustomRequest](/api/oM/Adapter/Adapters/SQL/Requests/CustomRequest)
    - BH.oM.Adapters.SQL.[TableRequest](/api/oM/Adapter/Adapters/SQL/Requests/TableRequest)
    - BH.oM.Structure.Requests.[BarResultRequest](/api/oM/Analytical/Structure/Requests/BarResultRequest)
    - BH.oM.Structure.Requests.[GlobalResultRequest](/api/oM/Analytical/Structure/Requests/GlobalResultRequest)
    - BH.oM.Structure.Requests.[MeshResultRequest](/api/oM/Analytical/Structure/Requests/MeshResultRequest)
    - BH.oM.Structure.Requests.[NodeResultRequest](/api/oM/Analytical/Structure/Requests/NodeResultRequest)


## Properties

### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Discipline | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[Discipline](/api/oM/Adapter/Adapters/Revit/Enums/Discipline)&gt; | Gets discipline enforced by the Request. If the result is different than defaultDiscipline and neither of two is Undefined, null is returned (the result discipline is conflicting with defaultDiscipline). | - | Revit_Engine |
| IFilterDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Returns a description of the filter represented by the given IRequest. | - | Revit_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IRequest : BH.oM.Base.IObject
```

Assembly: Data_oM.dll

The C# interface definition is available on github:

- [IRequest.cs](https://github.com/BHoM/BHoM/blob/develop/Data_oM/Requests\IRequest.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Data_oM/Requests/IRequest.json"
}
```

The JSON Schema is available on github here:

- [IRequest.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Data_oM/Requests/IRequest.json)
