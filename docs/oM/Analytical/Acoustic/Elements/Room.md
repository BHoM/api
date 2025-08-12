---
title: Room
---

# <small>BH.oM.Acoustic.</small>**Room**

An acoustics room is defined by the criteria related to the sound within the space, as well as its geometry

## Class structure

### Implemented interfaces and base types

???+ bhom "The Room is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Boundaries | [PolySurface](/api/oM/Dimensional/Geometry/Surface/PolySurface) | - | - |
| Area | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| Volume | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| Samples | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Receiver](/api/oM/Analytical/Acoustic/Elements/Receiver)&gt; | - | - |
| AcousticZone | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | This specifies the list of spaces associated with a particular occupant activity's acoustic criteria. | - |
| PublicAddressVoiceAlarmZone | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | This specifies the list of spaces associated with similar Public Address and Voice Alarm devices | - |
| AverageInternalAmbientNoiseLevelRequirement | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | This acoustic requirement specificies the maximum equivalent continuous noise level of a time-varying noise (LAeq,T) within a space. This metric is usually composed of noise from many sources, near and far and is measured in A-weighted decibels (dBA). | - |
| MaximumInternalAmbientNoiseLevelRequirement | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | This acoustic requirement specifies the maximum sound pressure level within a space (LAF,max). It is typically measured using the fast time constant in A-weighted decibels (dBA). | - |
| ReverberationTime | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | This acoustic requirement specifies the maximum time for a steady sound pressure level in an enclosed space to decay by 60 dB. This parameter is measured in second from the moment the sound source is switched off.  | - |
| NoiseRating | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Noise rating curves developed by the International Organization for Standardization (ISO) determine the acceptable indoor environment for hearing preservation, speech communication and annoyance. This requirement specifies the maximum noise rating for a space. | - |
| ImpactSoundInsulation | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | This specifies the required impact sound insulation performance for floors. The single figure target value is typically given in for in-situ field measurements (L'nTw) in decibels. The lower the L'nTw, the better the building element will attenuate impact noises. | - |
| SpeechTransmitionIndex | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Speech transmission index (STI) is a metric that represents the transmission quality of speech with respect to intelligibility by a speech transmission channel. This acoustic requirement specifies the minimum STI ranging between 0 and 1. | - |
| PrivacyRequirement | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | This specifies the acoustic privacy requirements of a space. Acoustic privacy for a space is rated according to the noise sensitivity of a receiving room and the level of activity noise within a source room. It is typically denoted by terms Not Private, Moderate and Confidential, and is used to determine the suitable level of sound insulation (DnT,w) for partitions between spaces. | - |
| MinimumSoundPressureLevel | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | This acoustic criterion specifies the minimum sound pressure level required at an audience plane from a Public Address or Voice Alarm system, in decibels.  | - |
| SoundPressureLevelCoverage | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | This acoustic criterion specifies the minimum coverage area of an audience plane that must attain the Public Address or Voice Alarm MinimumSoundPressureLevel requirement. Typically given as a proportion, input a requirement value between 0-1. e.g. 80% coverage = 0.8. | - |
| AcousticUnderlayRequirement | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | By selecting 'True' this boolean indicates the areas of a development that must utilise acoustic underlay in order to attain a suitable impact sound insulation performance (considering the activity in the source rooms and the sensitivity of the receiver room). | - |


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
public class Room : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: Acoustic_oM.dll

The C# class definition is available on github:

- [Room.cs](https://github.com/BHoM/BHoM/blob/develop/Acoustic_oM/Elements\Room.cs)

All history and changes of the class can be found by inspection the history.
