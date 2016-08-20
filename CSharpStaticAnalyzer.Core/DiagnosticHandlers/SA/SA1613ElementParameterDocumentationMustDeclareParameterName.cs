namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1613ElementParameterDocumentationMustDeclareParameterName : DiagnoticHandler
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
