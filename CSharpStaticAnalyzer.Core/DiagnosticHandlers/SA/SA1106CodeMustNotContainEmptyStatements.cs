namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1106CodeMustNotContainEmptyStatements : DiagnoticHandler
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
