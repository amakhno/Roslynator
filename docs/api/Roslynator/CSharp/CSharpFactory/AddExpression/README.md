# CSharpFactory\.AddExpression Method

[Home](../../../../README.md)

**Containing Type**: Roslynator\.CSharp\.[CSharpFactory](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [AddExpression(ExpressionSyntax, ExpressionSyntax)](#Roslynator_CSharp_CSharpFactory_AddExpression_Microsoft_CodeAnalysis_CSharp_Syntax_ExpressionSyntax_Microsoft_CodeAnalysis_CSharp_Syntax_ExpressionSyntax_) | |
| [AddExpression(ExpressionSyntax, SyntaxToken, ExpressionSyntax)](#Roslynator_CSharp_CSharpFactory_AddExpression_Microsoft_CodeAnalysis_CSharp_Syntax_ExpressionSyntax_Microsoft_CodeAnalysis_SyntaxToken_Microsoft_CodeAnalysis_CSharp_Syntax_ExpressionSyntax_) | |

## AddExpression\(ExpressionSyntax, ExpressionSyntax\) <a name="Roslynator_CSharp_CSharpFactory_AddExpression_Microsoft_CodeAnalysis_CSharp_Syntax_ExpressionSyntax_Microsoft_CodeAnalysis_CSharp_Syntax_ExpressionSyntax_"></a>

```csharp
public static Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax AddExpression(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax left, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax right)
```

### Parameters

**left** &emsp; Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[ExpressionSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.expressionsyntax)

**right** &emsp; Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[ExpressionSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.expressionsyntax)

### Returns

Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[BinaryExpressionSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.binaryexpressionsyntax)

## AddExpression\(ExpressionSyntax, SyntaxToken, ExpressionSyntax\) <a name="Roslynator_CSharp_CSharpFactory_AddExpression_Microsoft_CodeAnalysis_CSharp_Syntax_ExpressionSyntax_Microsoft_CodeAnalysis_SyntaxToken_Microsoft_CodeAnalysis_CSharp_Syntax_ExpressionSyntax_"></a>

```csharp
public static Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax AddExpression(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax left, Microsoft.CodeAnalysis.SyntaxToken operatorToken, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax right)
```

### Parameters

**left** &emsp; Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[ExpressionSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.expressionsyntax)

**operatorToken** &emsp; Microsoft\.CodeAnalysis\.[SyntaxToken](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtoken)

**right** &emsp; Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[ExpressionSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.expressionsyntax)

### Returns

Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[BinaryExpressionSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.binaryexpressionsyntax)
