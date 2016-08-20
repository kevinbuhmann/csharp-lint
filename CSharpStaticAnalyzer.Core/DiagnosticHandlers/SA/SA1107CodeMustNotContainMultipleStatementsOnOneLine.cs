namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1107CodeMustNotContainMultipleStatementsOnOneLine : DiagnoticHandler
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
