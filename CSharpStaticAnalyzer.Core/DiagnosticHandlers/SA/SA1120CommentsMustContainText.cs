namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1120CommentsMustContainText : DiagnoticHandler
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
