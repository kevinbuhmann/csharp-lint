namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1640FileHeaderMustHaveValidCompanyText : DiagnoticHandler
    {
        public override Serverity Serverity
        {
            get
            {
                return Serverity.None;
            }
        }
    }
}
