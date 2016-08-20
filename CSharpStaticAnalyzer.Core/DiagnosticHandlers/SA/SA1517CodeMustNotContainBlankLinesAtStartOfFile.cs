namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1517CodeMustNotContainBlankLinesAtStartOfFile : DiagnoticHandler
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
