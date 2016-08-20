namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1214ReadonlyElementsMustAppearBeforeNonReadonlyElements : DiagnoticHandler
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
