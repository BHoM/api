---
title: SqlClientAssemblyFixSettings
---

# <small>BH.oM.Adapters.SQL.</small>**SqlClientAssemblyFixSettings**

Initialisation settings for the SQL Toolkit ensuring that the correct Microsoft.Data.SqlClient assembly is loaded before any SQL component is used in Rhino 8. This is a fix until McNeel ships a working version of that dll.

## Class structure

### Implemented interfaces and base types

???+ bhom "The SqlClientAssemblyFixSettings is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Base.[ISettings](/api/oM/Framework/Base/Interface/ISettings)
    -  BH.oM.Base.[IInitialisationSettings](/api/oM/Framework/Base/Interface/IInitialisationSettings)
    -  BH.oM.Base.[IImmutable](/api/oM/Framework/Base/Interface/IImmutable)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| InitialisationMethod | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Method ran when the UI is loaded. This is in charge of loading the Microsoft.Data.SqlClient if we are in Rhino 8. | - |
| InitialisationAssembly | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Assmbly where the initialisation method can be found. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class SqlClientAssemblyFixSettings : BH.oM.Base.BHoMObject,
BH.oM.Base.IBHoMObject,
BH.oM.Base.IObject,
BH.oM.Base.ISettings,
BH.oM.Base.IInitialisationSettings,
BH.oM.Base.IImmutable
```

Assembly: SQL_oM.dll

The C# class definition is available on github:

- [SqlClientAssemblyFixSettings.cs](https://github.com/BHoM/SQL_Toolkit/blob/develop/SQL_oM/ToolkitSettings\SqlClientAssemblyFixSettings.cs)

All history and changes of the class can be found by inspection the history.
