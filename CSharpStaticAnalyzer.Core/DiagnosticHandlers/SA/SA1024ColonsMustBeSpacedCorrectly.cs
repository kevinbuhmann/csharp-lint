namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1024ColonsMustBeSpacedCorrectly : DiagnoticHandler
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
