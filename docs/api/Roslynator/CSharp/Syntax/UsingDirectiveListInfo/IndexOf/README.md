# UsingDirectiveListInfo\.IndexOf Method

[Home](../../../../../README.md)

**Containing Type**: Roslynator\.CSharp\.Syntax\.[UsingDirectiveListInfo](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [IndexOf(Func\<UsingDirectiveSyntax, Boolean>)](#Roslynator_CSharp_Syntax_UsingDirectiveListInfo_IndexOf_System_Func_Microsoft_CodeAnalysis_CSharp_Syntax_UsingDirectiveSyntax_System_Boolean__) | Searches for an using directive that matches the predicate and returns returns zero\-based index of the first occurrence in the list\. |
| [IndexOf(UsingDirectiveSyntax)](#Roslynator_CSharp_Syntax_UsingDirectiveListInfo_IndexOf_Microsoft_CodeAnalysis_CSharp_Syntax_UsingDirectiveSyntax_) | The index of the using directive in the list\. |

## IndexOf\(Func\<UsingDirectiveSyntax, Boolean>\) <a name="Roslynator_CSharp_Syntax_UsingDirectiveListInfo_IndexOf_System_Func_Microsoft_CodeAnalysis_CSharp_Syntax_UsingDirectiveSyntax_System_Boolean__"></a>

### Summary

Searches for an using directive that matches the predicate and returns returns zero\-based index of the first occurrence in the list\.

```csharp
public int IndexOf(Func<Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax, bool> predicate)
```

### Parameters

**predicate** &emsp; [Func](https://docs.microsoft.com/en-us/dotnet/api/system.func-2)\<Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[UsingDirectiveSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.usingdirectivesyntax), [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)>

### Returns

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

## IndexOf\(UsingDirectiveSyntax\) <a name="Roslynator_CSharp_Syntax_UsingDirectiveListInfo_IndexOf_Microsoft_CodeAnalysis_CSharp_Syntax_UsingDirectiveSyntax_"></a>

### Summary

The index of the using directive in the list\.

```csharp
public int IndexOf(Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax usingDirective)
```

### Parameters

**usingDirective** &emsp; Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[UsingDirectiveSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.usingdirectivesyntax)

### Returns

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)
