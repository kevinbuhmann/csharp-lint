namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1601PartialElementsMustBeDocumented : DiagnoticHandler
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
