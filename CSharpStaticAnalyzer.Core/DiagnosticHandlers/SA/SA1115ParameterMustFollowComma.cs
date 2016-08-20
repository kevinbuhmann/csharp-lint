namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1115ParameterMustFollowComma : DiagnoticHandler
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
