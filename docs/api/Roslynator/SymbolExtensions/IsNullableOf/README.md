# SymbolExtensions\.IsNullableOf Method

[Home](../../../README.md)

**Containing Type**: Roslynator\.[SymbolExtensions](../README.md)

**Assembly**: Roslynator\.Core\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [IsNullableOf(INamedTypeSymbol, ITypeSymbol)](#Roslynator_SymbolExtensions_IsNullableOf_Microsoft_CodeAnalysis_INamedTypeSymbol_Microsoft_CodeAnalysis_ITypeSymbol_) | Returns true if the type is [Nullable\<T>](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1) and it has specified type argument\. |
| [IsNullableOf(INamedTypeSymbol, SpecialType)](#Roslynator_SymbolExtensions_IsNullableOf_Microsoft_CodeAnalysis_INamedTypeSymbol_Microsoft_CodeAnalysis_SpecialType_) | Returns true if the type is [Nullable\<T>](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1) and it has specified type argument\. |
| [IsNullableOf(ITypeSymbol, ITypeSymbol)](#Roslynator_SymbolExtensions_IsNullableOf_Microsoft_CodeAnalysis_ITypeSymbol_Microsoft_CodeAnalysis_ITypeSymbol_) | Returns true if the type is [Nullable\<T>](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1) and it has specified type argument\. |
| [IsNullableOf(ITypeSymbol, SpecialType)](#Roslynator_SymbolExtensions_IsNullableOf_Microsoft_CodeAnalysis_ITypeSymbol_Microsoft_CodeAnalysis_SpecialType_) | Returns true if the type is [Nullable\<T>](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1) and it has specified type argument\. |

## IsNullableOf\(INamedTypeSymbol, ITypeSymbol\) <a name="Roslynator_SymbolExtensions_IsNullableOf_Microsoft_CodeAnalysis_INamedTypeSymbol_Microsoft_CodeAnalysis_ITypeSymbol_"></a>

### Summary

Returns true if the type is [Nullable\<T>](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1) and it has specified type argument\.

```csharp
public static bool IsNullableOf(this Microsoft.CodeAnalysis.INamedTypeSymbol namedTypeSymbol, Microsoft.CodeAnalysis.ITypeSymbol typeArgument)
```

### Parameters

**namedTypeSymbol** &emsp; Microsoft\.CodeAnalysis\.[INamedTypeSymbol](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.inamedtypesymbol)

**typeArgument** &emsp; Microsoft\.CodeAnalysis\.[ITypeSymbol](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.itypesymbol)

### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

## IsNullableOf\(INamedTypeSymbol, SpecialType\) <a name="Roslynator_SymbolExtensions_IsNullableOf_Microsoft_CodeAnalysis_INamedTypeSymbol_Microsoft_CodeAnalysis_SpecialType_"></a>

### Summary

Returns true if the type is [Nullable\<T>](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1) and it has specified type argument\.

```csharp
public static bool IsNullableOf(this Microsoft.CodeAnalysis.INamedTypeSymbol namedTypeSymbol, Microsoft.CodeAnalysis.SpecialType specialType)
```

### Parameters

**namedTypeSymbol** &emsp; Microsoft\.CodeAnalysis\.[INamedTypeSymbol](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.inamedtypesymbol)

**specialType** &emsp; Microsoft\.CodeAnalysis\.[SpecialType](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.specialtype)

### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

## IsNullableOf\(ITypeSymbol, ITypeSymbol\) <a name="Roslynator_SymbolExtensions_IsNullableOf_Microsoft_CodeAnalysis_ITypeSymbol_Microsoft_CodeAnalysis_ITypeSymbol_"></a>

### Summary

Returns true if the type is [Nullable\<T>](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1) and it has specified type argument\.

```csharp
public static bool IsNullableOf(this Microsoft.CodeAnalysis.ITypeSymbol typeSymbol, Microsoft.CodeAnalysis.ITypeSymbol typeArgument)
```

### Parameters

**typeSymbol** &emsp; Microsoft\.CodeAnalysis\.[ITypeSymbol](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.itypesymbol)

**typeArgument** &emsp; Microsoft\.CodeAnalysis\.[ITypeSymbol](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.itypesymbol)

### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

## IsNullableOf\(ITypeSymbol, SpecialType\) <a name="Roslynator_SymbolExtensions_IsNullableOf_Microsoft_CodeAnalysis_ITypeSymbol_Microsoft_CodeAnalysis_SpecialType_"></a>

### Summary

Returns true if the type is [Nullable\<T>](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1) and it has specified type argument\.

```csharp
public static bool IsNullableOf(this Microsoft.CodeAnalysis.ITypeSymbol typeSymbol, Microsoft.CodeAnalysis.SpecialType specialType)
```

### Parameters

**typeSymbol** &emsp; Microsoft\.CodeAnalysis\.[ITypeSymbol](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.itypesymbol)

**specialType** &emsp; Microsoft\.CodeAnalysis\.[SpecialType](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.specialtype)

### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)
