namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1112ClosingParenthesisMustBeOnLineOfOpeningParenthesis : DiagnoticHandler
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
