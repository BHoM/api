---
title: FileRequest
---

# <small>BH.oM.Adapters.File.</small>**FileRequest**

Used to query Files from a Parent directory.

## Class structure

### Implemented interfaces and base types

???+ bhom "The FileRequest is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Adapters.File.[IFileRequest](/api/oM/Adapter/Adapters/File/Requests/Interfaces/IFileRequest)
    -  BH.oM.Adapters.File.[ISortableRequest](/api/oM/Adapter/Adapters/File/Requests/Interfaces/ISortableRequest)
    -  BH.oM.Data.Requests.[IRequest](/api/oM/Framework/Data/Requests/IRequest)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Adapters.File.[IResourceRequest](/api/oM/Adapter/Adapters/File/Requests/Interfaces/IResourceRequest)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Location | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Files from this location will be queried. | - |
| SearchSubdirectories | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If enabled, look also in subdirectories. | - |
| MaxNesting | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | If SearchSubdirectories is true, this sets the maximum subdirectiory nesting level to look in.<br>Defaults to -1 which corresponds to no limit. | - |
| SortOrder | [SortOrder](/api/oM/Adapter/Adapters/File/enums/SortOrder) | Sorting order of the extracted Files. | - |
| MaxFiles | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Sets the maximum number of Files to retrieve, useful when using SearchSubdirectories.<br>Defaults to -1 which corresponds to no limit. | - |
| IncludeFileContents | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Whether to include the contents of the Files. | - |
| Exclusions | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | These files will be excluded from the results.<br>You can also specify string Full Paths. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Discipline | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[Discipline](/api/oM/Adapter/Adapters/Revit/Enums/Discipline)&gt; | Gets discipline enforced by the Request. If the result is different than defaultDiscipline and neither of two is Undefined, null is returned (the result discipline is conflicting with defaultDiscipline). | - | Revit_Engine |
| IFilterDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Returns a description of the filter represented by the given IRequest. | - | Revit_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class FileRequest : BH.oM.Adapters.File.IFileRequest,
BH.oM.Adapters.File.ISortableRequest,
BH.oM.Data.Requests.IRequest,
BH.oM.Base.IObject,
BH.oM.Adapters.File.IResourceRequest
```

Assembly: File_oM.dll

The C# class definition is available on github:

- [FileRequest.cs](https://github.com/BHoM/File_Toolkit/blob/develop/File_oM/Requests\FileRequest.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/File_oM/FileRequest.json"
}
```

The JSON Schema is available on github here:

- [FileRequest.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/File_oM/FileRequest.json)
