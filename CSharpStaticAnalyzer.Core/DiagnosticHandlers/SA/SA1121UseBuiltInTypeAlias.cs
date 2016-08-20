namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1121UseBuiltInTypeAlias : DiagnoticHandler
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
