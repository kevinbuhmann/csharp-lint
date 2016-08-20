namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1102QueryClauseMustFollowPreviousClause : DiagnoticHandler
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
