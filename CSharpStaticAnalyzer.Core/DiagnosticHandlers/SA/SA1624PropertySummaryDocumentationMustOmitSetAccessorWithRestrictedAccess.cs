namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1624PropertySummaryDocumentationMustOmitSetAccessorWithRestrictedAccess : DiagnoticHandler
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
