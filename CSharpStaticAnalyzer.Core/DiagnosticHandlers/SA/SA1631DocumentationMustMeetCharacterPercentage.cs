namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1631DocumentationMustMeetCharacterPercentage : DiagnoticHandler
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
