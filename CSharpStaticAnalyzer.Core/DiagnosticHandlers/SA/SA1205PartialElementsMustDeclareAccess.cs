namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1205PartialElementsMustDeclareAccess : DiagnoticHandler
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
