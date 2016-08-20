namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1104QueryClauseMustBeginOnNewLineWhenPreviousClauseSpansMultipleLines : DiagnoticHandler
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
