namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1116SplitParametersMustStartOnLineAfterDeclaration : DiagnoticHandler
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
