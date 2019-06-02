# SymbolExtensions\.ImplementsInterfaceMember Method

[Home](../../../README.md)

**Containing Type**: Roslynator\.[SymbolExtensions](../README.md)

**Assembly**: Roslynator\.Core\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [ImplementsInterfaceMember(ISymbol, Boolean)](#Roslynator_SymbolExtensions_ImplementsInterfaceMember_Microsoft_CodeAnalysis_ISymbol_System_Boolean_) | Returns true if the the symbol implements any interface member\. |
| [ImplementsInterfaceMember(ISymbol, INamedTypeSymbol, Boolean)](#Roslynator_SymbolExtensions_ImplementsInterfaceMember_Microsoft_CodeAnalysis_ISymbol_Microsoft_CodeAnalysis_INamedTypeSymbol_System_Boolean_) | Returns true if the symbol implements any member of the specified interface\. |
| [ImplementsInterfaceMember\<TSymbol>(ISymbol, Boolean)](../ImplementsInterfaceMember-1/README.md#Roslynator_SymbolExtensions_ImplementsInterfaceMember__1_Microsoft_CodeAnalysis_ISymbol_System_Boolean_) | Returns true if the symbol implements any interface member\. |
| [ImplementsInterfaceMember\<TSymbol>(ISymbol, INamedTypeSymbol, Boolean)](../ImplementsInterfaceMember-1/README.md#Roslynator_SymbolExtensions_ImplementsInterfaceMember__1_Microsoft_CodeAnalysis_ISymbol_Microsoft_CodeAnalysis_INamedTypeSymbol_System_Boolean_) | Returns true if the symbol implements any member of the specified interface\. |

## ImplementsInterfaceMember\(ISymbol, Boolean\) <a name="Roslynator_SymbolExtensions_ImplementsInterfaceMember_Microsoft_CodeAnalysis_ISymbol_System_Boolean_"></a>

### Summary

Returns true if the the symbol implements any interface member\.

```csharp
public static bool ImplementsInterfaceMember(this Microsoft.CodeAnalysis.ISymbol symbol, bool allInterfaces = false)
```

### Parameters

**symbol** &emsp; Microsoft\.CodeAnalysis\.[ISymbol](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.isymbol)

**allInterfaces** &emsp; [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

If true, use [ITypeSymbol.AllInterfaces](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.itypesymbol.allinterfaces), otherwise use [ITypeSymbol.Interfaces](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.itypesymbol.interfaces)\.

### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

## ImplementsInterfaceMember\(ISymbol, INamedTypeSymbol, Boolean\) <a name="Roslynator_SymbolExtensions_ImplementsInterfaceMember_Microsoft_CodeAnalysis_ISymbol_Microsoft_CodeAnalysis_INamedTypeSymbol_System_Boolean_"></a>

### Summary

Returns true if the symbol implements any member of the specified interface\.

```csharp
public static bool ImplementsInterfaceMember(this Microsoft.CodeAnalysis.ISymbol symbol, Microsoft.CodeAnalysis.INamedTypeSymbol interfaceSymbol, bool allInterfaces = false)
```

### Parameters

**symbol** &emsp; Microsoft\.CodeAnalysis\.[ISymbol](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.isymbol)

**interfaceSymbol** &emsp; Microsoft\.CodeAnalysis\.[INamedTypeSymbol](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.inamedtypesymbol)

**allInterfaces** &emsp; [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

If true, use [ITypeSymbol.AllInterfaces](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.itypesymbol.allinterfaces), otherwise use [ITypeSymbol.Interfaces](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.itypesymbol.interfaces)\.

### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

## ImplementsInterfaceMember\<TSymbol>\(ISymbol, Boolean\) <a name="Roslynator_SymbolExtensions_ImplementsInterfaceMember__1_Microsoft_CodeAnalysis_ISymbol_System_Boolean_"></a>

### Summary

Returns true if the symbol implements any interface member\.

```csharp
public static bool ImplementsInterfaceMember<TSymbol>(this Microsoft.CodeAnalysis.ISymbol symbol, bool allInterfaces = false) where TSymbol : Microsoft.CodeAnalysis.ISymbol
```

### Type Parameters

**TSymbol**

### Parameters

**symbol** &emsp; Microsoft\.CodeAnalysis\.[ISymbol](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.isymbol)

**allInterfaces** &emsp; [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

If true, use [ITypeSymbol.AllInterfaces](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.itypesymbol.allinterfaces), otherwise use [ITypeSymbol.Interfaces](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.itypesymbol.interfaces)\.

### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

## ImplementsInterfaceMember\<TSymbol>\(ISymbol, INamedTypeSymbol, Boolean\) <a name="Roslynator_SymbolExtensions_ImplementsInterfaceMember__1_Microsoft_CodeAnalysis_ISymbol_Microsoft_CodeAnalysis_INamedTypeSymbol_System_Boolean_"></a>

### Summary

Returns true if the symbol implements any member of the specified interface\.

```csharp
public static bool ImplementsInterfaceMember<TSymbol>(this Microsoft.CodeAnalysis.ISymbol symbol, Microsoft.CodeAnalysis.INamedTypeSymbol interfaceSymbol, bool allInterfaces = false) where TSymbol : Microsoft.CodeAnalysis.ISymbol
```

### Type Parameters

**TSymbol**

### Parameters

**symbol** &emsp; Microsoft\.CodeAnalysis\.[ISymbol](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.isymbol)

**interfaceSymbol** &emsp; Microsoft\.CodeAnalysis\.[INamedTypeSymbol](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.inamedtypesymbol)

**allInterfaces** &emsp; [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

If true, use [ITypeSymbol.AllInterfaces](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.itypesymbol.allinterfaces), otherwise use [ITypeSymbol.Interfaces](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.itypesymbol.interfaces)\.

### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)
