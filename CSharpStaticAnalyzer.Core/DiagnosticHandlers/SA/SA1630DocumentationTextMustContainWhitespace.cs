namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1630DocumentationTextMustContainWhitespace : DiagnoticHandler
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
