namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1207ProtectedMustComeBeforeInternal : DiagnoticHandler
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
