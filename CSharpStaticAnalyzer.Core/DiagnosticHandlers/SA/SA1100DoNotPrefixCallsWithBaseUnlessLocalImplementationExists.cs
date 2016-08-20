namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1100DoNotPrefixCallsWithBaseUnlessLocalImplementationExists : DiagnoticHandler
    {
        public override Serverity Serverity
        {
            get
            {
                return Serverity.MajorWarning;
            }
        }
    }
}
