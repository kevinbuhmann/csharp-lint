namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1103QueryClauseQueryClausesMustBeOnSeparateLinesOrAllOnOneLine : DiagnoticHandler
    {
        public override Serverity Serverity
        {
            get
            {
                return Serverity.MinorWarning;
            }
        }
    }
}
