namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1611ElementParametersMustBeDocumented : DiagnoticHandler
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
