namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1405DebugAssertMustProvideMessageText : DiagnoticHandler
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
