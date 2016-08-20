namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1639FileHeaderMustHaveSummary : DiagnoticHandler
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
