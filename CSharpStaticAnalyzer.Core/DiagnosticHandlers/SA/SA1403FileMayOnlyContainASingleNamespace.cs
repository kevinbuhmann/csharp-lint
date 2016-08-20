namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1403FileMayOnlyContainASingleNamespace : DiagnoticHandler
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
