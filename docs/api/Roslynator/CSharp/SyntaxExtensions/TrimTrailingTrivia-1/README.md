# SyntaxExtensions\.TrimTrailingTrivia Method

[Home](../../../../README.md)

**Containing Type**: Roslynator\.CSharp\.[SyntaxExtensions](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [TrimTrailingTrivia(SyntaxToken)](../TrimTrailingTrivia/README.md#Roslynator_CSharp_SyntaxExtensions_TrimTrailingTrivia_Microsoft_CodeAnalysis_SyntaxToken_) | Removes all trailing whitespace from the trailing trivia and returns a new token with the new trailing trivia\. [SyntaxKind.WhitespaceTrivia](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind.whitespacetrivia) and [SyntaxKind.EndOfLineTrivia](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind.endoflinetrivia) is considered to be a whitespace\. Returns the same token if there is nothing to trim\. |
| [TrimTrailingTrivia\<TNode>(TNode)](#Roslynator_CSharp_SyntaxExtensions_TrimTrailingTrivia__1___0_) | Removes all trailing whitespace from the trailing trivia and returns a new node with the new trailing trivia\. [SyntaxKind.WhitespaceTrivia](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind.whitespacetrivia) and [SyntaxKind.EndOfLineTrivia](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind.endoflinetrivia) is considered to be a whitespace\. Returns the same node if there is nothing to trim\. |

## TrimTrailingTrivia\(SyntaxToken\) <a name="Roslynator_CSharp_SyntaxExtensions_TrimTrailingTrivia_Microsoft_CodeAnalysis_SyntaxToken_"></a>

### Summary

Removes all trailing whitespace from the trailing trivia and returns a new token with the new trailing trivia\.
[SyntaxKind.WhitespaceTrivia](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind.whitespacetrivia) and [SyntaxKind.EndOfLineTrivia](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind.endoflinetrivia) is considered to be a whitespace\.
Returns the same token if there is nothing to trim\.

```csharp
public static Microsoft.CodeAnalysis.SyntaxToken TrimTrailingTrivia(this Microsoft.CodeAnalysis.SyntaxToken token)
```

### Parameters

**token** &emsp; Microsoft\.CodeAnalysis\.[SyntaxToken](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtoken)

### Returns

Microsoft\.CodeAnalysis\.[SyntaxToken](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtoken)

## TrimTrailingTrivia\<TNode>\(TNode\) <a name="Roslynator_CSharp_SyntaxExtensions_TrimTrailingTrivia__1___0_"></a>

### Summary

Removes all trailing whitespace from the trailing trivia and returns a new node with the new trailing trivia\.
[SyntaxKind.WhitespaceTrivia](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind.whitespacetrivia) and [SyntaxKind.EndOfLineTrivia](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind.endoflinetrivia) is considered to be a whitespace\.
Returns the same node if there is nothing to trim\.

```csharp
public static TNode TrimTrailingTrivia<TNode>(this TNode node) where TNode : Microsoft.CodeAnalysis.SyntaxNode
```

### Type Parameters

**TNode**

### Parameters

**node** &emsp; TNode

### Returns

TNode
