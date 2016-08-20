namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1204StaticElementsMustAppearBeforeInstanceElements : DiagnoticHandler
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
