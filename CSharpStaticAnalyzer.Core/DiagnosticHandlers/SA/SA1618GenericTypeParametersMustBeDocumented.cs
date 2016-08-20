namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1618GenericTypeParametersMustBeDocumented : DiagnoticHandler
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
