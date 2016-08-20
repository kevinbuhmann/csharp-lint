namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1007OperatorKeywordMustBeFollowedBySpace : DiagnoticHandler
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
