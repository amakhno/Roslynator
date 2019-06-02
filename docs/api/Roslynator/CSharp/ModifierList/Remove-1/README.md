# ModifierList\.Remove Method

[Home](../../../../README.md)

**Containing Type**: Roslynator\.CSharp\.[ModifierList](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Remove\<TNode>(TNode, SyntaxKind)](#Roslynator_CSharp_ModifierList_Remove__1___0_Microsoft_CodeAnalysis_CSharp_SyntaxKind_) | Creates a new node with a modifier of the specified kind removed\. |
| [Remove\<TNode>(TNode, SyntaxToken)](#Roslynator_CSharp_ModifierList_Remove__1___0_Microsoft_CodeAnalysis_SyntaxToken_) | Creates a new node with the specified modifier removed\. |

## Remove\<TNode>\(TNode, SyntaxKind\) <a name="Roslynator_CSharp_ModifierList_Remove__1___0_Microsoft_CodeAnalysis_CSharp_SyntaxKind_"></a>

### Summary

Creates a new node with a modifier of the specified kind removed\.

```csharp
public static TNode Remove<TNode>(TNode node, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind) where TNode : Microsoft.CodeAnalysis.SyntaxNode
```

### Type Parameters

**TNode**

### Parameters

**node** &emsp; TNode

**kind** &emsp; Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)

### Returns

TNode

## Remove\<TNode>\(TNode, SyntaxToken\) <a name="Roslynator_CSharp_ModifierList_Remove__1___0_Microsoft_CodeAnalysis_SyntaxToken_"></a>

### Summary

Creates a new node with the specified modifier removed\.

```csharp
public static TNode Remove<TNode>(TNode node, Microsoft.CodeAnalysis.SyntaxToken modifier) where TNode : Microsoft.CodeAnalysis.SyntaxNode
```

### Type Parameters

**TNode**

### Parameters

**node** &emsp; TNode

**modifier** &emsp; Microsoft\.CodeAnalysis\.[SyntaxToken](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtoken)

### Returns

TNode
