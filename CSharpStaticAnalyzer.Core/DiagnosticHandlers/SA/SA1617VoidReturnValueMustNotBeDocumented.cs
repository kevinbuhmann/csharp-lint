namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1617VoidReturnValueMustNotBeDocumented : DiagnoticHandler
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
