namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1119StatementMustNotUseUnnecessaryParenthesis : DiagnoticHandler
    {
        public override Serverity Serverity
        {
            get
            {
                return Serverity.MajorWarning;
            }
        }
    }
}
