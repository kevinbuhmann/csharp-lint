namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1641FileHeaderCompanyNameTextMustMatch : DiagnoticHandler
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
