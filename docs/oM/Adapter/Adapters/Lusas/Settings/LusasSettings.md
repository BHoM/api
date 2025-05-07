---
title: LusasSettings
---

# <small>BH.oM.Adapters.Lusas.</small>**LusasSettings**

General settings for any Adapter, to be specified when instantiating the Adapter.Implement this class to make your own Toolkit settings, e.g. SpeckleAdapterSettings.

## Class structure

### Implemented interfaces and base types

???+ bhom "The LusasSettings is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Adapter.[AdapterSettings](/api/oM/Framework/Adapter/Settings-Config/AdapterSettings)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| MergeTolerance | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Sets the merging tolerance used in Lusas. | - |
| LibrarySettings | [LibrarySettings](/api/oM/Adapter/Adapters/Lusas/Settings/LibrarySettings) | Sets the library settings. | - |
| StandardGravity | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Sets the standard gravity i.e. the acceleration due to gravity. This is used when GravityLoads are pushed/pulled from Lusas as the BHoM uses a factor of g, whereas Lusas uses a specific acceleration. | [Acceleration](/api/oM/Dimensional/Quantities/Attributes/Acceleration) [m/s²] |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| WrapNonBHoMObjects | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If your Toolkit needs support for non-BHoM objects, set this to true. | - |
| DefaultPushType | [PushType](/api/oM/Framework/Adapter/Enums/PushType) | If your Toolkit does not support the Full Push (FullCRUD method), you can select another behaviour here (e.g. CreateOnly). | - |
| CloneBeforePush | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Deep clones the objects before Pushing them.As the objects get modified during the Push (e.g. their externalId is added to them),this avoids backpropagation in visual programming environments like Grasshopper. | - |
| DefaultPullType | [PullType](/api/oM/Framework/Adapter/Enums/PullType) | - | - |
| HandleDependencies | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If your adapter does not define DependencyTypes, this can be set to false for performance. | - |
| HandlePriorities | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - |
| UseAdapterId | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - |
| UseHashComparerAsDefault | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - |
| ProcessInMemory | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - |
| OnlyUpdateChangedObjects | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true, Objects found to be the same according to the AdapterComparer for the provided type are checked for full equality using the HashComparer of the type (which by default checks every property except BHoM_Guid). If equal according to the HashComparer, they are not updated.<br>Otherwise, Objects found identical according to the AdapterComparer for the provided type are sent to the Update method. | - |
| CacheCRUDobjects | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true, CRUD operations will attempt read/write cache objects to speed things during a same Action. | - |
| CreateOnly_DistinctObjects | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true, CreateOnly method calls Distinct() on the first-level objects. | - |
| CreateOnly_DistinctDependencies | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true, CreateOnly method calls Distinct() on the dependency objects. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class LusasSettings : BH.oM.Adapter.AdapterSettings, BH.oM.Base.IObject
```

Assembly: Lusas_oM.dll

The C# class definition is available on github:

- [LusasSettings.cs](https://github.com/BHoM/Lusas_Toolkit/blob/develop/Lusas_oM/Settings\LusasSettings.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Lusas_oM/LusasSettings.json"
}
```

The JSON Schema is available on github here:

- [LusasSettings.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Lusas_oM/LusasSettings.json)
