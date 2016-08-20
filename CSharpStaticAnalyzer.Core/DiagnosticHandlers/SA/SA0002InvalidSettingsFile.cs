namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA0002InvalidSettingsFile : DiagnoticHandler
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
