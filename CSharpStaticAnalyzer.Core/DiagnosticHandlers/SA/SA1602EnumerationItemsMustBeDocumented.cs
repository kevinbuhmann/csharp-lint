namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1602EnumerationItemsMustBeDocumented : DiagnoticHandler
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
