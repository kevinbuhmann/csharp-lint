using Microsoft.CodeAnalysis;
using System;
using System.Linq;
using System.Reflection;

namespace CSharpStaticAnalyzer
{
    public static class SAViolations
    {
        private static PropertyInfo[] properties = typeof(SAViolations).GetProperties(BindingFlags.Static | BindingFlags.NonPublic);

        #region SA0000

        // XmlCommentAnalysisDisabled
        private static Severity SA0001 { get; } = Severity.None;

        // InvalidSettingsFile
        private static Severity SA0002 { get; } = Severity.None;

        #endregion

        #region SA1000

        // KeywordsMustBeSpacedCorrectly
        private static Severity SA1000 { get; } = Severity.MinorWarning;

        // CommasMustBeSpacedCorrectly
        private static Severity SA1001 { get; } = Severity.MinorWarning;

        // SemicolonsMustBeSpacedCorrectly
        private static Severity SA1002 { get; } = Severity.MinorWarning;

        // SymbolsMustBeSpacedCorrectly
        private static Severity SA1003 { get; } = Severity.MinorWarning;

        // DocumentationLinesMustBeginWithSingleSpace
        private static Severity SA1004 { get; } = Severity.None;

        // SingleLineCommentsMustBeginWithSingleSpace
        private static Severity SA1005 { get; } = Severity.MinorWarning;

        // PreprocessorKeywordsMustNotBePrecededBySpace
        private static Severity SA1006 { get; } = Severity.MinorWarning;

        // OperatorKeywordMustBeFollowedBySpace
        private static Severity SA1007 { get; } = Severity.MinorWarning;

        // OpeningParenthesisMustBeSpacedCorrectly
        private static Severity SA1008 { get; } = Severity.MinorWarning;

        // ClosingParenthesisMustBeSpacedCorrectly
        private static Severity SA1009 { get; } = Severity.MinorWarning;

        // OpeningSquareBracketsMustBeSpacedCorrectly
        private static Severity SA1010 { get; } = Severity.MinorWarning;

        // ClosingSquareBracketsMustBeSpacedCorrectly
        private static Severity SA1011 { get; } = Severity.MinorWarning;

        // OpeningBracesMustBeSpacedCorrectly
        private static Severity SA1012 { get; } = Severity.MinorWarning;

        // ClosingBracesMustBeSpacedCorrectly
        private static Severity SA1013 { get; } = Severity.MinorWarning;

        // OpeningGenericBracketsMustBeSpacedCorrectly
        private static Severity SA1014 { get; } = Severity.MinorWarning;

        // ClosingGenericBracketsMustBeSpacedCorrectly
        private static Severity SA1015 { get; } = Severity.MinorWarning;

        // OpeningAttributeBracketsMustBeSpacedCorrectly
        private static Severity SA1016 { get; } = Severity.MinorWarning;

        // ClosingAttributeBracketsMustBeSpacedCorrectly
        private static Severity SA1017 { get; } = Severity.MinorWarning;

        // NullableTypeSymbolsMustNotBePrecededBySpace
        private static Severity SA1018 { get; } = Severity.MinorWarning;

        // MemberAccessSymbolsMustBeSpacedCorrectly
        private static Severity SA1019 { get; } = Severity.MinorWarning;

        // IncrementDecrementSymbolsMustBeSpacedCorrectly
        private static Severity SA1020 { get; } = Severity.MinorWarning;

        // NegativeSignsMustBeSpacedCorrectly
        private static Severity SA1021 { get; } = Severity.MinorWarning;

        // PositiveSignsMustBeSpacedCorrectly
        private static Severity SA1022 { get; } = Severity.MinorWarning;

        // DereferenceAndAccessOfMustBeSpacedCorrectly
        private static Severity SA1023 { get; } = Severity.MinorWarning;

        // ColonsMustBeSpacedCorrectly
        private static Severity SA1024 { get; } = Severity.MinorWarning;

        // CodeMustNotContainMultipleWhitespaceInARow
        private static Severity SA1025 { get; } = Severity.MinorWarning;

        // CodeMustNotContainSpaceAfterNewKeywordInImplicitlyTypedArrayAllocation
        private static Severity SA1026 { get; } = Severity.MinorWarning;

        // UseTabsCorrectly
        private static Severity SA1027 { get; } = Severity.MinorWarning;

        // CodeMustNotContainTrailingWhitespace
        private static Severity SA1028 { get; } = Severity.MinorWarning;

        #endregion

        #region SA1100

        // DoNotPrefixCallsWithBaseUnlessLocalImplementationExists
        private static Severity SA1100 { get; } = Severity.MajorWarning;

        // PrefixLocalCallsWithThis
        private static Severity SA1101 { get; } = Severity.MajorWarning;

        // QueryClauseMustFollowPreviousClause
        private static Severity SA1102 { get; } = Severity.MinorWarning;

        // QueryClauseQueryClausesMustBeOnSeparateLinesOrAllOnOneLine
        private static Severity SA1103 { get; } = Severity.MinorWarning;

        // QueryClauseMustBeginOnNewLineWhenPreviousClauseSpansMultipleLines
        private static Severity SA1104 { get; } = Severity.MinorWarning;

        // QueryClausesSpanningMultipleLinesMustBeginOnOwnLine
        private static Severity SA1105 { get; } = Severity.MinorWarning;

        // CodeMustNotContainEmptyStatements
        private static Severity SA1106 { get; } = Severity.MajorWarning;

        // CodeMustNotContainMultipleStatementsOnOneLine
        private static Severity SA1107 { get; } = Severity.MajorWarning;

        // BlockStatementsMustNotContainEmbeddedComments
        private static Severity SA1108 { get; } = Severity.MajorWarning;

        // BlockStatementsMustNotContainEmbeddedRegions
        private static Severity SA1109 { get; } = Severity.MajorWarning;

        // OpeningParenthesisMustBeOnDeclarationLine
        private static Severity SA1110 { get; } = Severity.MajorWarning;

        // ClosingParenthesisMustBeOnLineOfLastParameter
        private static Severity SA1111 { get; } = Severity.MajorWarning;

        // ClosingParenthesisMustBeOnLineOfOpeningParenthesis
        private static Severity SA1112 { get; } = Severity.MajorWarning;

        // CommaMustBeOnSameLineAsPreviousParameter
        private static Severity SA1113 { get; } = Severity.MajorWarning;

        // ParameterListMustFollowDeclaration
        private static Severity SA1114 { get; } = Severity.MajorWarning;

        // ParameterMustFollowComma
        private static Severity SA1115 { get; } = Severity.MajorWarning;

        // SplitParametersMustStartOnLineAfterDeclaration
        private static Severity SA1116 { get; } = Severity.MajorWarning;

        // ParametersMustBeOnSameLineOrSeparateLines
        private static Severity SA1117 { get; } = Severity.MajorWarning;

        // ParameterMustNotSpanMultipleLines
        private static Severity SA1118 { get; } = Severity.MajorWarning;

        // StatementMustNotUseUnnecessaryParenthesis
        private static Severity SA1119 { get; } = Severity.MajorWarning;

        // CommentsMustContainText
        private static Severity SA1120 { get; } = Severity.MajorWarning;

        // UseBuiltInTypeAlias
        private static Severity SA1121 { get; } = Severity.MinorWarning;

        // UseStringEmptyForEmptyStrings
        private static Severity SA1122 { get; } = Severity.MinorWarning;

        // DoNotPlaceRegionsWithinElements
        private static Severity SA1123 { get; } = Severity.MajorWarning;

        // DoNotUseRegions
        private static Severity SA1124 { get; } = Severity.MinorWarning;

        // UseShorthandForNullableTypes
        private static Severity SA1125 { get; } = Severity.MinorWarning;

        // PrefixCallsCorrectly
        private static Severity SA1126 { get; } = Severity.MajorWarning;

        // GenericTypeConstraintsMustBeOnOwnLine
        private static Severity SA1127 { get; } = Severity.MajorWarning;

        // ConstructorInitializerMustBeOnOwnLine
        private static Severity SA1128 { get; } = Severity.MajorWarning;

        // DoNotUseDefaultValueTypeConstructor
        private static Severity SA1129 { get; } = Severity.MajorWarning;

        // UseLambdaSyntax
        private static Severity SA1130 { get; } = Severity.MinorWarning;

        // UseReadableConditions
        private static Severity SA1131 { get; } = Severity.MajorWarning;

        // DoNotCombineFields
        private static Severity SA1132 { get; } = Severity.MinorWarning;

        // DoNotCombineAttributes
        private static Severity SA1133 { get; } = Severity.MajorWarning;

        // AttributesMustNotShareLine
        private static Severity SA1134 { get; } = Severity.MajorWarning;

        // EnumValuesShouldBeOnSeparateLines
        private static Severity SA1136 { get; } = Severity.MajorWarning;

        #endregion

        #region SA1200

        // UsingDirectivesMustBePlacedCorrectly
        private static Severity SA1200 { get; } = Severity.None;

        // ElementsMustAppearInTheCorrectOrder
        private static Severity SA1201 { get; } = Severity.None;

        // ElementsMustBeOrderedByAccess
        private static Severity SA1202 { get; } = Severity.None;

        // ConstantsMustAppearBeforeFields
        private static Severity SA1203 { get; } = Severity.None;

        // StaticElementsMustAppearBeforeInstanceElements
        private static Severity SA1204 { get; } = Severity.None;

        // PartialElementsMustDeclareAccess
        private static Severity SA1205 { get; } = Severity.None;

        // DeclarationKeywordsMustFollowOrder
        private static Severity SA1206 { get; } = Severity.None;

        // ProtectedMustComeBeforeInternal
        private static Severity SA1207 { get; } = Severity.None;

        // SystemUsingDirectivesMustBePlacedBeforeOtherUsingDirectives
        private static Severity SA1208 { get; } = Severity.None;

        // UsingAliasDirectivesMustBePlacedAfterOtherUsingDirectives
        private static Severity SA1209 { get; } = Severity.None;

        // UsingDirectivesMustBeOrderedAlphabeticallyByNamespace
        private static Severity SA1210 { get; } = Severity.None;

        // UsingAliasDirectivesMustBeOrderedAlphabeticallyByAliasName
        private static Severity SA1211 { get; } = Severity.None;

        // PropertyAccessorsMustFollowOrder
        private static Severity SA1212 { get; } = Severity.None;

        // EventAccessorsMustFollowOrder
        private static Severity SA1213 { get; } = Severity.None;

        // ReadonlyElementsMustAppearBeforeNonReadonlyElements
        private static Severity SA1214 { get; } = Severity.None;

        // InstanceReadonlyElementsMustAppearBeforeInstanceNonReadonlyElements
        private static Severity SA1215 { get; } = Severity.None;

        // UsingStaticDirectivesMustBePlacedAtTheCorrectLocation
        private static Severity SA1216 { get; } = Severity.None;

        // UsingStaticDirectivesMustBeOrderedAlphabetically
        private static Severity SA1217 { get; } = Severity.None;

        #endregion

        #region SA1300

        // ElementMustBeginWithUpperCaseLetter
        private static Severity SA1300 { get; } = Severity.None;

        // ElementMustBeginWithLowerCaseLetter
        private static Severity SA1301 { get; } = Severity.None;

        // InterfaceNamesMustBeginWithI
        private static Severity SA1302 { get; } = Severity.None;

        // ConstFieldNamesMustBeginWithUpperCaseLetter
        private static Severity SA1303 { get; } = Severity.None;

        // NonPrivateReadonlyFieldsMustBeginWithUpperCaseLetter
        private static Severity SA1304 { get; } = Severity.None;

        // FieldNamesMustNotUseHungarianNotation
        private static Severity SA1305 { get; } = Severity.None;

        // FieldNamesMustBeginWithLowerCaseLetter
        private static Severity SA1306 { get; } = Severity.None;

        // AccessibleFieldsMustBeginWithUpperCaseLetter
        private static Severity SA1307 { get; } = Severity.MinorWarning;

        // VariableNamesMustNotBePrefixed
        private static Severity SA1308 { get; } = Severity.None;

        // FieldNamesMustNotBeginWithUnder
        private static Severity SA1309 { get; } = Severity.None;

        // FieldNamesMustNotContainUnder
        private static Severity SA1310 { get; } = Severity.None;

        // StaticReadonlyFieldsMustBeginWithUpperCaseLetter
        private static Severity SA1311 { get; } = Severity.None;

        // VariableNamesMustBeginWithLowerCaseLetter
        private static Severity SA1312 { get; } = Severity.None;

        // ParameterNamesMustBeginWithLowerCaseLetter
        private static Severity SA1313 { get; } = Severity.None;

        #endregion

        #region SA1400

        // AccessModifierMustBeDeclared
        private static Severity SA1400 { get; } = Severity.None;

        // FieldsMustBePrivate
        private static Severity SA1401 { get; } = Severity.MajorWarning;

        // FileMayOnlyContainASingleClass
        private static Severity SA1402 { get; } = Severity.None;

        // FileMayOnlyContainASingleNamespace
        private static Severity SA1403 { get; } = Severity.None;

        // CodeAnalysisSuppressionMustHaveJustification
        private static Severity SA1404 { get; } = Severity.None;

        // DebugAssertMustProvideMessageText
        private static Severity SA1405 { get; } = Severity.None;

        // DebugFailMustProvideMessageText
        private static Severity SA1406 { get; } = Severity.None;

        // ArithmeticExpressionsMustDeclarePrecedence
        private static Severity SA1407 { get; } = Severity.None;

        // ConditionalExpressionsMustDeclarePrecedence
        private static Severity SA1408 { get; } = Severity.None;

        // RemoveUnnecessaryCode
        private static Severity SA1409 { get; } = Severity.None;

        // RemoveDelegateParenthesisWhenPossible
        private static Severity SA1410 { get; } = Severity.None;

        // AttributeConstructorMustNotUseUnnecessaryParenthesis
        private static Severity SA1411 { get; } = Severity.None;

        // StoreFilesAsUtf8
        private static Severity SA1412 { get; } = Severity.None;

        // UseTrailingCommasInMultiLineInitializers
        private static Severity SA1413 { get; } = Severity.None;

        #endregion

        #region SA1400

        // BracesForMultiLineStatementsMustNotShareLine
        private static Severity SA1500 { get; } = Severity.None;

        // StatementMustNotBeOnSingleLine
        private static Severity SA1501 { get; } = Severity.None;

        // ElementMustNotBeOnSingleLine
        private static Severity SA1502 { get; } = Severity.None;

        // BracesMustNotBeOmitted
        private static Severity SA1503 { get; } = Severity.None;

        // AllAccessorsMustBeSingleLineOrMultiLine
        private static Severity SA1504 { get; } = Severity.None;

        // OpeningBracesMustNotBeFollowedByBlankLine
        private static Severity SA1505 { get; } = Severity.None;

        // ElementDocumentationHeadersMustNotBeFollowedByBlankLine
        private static Severity SA1506 { get; } = Severity.None;

        // CodeMustNotContainMultipleBlankLinesInARow
        private static Severity SA1507 { get; } = Severity.None;

        // ClosingBracesMustNotBePrecededByBlankLine
        private static Severity SA1508 { get; } = Severity.None;

        // OpeningBracesMustNotBePrecededByBlankLine
        private static Severity SA1509 { get; } = Severity.None;

        // ChainedStatementBlocksMustNotBePrecededByBlankLine
        private static Severity SA1510 { get; } = Severity.None;

        // WhileDoFooterMustNotBePrecededByBlankLine
        private static Severity SA1511 { get; } = Severity.None;

        // SingleLineCommentsMustNotBeFollowedByBlankLine
        private static Severity SA1512 { get; } = Severity.None;

        // ClosingBraceMustBeFollowedByBlankLine
        private static Severity SA1513 { get; } = Severity.None;

        // ElementDocumentationHeaderMustBePrecededByBlankLine
        private static Severity SA1514 { get; } = Severity.None;

        // SingleLineCommentMustBePrecededByBlankLine
        private static Severity SA1515 { get; } = Severity.None;

        // ElementsMustBeSeparatedByBlankLine
        private static Severity SA1516 { get; } = Severity.None;

        // CodeMustNotContainBlankLinesAtStartOfFile
        private static Severity SA1517 { get; } = Severity.None;

        // UseLineEndingsCorrectlyAtEndOfFile
        private static Severity SA1518 { get; } = Severity.None;

        // BracesMustNotBeOmittedFromMultiLineChildStatement
        private static Severity SA1519 { get; } = Severity.None;

        // UseBracesConsistently
        private static Severity SA1520 { get; } = Severity.None;

        #endregion

        #region SA1600

        // ElementsMustBeDocumented
        private static Severity SA1600 { get; } = Severity.None;

        // PartialElementsMustBeDocumented
        private static Severity SA1601 { get; } = Severity.None;

        // EnumerationItemsMustBeDocumented
        private static Severity SA1602 { get; } = Severity.None;

        // DocumentationMustContainValidXml
        private static Severity SA1603 { get; } = Severity.None;

        // ElementDocumentationMustHaveSummary
        private static Severity SA1604 { get; } = Severity.None;

        // PartialElementDocumentationMustHaveSummary
        private static Severity SA1605 { get; } = Severity.None;

        // ElementDocumentationMustHaveSummaryText
        private static Severity SA1606 { get; } = Severity.None;

        // PartialElementDocumentationMustHaveSummaryText
        private static Severity SA1607 { get; } = Severity.None;

        // ElementDocumentationMustNotHaveDefaultSummary
        private static Severity SA1608 { get; } = Severity.None;

        // PropertyDocumentationMustHaveValue
        private static Severity SA1609 { get; } = Severity.None;

        // PropertyDocumentationMustHaveValueText
        private static Severity SA1610 { get; } = Severity.None;

        // ElementParametersMustBeDocumented
        private static Severity SA1611 { get; } = Severity.None;

        // ElementParameterDocumentationMustMatchElementParameters
        private static Severity SA1612 { get; } = Severity.None;

        // ElementParameterDocumentationMustDeclareParameterName
        private static Severity SA1613 { get; } = Severity.None;

        // ElementParameterDocumentationMustHaveText
        private static Severity SA1614 { get; } = Severity.None;

        // ElementReturnValueMustBeDocumented
        private static Severity SA1615 { get; } = Severity.None;

        // ElementReturnValueDocumentationMustHaveText
        private static Severity SA1616 { get; } = Severity.None;

        // VoidReturnValueMustNotBeDocumented
        private static Severity SA1617 { get; } = Severity.None;

        // GenericTypeParametersMustBeDocumented
        private static Severity SA1618 { get; } = Severity.None;

        // GenericTypeParametersMustBeDocumentedPartialClass
        private static Severity SA1619 { get; } = Severity.None;

        // GenericTypeParameterDocumentationMustMatchTypeParameters
        private static Severity SA1620 { get; } = Severity.None;

        // GenericTypeParameterDocumentationMustDeclareParameterName
        private static Severity SA1621 { get; } = Severity.None;

        // GenericTypeParameterDocumentationMustHaveText
        private static Severity SA1622 { get; } = Severity.None;

        // PropertySummaryDocumentationMustMatchAccessors
        private static Severity SA1623 { get; } = Severity.None;

        // PropertySummaryDocumentationMustOmitSetAccessorWithRestrictedAccess
        private static Severity SA1624 { get; } = Severity.None;

        // ElementDocumentationMustNotBeCopiedAndPasted
        private static Severity SA1625 { get; } = Severity.None;

        // SingleLineCommentsMustNotUseDocumentationStyleSlashes
        private static Severity SA1626 { get; } = Severity.None;

        // DocumentationTextMustNotBeEmpty
        private static Severity SA1627 { get; } = Severity.None;

        // DocumentationTextMustBeginWithACapitalLetter
        private static Severity SA1628 { get; } = Severity.None;

        // DocumentationTextMustEndWithAPeriod
        private static Severity SA1629 { get; } = Severity.None;

        // DocumentationTextMustContainWhitespace
        private static Severity SA1630 { get; } = Severity.None;

        // DocumentationMustMeetCharacterPercentage
        private static Severity SA1631 { get; } = Severity.None;

        // DocumentationTextMustMeetMinimumCharacterLength
        private static Severity SA1632 { get; } = Severity.None;

        // FileMustHaveHeader
        private static Severity SA1633 { get; } = Severity.None;

        // FileHeaderMustShowCopyright
        private static Severity SA1634 { get; } = Severity.None;

        // FileHeaderMustHaveCopyrightText
        private static Severity SA1635 { get; } = Severity.None;

        // FileHeaderCopyrightTextMustMatch
        private static Severity SA1636 { get; } = Severity.None;

        // FileHeaderMustContainFileName
        private static Severity SA1637 { get; } = Severity.None;

        // FileHeaderFileNameDocumentationMustMatchFileName
        private static Severity SA1638 { get; } = Severity.None;

        // FileHeaderMustHaveSummary
        private static Severity SA1639 { get; } = Severity.None;

        // FileHeaderMustHaveValidCompanyText
        private static Severity SA1640 { get; } = Severity.None;

        // FileHeaderCompanyNameTextMustMatch
        private static Severity SA1641 { get; } = Severity.None;

        // ConstructorSummaryDocumentationMustBeginWithStandardText
        private static Severity SA1642 { get; } = Severity.None;

        // DestructorSummaryDocumentationMustBeginWithStandardText
        private static Severity SA1643 { get; } = Severity.None;

        // DocumentationHeadersMustNotContainBlankLines
        private static Severity SA1644 { get; } = Severity.None;

        // IncludedDocumentationFileDoesNotExist
        private static Severity SA1645 { get; } = Severity.None;

        // IncludedDocumentationXPathDoesNotExist
        private static Severity SA1646 { get; } = Severity.None;

        // IncludeNodeDoesNotContainValidFileAndPath
        private static Severity SA1647 { get; } = Severity.None;

        // InheritDocMustBeUsedWithInheritingClass
        private static Severity SA1648 { get; } = Severity.None;

        // FileNameMustMatchTypeName
        private static Severity SA1649 { get; } = Severity.None;

        // ElementDocumentationMustBeSpelledCorrectly
        private static Severity SA1650 { get; } = Severity.None;

        // DoNotUsePlaceholderElements
        private static Severity SA1651 { get; } = Severity.None;

        // EnableXmlDocumentationOutput
        private static Severity SA1652 { get; } = Severity.None;

        #endregion

        public static Severity GetSeverity(Diagnostic diagnostic)
        {
            if (diagnostic == null)
            {
                throw new ArgumentNullException(nameof(diagnostic));
            }

            if (!diagnostic.Id.StartsWith("SA"))
            {
                throw new ArgumentException("Diagnostic is not an SA violation.", nameof(diagnostic));
            }

            PropertyInfo property = properties.First(p => p.Name == diagnostic.Id);
            return (Severity)property.GetValue(null);
        }
    }
}
