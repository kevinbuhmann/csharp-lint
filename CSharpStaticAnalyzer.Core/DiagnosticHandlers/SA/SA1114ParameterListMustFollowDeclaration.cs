namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1114ParameterListMustFollowDeclaration : DiagnoticHandler
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
