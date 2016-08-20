namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1109BlockStatementsMustNotContainEmbeddedRegions : DiagnoticHandler
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
