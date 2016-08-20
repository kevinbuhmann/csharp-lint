namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1620GenericTypeParameterDocumentationMustMatchTypeParameters : DiagnoticHandler
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
