namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1016OpeningAttributeBracketsMustBeSpacedCorrectly : DiagnoticHandler
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
