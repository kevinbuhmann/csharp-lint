namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1000KeywordsMustBeSpacedCorrectly : DiagnoticHandler
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
