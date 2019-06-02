# SyntaxExtensions\.IsSimpleIf\(IfStatementSyntax\) Method

[Home](../../../../README.md)

**Containing Type**: Roslynator\.CSharp\.[SyntaxExtensions](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Summary

Returns true if the specified if statement is a simple if statement\.
Simple if statement is defined as follows: it is not a child of an else clause and it has no else clause\.

```csharp
public static bool IsSimpleIf(this Microsoft.CodeAnalysis.CSharp.Syntax.IfStatementSyntax ifStatement)
```

### Parameters

**ifStatement** &emsp; Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[IfStatementSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.ifstatementsyntax)

### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)
