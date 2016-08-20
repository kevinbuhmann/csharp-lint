namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1600ElementsMustBeDocumented : DiagnoticHandler
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
