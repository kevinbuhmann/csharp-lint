namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1619GenericTypeParametersMustBeDocumentedPartialClass : DiagnoticHandler
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
