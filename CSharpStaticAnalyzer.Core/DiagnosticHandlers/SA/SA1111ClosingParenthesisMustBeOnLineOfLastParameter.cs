namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1111ClosingParenthesisMustBeOnLineOfLastParameter : DiagnoticHandler
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
