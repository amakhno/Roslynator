# MetadataName\.Parse\(String\) Method

[Home](../../../README.md)

**Containing Type**: Roslynator\.[MetadataName](../README.md)

**Assembly**: Roslynator\.Core\.dll

## Summary

Converts the string representation of a fully qualified metadata name to its [MetadataName](../README.md) equivalent\.

```csharp
public static Roslynator.MetadataName Parse(string name)
```

### Parameters

**name** &emsp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

### Returns

Roslynator\.[MetadataName](../README.md)

### Exceptions

[ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)

**name** is empty or invalid\.

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**name** is `null`\.
