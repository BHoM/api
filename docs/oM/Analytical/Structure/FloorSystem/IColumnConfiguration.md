---
title: IColumnConfiguration&lt;T&gt;
---

# <small>BH.oM.Structure.FloorSystem.</small>**IColumnConfiguration&lt;T&gt;**

Base interface for the configuration of a column designed to support a particular number of stories at a given floor height.

## Interface structure

### Generic parameters

The IColumnConfiguration contains the following generic paramters:

#### T

Constrained by the following arguments:

- BH.oM.Structure.SectionProperties.[IGeometricalSection](/api/oM/Analytical/Structure/SectionProperties/IGeometricalSection)

### Implemented interfaces and base types

???+ bhom "The IColumnConfiguration`1 is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Structure.FloorSystem.[ConcreteColumnConfiguration](/api/oM/Analytical/Structure/FloorSystem/ColumnConfigurations/ConcreteColumnConfiguration)
    - BH.oM.Structure.FloorSystem.[SteelColumnConfiguration](/api/oM/Analytical/Structure/FloorSystem/ColumnConfigurations/SteelColumnConfiguration)
    - BH.oM.Structure.FloorSystem.[TimberColumnConfiguration](/api/oM/Analytical/Structure/FloorSystem/ColumnConfigurations/TimberColumnConfiguration)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ColumnSection | [T](#t) | Section of the column required for this configuration. | - |
| FloorHeight | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Floor-to-floor height that the column configuration is designed for. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| NumberOfStories | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Number of stories supported by the column in this configuration. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IColumnConfiguration`1 : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: Structure_oM.dll

The C# interface definition is available on github:

- [IColumnConfiguration.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/FloorSystem\IColumnConfiguration.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Structure_oM/FloorSystem/IColumnConfiguration`1.json"
}
```

The JSON Schema is available on github here:

- [IColumnConfiguration`1.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Structure_oM/FloorSystem/IColumnConfiguration`1.json)
