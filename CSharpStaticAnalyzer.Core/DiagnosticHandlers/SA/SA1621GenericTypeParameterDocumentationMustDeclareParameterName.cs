namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1621GenericTypeParameterDocumentationMustDeclareParameterName : DiagnoticHandler
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
