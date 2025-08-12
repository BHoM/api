---
title: Audit
---

# <small>BH.oM.Inspection.</small>**Audit**

An audit that covers all information associated with a single inspection. This includes issues, areas inspected, project information, construction progress, and distribution information.

## Class structure

### Implemented interfaces and base types

???+ bhom "The Audit is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Title | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Title of Audit (typically the project name or name of a specific scope of the project) | - |
| Filename | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Filename of Audit used to identify it when saved to reports or other formats | - |
| AuditID | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Unique ID of Audit provided by the Audit's source | - |
| SiteVisitNumber | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Site Visit Number of the Audit (this is a sequential number corresponding to the amount of audits conducted for this project up to this point) | - |
| Client | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Client for which the Audit is being recorded | - |
| RevisionNumber | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Revision Number of the Audit (typically 0, only used when the information related to a specific audit is revised) | - |
| InspectionDate | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/System.DateTime?view=netstandard-2.0) | Date the Audit was conducted in local time. | - |
| InspectionDateUtc | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/System.DateTime?view=netstandard-2.0) | Date the Audit was conducted in UTC time. | - |
| IssueDate | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/System.DateTime?view=netstandard-2.0) | Date the Audit was issued in local time. | - |
| IssueDateUtc | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/System.DateTime?view=netstandard-2.0) | Date the Audit was issued in UTC time. | - |
| Author | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Creator of the Audit | - |
| ProjectNumber | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Project Number of the Project the Audit is for | - |
| JobLeader | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Job leader of the Project the Audit is for | - |
| Distribution | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | List of people the Audit is distributed to | - |
| Attendance | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | List of people in attendance during audit | - |
| VisitPurpose | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Reason(s) for visit and audit | - |
| AreasInspected | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | List of areas inspected throughout the audit | - |
| InstallationProgressObjects | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[InstallationProgress](/api/oM/Analytical/Inspection/InstallationProgress)&gt; | Installation progress objects from the audit (Each of these corresponds to the status of a specific area inspected) | - |
| IssueNumbers | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Issues from audit. These are reference IssueNumbers to corresponding issues identified during the audit for various areas that need to be addressed, which can include supporting images of the work as applicable. | - |
| Score | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Score as a percentage. This represents the amount of issues / areas that have been resolved, and is an optional value not used by all audits. | - |


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
public class Audit : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: Inspection_oM.dll

The C# class definition is available on github:

- [Audit.cs](https://github.com/BHoM/BHoM/blob/develop/Inspection_oM/Audit.cs)

All history and changes of the class can be found by inspection the history.
