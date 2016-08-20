namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1507CodeMustNotContainMultipleBlankLinesInARow : DiagnoticHandler
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
