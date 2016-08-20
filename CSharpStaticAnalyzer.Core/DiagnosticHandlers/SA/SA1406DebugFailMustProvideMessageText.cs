namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1406DebugFailMustProvideMessageText : DiagnoticHandler
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
