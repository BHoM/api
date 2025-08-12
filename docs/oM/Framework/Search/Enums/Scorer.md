---
title: Scorer
---

# <small>BH.oM.Search.</small>**Scorer**

Defines the scorer method to be used in the fuzzy matching methods (i.e. Extract).

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| DefaultRatio |  Calculates a Levenshtein simple ratio between the strings. This indicates a measure of similarity.  |
| PartialRatio |  This ratio uses a heuristic called 'best partial' for when two strings are of noticeably different lengths.  |
| TokenSet |  Splits the strings into tokens and computes intersections and remainders between the tokens of the two strings.A comparison string is then built up and is compared using the simple ratio algorithm. Useful for strings where words appear redundantly.  |
| PartialTokenSet |  Splits the strings into tokens and computes intersections and remainders between the tokens of the two strings.A comparison string is then built up and is compared using the simple ratio algorithm. Useful for strings where words appear redundantly.  |
| TokenSort |  Find all alphanumeric tokens in the string and sort those tokens and then take ratio of resulting joined strings.  |
| PartialTokenSort |  Find all alphanumeric tokens in the string and sort those tokens and then take ratio of resulting joined strings.  |
| TokenAbbreviation |  Similarity ratio that attempts to determine whether one strings tokens are an abbreviation of the other strings tokens. One string must have all its characters in order in the other string to even be considered.  |
| PartialTokenAbbreviation |  Similarity ratio that attempts to determine whether one strings tokens are an abbreviation of the other strings tokens. One string must have all its characters in order in the other string to even be considered.  |
| TokenInitialism |  Splits longer string into tokens and takes the initialism and compares it to the shorter string.  |
| PartialTokenInitialism |  Splits longer string into tokens and takes the initialism and compares it to the shorter string.  |
| WeightedRatio |  Calculates a weighted ratio between the different algorithms for best results.  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum Scorer : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: Search_oM.dll

The C# enum definition is available on github:

- [Scorer.cs](https://github.com/BHoM/BHoM/blob/develop/Search_oM/Enums\Scorer.cs)

All history and changes of the class can be found by inspection the history.
