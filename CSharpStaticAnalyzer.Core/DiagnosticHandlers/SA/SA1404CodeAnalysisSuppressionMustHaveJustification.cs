namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1404CodeAnalysisSuppressionMustHaveJustification : DiagnoticHandler
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
