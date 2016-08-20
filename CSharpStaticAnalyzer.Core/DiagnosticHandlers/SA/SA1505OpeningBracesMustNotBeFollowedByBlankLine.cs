namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1505OpeningBracesMustNotBeFollowedByBlankLine : DiagnoticHandler
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
