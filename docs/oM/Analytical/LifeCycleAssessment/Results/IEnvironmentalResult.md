---
title: IEnvironmentalResult
---

# <small>BH.oM.LifeCycleAssessment.Results.</small>**IEnvironmentalResult**

Base interface for all Life Cycle Assessment results.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IEnvironmentalResult is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Analytical.Results.[IResultItem](/api/oM/Analytical/Analytical/Results/IResultItem)
    -  BH.oM.Analytical.Results.[IResult](/api/oM/Analytical/Analytical/Results/IResult)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  [IComparable](https://learn.microsoft.com/en-us/dotnet/api/System.IComparable-1?view=netstandard-2.0)&lt;BH.oM.Analytical.Results.[IResult](/api/oM/Analytical/Analytical/Results/IResult)&gt;
    -  BH.oM.Base.[IImmutable](/api/oM/Framework/Base/Interface/IImmutable)
    -  BH.oM.LifeCycleAssessment.[ILifeCycleAssessmentPhaseData](/api/oM/Analytical/LifeCycleAssessment/ILifeCycleAssessmentPhaseData)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - BH.oM.LifeCycleAssessment.Results.[IElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/IElementResult)&lt;[T](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/IElementResult#t)&gt;


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.LifeCycleAssessment.Results.[AbioticDepletionFossilResourcesElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/AbioticDepletionFossilResourcesElementResult)
    - BH.oM.LifeCycleAssessment.Results.[AbioticDepletionMineralsAndMetalsElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/AbioticDepletionMineralsAndMetalsElementResult)
    - BH.oM.LifeCycleAssessment.Results.[AcidificationElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/AcidificationElementResult)
    - BH.oM.LifeCycleAssessment.Results.[ClimateChangeBiogenicElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/ClimateChangeBiogenicElementResult)
    - BH.oM.LifeCycleAssessment.Results.[ClimateChangeFossilElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/ClimateChangeFossilElementResult)
    - BH.oM.LifeCycleAssessment.Results.[ClimateChangeLandUseElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/ClimateChangeLandUseElementResult)
    - BH.oM.LifeCycleAssessment.Results.[ClimateChangeTotalElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/ClimateChangeTotalElementResult)
    - BH.oM.LifeCycleAssessment.Results.[ClimateChangeTotalNoBiogenicElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/ClimateChangeTotalNoBiogenicElementResult)
    - BH.oM.LifeCycleAssessment.Results.[ElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/ElementResult)&lt;[T](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/ElementResult#t)&gt;
    - BH.oM.LifeCycleAssessment.Results.[EutrophicationAquaticFreshwaterElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/EutrophicationAquaticFreshwaterElementResult)
    - BH.oM.LifeCycleAssessment.Results.[EutrophicationAquaticMarineElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/EutrophicationAquaticMarineElementResult)
    - BH.oM.LifeCycleAssessment.Results.[EutrophicationCMLElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/EutrophicationCMLElementResult)
    - BH.oM.LifeCycleAssessment.Results.[EutrophicationTerrestrialElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/EutrophicationTerrestrialElementResult)
    - BH.oM.LifeCycleAssessment.Results.[EutrophicationTRACIElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/EutrophicationTRACIElementResult)
    - BH.oM.LifeCycleAssessment.Results.[OzoneDepletionElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/OzoneDepletionElementResult)
    - BH.oM.LifeCycleAssessment.Results.[PhotochemicalOzoneCreationCMLElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/PhotochemicalOzoneCreationCMLElementResult)
    - BH.oM.LifeCycleAssessment.Results.[PhotochemicalOzoneCreationElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/PhotochemicalOzoneCreationElementResult)
    - BH.oM.LifeCycleAssessment.Results.[PhotochemicalOzoneCreationTRACIElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/PhotochemicalOzoneCreationTRACIElementResult)
    - BH.oM.LifeCycleAssessment.Results.[WaterDeprivationElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/WaterDeprivationElementResult)
    - BH.oM.LifeCycleAssessment.Results.[AbioticDepletionFossilResourcesMaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/MaterialResults/AbioticDepletionFossilResourcesMaterialResult)
    - BH.oM.LifeCycleAssessment.Results.[AbioticDepletionMineralsAndMetalsMaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/MaterialResults/AbioticDepletionMineralsAndMetalsMaterialResult)
    - BH.oM.LifeCycleAssessment.Results.[AcidificationMaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/MaterialResults/AcidificationMaterialResult)
    - BH.oM.LifeCycleAssessment.Results.[ClimateChangeBiogenicMaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/MaterialResults/ClimateChangeBiogenicMaterialResult)
    - BH.oM.LifeCycleAssessment.Results.[ClimateChangeFossilMaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/MaterialResults/ClimateChangeFossilMaterialResult)
    - BH.oM.LifeCycleAssessment.Results.[ClimateChangeLandUseMaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/MaterialResults/ClimateChangeLandUseMaterialResult)
    - BH.oM.LifeCycleAssessment.Results.[ClimateChangeTotalMaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/MaterialResults/ClimateChangeTotalMaterialResult)
    - BH.oM.LifeCycleAssessment.Results.[ClimateChangeTotalNoBiogenicMaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/MaterialResults/ClimateChangeTotalNoBiogenicMaterialResult)
    - BH.oM.LifeCycleAssessment.Results.[EutrophicationAquaticFreshwaterMaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/MaterialResults/EutrophicationAquaticFreshwaterMaterialResult)
    - BH.oM.LifeCycleAssessment.Results.[EutrophicationAquaticMarineMaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/MaterialResults/EutrophicationAquaticMarineMaterialResult)
    - BH.oM.LifeCycleAssessment.Results.[EutrophicationCMLMaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/MaterialResults/EutrophicationCMLMaterialResult)
    - BH.oM.LifeCycleAssessment.Results.[EutrophicationTerrestrialMaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/MaterialResults/EutrophicationTerrestrialMaterialResult)
    - BH.oM.LifeCycleAssessment.Results.[EutrophicationTRACIMaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/MaterialResults/EutrophicationTRACIMaterialResult)
    - BH.oM.LifeCycleAssessment.Results.[MaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/MaterialResults/MaterialResult)
    - BH.oM.LifeCycleAssessment.Results.[OzoneDepletionMaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/MaterialResults/OzoneDepletionMaterialResult)
    - BH.oM.LifeCycleAssessment.Results.[PhotochemicalOzoneCreationCMLMaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/MaterialResults/PhotochemicalOzoneCreationCMLMaterialResult)
    - BH.oM.LifeCycleAssessment.Results.[PhotochemicalOzoneCreationMaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/MaterialResults/PhotochemicalOzoneCreationMaterialResult)
    - BH.oM.LifeCycleAssessment.Results.[PhotochemicalOzoneCreationTRACIMaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/MaterialResults/PhotochemicalOzoneCreationTRACIMaterialResult)
    - BH.oM.LifeCycleAssessment.Results.[WaterDeprivationMaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/MaterialResults/WaterDeprivationMaterialResult)


## Properties

### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| AllIdentifierProperties | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Gets the name of all properties of the result that are of identifier types. This is all properties tagged with any IdentifierAttribute. | - | Results_Engine |
| ATotal | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the total sum of values from all A-phases (A1-A5) with a set value (all values not NaN). | - | LifeCycleAssessment_Engine |
| BTotal | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the total sum of values from all B-phases (B1-B7) with a set value (all values not NaN). | - | LifeCycleAssessment_Engine |
| CTotal | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the total sum of values from all C-phases (C1-C4) with a set value (all values not NaN). | - | LifeCycleAssessment_Engine |
| IPhaseDataValues | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0)&gt; | Gets the values corresponding to the values of all phases as a list of doubles. | - | LifeCycleAssessment_Engine |
| ObjectIdentifierProperties | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Gets the name of all properties of the result that are of ObjectIdentifier types. This is all properties tagged with the ObjectIdentifierAttribute. | - | Results_Engine |
| ResultPropertyKeys | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Returns the result value carrying properties available for the result type provided. Currently only supported for IResultItem and IResultCollection&lt;IResultItem&gt; type results. | - | Results_Engine |
| ScenarioIdentifierProperties | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Gets the name of all properties of the result that are of Scenario types. This is all properties tagged with the ScenarioIdentifierAttribute. | - | Results_Engine |
| Total | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the total sum of values from all phases with a set value (all values not NaN). | - | LifeCycleAssessment_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IEnvironmentalResult : BH.oM.Analytical.Results.IResultItem,
BH.oM.Analytical.Results.IResult,
BH.oM.Base.IObject,
System.IComparable<BH.oM.Analytical.Results.IResult>,
BH.oM.Base.IImmutable,
BH.oM.LifeCycleAssessment.ILifeCycleAssessmentPhaseData
```

Assembly: LifeCycleAssessment_oM.dll

The interface is defined in C#. The class definition is available on github:

- [IEnvironmentalResult.cs](https://github.com/BHoM/BHoM/blob/develop/LifeCycleAssessment_oM/Results\IEnvironmentalResult.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` { .json .copy .select } title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/LifeCycleAssessment_oM/Results/IEnvironmentalResult.json}
```

The JSON Schema is available on github here:

- [IEnvironmentalResult.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/LifeCycleAssessment_oM/Results/IEnvironmentalResult.json)
