namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1131UseReadableConditions : DiagnoticHandler
    {
        public override Serverity Serverity
        {
            get
            {
                return Serverity.MajorWarning;
            }
        }
    }
}
