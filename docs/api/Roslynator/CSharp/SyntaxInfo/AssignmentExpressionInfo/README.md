# SyntaxInfo\.AssignmentExpressionInfo Method

[Home](../../../../README.md)

**Containing Type**: Roslynator\.CSharp\.[SyntaxInfo](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [AssignmentExpressionInfo(AssignmentExpressionSyntax, Boolean, Boolean)](#Roslynator_CSharp_SyntaxInfo_AssignmentExpressionInfo_Microsoft_CodeAnalysis_CSharp_Syntax_AssignmentExpressionSyntax_System_Boolean_System_Boolean_) | Creates a new [AssignmentExpressionInfo](../../Syntax/AssignmentExpressionInfo/README.md) from the specified assignment expression\. |
| [AssignmentExpressionInfo(SyntaxNode, Boolean, Boolean)](#Roslynator_CSharp_SyntaxInfo_AssignmentExpressionInfo_Microsoft_CodeAnalysis_SyntaxNode_System_Boolean_System_Boolean_) | Creates a new [AssignmentExpressionInfo](../../Syntax/AssignmentExpressionInfo/README.md) from the specified node\. |

## AssignmentExpressionInfo\(AssignmentExpressionSyntax, Boolean, Boolean\) <a name="Roslynator_CSharp_SyntaxInfo_AssignmentExpressionInfo_Microsoft_CodeAnalysis_CSharp_Syntax_AssignmentExpressionSyntax_System_Boolean_System_Boolean_"></a>

### Summary

Creates a new [AssignmentExpressionInfo](../../Syntax/AssignmentExpressionInfo/README.md) from the specified assignment expression\.

```csharp
public static Roslynator.CSharp.Syntax.AssignmentExpressionInfo AssignmentExpressionInfo(Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax assignmentExpression, bool walkDownParentheses = true, bool allowMissing = false)
```

### Parameters

**assignmentExpression** &emsp; Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[AssignmentExpressionSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.assignmentexpressionsyntax)

**walkDownParentheses** &emsp; [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

**allowMissing** &emsp; [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

### Returns

Roslynator\.CSharp\.Syntax\.[AssignmentExpressionInfo](../../Syntax/AssignmentExpressionInfo/README.md)

## AssignmentExpressionInfo\(SyntaxNode, Boolean, Boolean\) <a name="Roslynator_CSharp_SyntaxInfo_AssignmentExpressionInfo_Microsoft_CodeAnalysis_SyntaxNode_System_Boolean_System_Boolean_"></a>

### Summary

Creates a new [AssignmentExpressionInfo](../../Syntax/AssignmentExpressionInfo/README.md) from the specified node\.

```csharp
public static Roslynator.CSharp.Syntax.AssignmentExpressionInfo AssignmentExpressionInfo(Microsoft.CodeAnalysis.SyntaxNode node, bool walkDownParentheses = true, bool allowMissing = false)
```

### Parameters

**node** &emsp; Microsoft\.CodeAnalysis\.[SyntaxNode](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxnode)

**walkDownParentheses** &emsp; [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

**allowMissing** &emsp; [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

### Returns

Roslynator\.CSharp\.Syntax\.[AssignmentExpressionInfo](../../Syntax/AssignmentExpressionInfo/README.md)
