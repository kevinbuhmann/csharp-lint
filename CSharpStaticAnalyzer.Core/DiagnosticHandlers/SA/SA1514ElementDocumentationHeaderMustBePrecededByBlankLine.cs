namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1514ElementDocumentationHeaderMustBePrecededByBlankLine : DiagnoticHandler
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
