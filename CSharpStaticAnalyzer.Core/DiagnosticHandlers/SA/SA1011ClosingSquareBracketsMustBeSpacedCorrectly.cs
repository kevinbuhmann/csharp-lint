namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1011ClosingSquareBracketsMustBeSpacedCorrectly : DiagnoticHandler
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
