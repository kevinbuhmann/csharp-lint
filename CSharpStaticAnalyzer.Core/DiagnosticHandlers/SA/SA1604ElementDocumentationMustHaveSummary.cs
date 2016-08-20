namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1604ElementDocumentationMustHaveSummary : DiagnoticHandler
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
