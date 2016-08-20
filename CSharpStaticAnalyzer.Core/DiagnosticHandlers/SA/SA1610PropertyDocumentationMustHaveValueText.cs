namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1610PropertyDocumentationMustHaveValueText : DiagnoticHandler
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
