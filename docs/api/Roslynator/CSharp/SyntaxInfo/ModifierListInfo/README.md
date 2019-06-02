# SyntaxInfo\.ModifierListInfo Method

[Home](../../../../README.md)

**Containing Type**: Roslynator\.CSharp\.[SyntaxInfo](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [ModifierListInfo(AccessorDeclarationSyntax)](#Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_AccessorDeclarationSyntax_) | Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified accessor declaration\. |
| [ModifierListInfo(ClassDeclarationSyntax)](#Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_ClassDeclarationSyntax_) | Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified class declaration\. |
| [ModifierListInfo(ConstructorDeclarationSyntax)](#Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_ConstructorDeclarationSyntax_) | Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified constructor declaration\. |
| [ModifierListInfo(ConversionOperatorDeclarationSyntax)](#Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_ConversionOperatorDeclarationSyntax_) | Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified conversion operator declaration\. |
| [ModifierListInfo(DelegateDeclarationSyntax)](#Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_DelegateDeclarationSyntax_) | Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified delegate declaration\. |
| [ModifierListInfo(DestructorDeclarationSyntax)](#Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_DestructorDeclarationSyntax_) | Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified destructor declaration\. |
| [ModifierListInfo(EnumDeclarationSyntax)](#Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_EnumDeclarationSyntax_) | Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified enum declaration\. |
| [ModifierListInfo(EventDeclarationSyntax)](#Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_EventDeclarationSyntax_) | Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified event declaration\. |
| [ModifierListInfo(EventFieldDeclarationSyntax)](#Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_EventFieldDeclarationSyntax_) | Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified event field declaration\. |
| [ModifierListInfo(FieldDeclarationSyntax)](#Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_FieldDeclarationSyntax_) | Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified field declaration\. |
| [ModifierListInfo(IncompleteMemberSyntax)](#Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_IncompleteMemberSyntax_) | Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified incomplete member\. |
| [ModifierListInfo(IndexerDeclarationSyntax)](#Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_IndexerDeclarationSyntax_) | Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified indexer declaration\. |
| [ModifierListInfo(InterfaceDeclarationSyntax)](#Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_InterfaceDeclarationSyntax_) | Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified interface declaration\. |
| [ModifierListInfo(LocalDeclarationStatementSyntax)](#Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_LocalDeclarationStatementSyntax_) | Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified local declaration statement\. |
| [ModifierListInfo(LocalFunctionStatementSyntax)](#Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_LocalFunctionStatementSyntax_) | Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified local function\. |
| [ModifierListInfo(MethodDeclarationSyntax)](#Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_MethodDeclarationSyntax_) | Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified method declaration\. |
| [ModifierListInfo(OperatorDeclarationSyntax)](#Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_OperatorDeclarationSyntax_) | Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified operator declaration\. |
| [ModifierListInfo(ParameterSyntax)](#Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_ParameterSyntax_) | Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified parameter\. |
| [ModifierListInfo(PropertyDeclarationSyntax)](#Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_PropertyDeclarationSyntax_) | Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified property declaration\. |
| [ModifierListInfo(StructDeclarationSyntax)](#Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_StructDeclarationSyntax_) | Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified struct declaration\. |
| [ModifierListInfo(SyntaxNode)](#Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_SyntaxNode_) | Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified node\. |

## ModifierListInfo\(AccessorDeclarationSyntax\) <a name="Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_AccessorDeclarationSyntax_"></a>

### Summary

Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified accessor declaration\.

```csharp
public static Roslynator.CSharp.Syntax.ModifierListInfo ModifierListInfo(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax accessorDeclaration)
```

### Parameters

**accessorDeclaration** &emsp; Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[AccessorDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.accessordeclarationsyntax)

### Returns

Roslynator\.CSharp\.Syntax\.[ModifierListInfo](../../Syntax/ModifierListInfo/README.md)

## ModifierListInfo\(ClassDeclarationSyntax\) <a name="Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_ClassDeclarationSyntax_"></a>

### Summary

Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified class declaration\.

```csharp
public static Roslynator.CSharp.Syntax.ModifierListInfo ModifierListInfo(Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax classDeclaration)
```

### Parameters

**classDeclaration** &emsp; Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[ClassDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.classdeclarationsyntax)

### Returns

Roslynator\.CSharp\.Syntax\.[ModifierListInfo](../../Syntax/ModifierListInfo/README.md)

## ModifierListInfo\(ConstructorDeclarationSyntax\) <a name="Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_ConstructorDeclarationSyntax_"></a>

### Summary

Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified constructor declaration\.

```csharp
public static Roslynator.CSharp.Syntax.ModifierListInfo ModifierListInfo(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax constructorDeclaration)
```

### Parameters

**constructorDeclaration** &emsp; Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[ConstructorDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.constructordeclarationsyntax)

### Returns

Roslynator\.CSharp\.Syntax\.[ModifierListInfo](../../Syntax/ModifierListInfo/README.md)

## ModifierListInfo\(ConversionOperatorDeclarationSyntax\) <a name="Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_ConversionOperatorDeclarationSyntax_"></a>

### Summary

Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified conversion operator declaration\.

```csharp
public static Roslynator.CSharp.Syntax.ModifierListInfo ModifierListInfo(Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax conversionOperatorDeclaration)
```

### Parameters

**conversionOperatorDeclaration** &emsp; Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[ConversionOperatorDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.conversionoperatordeclarationsyntax)

### Returns

Roslynator\.CSharp\.Syntax\.[ModifierListInfo](../../Syntax/ModifierListInfo/README.md)

## ModifierListInfo\(DelegateDeclarationSyntax\) <a name="Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_DelegateDeclarationSyntax_"></a>

### Summary

Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified delegate declaration\.

```csharp
public static Roslynator.CSharp.Syntax.ModifierListInfo ModifierListInfo(Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax delegateDeclaration)
```

### Parameters

**delegateDeclaration** &emsp; Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[DelegateDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.delegatedeclarationsyntax)

### Returns

Roslynator\.CSharp\.Syntax\.[ModifierListInfo](../../Syntax/ModifierListInfo/README.md)

## ModifierListInfo\(DestructorDeclarationSyntax\) <a name="Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_DestructorDeclarationSyntax_"></a>

### Summary

Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified destructor declaration\.

```csharp
public static Roslynator.CSharp.Syntax.ModifierListInfo ModifierListInfo(Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax destructorDeclaration)
```

### Parameters

**destructorDeclaration** &emsp; Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[DestructorDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.destructordeclarationsyntax)

### Returns

Roslynator\.CSharp\.Syntax\.[ModifierListInfo](../../Syntax/ModifierListInfo/README.md)

## ModifierListInfo\(EnumDeclarationSyntax\) <a name="Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_EnumDeclarationSyntax_"></a>

### Summary

Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified enum declaration\.

```csharp
public static Roslynator.CSharp.Syntax.ModifierListInfo ModifierListInfo(Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax enumDeclaration)
```

### Parameters

**enumDeclaration** &emsp; Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[EnumDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.enumdeclarationsyntax)

### Returns

Roslynator\.CSharp\.Syntax\.[ModifierListInfo](../../Syntax/ModifierListInfo/README.md)

## ModifierListInfo\(EventDeclarationSyntax\) <a name="Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_EventDeclarationSyntax_"></a>

### Summary

Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified event declaration\.

```csharp
public static Roslynator.CSharp.Syntax.ModifierListInfo ModifierListInfo(Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax eventDeclaration)
```

### Parameters

**eventDeclaration** &emsp; Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[EventDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.eventdeclarationsyntax)

### Returns

Roslynator\.CSharp\.Syntax\.[ModifierListInfo](../../Syntax/ModifierListInfo/README.md)

## ModifierListInfo\(EventFieldDeclarationSyntax\) <a name="Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_EventFieldDeclarationSyntax_"></a>

### Summary

Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified event field declaration\.

```csharp
public static Roslynator.CSharp.Syntax.ModifierListInfo ModifierListInfo(Microsoft.CodeAnalysis.CSharp.Syntax.EventFieldDeclarationSyntax eventFieldDeclaration)
```

### Parameters

**eventFieldDeclaration** &emsp; Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[EventFieldDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.eventfielddeclarationsyntax)

### Returns

Roslynator\.CSharp\.Syntax\.[ModifierListInfo](../../Syntax/ModifierListInfo/README.md)

## ModifierListInfo\(FieldDeclarationSyntax\) <a name="Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_FieldDeclarationSyntax_"></a>

### Summary

Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified field declaration\.

```csharp
public static Roslynator.CSharp.Syntax.ModifierListInfo ModifierListInfo(Microsoft.CodeAnalysis.CSharp.Syntax.FieldDeclarationSyntax fieldDeclaration)
```

### Parameters

**fieldDeclaration** &emsp; Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[FieldDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.fielddeclarationsyntax)

### Returns

Roslynator\.CSharp\.Syntax\.[ModifierListInfo](../../Syntax/ModifierListInfo/README.md)

## ModifierListInfo\(IncompleteMemberSyntax\) <a name="Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_IncompleteMemberSyntax_"></a>

### Summary

Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified incomplete member\.

```csharp
public static Roslynator.CSharp.Syntax.ModifierListInfo ModifierListInfo(Microsoft.CodeAnalysis.CSharp.Syntax.IncompleteMemberSyntax incompleteMember)
```

### Parameters

**incompleteMember** &emsp; Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[IncompleteMemberSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.incompletemembersyntax)

### Returns

Roslynator\.CSharp\.Syntax\.[ModifierListInfo](../../Syntax/ModifierListInfo/README.md)

## ModifierListInfo\(IndexerDeclarationSyntax\) <a name="Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_IndexerDeclarationSyntax_"></a>

### Summary

Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified indexer declaration\.

```csharp
public static Roslynator.CSharp.Syntax.ModifierListInfo ModifierListInfo(Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax indexerDeclaration)
```

### Parameters

**indexerDeclaration** &emsp; Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[IndexerDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.indexerdeclarationsyntax)

### Returns

Roslynator\.CSharp\.Syntax\.[ModifierListInfo](../../Syntax/ModifierListInfo/README.md)

## ModifierListInfo\(InterfaceDeclarationSyntax\) <a name="Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_InterfaceDeclarationSyntax_"></a>

### Summary

Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified interface declaration\.

```csharp
public static Roslynator.CSharp.Syntax.ModifierListInfo ModifierListInfo(Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax interfaceDeclaration)
```

### Parameters

**interfaceDeclaration** &emsp; Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[InterfaceDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.interfacedeclarationsyntax)

### Returns

Roslynator\.CSharp\.Syntax\.[ModifierListInfo](../../Syntax/ModifierListInfo/README.md)

## ModifierListInfo\(LocalDeclarationStatementSyntax\) <a name="Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_LocalDeclarationStatementSyntax_"></a>

### Summary

Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified local declaration statement\.

```csharp
public static Roslynator.CSharp.Syntax.ModifierListInfo ModifierListInfo(Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax localDeclarationStatement)
```

### Parameters

**localDeclarationStatement** &emsp; Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[LocalDeclarationStatementSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.localdeclarationstatementsyntax)

### Returns

Roslynator\.CSharp\.Syntax\.[ModifierListInfo](../../Syntax/ModifierListInfo/README.md)

## ModifierListInfo\(LocalFunctionStatementSyntax\) <a name="Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_LocalFunctionStatementSyntax_"></a>

### Summary

Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified local function\.

```csharp
public static Roslynator.CSharp.Syntax.ModifierListInfo ModifierListInfo(Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax localFunctionStatement)
```

### Parameters

**localFunctionStatement** &emsp; Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[LocalFunctionStatementSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.localfunctionstatementsyntax)

### Returns

Roslynator\.CSharp\.Syntax\.[ModifierListInfo](../../Syntax/ModifierListInfo/README.md)

## ModifierListInfo\(MethodDeclarationSyntax\) <a name="Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_MethodDeclarationSyntax_"></a>

### Summary

Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified method declaration\.

```csharp
public static Roslynator.CSharp.Syntax.ModifierListInfo ModifierListInfo(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax methodDeclaration)
```

### Parameters

**methodDeclaration** &emsp; Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[MethodDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.methoddeclarationsyntax)

### Returns

Roslynator\.CSharp\.Syntax\.[ModifierListInfo](../../Syntax/ModifierListInfo/README.md)

## ModifierListInfo\(OperatorDeclarationSyntax\) <a name="Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_OperatorDeclarationSyntax_"></a>

### Summary

Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified operator declaration\.

```csharp
public static Roslynator.CSharp.Syntax.ModifierListInfo ModifierListInfo(Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax operatorDeclaration)
```

### Parameters

**operatorDeclaration** &emsp; Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[OperatorDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.operatordeclarationsyntax)

### Returns

Roslynator\.CSharp\.Syntax\.[ModifierListInfo](../../Syntax/ModifierListInfo/README.md)

## ModifierListInfo\(ParameterSyntax\) <a name="Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_ParameterSyntax_"></a>

### Summary

Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified parameter\.

```csharp
public static Roslynator.CSharp.Syntax.ModifierListInfo ModifierListInfo(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax parameter)
```

### Parameters

**parameter** &emsp; Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[ParameterSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.parametersyntax)

### Returns

Roslynator\.CSharp\.Syntax\.[ModifierListInfo](../../Syntax/ModifierListInfo/README.md)

## ModifierListInfo\(PropertyDeclarationSyntax\) <a name="Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_PropertyDeclarationSyntax_"></a>

### Summary

Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified property declaration\.

```csharp
public static Roslynator.CSharp.Syntax.ModifierListInfo ModifierListInfo(Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax propertyDeclaration)
```

### Parameters

**propertyDeclaration** &emsp; Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[PropertyDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.propertydeclarationsyntax)

### Returns

Roslynator\.CSharp\.Syntax\.[ModifierListInfo](../../Syntax/ModifierListInfo/README.md)

## ModifierListInfo\(StructDeclarationSyntax\) <a name="Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_StructDeclarationSyntax_"></a>

### Summary

Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified struct declaration\.

```csharp
public static Roslynator.CSharp.Syntax.ModifierListInfo ModifierListInfo(Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax structDeclaration)
```

### Parameters

**structDeclaration** &emsp; Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[StructDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.structdeclarationsyntax)

### Returns

Roslynator\.CSharp\.Syntax\.[ModifierListInfo](../../Syntax/ModifierListInfo/README.md)

## ModifierListInfo\(SyntaxNode\) <a name="Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_SyntaxNode_"></a>

### Summary

Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified node\.

```csharp
public static Roslynator.CSharp.Syntax.ModifierListInfo ModifierListInfo(Microsoft.CodeAnalysis.SyntaxNode node)
```

### Parameters

**node** &emsp; Microsoft\.CodeAnalysis\.[SyntaxNode](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxnode)

### Returns

Roslynator\.CSharp\.Syntax\.[ModifierListInfo](../../Syntax/ModifierListInfo/README.md)
