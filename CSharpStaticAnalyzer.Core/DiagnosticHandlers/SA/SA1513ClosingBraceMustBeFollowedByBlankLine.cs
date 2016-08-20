namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1513ClosingBraceMustBeFollowedByBlankLine : DiagnoticHandler
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
