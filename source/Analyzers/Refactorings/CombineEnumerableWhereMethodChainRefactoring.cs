﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Text;
using Roslynator.CSharp;
using static Roslynator.CSharp.CSharpFactory;

namespace Roslynator.CSharp.Refactorings
{
    internal static class CombineEnumerableWhereMethodChainRefactoring
    {
        public static void Analyze(
            SyntaxNodeAnalysisContext context,
            InvocationExpressionSyntax invocation,
            MemberAccessExpressionSyntax memberAccess)
        {
            if (memberAccess.Expression?.Kind() != SyntaxKind.InvocationExpression)
                return;

            var invocation2 = (InvocationExpressionSyntax)memberAccess.Expression;

            if (invocation2.ArgumentList?.Arguments.Count != 1)
                return;

            if (invocation2.Expression?.Kind() != SyntaxKind.SimpleMemberAccessExpression)
                return;

            var memberAccess2 = (MemberAccessExpressionSyntax)invocation2.Expression;

            SemanticModel semanticModel = context.SemanticModel;
            CancellationToken cancellationToken = context.CancellationToken;

            if (!string.Equals(memberAccess2.Name?.Identifier.ValueText, "Where", StringComparison.Ordinal))
                return;

            IMethodSymbol methodSymbol2 = semanticModel.GetReducedExtensionMethodInfo(invocation2, cancellationToken).Symbol;

            if (methodSymbol2 == null)
                return;

            if (!SymbolUtility.IsLinqExtensionOfIEnumerableOfT(methodSymbol2, semanticModel, "Where", parameterCount: 2))
                return;

            if (SymbolUtility.IsPredicateFunc(
                methodSymbol2.Parameters[1].Type,
                methodSymbol2.TypeArguments[0],
                semanticModel))
            {
                IMethodSymbol methodSymbol = semanticModel.GetReducedExtensionMethodInfo(invocation, cancellationToken).Symbol;

                if (methodSymbol != null
                    && SymbolUtility.IsLinqWhere(methodSymbol, semanticModel))
                {
                    Analyze(context, invocation, invocation2, memberAccess, memberAccess2);
                }
            }
            else if (SymbolUtility.IsPredicateFunc(
                methodSymbol2.Parameters[1].Type,
                methodSymbol2.TypeArguments[0],
                semanticModel.Compilation.GetSpecialType(SpecialType.System_Int32),
                semanticModel))
            {
                IMethodSymbol methodSymbol = semanticModel.GetReducedExtensionMethodInfo(invocation, cancellationToken).Symbol;

                if (methodSymbol != null
                    && SymbolUtility.IsLinqWhereWithIndex(methodSymbol, semanticModel))
                {
                    Analyze(context, invocation, invocation2, memberAccess, memberAccess2);
                }
            }
        }

        private static void Analyze(
            SyntaxNodeAnalysisContext context,
            InvocationExpressionSyntax invocation1,
            InvocationExpressionSyntax invocation2,
            MemberAccessExpressionSyntax memberAccess1,
            MemberAccessExpressionSyntax memberAccess2)
        {
            ExpressionSyntax expression1 = invocation1.ArgumentList.Arguments.First().Expression;
            ExpressionSyntax expression2 = invocation2.ArgumentList.Arguments.First().Expression;

            if (CheckLambdas(expression1, expression2))
            {
                TextSpan span = TextSpan.FromBounds(memberAccess2.Name.Span.Start, invocation1.Span.End);

                if (!invocation1.ContainsDirectives(span))
                {
                    context.ReportDiagnostic(
                        DiagnosticDescriptors.CombineEnumerableWhereMethodChain,
                        Location.Create(invocation1.SyntaxTree, span));

                    FadeOut(context, invocation1, memberAccess1, (LambdaExpressionSyntax)expression1);
                }
            }
        }

        private static void FadeOut(SyntaxNodeAnalysisContext context, InvocationExpressionSyntax invocation, MemberAccessExpressionSyntax memberAccess, LambdaExpressionSyntax lambda)
        {
            TextSpan span = TextSpan.FromBounds(memberAccess.OperatorToken.Span.Start, lambda.ArrowToken.Span.End);

            context.ReportDiagnostic(DiagnosticDescriptors.CombineEnumerableWhereMethodChainFadeOut, Location.Create(invocation.SyntaxTree, span));
            context.ReportDiagnostic(DiagnosticDescriptors.CombineEnumerableWhereMethodChainFadeOut, invocation.ArgumentList.CloseParenToken);
        }

        private static bool CheckLambdas(ExpressionSyntax expression1, ExpressionSyntax expression2)
        {
            switch (expression1.Kind())
            {
                case SyntaxKind.SimpleLambdaExpression:
                    {
                        if (expression2?.Kind() == SyntaxKind.SimpleLambdaExpression)
                        {
                            var lambda1 = (SimpleLambdaExpressionSyntax)expression1;
                            var lambda2 = (SimpleLambdaExpressionSyntax)expression2;

                            return ParameterIdentifierEquals(lambda1.Parameter, lambda2.Parameter)
                                && lambda1.Body is ExpressionSyntax
                                && lambda2.Body is ExpressionSyntax;
                        }

                        break;
                    }
                case SyntaxKind.ParenthesizedLambdaExpression:
                    {
                        if (expression2?.Kind() == SyntaxKind.ParenthesizedLambdaExpression)
                        {
                            var lambda1 = (ParenthesizedLambdaExpressionSyntax)expression1;
                            var lambda2 = (ParenthesizedLambdaExpressionSyntax)expression2;

                            ParameterListSyntax parameterList1 = lambda1.ParameterList;
                            ParameterListSyntax parameterList2 = lambda2.ParameterList;

                            if (parameterList1 != null
                                && parameterList2 != null)
                            {
                                SeparatedSyntaxList<ParameterSyntax> parameters1 = parameterList1.Parameters;
                                SeparatedSyntaxList<ParameterSyntax> parameters2 = parameterList2.Parameters;

                                if (parameters1.Count == parameters2.Count)
                                {
                                    for (int i = 0; i < parameters1.Count; i++)
                                    {
                                        if (!ParameterIdentifierEquals(parameters1[i], parameters2[i]))
                                            return false;
                                    }

                                    return true;
                                }
                            }
                        }

                        break;
                    }
            }

            return false;
        }

        private static bool ParameterIdentifierEquals(ParameterSyntax parameter1, ParameterSyntax parameter2)
        {
            return parameter1?.Identifier.ValueText.Equals(parameter2.Identifier.ValueText, StringComparison.Ordinal) == true;
        }

        public static Task<Document> RefactorAsync(
            Document document,
            InvocationExpressionSyntax invocation,
            CancellationToken cancellationToken)
        {
            var memberAccess = (MemberAccessExpressionSyntax)invocation.Expression;

            var invocation2 = (InvocationExpressionSyntax)memberAccess.Expression;

            ExpressionSyntax expression1 = GetCondition(invocation);
            ExpressionSyntax expression2 = GetCondition(invocation2);

            InvocationExpressionSyntax newInvocation = invocation2.ReplaceNode(
                expression2,
                LogicalAndExpression(
                    expression2.Parenthesize(),
                    expression1.Parenthesize()));

            var newMemberAccess = (MemberAccessExpressionSyntax)newInvocation.Expression;

            SyntaxTriviaList trailingTrivia = invocation.GetTrailingTrivia();

            IEnumerable<SyntaxTrivia> trivia = invocation.DescendantTrivia(TextSpan.FromBounds(invocation2.Span.End, memberAccess.Name.SpanStart));

            if (trivia.Any(f => !f.IsWhitespaceOrEndOfLineTrivia()))
                trailingTrivia = trailingTrivia.InsertRange(0, trivia);

            newInvocation = newInvocation
                .WithExpression(newMemberAccess)
                .WithTrailingTrivia(trailingTrivia)
                .WithFormatterAnnotation();

            return document.ReplaceNodeAsync(invocation, newInvocation, cancellationToken);
        }

        private static ExpressionSyntax GetCondition(InvocationExpressionSyntax invocation)
        {
            ArgumentSyntax argument = invocation.ArgumentList.Arguments.First();

            var lambda = (LambdaExpressionSyntax)argument.Expression;

            return (ExpressionSyntax)lambda.Body;
        }
    }
}
