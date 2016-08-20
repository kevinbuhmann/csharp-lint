namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1002SemicolonsMustBeSpacedCorrectly : DiagnoticHandler
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
