namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1629DocumentationTextMustEndWithAPeriod : DiagnoticHandler
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
