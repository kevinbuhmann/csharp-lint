namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1500BracesForMultiLineStatementsMustNotShareLine : DiagnoticHandler
    {
        public override Serverity Serverity
        {
            get
            {
                return Serverity.None;
            }
        }
    }
}
