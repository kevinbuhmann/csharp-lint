namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1412StoreFilesAsUtf8 : DiagnoticHandler
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
