namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1638FileHeaderFileNameDocumentationMustMatchFileName : DiagnoticHandler
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
