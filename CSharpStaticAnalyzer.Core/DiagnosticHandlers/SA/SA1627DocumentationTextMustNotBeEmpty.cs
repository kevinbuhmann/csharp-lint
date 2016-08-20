namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1627DocumentationTextMustNotBeEmpty : DiagnoticHandler
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
