namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1612ElementParameterDocumentationMustMatchElementParameters : DiagnoticHandler
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
