# SyntaxExtensions\.ToSeparatedSyntaxList Method

[Home](../../../../README.md)

**Containing Type**: Roslynator\.CSharp\.[SyntaxExtensions](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [ToSeparatedSyntaxList\<TNode>(IEnumerable\<SyntaxNodeOrToken>)](#Roslynator_CSharp_SyntaxExtensions_ToSeparatedSyntaxList__1_System_Collections_Generic_IEnumerable_Microsoft_CodeAnalysis_SyntaxNodeOrToken__) | Creates a separated list of syntax nodes from a sequence of nodes and tokens\. |
| [ToSeparatedSyntaxList\<TNode>(IEnumerable\<TNode>)](#Roslynator_CSharp_SyntaxExtensions_ToSeparatedSyntaxList__1_System_Collections_Generic_IEnumerable___0__) | Creates a separated list of syntax nodes from a sequence of nodes\. |

## ToSeparatedSyntaxList\<TNode>\(IEnumerable\<SyntaxNodeOrToken>\) <a name="Roslynator_CSharp_SyntaxExtensions_ToSeparatedSyntaxList__1_System_Collections_Generic_IEnumerable_Microsoft_CodeAnalysis_SyntaxNodeOrToken__"></a>

### Summary

Creates a separated list of syntax nodes from a sequence of nodes and tokens\.

```csharp
public static Microsoft.CodeAnalysis.SeparatedSyntaxList<TNode> ToSeparatedSyntaxList<TNode>(this System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken> nodesAndTokens) where TNode : Microsoft.CodeAnalysis.SyntaxNode
```

### Type Parameters

**TNode**

### Parameters

**nodesAndTokens** &emsp; System\.Collections\.Generic\.[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<Microsoft\.CodeAnalysis\.[SyntaxNodeOrToken](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxnodeortoken)>

### Returns

Microsoft\.CodeAnalysis\.[SeparatedSyntaxList](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.separatedsyntaxlist-1)\<TNode>

## ToSeparatedSyntaxList\<TNode>\(IEnumerable\<TNode>\) <a name="Roslynator_CSharp_SyntaxExtensions_ToSeparatedSyntaxList__1_System_Collections_Generic_IEnumerable___0__"></a>

### Summary

Creates a separated list of syntax nodes from a sequence of nodes\.

```csharp
public static Microsoft.CodeAnalysis.SeparatedSyntaxList<TNode> ToSeparatedSyntaxList<TNode>(this System.Collections.Generic.IEnumerable<TNode> nodes) where TNode : Microsoft.CodeAnalysis.SyntaxNode
```

### Type Parameters

**TNode**

### Parameters

**nodes** &emsp; System\.Collections\.Generic\.[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<TNode>

### Returns

Microsoft\.CodeAnalysis\.[SeparatedSyntaxList](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.separatedsyntaxlist-1)\<TNode>
