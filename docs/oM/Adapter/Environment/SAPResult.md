---
title: SAPResult
---

# <small>BH.oM.Environment.SAP.</small>**SAPResult**

An individual result for a single iteration of a SAP analysis on a dwelling.

## Class structure

### Implemented interfaces and base types

???+ bhom "The SAPResult is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| DwellingName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The name of the dwelling (the plot reference). | - |
| DwellingCount | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | The number of dwellings in the block that match this dwelling type. | - |
| Iteration | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The name of the iteration analysed. | - |
| TotalFloorArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The floor area of a single dwelling of this type. Also referred to as the Total Floor Area (TFA). | - |
| FloorAreaByBlock | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The total floor area of the dwelling type, calculated as the TotalFloorArea multiplied by the DwellingCount. | - |
| WallArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The total wall area of the dwelling. | - |
| WindowArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The total window area of the dwelling. | - |
| WallToFloorRatio | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The ratio of walls to floor for the dwelling. | - |
| WindowToFloorRatio | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The ratio of windows to floor for the dwelling. | - |
| WindowToWallRatio | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The ratio of window to wall for the dwelling. | - |
| NotionalWindowArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The total notional window area of the dwelling as your benchmark. | - |
| NotionalWindowToWallRatio | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The ratio of the notional window to wall for the dwelling. | - |
| DER | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The Dwelling Emission Rate (DER) - calculated as part of the analysis. | - |
| TER | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The Target Emission Rate (TER) for the dwelling. | - |
| DERTERImprovement | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The improvement of Emission Rate between the Target (TER) and actual (DER). Calculated as ( (TER - DER) / TER). | - |
| DPER | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The Dwelling Primary Energy Rating (DPER) for the dwelling - calculated as part of the analysis. | - |
| TPER | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The Target Primary Energy Rating (TPER) for the dwelling. | - |
| DPERTPERImprovement | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The improvement of Primary Energy Rating between the Target (TPER) and actual (DPER). Calculated as ( (TPER - DPER) / TPER). | - |
| DFEE | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The Dwelling Fabric Energy Efficiency (DFEE) for the dwelling - calculated as part of the analysis. | - |
| TFEE | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The Target Fabric Energy Efficiency (TFEE) for the dwelling. | - |
| DFEETFEEImprovement | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The improvement of Fabric Energy Efficiency between the Target (TFEE) and actual (DFEE). Calculated as ( (TFEE - DFEE) / TFEE). | - |
| BlockDER | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Calculation of the Dwelling Emission Rate (DER) multiplied by the total floor area for the dwelling type, calculated as the DER multiplied by FloorAreaByBlock. | - |
| BlockTER | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Calculation of the Target Emission Rate (TER) multiplied by the total floor area for the dwelling type, calculated as the TER multiplied by FloorAreaByBlock. | - |
| BlockDPER | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Calculation of the Dwelling Primary Energy Rating (DPER) multiplied by the total floor area for the dwelling type, calculated as the DPER multiplied by the FloorAreaByBlock. | - |
| BlockTPER | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Calculation of the Target Primary Energy Rating (TPER) multiplied by the total floor area for the dwelling type, calculated as the TPER multiplied by the FloorAreaByBlock. | - |
| BlockDFEE | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Calculation of the Dwelling Fabric Energy Efficiency (DFEE) multiplied by the total floor area for the dwelling type, calculated as the DFEE multiplied by the FloorAreaByBlock. | - |
| BlockTFEE | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Calculation of the Target Fabric Energy Efficiency (TFEE) multiplied by the total floor area for the dwelling type, calculated as the TFEE multiplied by the FloorAreaByBlock. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class SAPResult : BH.oM.Base.IObject
```

Assembly: SAP_oM.dll

The C# class definition is available on github:

- [SAPResult.cs](https://github.com/BHoM/SAP_Toolkit/blob/develop/SAP_oM/SAPResult.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/SAP_oM/SAP/SAPResult.json"
}
```

The JSON Schema is available on github here:

- [SAPResult.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/SAP_oM/SAP/SAPResult.json)
