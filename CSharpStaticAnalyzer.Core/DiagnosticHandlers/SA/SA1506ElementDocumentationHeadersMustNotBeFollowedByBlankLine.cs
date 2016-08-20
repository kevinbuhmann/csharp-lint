namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1506ElementDocumentationHeadersMustNotBeFollowedByBlankLine : DiagnoticHandler
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
