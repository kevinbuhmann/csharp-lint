namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1605PartialElementDocumentationMustHaveSummary : DiagnoticHandler
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
