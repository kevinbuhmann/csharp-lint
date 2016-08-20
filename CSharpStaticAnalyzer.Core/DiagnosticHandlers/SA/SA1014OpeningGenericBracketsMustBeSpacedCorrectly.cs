namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1014OpeningGenericBracketsMustBeSpacedCorrectly : DiagnoticHandler
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
