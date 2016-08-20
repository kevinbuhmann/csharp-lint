namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1637FileHeaderMustContainFileName : DiagnoticHandler
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
