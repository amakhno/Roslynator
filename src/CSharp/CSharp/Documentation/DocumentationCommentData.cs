﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Diagnostics;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace Roslynator.CSharp.Documentation
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    internal readonly struct DocumentationCommentData
    {
        internal DocumentationCommentData(SyntaxTrivia comment, DocumentationCommentOrigin origin)
        {
            Comment = comment;
            Origin = origin;
        }

        public SyntaxTrivia Comment { get; }

        public DocumentationCommentOrigin Origin { get; }

        public bool Success
        {
            get { return Comment.Kind() == SyntaxKind.SingleLineDocumentationCommentTrivia; }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string DebuggerDisplay
        {
            get { return (Success) ? $"{Origin} {Comment}" : "Uninitalized"; }
        }
    }
}
