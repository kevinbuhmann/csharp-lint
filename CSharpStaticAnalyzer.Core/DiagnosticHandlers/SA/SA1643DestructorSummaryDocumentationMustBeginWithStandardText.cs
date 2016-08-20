namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1643DestructorSummaryDocumentationMustBeginWithStandardText : DiagnoticHandler
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
