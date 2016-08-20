namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1202ElementsMustBeOrderedByAccess : DiagnoticHandler
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
