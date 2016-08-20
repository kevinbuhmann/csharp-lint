namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1004DocumentationLinesMustBeginWithSingleSpace : DiagnoticHandler
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
