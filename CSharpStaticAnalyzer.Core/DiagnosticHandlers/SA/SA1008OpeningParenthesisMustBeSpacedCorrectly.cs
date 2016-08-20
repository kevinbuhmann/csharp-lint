namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1008OpeningParenthesisMustBeSpacedCorrectly : DiagnoticHandler
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
