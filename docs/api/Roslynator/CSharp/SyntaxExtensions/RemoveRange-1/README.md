# SyntaxExtensions\.RemoveRange Method

[Home](../../../../README.md)

**Containing Type**: Roslynator\.CSharp\.[SyntaxExtensions](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [RemoveRange(SyntaxTokenList, Int32, Int32)](../RemoveRange/README.md#Roslynator_CSharp_SyntaxExtensions_RemoveRange_Microsoft_CodeAnalysis_SyntaxTokenList_System_Int32_System_Int32_) | Creates a new list with tokens in the specified range removed\. |
| [RemoveRange(SyntaxTriviaList, Int32, Int32)](../RemoveRange/README.md#Roslynator_CSharp_SyntaxExtensions_RemoveRange_Microsoft_CodeAnalysis_SyntaxTriviaList_System_Int32_System_Int32_) | Creates a new list with trivia in the specified range removed\. |
| [RemoveRange\<TNode>(SeparatedSyntaxList\<TNode>, Int32, Int32)](#Roslynator_CSharp_SyntaxExtensions_RemoveRange__1_Microsoft_CodeAnalysis_SeparatedSyntaxList___0__System_Int32_System_Int32_) | Creates a new list with elements in the specified range removed\. |
| [RemoveRange\<TNode>(SyntaxList\<TNode>, Int32, Int32)](#Roslynator_CSharp_SyntaxExtensions_RemoveRange__1_Microsoft_CodeAnalysis_SyntaxList___0__System_Int32_System_Int32_) | Creates a new list with elements in the specified range removed\. |

## RemoveRange\(SyntaxTokenList, Int32, Int32\) <a name="Roslynator_CSharp_SyntaxExtensions_RemoveRange_Microsoft_CodeAnalysis_SyntaxTokenList_System_Int32_System_Int32_"></a>

### Summary

Creates a new list with tokens in the specified range removed\.

```csharp
public static Microsoft.CodeAnalysis.SyntaxTokenList RemoveRange(this Microsoft.CodeAnalysis.SyntaxTokenList list, int index, int count)
```

### Parameters

**list** &emsp; Microsoft\.CodeAnalysis\.[SyntaxTokenList](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtokenlist)

**index** &emsp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

An index of the first element to remove\.

**count** &emsp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of elements to remove\.

### Returns

Microsoft\.CodeAnalysis\.[SyntaxTokenList](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtokenlist)

## RemoveRange\(SyntaxTriviaList, Int32, Int32\) <a name="Roslynator_CSharp_SyntaxExtensions_RemoveRange_Microsoft_CodeAnalysis_SyntaxTriviaList_System_Int32_System_Int32_"></a>

### Summary

Creates a new list with trivia in the specified range removed\.

```csharp
public static Microsoft.CodeAnalysis.SyntaxTriviaList RemoveRange(this Microsoft.CodeAnalysis.SyntaxTriviaList list, int index, int count)
```

### Parameters

**list** &emsp; Microsoft\.CodeAnalysis\.[SyntaxTriviaList](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtrivialist)

**index** &emsp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

An index of the first element to remove\.

**count** &emsp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of elements to remove\.

### Returns

Microsoft\.CodeAnalysis\.[SyntaxTriviaList](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtrivialist)

## RemoveRange\<TNode>\(SeparatedSyntaxList\<TNode>, Int32, Int32\) <a name="Roslynator_CSharp_SyntaxExtensions_RemoveRange__1_Microsoft_CodeAnalysis_SeparatedSyntaxList___0__System_Int32_System_Int32_"></a>

### Summary

Creates a new list with elements in the specified range removed\.

```csharp
public static Microsoft.CodeAnalysis.SeparatedSyntaxList<TNode> RemoveRange<TNode>(this Microsoft.CodeAnalysis.SeparatedSyntaxList<TNode> list, int index, int count) where TNode : Microsoft.CodeAnalysis.SyntaxNode
```

### Type Parameters

**TNode**

### Parameters

**list** &emsp; Microsoft\.CodeAnalysis\.[SeparatedSyntaxList](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.separatedsyntaxlist-1)\<TNode>

**index** &emsp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

An index of the first element to remove\.

**count** &emsp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of elements to remove\.

### Returns

Microsoft\.CodeAnalysis\.[SeparatedSyntaxList](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.separatedsyntaxlist-1)\<TNode>

## RemoveRange\<TNode>\(SyntaxList\<TNode>, Int32, Int32\) <a name="Roslynator_CSharp_SyntaxExtensions_RemoveRange__1_Microsoft_CodeAnalysis_SyntaxList___0__System_Int32_System_Int32_"></a>

### Summary

Creates a new list with elements in the specified range removed\.

```csharp
public static Microsoft.CodeAnalysis.SyntaxList<TNode> RemoveRange<TNode>(this Microsoft.CodeAnalysis.SyntaxList<TNode> list, int index, int count) where TNode : Microsoft.CodeAnalysis.SyntaxNode
```

### Type Parameters

**TNode**

### Parameters

**list** &emsp; Microsoft\.CodeAnalysis\.[SyntaxList](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxlist-1)\<TNode>

**index** &emsp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

An index of the first element to remove\.

**count** &emsp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of elements to remove\.

### Returns

Microsoft\.CodeAnalysis\.[SyntaxList](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxlist-1)\<TNode>
