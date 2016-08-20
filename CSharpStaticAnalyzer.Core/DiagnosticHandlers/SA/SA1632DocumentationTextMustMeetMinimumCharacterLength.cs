namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1632DocumentationTextMustMeetMinimumCharacterLength : DiagnoticHandler
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
