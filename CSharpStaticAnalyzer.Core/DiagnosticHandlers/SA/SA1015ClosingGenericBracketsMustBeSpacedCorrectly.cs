namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1015ClosingGenericBracketsMustBeSpacedCorrectly : DiagnoticHandler
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
