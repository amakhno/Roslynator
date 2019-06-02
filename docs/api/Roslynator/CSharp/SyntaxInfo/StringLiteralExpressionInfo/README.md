# SyntaxInfo\.StringLiteralExpressionInfo Method

[Home](../../../../README.md)

**Containing Type**: Roslynator\.CSharp\.[SyntaxInfo](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [StringLiteralExpressionInfo(LiteralExpressionSyntax)](#Roslynator_CSharp_SyntaxInfo_StringLiteralExpressionInfo_Microsoft_CodeAnalysis_CSharp_Syntax_LiteralExpressionSyntax_) | Creates a new [StringLiteralExpressionInfo](../../Syntax/StringLiteralExpressionInfo/README.md) from the specified literal expression\. |
| [StringLiteralExpressionInfo(SyntaxNode, Boolean)](#Roslynator_CSharp_SyntaxInfo_StringLiteralExpressionInfo_Microsoft_CodeAnalysis_SyntaxNode_System_Boolean_) | Creates a new [StringLiteralExpressionInfo](../../Syntax/StringLiteralExpressionInfo/README.md) from the specified node\. |

## StringLiteralExpressionInfo\(LiteralExpressionSyntax\) <a name="Roslynator_CSharp_SyntaxInfo_StringLiteralExpressionInfo_Microsoft_CodeAnalysis_CSharp_Syntax_LiteralExpressionSyntax_"></a>

### Summary

Creates a new [StringLiteralExpressionInfo](../../Syntax/StringLiteralExpressionInfo/README.md) from the specified literal expression\.

```csharp
public static Roslynator.CSharp.Syntax.StringLiteralExpressionInfo StringLiteralExpressionInfo(Microsoft.CodeAnalysis.CSharp.Syntax.LiteralExpressionSyntax literalExpression)
```

### Parameters

**literalExpression** &emsp; Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[LiteralExpressionSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.literalexpressionsyntax)

### Returns

Roslynator\.CSharp\.Syntax\.[StringLiteralExpressionInfo](../../Syntax/StringLiteralExpressionInfo/README.md)

## StringLiteralExpressionInfo\(SyntaxNode, Boolean\) <a name="Roslynator_CSharp_SyntaxInfo_StringLiteralExpressionInfo_Microsoft_CodeAnalysis_SyntaxNode_System_Boolean_"></a>

### Summary

Creates a new [StringLiteralExpressionInfo](../../Syntax/StringLiteralExpressionInfo/README.md) from the specified node\.

```csharp
public static Roslynator.CSharp.Syntax.StringLiteralExpressionInfo StringLiteralExpressionInfo(Microsoft.CodeAnalysis.SyntaxNode node, bool walkDownParentheses = true)
```

### Parameters

**node** &emsp; Microsoft\.CodeAnalysis\.[SyntaxNode](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxnode)

**walkDownParentheses** &emsp; [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

### Returns

Roslynator\.CSharp\.Syntax\.[StringLiteralExpressionInfo](../../Syntax/StringLiteralExpressionInfo/README.md)
