namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1512SingleLineCommentsMustNotBeFollowedByBlankLine : DiagnoticHandler
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
