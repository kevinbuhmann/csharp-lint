namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1105QueryClausesSpanningMultipleLinesMustBeginOnOwnLine : DiagnoticHandler
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
