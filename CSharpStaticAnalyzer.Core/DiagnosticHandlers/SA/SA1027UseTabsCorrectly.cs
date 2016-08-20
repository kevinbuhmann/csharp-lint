namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1027UseTabsCorrectly : DiagnoticHandler
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
