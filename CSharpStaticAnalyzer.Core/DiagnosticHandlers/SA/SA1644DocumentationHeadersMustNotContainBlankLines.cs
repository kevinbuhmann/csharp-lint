namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1644DocumentationHeadersMustNotContainBlankLines : DiagnoticHandler
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
