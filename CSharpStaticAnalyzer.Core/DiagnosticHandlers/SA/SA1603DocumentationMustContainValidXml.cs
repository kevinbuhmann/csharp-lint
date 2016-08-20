namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1603DocumentationMustContainValidXml : DiagnoticHandler
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
