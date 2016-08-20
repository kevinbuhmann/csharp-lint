namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1113CommaMustBeOnSameLineAsPreviousParameter : DiagnoticHandler
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
