namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1626SingleLineCommentsMustNotUseDocumentationStyleSlashes : DiagnoticHandler
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
