namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1005SingleLineCommentsMustBeginWithSingleSpace : DiagnoticHandler
    {
        public override Serverity Serverity
        {
            get
            {
                return Serverity.MinorWarning;
            }
        }
    }
}
