namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1110OpeningParenthesisMustBeOnDeclarationLine : DiagnoticHandler
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
