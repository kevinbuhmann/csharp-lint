namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1634FileHeaderMustShowCopyright : DiagnoticHandler
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
