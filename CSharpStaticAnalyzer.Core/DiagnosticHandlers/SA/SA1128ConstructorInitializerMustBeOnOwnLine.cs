namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1128ConstructorInitializerMustBeOnOwnLine : DiagnoticHandler
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
