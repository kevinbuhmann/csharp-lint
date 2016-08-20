namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1647IncludeNodeDoesNotContainValidFileAndPath : DiagnoticHandler
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
