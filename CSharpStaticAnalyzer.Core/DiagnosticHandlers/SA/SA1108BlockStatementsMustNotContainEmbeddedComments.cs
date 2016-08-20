namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1108BlockStatementsMustNotContainEmbeddedComments : DiagnoticHandler
    {
        public override Serverity Serverity
        {
            get
            {
                return Serverity.MajorWarning;
            }
        }
    }
}
