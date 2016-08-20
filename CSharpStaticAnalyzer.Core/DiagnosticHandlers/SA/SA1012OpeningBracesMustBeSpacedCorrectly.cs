namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1012OpeningBracesMustBeSpacedCorrectly : DiagnoticHandler
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
