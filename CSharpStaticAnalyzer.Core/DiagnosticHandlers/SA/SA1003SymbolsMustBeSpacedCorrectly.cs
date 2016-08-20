namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1003SymbolsMustBeSpacedCorrectly : DiagnoticHandler
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
