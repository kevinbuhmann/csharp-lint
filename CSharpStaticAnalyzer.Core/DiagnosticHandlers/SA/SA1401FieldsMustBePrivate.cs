namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1401FieldsMustBePrivate : DiagnoticHandler
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
