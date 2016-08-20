namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1607PartialElementDocumentationMustHaveSummaryText : DiagnoticHandler
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
