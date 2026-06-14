---
title: CustomRibbonSettings
---

# <small>BH.oM.UI.</small>**CustomRibbonSettings**



## Class structure

### Implemented interfaces and base types

???+ bhom "The CustomRibbonSettings is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[ISettings](/api/oM/Framework/Base/Interface/ISettings)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Entries | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[CustomRibbonEntry](/api/oM/UI/UI/CustomRibbonEntry)&gt; | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class CustomRibbonSettings : BH.oM.Base.ISettings, BH.oM.Base.IObject
```

Assembly: UI_oM.dll

The C# class definition is available on github:

- [CustomRibbonSettings.cs](https://github.com/BHoM/BHoM_UI/blob/develop/UI_oM/CustomRibbonSettings.cs)

All history and changes of the class can be found by inspection the history.
