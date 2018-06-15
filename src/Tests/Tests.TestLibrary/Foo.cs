﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

#region usings
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using Roslynator;
using Roslynator.CSharp;
using Roslynator.CSharp.Syntax;
#endregion usings

#pragma warning disable RCS1018, RCS1213, CA1822

namespace Roslynator.Tests
{
    internal static class JoinStringExpressions
    {
        public static void Foo()
        {
            string s = "ab";

            s = $"\"\r\n\\{{}}{s}" + $"\"\r\n\\{{}}{s}";

            s = $"\"\r\n\\{{}}{s}" + "\"\r\n\\{}";

            s = $"\"\r\n\\{{}}{s}" + @"""
\{}" + @"""
\{}";

            s = $@"""
\{{}}{s}" + "\"\r\n\\{}";

            s = $@"""
\{{}}{s}" + $@"""
\{{}}{s}";

            // n

            s = "x"
                + "x";

            s = "x" + @"x";

            s = @"x" + "x";

            s = "x" + $"{s}";

            s = $"{s}" + "x";

            s = "\"\r\n\\{}" + @"""
\{}";

            s = $"\"\r\n\\{{}}{s}" + $@"""
\{{}}{s}";

            s = "\"\r\n\\{}" + @"""
\{}" + $"\"\r\n\\{{}}{s}";

            s = "\"\r\n\\{}" + @"""
\{}" + $@"""
\{{}}{s}";
        }
    }
}
