namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1010OpeningSquareBracketsMustBeSpacedCorrectly : DiagnoticHandler
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
