namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1020IncrementDecrementSymbolsMustBeSpacedCorrectly : DiagnoticHandler
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
