namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1413UseTrailingCommasInMultiLineInitializers : DiagnoticHandler
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
