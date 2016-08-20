namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1001CommasMustBeSpacedCorrectly : DiagnoticHandler
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
