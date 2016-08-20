namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1017ClosingAttributeBracketsMustBeSpacedCorrectly : DiagnoticHandler
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
