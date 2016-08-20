namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1633FileMustHaveHeader : DiagnoticHandler
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
