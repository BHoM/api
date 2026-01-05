---
title: PhotochemicalOzoneCreationTRACIMetric
---

# <small>BH.oM.LifeCycleAssessment.MaterialFragments.</small>**PhotochemicalOzoneCreationTRACIMetric**

Photochemical Ozone Creation as defined by the TRACI standard for a particular product or material. Forms part of an EPD, and should be evaluated based on the QuantityType stated on the EPD.

## Class structure

### Implemented interfaces and base types

???+ bhom "The PhotochemicalOzoneCreationTRACIMetric is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.LifeCycleAssessment.MaterialFragments.[IEnvironmentalMetric](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalMetrics/IEnvironmentalMetric)
    -  BH.oM.LifeCycleAssessment.Interfaces.[ILifeCycleAssessmentModuleData](/api/oM/Analytical/LifeCycleAssessment/Interfaces/ILifeCycleAssessmentModuleData)&lt;[Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;BH.oM.LifeCycleAssessment.[Module](/api/oM/Analytical/LifeCycleAssessment/Enums/Module), [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0)&gt;&gt;
    -  BH.oM.LifeCycleAssessment.Interfaces.[ILifeCycleAssessmentIndicator](/api/oM/Analytical/LifeCycleAssessment/Interfaces/ILifeCycleAssessmentIndicator)
    -  BH.oM.Base.[IDynamicObject](/api/oM/Framework/Base/Interface/IDynamicObject)
    -  BH.oM.LifeCycleAssessment.Interfaces.[IDeprecatedStandard](/api/oM/Analytical/LifeCycleAssessment/Interfaces/IDeprecatedStandard)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Indicators | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[Module](/api/oM/Analytical/LifeCycleAssessment/Enums/Module), [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0)&gt; | Set of factors per module.<br>This is a dynamic collection that stores the optional properties defined below. | [PhotochemicalOzoneCreationTRACIPerQuantity](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACIPerQuantity) [kg O₃ eq per unit] |




### Optional properties

The following properties are optional and can be included on a object definition in any combination

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| A0 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Activities in A0 include, but are not limited to, non-physical processes before construction such as preliminary studies, impact assessments, risk assessments, stakeholder engagement, design and technical studies, product/material tests, site surveys and acquisition of land and design.<br>This LCA module is specific to RICS Professional Standard, Whole Life Carbon Assessment for the Built Environment (2023). | [PhotochemicalOzoneCreationTRACIPerQuantity](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACIPerQuantity) [kg O₃ eq per unit] |
| A1 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The A1 module is part of the A1-A3 product stage and consists of raw material extraction and supply. | [PhotochemicalOzoneCreationTRACIPerQuantity](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACIPerQuantity) [kg O₃ eq per unit] |
| A2 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The A2 module is part of the A1-A3 product stage and relates to all transport during the product stage. | [PhotochemicalOzoneCreationTRACIPerQuantity](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACIPerQuantity) [kg O₃ eq per unit] |
| A3 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The A3 module is part of the A1-A3 product stage and relates to all manufacturing during the product stage. | [PhotochemicalOzoneCreationTRACIPerQuantity](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACIPerQuantity) [kg O₃ eq per unit] |
| A1toA3 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Full Product stage - Sum of modules A1, A2 and A3, including raw material extraction, transport during production and manufacturing. | [PhotochemicalOzoneCreationTRACIPerQuantity](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACIPerQuantity) [kg O₃ eq per unit] |
| A4 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Module A4 captures the impacts associated with the transportation of the materials and components from the factory gate to and from the project site. | [PhotochemicalOzoneCreationTRACIPerQuantity](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACIPerQuantity) [kg O₃ eq per unit] |
| A5 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Module A5 captures the carbon impacts arising from any on-site construction-related activities and consists of several sub-modules: A5.1 Pre-construction demolition (if applicable), A5.2 Construction activities, A5.3 Waste and waste management, and A5.4 Worker transport (optional). | [PhotochemicalOzoneCreationTRACIPerQuantity](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACIPerQuantity) [kg O₃ eq per unit] |
| A5_1 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Module A5.1 Pre-construction demolition consists of demolition/deconstruction of existing buildings and structures, and/or parts thereof, including transport from site and waste processing of removed materials. | [PhotochemicalOzoneCreationTRACIPerQuantity](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACIPerQuantity) [kg O₃ eq per unit] |
| A5_2 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Module A5.2 Construction activities consists of site preparation; temporary works; ground works; connection to utilities; transport and onsite storage of construction products, materials and equipment; onsite production/assembly of products; works for the installation and ancillary materials (e.g. formworks and their disposal); heating/cooling/ventilation of site facilities; energy and water use for construction processes and landscaping. | [PhotochemicalOzoneCreationTRACIPerQuantity](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACIPerQuantity) [kg O₃ eq per unit] |
| A5_3 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Module A5.3 Waste and waste management consists of production, transportation, storage and end-of-life treatment and disposal of any material/waste onsite; transport, waste management and disposal of packing materials. | [PhotochemicalOzoneCreationTRACIPerQuantity](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACIPerQuantity) [kg O₃ eq per unit] |
| A5_4 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Module A5.4 Worker transport consists of emissions of site workers travelling to and from site. | [PhotochemicalOzoneCreationTRACIPerQuantity](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACIPerQuantity) [kg O₃ eq per unit] |
| B1 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Module B1 captures the non-energy-related impacts during the life of a built asset arising from its components and consists of two sub-modules, B1.1 In-use: material emissions and removals and B1.2 In-use: fugitive emissions (refrigerants). | [PhotochemicalOzoneCreationTRACIPerQuantity](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACIPerQuantity) [kg O₃ eq per unit] |
| B1_1 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Module B1.1 In-use: material emissions and removals consists of Release from materials of gases with GWP, e.g. blowing agents from insulation; reabsorption of CO2 into products containing lime and cement through carbonation, and removals from vegetation. | [PhotochemicalOzoneCreationTRACIPerQuantity](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACIPerQuantity) [kg O₃ eq per unit] |
| B1_2 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Module B1.2 In-use: fugitive emissions (refrigerants) consists of the accidental release of refrigerants with GWP from MEP equipment such as cooling systems and heat pumps. | [PhotochemicalOzoneCreationTRACIPerQuantity](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACIPerQuantity) [kg O₃ eq per unit] |
| B2 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Module B2 Maintenance impacts must account for the carbon impacts from any activities relating to maintenance processes, including cleaning, as well as any relevant products used and waste produced over the reference study period. | [PhotochemicalOzoneCreationTRACIPerQuantity](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACIPerQuantity) [kg O₃ eq per unit] |
| B3 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Module B3 Repair impacts must take into account carbon impacts from all activities that relate to repair processes, and any products used and waste produced over the reference study period. All impacts from the production, transportation to and from site, and installation of the repaired items must be included. | [PhotochemicalOzoneCreationTRACIPerQuantity](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACIPerQuantity) [kg O₃ eq per unit] |
| B1toB3 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Use, Maintenance and Repair modules in the Use stage - Sum of modules B1, B2 and B3. | [PhotochemicalOzoneCreationTRACIPerQuantity](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACIPerQuantity) [kg O₃ eq per unit] |
| B4 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Module B4 Replacement impacts must take into account any carbon impacts associated with the anticipated replacement of built asset components, including any impacts from the replacement process, over the reference study period. All impacts from the production, transportation to site and installation of the replacement items must be included, as well as any losses during these processes, as well as any impacts associated with the removal and end-of-life treatment of replaced items. Module B4 consists of two sub-modules, B4.1 Replacement of construction products, components and systems and B4.2 B4.2 Replacement of industrial systems (if applicable for infrastructure). | [PhotochemicalOzoneCreationTRACIPerQuantity](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACIPerQuantity) [kg O₃ eq per unit] |
| B4_1 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Module B4.1 Replacement of construction products, components and systems, consists of replacement, including manufacture, transport and installation of new, like-for-like products, components or systems, as well as the deconstruction and waste treatment of removed products, components and systems. | [PhotochemicalOzoneCreationTRACIPerQuantity](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACIPerQuantity) [kg O₃ eq per unit] |
| B4_2 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Module B4.2 Replacement of industrial systems (if applicable for infrastructure) consists of replacement of industrial systems, including manufacture, transport and installation of new, like-for-like systems, as well as the deconstruction and waste treatment of removed systems. | [PhotochemicalOzoneCreationTRACIPerQuantity](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACIPerQuantity) [kg O₃ eq per unit] |
| B5 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Module B5 Impacts from retrofit/refurbishment/planned changes consists of All impacts arising from the production, transport to site and installation of the components used for a change or refurbishment planned prior to project completion, but undertaken during the in-use stage. | [PhotochemicalOzoneCreationTRACIPerQuantity](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACIPerQuantity) [kg O₃ eq per unit] |
| B4toB5 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Replacement and Refurbishment modules in the Use stage - Sum of modules B4 and B5. | [PhotochemicalOzoneCreationTRACIPerQuantity](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACIPerQuantity) [kg O₃ eq per unit] |
| B1toB5 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Full Use Stage except operational energy and Water use - Sum of modules B1, B2, B3, B4 and B5. | [PhotochemicalOzoneCreationTRACIPerQuantity](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACIPerQuantity) [kg O₃ eq per unit] |
| B6 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Module B6 Operational energy use consists of carbon emissions from all operational energy use by a building or infrastructure asset over its life cycle. | [PhotochemicalOzoneCreationTRACIPerQuantity](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACIPerQuantity) [kg O₃ eq per unit] |
| B7 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Module B7 Operational water use consists of the carbon impacts from water use during the operation of the built asset over its life cycle and consists of 3 sub-modules: B7.1 Water used by integrated systems, B7.2 Water used by other integrated systems, and B7.3 Water used by non-integrated systems. | [PhotochemicalOzoneCreationTRACIPerQuantity](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACIPerQuantity) [kg O₃ eq per unit] |
| B1toB7 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Full Use Stage - Sum of modules B1, B2, B3, B4, B5, B6 and B7. | [PhotochemicalOzoneCreationTRACIPerQuantity](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACIPerQuantity) [kg O₃ eq per unit] |
| B7_1 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Module B7.1 Water used by integrated systems consists of Water for sanitation, cooking and drinking; irrigation of associated landscape areas, green roofs and walls; and heating, cooling, ventilation and humidification systems. | [PhotochemicalOzoneCreationTRACIPerQuantity](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACIPerQuantity) [kg O₃ eq per unit] |
| B7_2 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Module B7.2 Water used by other integrated systems consists of water used by fountains, swimming pools and saunas. | [PhotochemicalOzoneCreationTRACIPerQuantity](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACIPerQuantity) [kg O₃ eq per unit] |
| B7_3 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Module B7.3 Water used by non-integrated systems consists of water used for dishwashers, washing machines and washing cars. | [PhotochemicalOzoneCreationTRACIPerQuantity](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACIPerQuantity) [kg O₃ eq per unit] |
| B8 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Module B8 User activities in buildings covers impacts associated with user activities taking place during the operation of buildings that are not covered by B1-B7. There are 3 sub-modules to B8 including: B8.1 Energy-related impacts associated with building user mobility/ transport not covered in B6, such as user mobility/ commuting to a building (optional), B8.2 Energy-related impacts associated with building user charging of electric vehicles on-site (optional), and B8.3 Other energy related impacts associated with building user activities relating to the building�s intended use, such as upstream embodied impacts of consumables used in the building, e.g. stationery and printing paper for an office (optional). | [PhotochemicalOzoneCreationTRACIPerQuantity](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACIPerQuantity) [kg O₃ eq per unit] |
| B8_1 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Module B8.1 consists of energy-related impacts associated with building user mobility/ transport not covered in B6, such as user mobility/ commuting to a building (optional). | [PhotochemicalOzoneCreationTRACIPerQuantity](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACIPerQuantity) [kg O₃ eq per unit] |
| B8_2 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Module B8.2 consists of energy-related impacts associated with building user charging of electric vehicles on-site (optional). | [PhotochemicalOzoneCreationTRACIPerQuantity](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACIPerQuantity) [kg O₃ eq per unit] |
| B8_3 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Module B8.3 consists of other energy related impacts associated with building user activities relating to the building's intended use, such as upstream embodied impacts of consumables used in the building, e.g. stationery and printing paper for an office (optional). | [PhotochemicalOzoneCreationTRACIPerQuantity](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACIPerQuantity) [kg O₃ eq per unit] |
| C1 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Module C1 Deconstruction and demolition impacts consists of the impacts arising from any on- or offsite deconstruction and demolition activities at the end of life of the asset, including any energy consumption for site accommodation and plant use. | [PhotochemicalOzoneCreationTRACIPerQuantity](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACIPerQuantity) [kg O₃ eq per unit] |
| C2 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Module C2 Transport impacts consists of any carbon impacts associated with the transportation of material from deconstruction and demolition to the appropriate final location, including any interim stations. | [PhotochemicalOzoneCreationTRACIPerQuantity](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACIPerQuantity) [kg O₃ eq per unit] |
| C3 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Module C3 Waste processing for reuse, recycling or other recovery consists of materials and/or components that are intended to be reused, recycled or recovered after the RSP of the asset, any impacts associated with their preparation for reuse, waste treatment and recovery prior to reaching the end-of-waste state. | [PhotochemicalOzoneCreationTRACIPerQuantity](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACIPerQuantity) [kg O₃ eq per unit] |
| C4 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Module C4 Disposal impacts consists of impacts resulting from any processing required prior to disposal and from the degradation of landfilled materials, or incineration without energy recovery or in a plant without R1 status (Energy Efficiency Formula standard, according to the Waste Framework Directive, less than 65%). This is only applicable for items not being recovered for reuse, recycling or other recovery. | [PhotochemicalOzoneCreationTRACIPerQuantity](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACIPerQuantity) [kg O₃ eq per unit] |
| C3toC4 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Waste Processing and disposal modules in the End of Life stage - Sum of Modules C3 and C4. | [PhotochemicalOzoneCreationTRACIPerQuantity](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACIPerQuantity) [kg O₃ eq per unit] |
| C1toC4 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Full End of Life stage- Sum of Modules C1, C2, C3 and C4. | [PhotochemicalOzoneCreationTRACIPerQuantity](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACIPerQuantity) [kg O₃ eq per unit] |
| D | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Module D consists of benefits and loads beyond the system boundary and consists of two sub-modules D1 potential benefits and loads from reuse, recycling and energy recovery from the net output flows of materials exiting the system boundary, and/or from other recovery (e.g. from incineration or from use of captured landfill gas) and D2 potential benefits and loads from exported utilities exiting the system boundary. | [PhotochemicalOzoneCreationTRACIPerQuantity](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACIPerQuantity) [kg O₃ eq per unit] |
| D_1 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Module D1 covers the potential loads and benefits from reusing or recycling materials and components at end of life, or from any energy recovered from them at end of life (e.g. energy from waste, incineration or use of captured landfill gas).<br>Module D1 is relevant to any end-of-life output from the asset during construction (module A5); maintenance, repair, replacement and refurbishment (modules B2-B5); and from waste treatment and disposal (modules C3 and C4).<br>It also includes loads and benefits associated with the deconstruction/demolition activities of existing assets on the site, assessed in module A5.1. Module D1 must be communicated separately, as it mainly occurs beyond the RSP and outside the system boundary of the project being assessed, and also includes inherent uncertainty regarding the future treatment of building components. | [PhotochemicalOzoneCreationTRACIPerQuantity](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACIPerQuantity) [kg O₃ eq per unit] |
| D_2 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Module D2 indicates that if a building generates more energy than it uses over the course of the year, this 'exported' energy is reported as part of module B6 for buildings (see Appendix G2).<br>For infrastructure that generates energy or produces other utilities, these are reported as exported utilities as part of B8. For both buildings and infrastructure assets, any benefit from these exported utilities (e.g. the avoided impact of grid electricity generation for exported electricity) is reported in D2. | [PhotochemicalOzoneCreationTRACIPerQuantity](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACIPerQuantity) [kg O₃ eq per unit] |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| ATotal | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the total sum of values from all A-modules (A1-A5) with a set value (all values not NaN). | - | LifeCycleAssessment_Engine |
| BTotal | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the total sum of values from all B-modules (B1-B7) with a set value (all values not NaN). | - | LifeCycleAssessment_Engine |
| CTotal | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the total sum of values from all C-modules (C1-C4) with a set value (all values not NaN). | - | LifeCycleAssessment_Engine |
| IMetricType | [MetricType](/api/oM/Analytical/LifeCycleAssessment/Enums/MetricType) | - | - | LifeCycleAssessment_Engine |
| Total | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the total sum of values from all modules with a set value (all values not NaN). | - | LifeCycleAssessment_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class PhotochemicalOzoneCreationTRACIMetric : BH.oM.Base.BHoMObject,
BH.oM.Base.IBHoMObject,
BH.oM.Base.IObject,
BH.oM.LifeCycleAssessment.MaterialFragments.IEnvironmentalMetric,
BH.oM.LifeCycleAssessment.Interfaces.ILifeCycleAssessmentModuleData<System.Collections.Generic.Dictionary<BH.oM.LifeCycleAssessment.Module, System.Double>>,
BH.oM.LifeCycleAssessment.Interfaces.ILifeCycleAssessmentIndicator,
BH.oM.Base.IDynamicObject,
BH.oM.LifeCycleAssessment.Interfaces.IDeprecatedStandard
```

Assembly: LifeCycleAssessment_oM.dll

The C# class definition is available on github:

- [PhotochemicalOzoneCreationTRACIMetric.cs](https://github.com/BHoM/BHoM/blob/develop/LifeCycleAssessment_oM/MaterialFragments\EnvironmentalMetrics\PhotochemicalOzoneCreationTRACIMetric.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/LifeCycleAssessment_oM/MaterialFragments/PhotochemicalOzoneCreationTRACIMetric.json"
}
```

The JSON Schema is available on github here:

- [PhotochemicalOzoneCreationTRACIMetric.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/LifeCycleAssessment_oM/MaterialFragments/PhotochemicalOzoneCreationTRACIMetric.json)
