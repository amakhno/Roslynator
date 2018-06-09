﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.CodeAnalysis.Diagnostics;
using Roslynator.CSharp.CodeFixes;
using Xunit;

#pragma warning disable RCS1090

namespace Roslynator.CSharp.Analysis.Tests
{
    public class RCS1085UseAutoPropertyTests : AbstractCSharpCodeFixVerifier
    {
        public override DiagnosticDescriptor Descriptor { get; } = DiagnosticDescriptors.UseAutoProperty;

        public override DiagnosticAnalyzer Analyzer { get; } = new UseAutoPropertyAnalyzer();

        public override CodeFixProvider FixProvider { get; } = new PropertyDeclarationCodeFixProvider();

        [Fact, Trait(Traits.Analyzer, DiagnosticIdentifiers.UseAutoProperty)]
        public async Task Test_Property()
        {
            await VerifyDiagnosticAndFixAsync(@"
class C
{
    private string _f = null;

    public string [|P|]
    {
        get { return _f; }
        set { _f = value; }
    }

    public C()
    {
        string P = null;
        _f = null;
        this._f = null;

        var c = new C();
        c._f = null;
    }

    void M(string p)
    {
        M(_f);
    }
}
", @"
class C
{

    public string P { get; set; } = null;

    public C()
    {
        string P = null;
        this.P = null;
        this.P = null;

        var c = new C();
        c.P = null;
    }

    void M(string p)
    {
        M(P);
    }
}
");
        }

        [Fact, Trait(Traits.Analyzer, DiagnosticIdentifiers.UseAutoProperty)]
        public async Task Test_Property_AccessWithExpressionBody()
        {
            await VerifyDiagnosticAndFixAsync(@"
class C
{
    private string _f;

    public string [|@string|]
    {
        get => _f;
        set => _f = value;
    }

    public C()
    {
        this._f = null;
    }

    void M()
    {
        _f = null;
    }
}
", @"
class C
{

    public string @string { get; set; }

    public C()
    {
        this.@string = null;
    }

    void M()
    {
        @string = null;
    }
}
");
        }

        [Fact, Trait(Traits.Analyzer, DiagnosticIdentifiers.UseAutoProperty)]
        public async Task Test_ReadOnlyProperty()
        {
            await VerifyDiagnosticAndFixAsync(@"
class C
{
    private readonly string _f, _f2 = null;

    public string [|P|]
    {
        get { return _f; }
    }

    public C()
    {
        _f = null;
    }
}
", @"
class C
{
    private readonly string _f2 = null;

    public string P { get; }

    public C()
    {
        P = null;
    }
}
");
        }

        [Fact, Trait(Traits.Analyzer, DiagnosticIdentifiers.UseAutoProperty)]
        public async Task Test_ReadOnlyPropertyWithExpressionBody()
        {
            await VerifyDiagnosticAndFixAsync(@"
class C
{
    private readonly string _f;

    public string [|P|] => _f;

    public C()
    {
        _f = null;
    }
}
", @"
class C
{

    public string P { get; }

    public C()
    {
        P = null;
    }
}
");
        }

        [Fact, Trait(Traits.Analyzer, DiagnosticIdentifiers.UseAutoProperty)]
        public async Task Test_StaticProperty()
        {
            await VerifyDiagnosticAndFixAsync(@"
class C
{
    private static string _f = null;

    public static string [|P|]
    {
        get { return _f; }
        set { _f = value; }
    }

    static C()
    {
        string P = null;
        _f = null;
        C._f = null;
    }

    public C()
    {
        _f = null;
        C._f = null;
    }
}
", @"
class C
{

    public static string P { get; set; } = null;

    static C()
    {
        string P = null;
        C.P = null;
        C.P = null;
    }

    public C()
    {
        P = null;
        C.P = null;
    }
}
");
        }

        [Fact, Trait(Traits.Analyzer, DiagnosticIdentifiers.UseAutoProperty)]
        public async Task Test_ReadOnlyStaticProperty()
        {
            await VerifyDiagnosticAndFixAsync(@"
class C
{
    private readonly static string _f = null;

    public static string [|P|]
    {
        get { return _f; }
    }

    static C()
    {
        _f = null;
    }
}
", @"
class C
{

    public static string P { get; } = null;

    static C()
    {
        P = null;
    }
}
");
        }

        [Fact, Trait(Traits.Analyzer, DiagnosticIdentifiers.UseAutoProperty)]
        public async Task Test_PartialClass()
        {
            await VerifyDiagnosticAndFixAsync(@"
partial class C
{
    private string _f;

    public string [|P|]
    {
        get { return _f; }
        set { _f = value; }
    }

    public C()
    {
        _f = null;
    }
}

partial class C
{
    void M()
    {
        _f = null;
    }
}
", @"
partial class C
{

    public string P { get; set; }

    public C()
    {
        P = null;
    }
}

partial class C
{
    void M()
    {
        P = null;
    }
}
");
        }

        [Fact, Trait(Traits.Analyzer, DiagnosticIdentifiers.UseAutoProperty)]
        public async Task Test_SealedClass()
        {
            await VerifyDiagnosticAndFixAsync(@"
sealed class C : B
{
    private readonly string _f;

    public override string [|P|]
    {
        get { return _f; }
    }

    public C()
    {
        _f = null;
    }
}

abstract class B
{
    public abstract string P { get; }
}
", @"
sealed class C : B
{

    public override string P { get; }

    public C()
    {
        P = null;
    }
}

abstract class B
{
    public abstract string P { get; }
}
");
        }

        [Fact, Trait(Traits.Analyzer, DiagnosticIdentifiers.UseAutoProperty)]
        public async Task Test_PartialClassInMultipleDocuments()
        {
            await VerifyDiagnosticAndFixAsync(@"
partial class C
{
    private string _f;

    public string [|P|]
    {
        get { return _f; }
        set { _f = value; }
    }
}

partial class C
{
    public C()
    {
        _f = null;
    }
}
", @"
partial class C
{

    public string P { get; set; }
}

partial class C
{
    public C()
    {
        P = null;
    }
}
",
 additionalData: new (string, string)[]
{ (@"
partial class C
{
    public C(object p)
    {
        _f = null;
    }

    void M2()
    {
        _f = null;
    }
}
", @"
partial class C
{
    public C(object p)
    {
        P = null;
    }

    void M2()
    {
        P = null;
    }
}
") });
        }

        [Fact, Trait(Traits.Analyzer, DiagnosticIdentifiers.UseAutoProperty)]
        public async Task TestNoDiagnostic_ClassWithStructLayoutAttribute()
        {
            await VerifyNoDiagnosticAsync(@"
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit)]
class C
{
    [FieldOffset(0)]
    string _f;

    string P
    {
        get { return _f; }
        set { _f = value; }
    }
}
");
        }

        [Fact, Trait(Traits.Analyzer, DiagnosticIdentifiers.UseAutoProperty)]
        public async Task TestNoDiagnostic_StructWithStructLayoutAttribute()
        {
            await VerifyNoDiagnosticAsync(@"
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit)]
struct C
{
    [FieldOffset(0)]
    string _f;

    string P
    {
        get { return _f; }
        set { _f = value; }
    }
}
");
        }

        [Fact, Trait(Traits.Analyzer, DiagnosticIdentifiers.UseAutoProperty)]
        public async Task TestNoDiagnostic_FieldWithNonSerializedAttribute()
        {
            await VerifyNoDiagnosticAsync(@"
using System;

class C
{
    [NonSerialized]
    string _f;

    string P
    {
        get { return _f; }
        set { _f = value; }
    }
}
");
        }

        [Fact, Trait(Traits.Analyzer, DiagnosticIdentifiers.UseAutoProperty)]
        public async Task TestNoDiagnostic_PropertyWithExplicitImplementation()
        {
            await VerifyNoDiagnosticAsync(@"
using System;

class C : I
{
    private string _f;

    string I.P
    {
        get { return _f; }
        set { _f = value; }
    }
}

interface I
{
    string P { get; set; }
}
");
        }

        [Fact, Trait(Traits.Analyzer, DiagnosticIdentifiers.UseAutoProperty)]
        public async Task TestNoDiagnostic_FieldUsedInRefArgument()
        {
            await VerifyNoDiagnosticAsync(@"
class C
{
    private string _f = null;

    public string P
    {
        get { return _f; }
        set { _f = value; }
    }

    private string M(ref string p)
    {
        return M(ref _f);
    }
}
");
        }

        [Fact, Trait(Traits.Analyzer, DiagnosticIdentifiers.UseAutoProperty)]
        public async Task TestNoDiagnostic_FieldUsedInRefArgument2()
        {
            await VerifyNoDiagnosticAsync(@"
class C
{
    private string _f = null;

    public string P
    {
        get { return _f; }
        set { _f = value; }
    }

    private string M(ref string p)
    {
        return M(ref (_f));
    }
}
");
        }

        [Fact, Trait(Traits.Analyzer, DiagnosticIdentifiers.UseAutoProperty)]
        public async Task TestNoDiagnostic_FieldUsedInRefArgument3()
        {
            await VerifyNoDiagnosticAsync(@"
class C
{
    private string _f = null;

    public string P
    {
        get { return _f; }
        set { _f = value; }
    }

    private string M(ref string p)
    {
        return M(ref this._f);
    }
}
");
        }

        [Fact, Trait(Traits.Analyzer, DiagnosticIdentifiers.UseAutoProperty)]
        public async Task TestNoDiagnostic_FieldUsedInOutArgument()
        {
            await VerifyNoDiagnosticAsync(@"
class C
{
    private string _f = null;

    public string P
    {
        get { return _f; }
        set { _f = value; }
    }

    private bool M(out string p)
    {
        p = null;
        return M(out _f);
    }
}
");
        }

        [Fact, Trait(Traits.Analyzer, DiagnosticIdentifiers.UseAutoProperty)]
        public async Task TestNoDiagnostic_FieldUsedInOutArgument2()
        {
            await VerifyNoDiagnosticAsync(@"
class C
{
    private string _f = null;

    public string P
    {
        get { return _f; }
        set { _f = value; }
    }

    private bool M(out string p)
    {
        p = null;
        return M(out (_f));
    }
}
");
        }

        [Fact, Trait(Traits.Analyzer, DiagnosticIdentifiers.UseAutoProperty)]
        public async Task TestNoDiagnostic_FieldUsedInOutArgument3()
        {
            await VerifyNoDiagnosticAsync(@"
class C
{
    private string _f = null;

    public string P
    {
        get { return _f; }
        set { _f = value; }
    }

    private bool M(out string p)
    {
        p = null;
        return M(out this._f);
    }
}
");
        }

        [Fact, Trait(Traits.Analyzer, DiagnosticIdentifiers.UseAutoProperty)]
        public async Task TestNoDiagnostic_OverriddenPropertyWithNotImplementedAccessor()
        {
            await VerifyNoDiagnosticAsync(@"
class B
{
    public virtual bool P { get; set; }
}

class C : B
{
    private readonly bool _f;

    public override bool P
    {
        get { return _f; }
    }
}
");
        }

        [Fact, Trait(Traits.Analyzer, DiagnosticIdentifiers.UseAutoProperty)]
        public async Task TestNoDiagnostic_OverriddenPropertyWithNotImplementedAccessor_ExpressionBody()
        {
            await VerifyNoDiagnosticAsync(@"
class B
{
    public virtual bool P { get; set; }
}

class C : B
{
    private readonly bool _f;

    public override bool P => _f;
}
");
        }

        [Fact, Trait(Traits.Analyzer, DiagnosticIdentifiers.UseAutoProperty)]
        public async Task TestNoDiagnostic_PropertyAndFieldHaveDifferentTypes()
        {
            await VerifyNoDiagnosticAsync(@"
class C
{
    string _f;

    object P
    {
        get { return _f; }
        set { _f = (string)value; }
    }
}
");
        }

        [Fact, Trait(Traits.Analyzer, DiagnosticIdentifiers.UseAutoProperty)]
        public async Task TestNoDiagnostic_VirtualProperty_BackingFieldAssignedInConstructor()
        {
            await VerifyNoDiagnosticAsync(@"
class C : B
{
    private readonly string _f;

    public override string P
    {
        get { return _f; }
    }

    public C()
    {
        _f = null;
    }
}

abstract class B
{
    public abstract string P { get; }
}
");
        }

        [Fact, Trait(Traits.Analyzer, DiagnosticIdentifiers.UseAutoProperty)]
        public async Task TestNoDiagnostic_OverrideProperty_BackingFieldAssignedInConstructor()
        {
            await VerifyNoDiagnosticAsync(@"
class C
{
    private readonly string _f;

    public virtual string P
    {
        get { return _f; }
    }

    public C()
    {
        _f = null;
    }
}
");
        }
    }
}