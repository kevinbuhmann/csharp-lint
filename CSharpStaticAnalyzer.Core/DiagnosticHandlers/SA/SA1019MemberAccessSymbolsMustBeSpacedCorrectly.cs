namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1019MemberAccessSymbolsMustBeSpacedCorrectly : DiagnoticHandler
    {
        public override Serverity Serverity
        {
            get
            {
                return Serverity.MinorWarning;
            }
        }
    }
}
