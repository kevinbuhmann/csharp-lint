namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1117ParametersMustBeOnSameLineOrSeparateLines : DiagnoticHandler
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
