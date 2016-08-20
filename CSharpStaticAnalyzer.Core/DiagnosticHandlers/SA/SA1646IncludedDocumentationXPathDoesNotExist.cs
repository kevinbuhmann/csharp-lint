namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1646IncludedDocumentationXPathDoesNotExist : DiagnoticHandler
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
