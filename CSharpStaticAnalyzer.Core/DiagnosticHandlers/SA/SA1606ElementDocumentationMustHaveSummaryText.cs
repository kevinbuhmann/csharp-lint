namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1606ElementDocumentationMustHaveSummaryText : DiagnoticHandler
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
