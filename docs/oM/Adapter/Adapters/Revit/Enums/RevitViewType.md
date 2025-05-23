---
title: RevitViewType
---

# <small>BH.oM.Adapters.Revit.Enums.</small>**RevitViewType**

Enumerator defining view type of Revit view. A clone of Autodesk.Revit.DB.ViewType enum.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| Undefined |  Undefined/unspecified type of view.  |
| FloorPlan |  Floor plan type of view.  |
| CeilingPlan |  Reflected ceiling plan type of view.  |
| Elevation |  Elevation type of view.  |
| ThreeD |  3-D type of view.  |
| Schedule |  Schedule type of view.  |
| DrawingSheet |  Drawing sheet type of view.  |
| ProjectBrowser |  The project browser view.  |
| Report |  Report type of view.  |
| DraftingView |  Drafting type of view.  |
| Legend |  Legend type of view.  |
| SystemBrowser |  The MEP system browser view.  |
| EngineeringPlan |  Structural plan or Engineering plan type of view.  |
| AreaPlan |  Area plan type of view.  |
| Section |  Cross section type of view.  |
| Detail |  Detail type of view.  |
| CostReport |  Cost Report view.  |
| LoadsReport |  Loads Report view.  |
| PresureLossReport |  Pressure Loss Report view.  |
| ColumnSchedule |  Column Schedule type of view.  |
| PanelSchedule |  Panel Schedule Report view.  |
| Walkthrough |  Walk-Through type of 3D view.  |
| Rendering |  Rendering type of view.  |
| SystemsAnalysisReport |  Systems analysis report view.  |
| Internal |  Revit's internal type of view.  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum RevitViewType : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: Revit_oM.dll

The C# enum definition is available on github:

- [RevitViewType.cs](https://github.com/BHoM/Revit_Toolkit/blob/develop/Revit_oM/Enums\RevitViewType.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Revit_oM/Enums/RevitViewType.json"
}
```

The JSON Schema is available on github here:

- [RevitViewType.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Revit_oM/Enums/RevitViewType.json)
