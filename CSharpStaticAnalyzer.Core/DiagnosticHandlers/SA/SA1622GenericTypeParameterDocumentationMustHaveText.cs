namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1622GenericTypeParameterDocumentationMustHaveText : DiagnoticHandler
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
