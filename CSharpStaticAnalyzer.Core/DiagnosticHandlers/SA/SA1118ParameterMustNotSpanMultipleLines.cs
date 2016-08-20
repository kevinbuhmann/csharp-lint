namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1118ParameterMustNotSpanMultipleLines : DiagnoticHandler
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
