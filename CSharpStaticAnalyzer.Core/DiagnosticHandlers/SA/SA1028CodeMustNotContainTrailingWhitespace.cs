namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1028CodeMustNotContainTrailingWhitespace : DiagnoticHandler
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
