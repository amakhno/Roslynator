# SyntaxInfo\.SingleLocalDeclarationStatementInfo Method

[Home](../../../../README.md)

**Containing Type**: Roslynator\.CSharp\.[SyntaxInfo](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [SingleLocalDeclarationStatementInfo(ExpressionSyntax)](#Roslynator_CSharp_SyntaxInfo_SingleLocalDeclarationStatementInfo_Microsoft_CodeAnalysis_CSharp_Syntax_ExpressionSyntax_) | Creates a new [SingleLocalDeclarationStatementInfo](../../Syntax/SingleLocalDeclarationStatementInfo/README.md) from the specified value\. |
| [SingleLocalDeclarationStatementInfo(LocalDeclarationStatementSyntax, Boolean)](#Roslynator_CSharp_SyntaxInfo_SingleLocalDeclarationStatementInfo_Microsoft_CodeAnalysis_CSharp_Syntax_LocalDeclarationStatementSyntax_System_Boolean_) | Creates a new [SingleLocalDeclarationStatementInfo](../../Syntax/SingleLocalDeclarationStatementInfo/README.md) from the specified local declaration statement\. |
| [SingleLocalDeclarationStatementInfo(StatementSyntax, Boolean)](#Roslynator_CSharp_SyntaxInfo_SingleLocalDeclarationStatementInfo_Microsoft_CodeAnalysis_CSharp_Syntax_StatementSyntax_System_Boolean_) | Creates a new [SingleLocalDeclarationStatementInfo](../../Syntax/SingleLocalDeclarationStatementInfo/README.md) from the specified statement\. |
| [SingleLocalDeclarationStatementInfo(VariableDeclarationSyntax, Boolean)](#Roslynator_CSharp_SyntaxInfo_SingleLocalDeclarationStatementInfo_Microsoft_CodeAnalysis_CSharp_Syntax_VariableDeclarationSyntax_System_Boolean_) | Creates a new [SingleLocalDeclarationStatementInfo](../../Syntax/SingleLocalDeclarationStatementInfo/README.md) from the specified variable declaration\. |

## SingleLocalDeclarationStatementInfo\(ExpressionSyntax\) <a name="Roslynator_CSharp_SyntaxInfo_SingleLocalDeclarationStatementInfo_Microsoft_CodeAnalysis_CSharp_Syntax_ExpressionSyntax_"></a>

### Summary

Creates a new [SingleLocalDeclarationStatementInfo](../../Syntax/SingleLocalDeclarationStatementInfo/README.md) from the specified value\.

```csharp
public static Roslynator.CSharp.Syntax.SingleLocalDeclarationStatementInfo SingleLocalDeclarationStatementInfo(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax value)
```

### Parameters

**value** &emsp; Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[ExpressionSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.expressionsyntax)

### Returns

Roslynator\.CSharp\.Syntax\.[SingleLocalDeclarationStatementInfo](../../Syntax/SingleLocalDeclarationStatementInfo/README.md)

## SingleLocalDeclarationStatementInfo\(LocalDeclarationStatementSyntax, Boolean\) <a name="Roslynator_CSharp_SyntaxInfo_SingleLocalDeclarationStatementInfo_Microsoft_CodeAnalysis_CSharp_Syntax_LocalDeclarationStatementSyntax_System_Boolean_"></a>

### Summary

Creates a new [SingleLocalDeclarationStatementInfo](../../Syntax/SingleLocalDeclarationStatementInfo/README.md) from the specified local declaration statement\.

```csharp
public static Roslynator.CSharp.Syntax.SingleLocalDeclarationStatementInfo SingleLocalDeclarationStatementInfo(Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax localDeclarationStatement, bool allowMissing = false)
```

### Parameters

**localDeclarationStatement** &emsp; Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[LocalDeclarationStatementSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.localdeclarationstatementsyntax)

**allowMissing** &emsp; [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

### Returns

Roslynator\.CSharp\.Syntax\.[SingleLocalDeclarationStatementInfo](../../Syntax/SingleLocalDeclarationStatementInfo/README.md)

## SingleLocalDeclarationStatementInfo\(StatementSyntax, Boolean\) <a name="Roslynator_CSharp_SyntaxInfo_SingleLocalDeclarationStatementInfo_Microsoft_CodeAnalysis_CSharp_Syntax_StatementSyntax_System_Boolean_"></a>

### Summary

Creates a new [SingleLocalDeclarationStatementInfo](../../Syntax/SingleLocalDeclarationStatementInfo/README.md) from the specified statement\.

```csharp
public static Roslynator.CSharp.Syntax.SingleLocalDeclarationStatementInfo SingleLocalDeclarationStatementInfo(Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax statement, bool allowMissing = false)
```

### Parameters

**statement** &emsp; Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[StatementSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.statementsyntax)

**allowMissing** &emsp; [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

### Returns

Roslynator\.CSharp\.Syntax\.[SingleLocalDeclarationStatementInfo](../../Syntax/SingleLocalDeclarationStatementInfo/README.md)

## SingleLocalDeclarationStatementInfo\(VariableDeclarationSyntax, Boolean\) <a name="Roslynator_CSharp_SyntaxInfo_SingleLocalDeclarationStatementInfo_Microsoft_CodeAnalysis_CSharp_Syntax_VariableDeclarationSyntax_System_Boolean_"></a>

### Summary

Creates a new [SingleLocalDeclarationStatementInfo](../../Syntax/SingleLocalDeclarationStatementInfo/README.md) from the specified variable declaration\.

```csharp
public static Roslynator.CSharp.Syntax.SingleLocalDeclarationStatementInfo SingleLocalDeclarationStatementInfo(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax variableDeclaration, bool allowMissing = false)
```

### Parameters

**variableDeclaration** &emsp; Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[VariableDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.variabledeclarationsyntax)

**allowMissing** &emsp; [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

### Returns

Roslynator\.CSharp\.Syntax\.[SingleLocalDeclarationStatementInfo](../../Syntax/SingleLocalDeclarationStatementInfo/README.md)
