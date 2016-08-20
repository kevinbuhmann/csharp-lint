namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1609PropertyDocumentationMustHaveValue : DiagnoticHandler
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
