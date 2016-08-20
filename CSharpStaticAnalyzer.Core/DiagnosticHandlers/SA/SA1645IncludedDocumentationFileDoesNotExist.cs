namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1645IncludedDocumentationFileDoesNotExist : DiagnoticHandler
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
