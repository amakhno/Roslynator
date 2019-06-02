# ModifierList\.Insert Method

[Home](../../../../README.md)

**Containing Type**: Roslynator\.CSharp\.[ModifierList](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Insert(SyntaxTokenList, SyntaxKind, IComparer\<SyntaxKind>)](../Insert/README.md#Roslynator_CSharp_ModifierList_Insert_Microsoft_CodeAnalysis_SyntaxTokenList_Microsoft_CodeAnalysis_CSharp_SyntaxKind_System_Collections_Generic_IComparer_Microsoft_CodeAnalysis_CSharp_SyntaxKind__) | Creates a new list of modifiers with the modifier of the specified kind inserted\. |
| [Insert(SyntaxTokenList, SyntaxToken, IComparer\<SyntaxToken>)](../Insert/README.md#Roslynator_CSharp_ModifierList_Insert_Microsoft_CodeAnalysis_SyntaxTokenList_Microsoft_CodeAnalysis_SyntaxToken_System_Collections_Generic_IComparer_Microsoft_CodeAnalysis_SyntaxToken__) | Creates a new list of modifiers with a specified modifier inserted\. |
| [Insert\<TNode>(TNode, SyntaxKind, IComparer\<SyntaxKind>)](#Roslynator_CSharp_ModifierList_Insert__1___0_Microsoft_CodeAnalysis_CSharp_SyntaxKind_System_Collections_Generic_IComparer_Microsoft_CodeAnalysis_CSharp_SyntaxKind__) | Creates a new node with a modifier of the specified kind inserted\. |
| [Insert\<TNode>(TNode, SyntaxToken, IComparer\<SyntaxToken>)](#Roslynator_CSharp_ModifierList_Insert__1___0_Microsoft_CodeAnalysis_SyntaxToken_System_Collections_Generic_IComparer_Microsoft_CodeAnalysis_SyntaxToken__) | Creates a new node with the specified modifier inserted\. |

## Insert\(SyntaxTokenList, SyntaxKind, IComparer\<SyntaxKind>\) <a name="Roslynator_CSharp_ModifierList_Insert_Microsoft_CodeAnalysis_SyntaxTokenList_Microsoft_CodeAnalysis_CSharp_SyntaxKind_System_Collections_Generic_IComparer_Microsoft_CodeAnalysis_CSharp_SyntaxKind__"></a>

### Summary

Creates a new list of modifiers with the modifier of the specified kind inserted\.

```csharp
public static Microsoft.CodeAnalysis.SyntaxTokenList Insert(Microsoft.CodeAnalysis.SyntaxTokenList modifiers, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind, System.Collections.Generic.IComparer<Microsoft.CodeAnalysis.CSharp.SyntaxKind> comparer = null)
```

### Parameters

**modifiers** &emsp; Microsoft\.CodeAnalysis\.[SyntaxTokenList](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtokenlist)

**kind** &emsp; Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)

**comparer** &emsp; System\.Collections\.Generic\.[IComparer](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icomparer-1)\<Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)>

### Returns

Microsoft\.CodeAnalysis\.[SyntaxTokenList](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtokenlist)

## Insert\(SyntaxTokenList, SyntaxToken, IComparer\<SyntaxToken>\) <a name="Roslynator_CSharp_ModifierList_Insert_Microsoft_CodeAnalysis_SyntaxTokenList_Microsoft_CodeAnalysis_SyntaxToken_System_Collections_Generic_IComparer_Microsoft_CodeAnalysis_SyntaxToken__"></a>

### Summary

Creates a new list of modifiers with a specified modifier inserted\.

```csharp
public static Microsoft.CodeAnalysis.SyntaxTokenList Insert(Microsoft.CodeAnalysis.SyntaxTokenList modifiers, Microsoft.CodeAnalysis.SyntaxToken modifier, System.Collections.Generic.IComparer<Microsoft.CodeAnalysis.SyntaxToken> comparer = null)
```

### Parameters

**modifiers** &emsp; Microsoft\.CodeAnalysis\.[SyntaxTokenList](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtokenlist)

**modifier** &emsp; Microsoft\.CodeAnalysis\.[SyntaxToken](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtoken)

**comparer** &emsp; System\.Collections\.Generic\.[IComparer](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icomparer-1)\<Microsoft\.CodeAnalysis\.[SyntaxToken](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtoken)>

### Returns

Microsoft\.CodeAnalysis\.[SyntaxTokenList](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtokenlist)

## Insert\<TNode>\(TNode, SyntaxKind, IComparer\<SyntaxKind>\) <a name="Roslynator_CSharp_ModifierList_Insert__1___0_Microsoft_CodeAnalysis_CSharp_SyntaxKind_System_Collections_Generic_IComparer_Microsoft_CodeAnalysis_CSharp_SyntaxKind__"></a>

### Summary

Creates a new node with a modifier of the specified kind inserted\.

```csharp
public static TNode Insert<TNode>(TNode node, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind, System.Collections.Generic.IComparer<Microsoft.CodeAnalysis.CSharp.SyntaxKind> comparer = null) where TNode : Microsoft.CodeAnalysis.SyntaxNode
```

### Type Parameters

**TNode**

### Parameters

**node** &emsp; TNode

**kind** &emsp; Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)

**comparer** &emsp; System\.Collections\.Generic\.[IComparer](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icomparer-1)\<Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)>

### Returns

TNode

## Insert\<TNode>\(TNode, SyntaxToken, IComparer\<SyntaxToken>\) <a name="Roslynator_CSharp_ModifierList_Insert__1___0_Microsoft_CodeAnalysis_SyntaxToken_System_Collections_Generic_IComparer_Microsoft_CodeAnalysis_SyntaxToken__"></a>

### Summary

Creates a new node with the specified modifier inserted\.

```csharp
public static TNode Insert<TNode>(TNode node, Microsoft.CodeAnalysis.SyntaxToken modifier, System.Collections.Generic.IComparer<Microsoft.CodeAnalysis.SyntaxToken> comparer = null) where TNode : Microsoft.CodeAnalysis.SyntaxNode
```

### Type Parameters

**TNode**

### Parameters

**node** &emsp; TNode

**modifier** &emsp; Microsoft\.CodeAnalysis\.[SyntaxToken](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtoken)

**comparer** &emsp; System\.Collections\.Generic\.[IComparer](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icomparer-1)\<Microsoft\.CodeAnalysis\.[SyntaxToken](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtoken)>

### Returns

TNode
