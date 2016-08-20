namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1616ElementReturnValueDocumentationMustHaveText : DiagnoticHandler
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
