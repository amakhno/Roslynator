# CSharpFactory\.ObjectInitializerExpression Method

[Home](../../../../README.md)

**Containing Type**: Roslynator\.CSharp\.[CSharpFactory](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [ObjectInitializerExpression(SeparatedSyntaxList\<ExpressionSyntax>)](#Roslynator_CSharp_CSharpFactory_ObjectInitializerExpression_Microsoft_CodeAnalysis_SeparatedSyntaxList_Microsoft_CodeAnalysis_CSharp_Syntax_ExpressionSyntax__) | |
| [ObjectInitializerExpression(SyntaxToken, SeparatedSyntaxList\<ExpressionSyntax>, SyntaxToken)](#Roslynator_CSharp_CSharpFactory_ObjectInitializerExpression_Microsoft_CodeAnalysis_SyntaxToken_Microsoft_CodeAnalysis_SeparatedSyntaxList_Microsoft_CodeAnalysis_CSharp_Syntax_ExpressionSyntax__Microsoft_CodeAnalysis_SyntaxToken_) | |

## ObjectInitializerExpression\(SeparatedSyntaxList\<ExpressionSyntax>\) <a name="Roslynator_CSharp_CSharpFactory_ObjectInitializerExpression_Microsoft_CodeAnalysis_SeparatedSyntaxList_Microsoft_CodeAnalysis_CSharp_Syntax_ExpressionSyntax__"></a>

```csharp
public static Microsoft.CodeAnalysis.CSharp.Syntax.InitializerExpressionSyntax ObjectInitializerExpression(Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax> expressions = default)
```

### Parameters

**expressions** &emsp; Microsoft\.CodeAnalysis\.[SeparatedSyntaxList](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.separatedsyntaxlist-1)\<Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[ExpressionSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.expressionsyntax)>

### Returns

Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[InitializerExpressionSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.initializerexpressionsyntax)

## ObjectInitializerExpression\(SyntaxToken, SeparatedSyntaxList\<ExpressionSyntax>, SyntaxToken\) <a name="Roslynator_CSharp_CSharpFactory_ObjectInitializerExpression_Microsoft_CodeAnalysis_SyntaxToken_Microsoft_CodeAnalysis_SeparatedSyntaxList_Microsoft_CodeAnalysis_CSharp_Syntax_ExpressionSyntax__Microsoft_CodeAnalysis_SyntaxToken_"></a>

```csharp
public static Microsoft.CodeAnalysis.CSharp.Syntax.InitializerExpressionSyntax ObjectInitializerExpression(Microsoft.CodeAnalysis.SyntaxToken openBraceToken, Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax> expressions, Microsoft.CodeAnalysis.SyntaxToken closeBraceToken)
```

### Parameters

**openBraceToken** &emsp; Microsoft\.CodeAnalysis\.[SyntaxToken](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtoken)

**expressions** &emsp; Microsoft\.CodeAnalysis\.[SeparatedSyntaxList](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.separatedsyntaxlist-1)\<Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[ExpressionSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.expressionsyntax)>

**closeBraceToken** &emsp; Microsoft\.CodeAnalysis\.[SyntaxToken](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtoken)

### Returns

Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[InitializerExpressionSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.initializerexpressionsyntax)
