namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1013ClosingBracesMustBeSpacedCorrectly : DiagnoticHandler
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
