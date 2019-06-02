# WorkspaceSyntaxExtensions\.WithRenameAnnotation\(SyntaxToken\) Method

[Home](../../../../README.md)

**Containing Type**: Roslynator\.CSharp\.[WorkspaceSyntaxExtensions](../README.md)

**Assembly**: Roslynator\.CSharp\.Workspaces\.dll

## Summary

Adds "rename" annotation to the specified token, creating a new token of the same type with the "rename" annotation on it\.
"Rename" annotation is specified by [RenameAnnotation.Kind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.codeactions.renameannotation.kind)\.

```csharp
public static Microsoft.CodeAnalysis.SyntaxToken WithRenameAnnotation(this Microsoft.CodeAnalysis.SyntaxToken token)
```

### Parameters

**token** &emsp; Microsoft\.CodeAnalysis\.[SyntaxToken](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtoken)

### Returns

Microsoft\.CodeAnalysis\.[SyntaxToken](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtoken)
