---
title: AdapterSettings
---

# <small>BH.oM.Adapter.</small>**AdapterSettings**

General settings for any Adapter, to be specified when instantiating the Adapter.Implement this class to make your own Toolkit settings, e.g. SpeckleAdapterSettings.

## Class structure

### Implemented interfaces and base types

???+ bhom "The AdapterSettings is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes inheriting from this class

???+ bhom "The following classes are inheriting from this class:"

    - BH.oM.Adapters.AGS.[AGSSettings](/api/oM/Adapter/Adapters/AGS/AGSSettings)
    - BH.oM.Adapters.Lusas.[LusasSettings](/api/oM/Adapter/Adapters/Lusas/Settings/LusasSettings)
    - BH.oM.Adapters.MidasCivil.[MidasCivilSettings](/api/oM/Adapter/Adapters/MidasCivil/Settings/MidasCivilSettings)


## Properties



### Defining properties

The following properties are defined on the class

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
public class AdapterSettings : BH.oM.Base.IObject
```

Assembly: Adapter_oM.dll

The C# class definition is available on github:

- [AdapterSettings.cs](https://github.com/BHoM/BHoM_Adapter/blob/develop/Adapter_oM/Settings-Config\AdapterSettings.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Adapter_oM/AdapterSettings.json"
}
```

The JSON Schema is available on github here:

- [AdapterSettings.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Adapter_oM/AdapterSettings.json)
