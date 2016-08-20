namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1126PrefixCallsCorrectly : DiagnoticHandler
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
