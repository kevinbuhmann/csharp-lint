namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1623PropertySummaryDocumentationMustMatchAccessors : DiagnoticHandler
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
