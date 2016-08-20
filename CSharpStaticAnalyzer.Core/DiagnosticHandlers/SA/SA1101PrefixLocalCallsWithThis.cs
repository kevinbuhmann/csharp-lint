namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1101PrefixLocalCallsWithThis : DiagnoticHandler
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
