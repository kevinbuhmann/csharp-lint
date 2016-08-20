namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1642ConstructorSummaryDocumentationMustBeginWithStandardText : DiagnoticHandler
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
