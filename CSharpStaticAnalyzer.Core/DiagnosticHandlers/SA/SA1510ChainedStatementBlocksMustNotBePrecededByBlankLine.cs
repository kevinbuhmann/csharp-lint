namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1510ChainedStatementBlocksMustNotBePrecededByBlankLine : DiagnoticHandler
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
