namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1009ClosingParenthesisMustBeSpacedCorrectly : DiagnoticHandler
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
