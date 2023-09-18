//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from ./web-version-source-code/SquirrelLanguageGrammar/Squirrel.g4 by ANTLR 4.9.3

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="ISquirrelVisitor{Result}"/>,
/// which can be extended to create a visitor which only needs to handle a subset
/// of the available methods.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.3")]
[System.Diagnostics.DebuggerNonUserCode]
[System.CLSCompliant(false)]
public partial class SquirrelBaseVisitor<Result> : AbstractParseTreeVisitor<Result>, ISquirrelVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="SquirrelParser.id"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitId([NotNull] SquirrelParser.IdContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SquirrelParser.boolean"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitBoolean([NotNull] SquirrelParser.BooleanContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SquirrelParser.whileKeyword"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitWhileKeyword([NotNull] SquirrelParser.WhileKeywordContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SquirrelParser.str"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitStr([NotNull] SquirrelParser.StrContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SquirrelParser.derefexp"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDerefexp([NotNull] SquirrelParser.DerefexpContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SquirrelParser.stats"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitStats([NotNull] SquirrelParser.StatsContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SquirrelParser.statincludingemptystatement"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitStatincludingemptystatement([NotNull] SquirrelParser.StatincludingemptystatementContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SquirrelParser.functionDeclaration"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFunctionDeclaration([NotNull] SquirrelParser.FunctionDeclarationContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SquirrelParser.functionParameter"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFunctionParameter([NotNull] SquirrelParser.FunctionParameterContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SquirrelParser.stat"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitStat([NotNull] SquirrelParser.StatContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SquirrelParser.breakStatement"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitBreakStatement([NotNull] SquirrelParser.BreakStatementContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SquirrelParser.switchCaseStatement"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitSwitchCaseStatement([NotNull] SquirrelParser.SwitchCaseStatementContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SquirrelParser.statNotIncludingObjectLiteral"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitStatNotIncludingObjectLiteral([NotNull] SquirrelParser.StatNotIncludingObjectLiteralContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SquirrelParser.arrayLiteral"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitArrayLiteral([NotNull] SquirrelParser.ArrayLiteralContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SquirrelParser.initz"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitInitz([NotNull] SquirrelParser.InitzContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SquirrelParser.negativeSign"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitNegativeSign([NotNull] SquirrelParser.NegativeSignContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SquirrelParser.incrementOperator"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitIncrementOperator([NotNull] SquirrelParser.IncrementOperatorContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SquirrelParser.decrementOperator"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDecrementOperator([NotNull] SquirrelParser.DecrementOperatorContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SquirrelParser.equalequal"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitEqualequal([NotNull] SquirrelParser.EqualequalContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SquirrelParser.notequal"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitNotequal([NotNull] SquirrelParser.NotequalContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SquirrelParser.arrayIndexing"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitArrayIndexing([NotNull] SquirrelParser.ArrayIndexingContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SquirrelParser.openParen"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitOpenParen([NotNull] SquirrelParser.OpenParenContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SquirrelParser.closeParen"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCloseParen([NotNull] SquirrelParser.CloseParenContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SquirrelParser.objectLiteral"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitObjectLiteral([NotNull] SquirrelParser.ObjectLiteralContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SquirrelParser.propertyAssignment"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPropertyAssignment([NotNull] SquirrelParser.PropertyAssignmentContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SquirrelParser.exp"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitExp([NotNull] SquirrelParser.ExpContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SquirrelParser.openSquareBracket"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitOpenSquareBracket([NotNull] SquirrelParser.OpenSquareBracketContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SquirrelParser.typeOf"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTypeOf([NotNull] SquirrelParser.TypeOfContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SquirrelParser.ternaryOperator"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTernaryOperator([NotNull] SquirrelParser.TernaryOperatorContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SquirrelParser.classStatements"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitClassStatements([NotNull] SquirrelParser.ClassStatementsContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SquirrelParser.classVariableDeclaration"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitClassVariableDeclaration([NotNull] SquirrelParser.ClassVariableDeclarationContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SquirrelParser.classConstructorDeclaration"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitClassConstructorDeclaration([NotNull] SquirrelParser.ClassConstructorDeclarationContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SquirrelParser.classConstructorArgs"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitClassConstructorArgs([NotNull] SquirrelParser.ClassConstructorArgsContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SquirrelParser.classConstructorArg"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitClassConstructorArg([NotNull] SquirrelParser.ClassConstructorArgContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SquirrelParser.classFunctionDeclaration"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitClassFunctionDeclaration([NotNull] SquirrelParser.ClassFunctionDeclarationContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SquirrelParser.instanceofOperator"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitInstanceofOperator([NotNull] SquirrelParser.InstanceofOperatorContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SquirrelParser.cloneOperator"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCloneOperator([NotNull] SquirrelParser.CloneOperatorContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SquirrelParser.expNotIncludingObjectLiteral"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitExpNotIncludingObjectLiteral([NotNull] SquirrelParser.ExpNotIncludingObjectLiteralContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SquirrelParser.assignmentModificationOperator"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAssignmentModificationOperator([NotNull] SquirrelParser.AssignmentModificationOperatorContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SquirrelParser.arguments"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitArguments([NotNull] SquirrelParser.ArgumentsContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SquirrelParser.argument"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitArgument([NotNull] SquirrelParser.ArgumentContext context) { return VisitChildren(context); }
}