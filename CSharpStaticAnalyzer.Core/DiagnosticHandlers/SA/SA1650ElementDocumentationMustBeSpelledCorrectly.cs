namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1650ElementDocumentationMustBeSpelledCorrectly : DiagnoticHandler
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
