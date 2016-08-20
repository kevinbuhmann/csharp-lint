namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1615ElementReturnValueMustBeDocumented : DiagnoticHandler
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
