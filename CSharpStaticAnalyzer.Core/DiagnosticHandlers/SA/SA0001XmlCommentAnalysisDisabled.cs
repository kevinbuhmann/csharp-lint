namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA0001XmlCommentAnalysisDisabled : DiagnoticHandler
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
