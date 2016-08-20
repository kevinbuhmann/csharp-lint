namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1127GenericTypeConstraintsMustBeOnOwnLine : DiagnoticHandler
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
