namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1022PositiveSignsMustBeSpacedCorrectly : DiagnoticHandler
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
