﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Roslynator.Documentation
{
    [Flags]
    public enum OmitContainingNamespaceParts
    {
        None = 0,
        Root = 1,
        ContainingType = 2,
        Parameter = 4,
        ReturnType = 8,
        BaseType = 16,
        Attribute = 32,
        DerivedType = 64,
        ImplementedInterface = 128,
        ImplementedMember = 256,
        Exception = 512,
        SeeAlso = 1024,
        All = Root | ContainingType | ReturnType | BaseType | Attribute | DerivedType | ImplementedInterface | ImplementedMember | Exception | SeeAlso
    }
}
