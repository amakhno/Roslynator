﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

// <auto-generated>

using System;
using Microsoft.CodeAnalysis;

namespace Roslynator.Formatting.CSharp
{
    public static partial class DiagnosticDescriptors
    {
        /// <summary>ROS0001</summary>
        public static readonly DiagnosticDescriptor RemoveNewLinesFromAccessorListOfAutoProperty = new DiagnosticDescriptor(
            id:                 DiagnosticIdentifiers.RemoveNewLinesFromAccessorListOfAutoProperty, 
            title:              "Remove newlines from accessor list of auto-property.", 
            messageFormat:      "Remove newlines from accessor list of auto-property.", 
            category:           DiagnosticCategories.Formatting, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        $"{HelpLinkUriRoot}{DiagnosticIdentifiers.RemoveNewLinesFromAccessorListOfAutoProperty}", 
            customTags:         Array.Empty<string>());

        /// <summary>ROS0002</summary>
        public static readonly DiagnosticDescriptor AddNewLinesToAccessorListOfFullProperty = new DiagnosticDescriptor(
            id:                 DiagnosticIdentifiers.AddNewLinesToAccessorListOfFullProperty, 
            title:              "Add newlines to accessor list of full property.", 
            messageFormat:      "Add newlines to accessor list of full property.", 
            category:           DiagnosticCategories.Formatting, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        $"{HelpLinkUriRoot}{DiagnosticIdentifiers.AddNewLinesToAccessorListOfFullProperty}", 
            customTags:         Array.Empty<string>());

        /// <summary>ROS0003</summary>
        public static readonly DiagnosticDescriptor RemoveNewLinesFromAccessor = new DiagnosticDescriptor(
            id:                 DiagnosticIdentifiers.RemoveNewLinesFromAccessor, 
            title:              "Remove newlines from accessor with single-line expression.", 
            messageFormat:      "Remove newlines from accessor with single-line expression.", 
            category:           DiagnosticCategories.Formatting, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        $"{HelpLinkUriRoot}{DiagnosticIdentifiers.RemoveNewLinesFromAccessor}", 
            customTags:         Array.Empty<string>());

        /// <summary>ROS0004</summary>
        public static readonly DiagnosticDescriptor PlaceBinaryOperatorAfterOperand = new DiagnosticDescriptor(
            id:                 DiagnosticIdentifiers.PlaceBinaryOperatorAfterOperand, 
            title:              "Place binary operator after operand.", 
            messageFormat:      "Place binary operator after operand.", 
            category:           DiagnosticCategories.Formatting, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        $"{HelpLinkUriRoot}{DiagnosticIdentifiers.PlaceBinaryOperatorAfterOperand}", 
            customTags:         Array.Empty<string>());

        /// <summary>ROS0005</summary>
        public static readonly DiagnosticDescriptor PlaceConditionalOperatorAfterExpression = new DiagnosticDescriptor(
            id:                 DiagnosticIdentifiers.PlaceConditionalOperatorAfterExpression, 
            title:              "Place conditional operator after expression.", 
            messageFormat:      "Place conditional operator after expression.", 
            category:           DiagnosticCategories.Formatting, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        $"{HelpLinkUriRoot}{DiagnosticIdentifiers.PlaceConditionalOperatorAfterExpression}", 
            customTags:         Array.Empty<string>());

        /// <summary>ROS0006</summary>
        public static readonly DiagnosticDescriptor AddEmptyLineAfterRegionAndBeforeEndRegion = new DiagnosticDescriptor(
            id:                 DiagnosticIdentifiers.AddEmptyLineAfterRegionAndBeforeEndRegion, 
            title:              "Add empty line after #region and before #endregion.", 
            messageFormat:      "Add empty line {0}.", 
            category:           DiagnosticCategories.Formatting, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        $"{HelpLinkUriRoot}{DiagnosticIdentifiers.AddEmptyLineAfterRegionAndBeforeEndRegion}", 
            customTags:         Array.Empty<string>());

        /// <summary>ROS0007</summary>
        public static readonly DiagnosticDescriptor RemoveNewLineBetweenIfKeywordAndElseKeyword = new DiagnosticDescriptor(
            id:                 DiagnosticIdentifiers.RemoveNewLineBetweenIfKeywordAndElseKeyword, 
            title:              "Remove newline between 'if' keyword and 'else' keyword.", 
            messageFormat:      "Remove newline between 'if' keyword and 'else' keyword.", 
            category:           DiagnosticCategories.Formatting, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        $"{HelpLinkUriRoot}{DiagnosticIdentifiers.RemoveNewLineBetweenIfKeywordAndElseKeyword}", 
            customTags:         Array.Empty<string>());

        /// <summary>ROS0008</summary>
        public static readonly DiagnosticDescriptor RemoveNewLineBeforeWhileKeywordOfDoStatement = new DiagnosticDescriptor(
            id:                 DiagnosticIdentifiers.RemoveNewLineBeforeWhileKeywordOfDoStatement, 
            title:              "Remove newline before 'while' keyword of do statement.", 
            messageFormat:      "Remove newline before 'while' keyword of do statement.", 
            category:           DiagnosticCategories.Formatting, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        $"{HelpLinkUriRoot}{DiagnosticIdentifiers.RemoveNewLineBeforeWhileKeywordOfDoStatement}", 
            customTags:         Array.Empty<string>());

        /// <summary>ROS0009</summary>
        public static readonly DiagnosticDescriptor AddEmptyLineBeforeAndAfterUsingDirectiveList = new DiagnosticDescriptor(
            id:                 DiagnosticIdentifiers.AddEmptyLineBeforeAndAfterUsingDirectiveList, 
            title:              "Add empty line before and after using directive list.", 
            messageFormat:      ">Add empty line before and after using directive list.", 
            category:           DiagnosticCategories.Formatting, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        $"{HelpLinkUriRoot}{DiagnosticIdentifiers.AddEmptyLineBeforeAndAfterUsingDirectiveList}", 
            customTags:         Array.Empty<string>());

        /// <summary>ROS0010</summary>
        public static readonly DiagnosticDescriptor AddEmptyLineBetweenSwitchSections = new DiagnosticDescriptor(
            id:                 DiagnosticIdentifiers.AddEmptyLineBetweenSwitchSections, 
            title:              "Add empty line between switch sections.", 
            messageFormat:      "Add empty line between switch sections.", 
            category:           DiagnosticCategories.Formatting, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        $"{HelpLinkUriRoot}{DiagnosticIdentifiers.AddEmptyLineBetweenSwitchSections}", 
            customTags:         Array.Empty<string>());

        /// <summary>ROS0011</summary>
        public static readonly DiagnosticDescriptor PlaceExpressionBodyArrowAtEndOfLine = new DiagnosticDescriptor(
            id:                 DiagnosticIdentifiers.PlaceExpressionBodyArrowAtEndOfLine, 
            title:              "Place expression-body arrow at the end of line.", 
            messageFormat:      "Place expression-body arrow at the end of line.", 
            category:           DiagnosticCategories.Formatting, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        $"{HelpLinkUriRoot}{DiagnosticIdentifiers.PlaceExpressionBodyArrowAtEndOfLine}", 
            customTags:         Array.Empty<string>());

        /// <summary>ROS0012</summary>
        public static readonly DiagnosticDescriptor PlaceExpressionBodyArrowBeforeExpression = new DiagnosticDescriptor(
            id:                 DiagnosticIdentifiers.PlaceExpressionBodyArrowBeforeExpression, 
            title:              "Place expression-body arrow after expression.", 
            messageFormat:      "Place expression-body arrow after expression.", 
            category:           DiagnosticCategories.Formatting, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        $"{HelpLinkUriRoot}{DiagnosticIdentifiers.PlaceExpressionBodyArrowBeforeExpression}", 
            customTags:         Array.Empty<string>());

        /// <summary>ROS0013</summary>
        public static readonly DiagnosticDescriptor AddNewLineBeforeTypeParameterConstraint = new DiagnosticDescriptor(
            id:                 DiagnosticIdentifiers.AddNewLineBeforeTypeParameterConstraint, 
            title:              "Add newline before type parameter constraint.", 
            messageFormat:      "Add newline before type parameter constraint.", 
            category:           DiagnosticCategories.Formatting, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        $"{HelpLinkUriRoot}{DiagnosticIdentifiers.AddNewLineBeforeTypeParameterConstraint}", 
            customTags:         Array.Empty<string>());

        /// <summary>ROS0014</summary>
        public static readonly DiagnosticDescriptor AddNewLineBeforeConstructorInitializer = new DiagnosticDescriptor(
            id:                 DiagnosticIdentifiers.AddNewLineBeforeConstructorInitializer, 
            title:              "Add newline before constructor initializer.", 
            messageFormat:      "Add newline before constructor initializer.", 
            category:           DiagnosticCategories.Formatting, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        $"{HelpLinkUriRoot}{DiagnosticIdentifiers.AddNewLineBeforeConstructorInitializer}", 
            customTags:         Array.Empty<string>());

        /// <summary>ROS0015</summary>
        public static readonly DiagnosticDescriptor AddEmptyLineBetweenSinglelineDeclarations = new DiagnosticDescriptor(
            id:                 DiagnosticIdentifiers.AddEmptyLineBetweenSinglelineDeclarations, 
            title:              "Add empty line between single-line declarations.", 
            messageFormat:      "Add empty line between single-line declarations.", 
            category:           DiagnosticCategories.Formatting, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        $"{HelpLinkUriRoot}{DiagnosticIdentifiers.AddEmptyLineBetweenSinglelineDeclarations}", 
            customTags:         Array.Empty<string>());

        /// <summary>ROS0016</summary>
        public static readonly DiagnosticDescriptor AddEmptyLineBetweenDeclarationAndDocumentationComment = new DiagnosticDescriptor(
            id:                 DiagnosticIdentifiers.AddEmptyLineBetweenDeclarationAndDocumentationComment, 
            title:              "Add empty line between declarations and documentation comment.", 
            messageFormat:      "Add empty line between declarations and documentation comment.", 
            category:           DiagnosticCategories.Formatting, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        $"{HelpLinkUriRoot}{DiagnosticIdentifiers.AddEmptyLineBetweenDeclarationAndDocumentationComment}", 
            customTags:         Array.Empty<string>());

        /// <summary>ROS1023</summary>
        public static readonly DiagnosticDescriptor AddNewLineToEmptyBlock = new DiagnosticDescriptor(
            id:                 DiagnosticIdentifiers.AddNewLineToEmptyBlock, 
            title:              "Add newline to empty block.", 
            messageFormat:      "Add newline to empty block.", 
            category:           DiagnosticCategories.Formatting, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        $"{HelpLinkUriRoot}{DiagnosticIdentifiers.AddNewLineToEmptyBlock}", 
            customTags:         Array.Empty<string>());

        /// <summary>ROS1025</summary>
        public static readonly DiagnosticDescriptor AddNewLineBeforeEnumMember = new DiagnosticDescriptor(
            id:                 DiagnosticIdentifiers.AddNewLineBeforeEnumMember, 
            title:              "Add newline before enum member.", 
            messageFormat:      "Add newline before enum member.", 
            category:           DiagnosticCategories.Formatting, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        $"{HelpLinkUriRoot}{DiagnosticIdentifiers.AddNewLineBeforeEnumMember}", 
            customTags:         Array.Empty<string>());

        /// <summary>ROS1026</summary>
        public static readonly DiagnosticDescriptor AddNewLineBeforeStatement = new DiagnosticDescriptor(
            id:                 DiagnosticIdentifiers.AddNewLineBeforeStatement, 
            title:              "Add newline before statement.", 
            messageFormat:      "Add newline before statement.", 
            category:           DiagnosticCategories.Formatting, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        $"{HelpLinkUriRoot}{DiagnosticIdentifiers.AddNewLineBeforeStatement}", 
            customTags:         Array.Empty<string>());

        /// <summary>ROS1027</summary>
        public static readonly DiagnosticDescriptor AddNewLineBeforeEmbeddedStatement = new DiagnosticDescriptor(
            id:                 DiagnosticIdentifiers.AddNewLineBeforeEmbeddedStatement, 
            title:              "Add newline before embedded statement.", 
            messageFormat:      "Add newline before embedded statement.", 
            category:           DiagnosticCategories.Formatting, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        $"{HelpLinkUriRoot}{DiagnosticIdentifiers.AddNewLineBeforeEmbeddedStatement}", 
            customTags:         Array.Empty<string>());

        /// <summary>ROS1028</summary>
        public static readonly DiagnosticDescriptor AddNewLineAfterSwitchLabel = new DiagnosticDescriptor(
            id:                 DiagnosticIdentifiers.AddNewLineAfterSwitchLabel, 
            title:              "Add newline after switch label.", 
            messageFormat:      "Add newline after switch label.", 
            category:           DiagnosticCategories.Formatting, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        $"{HelpLinkUriRoot}{DiagnosticIdentifiers.AddNewLineAfterSwitchLabel}", 
            customTags:         Array.Empty<string>());

        /// <summary>ROS1029</summary>
        public static readonly DiagnosticDescriptor PlaceBinaryOperatorBeforeOperand = new DiagnosticDescriptor(
            id:                 DiagnosticIdentifiers.PlaceBinaryOperatorBeforeOperand, 
            title:              "Place operator before operand.", 
            messageFormat:      "Place operator before operand.", 
            category:           DiagnosticCategories.Formatting, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        $"{HelpLinkUriRoot}{DiagnosticIdentifiers.PlaceBinaryOperatorBeforeOperand}", 
            customTags:         Array.Empty<string>());

        /// <summary>ROS1030</summary>
        public static readonly DiagnosticDescriptor AddEmptyLineAfterEmbeddedStatement = new DiagnosticDescriptor(
            id:                 DiagnosticIdentifiers.AddEmptyLineAfterEmbeddedStatement, 
            title:              "Add empty line after embedded statement.", 
            messageFormat:      "Add empty line after embedded statement.", 
            category:           DiagnosticCategories.Formatting, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        $"{HelpLinkUriRoot}{DiagnosticIdentifiers.AddEmptyLineAfterEmbeddedStatement}", 
            customTags:         Array.Empty<string>());

        /// <summary>ROS1057</summary>
        public static readonly DiagnosticDescriptor AddEmptyLineBetweenDeclarations = new DiagnosticDescriptor(
            id:                 DiagnosticIdentifiers.AddEmptyLineBetweenDeclarations, 
            title:              "Add empty line between declarations.", 
            messageFormat:      "Add empty line between declarations.", 
            category:           DiagnosticCategories.Formatting, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        $"{HelpLinkUriRoot}{DiagnosticIdentifiers.AddEmptyLineBetweenDeclarations}", 
            customTags:         Array.Empty<string>());

        /// <summary>ROS1076</summary>
        public static readonly DiagnosticDescriptor AddNewLineToEmptyTypeDeclaration = new DiagnosticDescriptor(
            id:                 DiagnosticIdentifiers.AddNewLineToEmptyTypeDeclaration, 
            title:              "Add newline to empty type declaration.", 
            messageFormat:      "Add newline to empty type declaration.", 
            category:           DiagnosticCategories.Formatting, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        $"{HelpLinkUriRoot}{DiagnosticIdentifiers.AddNewLineToEmptyTypeDeclaration}", 
            customTags:         Array.Empty<string>());

        /// <summary>ROS1086</summary>
        public static readonly DiagnosticDescriptor UseLinefeedAsNewLine = new DiagnosticDescriptor(
            id:                 DiagnosticIdentifiers.UseLinefeedAsNewLine, 
            title:              "Use linefeed as newline.", 
            messageFormat:      "Use linefeed as newline.", 
            category:           DiagnosticCategories.Formatting, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        $"{HelpLinkUriRoot}{DiagnosticIdentifiers.UseLinefeedAsNewLine}", 
            customTags:         Array.Empty<string>());

        /// <summary>ROS1087</summary>
        public static readonly DiagnosticDescriptor UseCarriageReturnAndLinefeedAsNewLine = new DiagnosticDescriptor(
            id:                 DiagnosticIdentifiers.UseCarriageReturnAndLinefeedAsNewLine, 
            title:              "Use carriage return + linefeed as newline.", 
            messageFormat:      "Use carriage return + linefeed as newline.", 
            category:           DiagnosticCategories.Formatting, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        $"{HelpLinkUriRoot}{DiagnosticIdentifiers.UseCarriageReturnAndLinefeedAsNewLine}", 
            customTags:         Array.Empty<string>());

        /// <summary>ROS1088</summary>
        public static readonly DiagnosticDescriptor UseSpacesInsteadOfTab = new DiagnosticDescriptor(
            id:                 DiagnosticIdentifiers.UseSpacesInsteadOfTab, 
            title:              "Use spaces instead of tab.", 
            messageFormat:      "Use spaces instead of tab.", 
            category:           DiagnosticCategories.Formatting, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        $"{HelpLinkUriRoot}{DiagnosticIdentifiers.UseSpacesInsteadOfTab}", 
            customTags:         Array.Empty<string>());

        /// <summary>ROS1092</summary>
        public static readonly DiagnosticDescriptor AddEmptyLineBeforeClosingBraceOfDoStatement = new DiagnosticDescriptor(
            id:                 DiagnosticIdentifiers.AddEmptyLineBeforeClosingBraceOfDoStatement, 
            title:              "Add empty line before closing brace of 'do' statement.", 
            messageFormat:      "Add empty line before closing brace of 'do' statement.", 
            category:           DiagnosticCategories.Formatting, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        $"{HelpLinkUriRoot}{DiagnosticIdentifiers.AddEmptyLineBeforeClosingBraceOfDoStatement}", 
            customTags:         Array.Empty<string>());

        /// <summary>ROS1153</summary>
        public static readonly DiagnosticDescriptor AddEmptyLineAfterClosingBraceOfBlock = new DiagnosticDescriptor(
            id:                 DiagnosticIdentifiers.AddEmptyLineAfterClosingBraceOfBlock, 
            title:              "Add empty line after closing brace of block.", 
            messageFormat:      "Add empty line after closing brace of block.", 
            category:           DiagnosticCategories.Formatting, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        $"{HelpLinkUriRoot}{DiagnosticIdentifiers.AddEmptyLineAfterClosingBraceOfBlock}", 
            customTags:         Array.Empty<string>());

        /// <summary>ROS1184</summary>
        public static readonly DiagnosticDescriptor PlaceConditionalOperatorBeforeExpression = new DiagnosticDescriptor(
            id:                 DiagnosticIdentifiers.PlaceConditionalOperatorBeforeExpression, 
            title:              "Place conditional operator before expression.", 
            messageFormat:      "Place conditional operator before expression.", 
            category:           DiagnosticCategories.Formatting, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        $"{HelpLinkUriRoot}{DiagnosticIdentifiers.PlaceConditionalOperatorBeforeExpression}", 
            customTags:         Array.Empty<string>());

        /// <summary>ROS1185</summary>
        public static readonly DiagnosticDescriptor AddNewLinesToBlock = new DiagnosticDescriptor(
            id:                 DiagnosticIdentifiers.AddNewLinesToBlock, 
            title:              "Add newlines to block.", 
            messageFormat:      "Add newlines to block.", 
            category:           DiagnosticCategories.Formatting, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        $"{HelpLinkUriRoot}{DiagnosticIdentifiers.AddNewLinesToBlock}", 
            customTags:         Array.Empty<string>());

    }
}