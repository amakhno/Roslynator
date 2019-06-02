# MemberDeclarationListInfo\.IndexOf Method

[Home](../../../../../README.md)

**Containing Type**: Roslynator\.CSharp\.Syntax\.[MemberDeclarationListInfo](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [IndexOf(Func\<MemberDeclarationSyntax, Boolean>)](#Roslynator_CSharp_Syntax_MemberDeclarationListInfo_IndexOf_System_Func_Microsoft_CodeAnalysis_CSharp_Syntax_MemberDeclarationSyntax_System_Boolean__) | Searches for a member that matches the predicate and returns returns zero\-based index of the first occurrence in the list\. |
| [IndexOf(MemberDeclarationSyntax)](#Roslynator_CSharp_Syntax_MemberDeclarationListInfo_IndexOf_Microsoft_CodeAnalysis_CSharp_Syntax_MemberDeclarationSyntax_) | The index of the member in the list\. |

## IndexOf\(Func\<MemberDeclarationSyntax, Boolean>\) <a name="Roslynator_CSharp_Syntax_MemberDeclarationListInfo_IndexOf_System_Func_Microsoft_CodeAnalysis_CSharp_Syntax_MemberDeclarationSyntax_System_Boolean__"></a>

### Summary

Searches for a member that matches the predicate and returns returns zero\-based index of the first occurrence in the list\.

```csharp
public int IndexOf(Func<Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax, bool> predicate)
```

### Parameters

**predicate** &emsp; [Func](https://docs.microsoft.com/en-us/dotnet/api/system.func-2)\<Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[MemberDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.memberdeclarationsyntax), [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)>

### Returns

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

## IndexOf\(MemberDeclarationSyntax\) <a name="Roslynator_CSharp_Syntax_MemberDeclarationListInfo_IndexOf_Microsoft_CodeAnalysis_CSharp_Syntax_MemberDeclarationSyntax_"></a>

### Summary

The index of the member in the list\.

```csharp
public int IndexOf(Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax member)
```

### Parameters

**member** &emsp; Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[MemberDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.memberdeclarationsyntax)

### Returns

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)
